using ReadCat.Payloads;
using ReadCat.Properties;
using System;
using System.Windows.Forms;
namespace ReadCat
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            ApiHelper.initializeClient();
        }
        private AuthService service = new AuthService();
        private int expiryTime = 0;
        protected override void OnLoad(EventArgs e)
        {
            Utils.panelCentralization(mainAuthPanel, rightPanel, signinPanel, registrationPanel,helperPanel6);
            mainAuthPanel.BringToFront();
            validator.Start();
            base.OnLoad(e);
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            animator.HideSync(mainAuthPanel);
            registrationPanel.BringToFront();
            animator.ShowSync(registrationPanel);
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            animator.HideSync(mainAuthPanel);
            signinPanel.BringToFront();
            animator.ShowSync(signinPanel);
        }

        private void backToSignIn_Click(object sender, EventArgs e)
        {
            animator.HideSync(registrationPanel);
            signinPanel.BringToFront();
            animator.ShowSync(signinPanel);
        }

        private void register_Click(object sender, EventArgs e)
        {
            animator.HideSync(signinPanel);
            registrationPanel.BringToFront();
            animator.ShowSync(registrationPanel);
        }
        private void label1_Click(object sender, EventArgs e)
        {
            animator.HideSync(forgotPasswordPanel1);
            signinPanel.BringToFront();
            animator.ShowSync(signinPanel);
            Utils.clearTextBoxes(forgotPasswordEmailBox);
        }
        private void forgotPassword_Click(object sender, EventArgs e)
        {
            animator.HideSync(signinPanel);
            forgotPasswordPanel1.BringToFront();
            animator.ShowSync(forgotPasswordPanel1);
            animator.HideSync(registrationPanel);
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            RegisterDto dto = new RegisterDto()
            {
                username = rUsernameBox.Text,
                password = rPasswordBox.Text,
                email = rEmailBox.Text,
                nickname = nicknameBox.Text
            };
            registerButton.Image = Resources.spin;
            ApiResponse response = await service.register(dto);
            if (response.success)
            {
                backToSignIn_Click(sender, e);
                registerButton.Image = null;
                messageBox.Show("Successfully registered! Please verify your email and log in.");
                Utils.clearTextBoxes(nicknameBox, rUsernameBox, rPasswordBox, rEmailBox);
            }
            else
            {
                registerButton.Image = null;
                errorMessageBox.Show(response.message);
            }
        }

        private void validator_Tick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(rEmailBox.Text)
                && !String.IsNullOrEmpty(rUsernameBox.Text)
                && !String.IsNullOrEmpty(rPasswordBox.Text)
                && Utils.validUsername(rUsernameBox.Text)
                && Utils.validEmail(rEmailBox.Text)
                && Utils.validPassword(rPasswordBox.Text))
                registerButton.Enabled = true;
            else registerButton.Enabled = false;

            Utils.controlLabels(rPasswordBox.Text, passwordVerifierText1, passwordVerifierText2);
            Utils.controlLabels(newPasswordBox.Text, passwordVerifierText3, passwordVerifierText4);

            if (Utils.validEmail(forgotPasswordEmailBox.Text))
                sendCodeButton.Enabled = true;
            else
                sendCodeButton.Enabled = false;
        }

        private void rPasswordBox_Enter(object sender, EventArgs e)
        {
            if (helperPanel3.Height <= 50)
            {
                helperPanel3.Height = helperPanel3.Height + 30;
                helperPanel2.Top = helperPanel2.Top + 30;
            }
        }

        private void rPasswordBox_Leave(object sender, EventArgs e)
        {
            if (helperPanel3.Height > 50)
            {
                helperPanel3.Height = helperPanel3.Height - 30;
                helperPanel2.Top = helperPanel2.Top - 30;
            }
        }

        private async void signinButton_Click(object sender, EventArgs e)
        {
            LoginDto dto = new LoginDto()
            {
                username = lUsernameBox.Text,
                password = lPasswordBox.Text
            };
            signinButton.Image = Resources.spin;
            ApiResponse response = await service.login(dto);
            if (response.success)
            {
                signinButton.Image = null;
                Settings.Default.token = response.message;
                Settings.Default.Save();
                Utils.clearTextBoxes(lUsernameBox, lPasswordBox);
                Application.Restart();
            }
            else
            {
                if (response.message.Equals("Bad credentials"))
                    response.message = "Username or password incorrect";
                errorMessageBox.Show(response.message);
                signinButton.Image = null;
            }
        }

        private void disableCapsLockBallon(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock) e.SuppressKeyPress = true;
        }

        private async void sendCodeButton_Click(object sender, EventArgs e)
        {
            Settings.Default.expiryTime = 180;
            Settings.Default.lastEmail = forgotPasswordEmailBox.Text;
            Settings.Default.Save();
            expiryTime = Settings.Default.expiryTime;
            ApiResponse response = await service.forgotPassword(forgotPasswordEmailBox.Text);
            if (response.success)
            {
                animator.HideSync(forgotPasswordPanel1);
                forgotPasswordPanel2.BringToFront();
                animator.ShowSync(forgotPasswordPanel2);
                expiryCounter.Start();
                messageBox.Show(response.message);
                Utils.clearTextBoxes(forgotPasswordEmailBox);
            }
            else
                messageBox.Show(response.message);
        }

        private async void resetPasswordButton_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(otpCodeBox.Text) || String.IsNullOrWhiteSpace(otpCodeBox.Text))
            {
                messageBox.Show("Confirmation code required!");
                return;
            }
            PasswordResetDto dto = new PasswordResetDto()
            {
                password = newPasswordBox.Text,
                prePassword = confirmNewPasswordBox.Text,
                code = Int32.Parse(otpCodeBox.Text),
                email = Settings.Default.lastEmail
            };
            ApiResponse response = await service.resetPassword(dto);
            if (response.success)
            {
                animator.HideSync(forgotPasswordPanel2);
                signinPanel.BringToFront();
                animator.ShowSync(signinPanel);
                animator.HideSync(forgotPasswordPanel1);
                Utils.clearTextBoxes(newPasswordBox,confirmNewPasswordBox);otpCodeBox.Clear();
                messageBox.Show(response.message);
            }
            else
                messageBox.Show(response.message);
        }

        private void expiryCounter_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = TimeSpan.FromSeconds(expiryTime);
            if (expiryTime <= 0)
            {
                expiryCounter.Stop();
                resendCodeButton.Enabled = true;
            }
            if (expiryTime > 0)
                expiryTime--;
            expiryTimeText.Text = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
        }

        private async void resendCodeButton_Click(object sender, EventArgs e)
        {
            ApiResponse response = await service.resendCode(Settings.Default.lastEmail);
            if (response.success)
            {
                resendCodeButton.Enabled = false;
                otpCodeBox.Clear();
                expiryTime = Settings.Default.expiryTime;
                expiryCounter.Start();
            }
            else messageBox.Show(response.message);
        }

        private void newPasswordBox_Enter(object sender, EventArgs e)
        {
            if (helperPanel7.Height <= 50)
            {
                helperPanel7.Height = helperPanel3.Height + 30;
                helperPanel8.Top = helperPanel8.Top + 30;
            }
        }

        private void newPasswordBox_Leave(object sender, EventArgs e)
        {
            if (helperPanel7.Height > 50)
            {
                helperPanel7.Height = helperPanel7.Height - 30;
                helperPanel8.Top = helperPanel8.Top - 30;
            }
        }
    }
}
