namespace ReadCat
{
    partial class Authorization
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.rightPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.forgotPasswordPanel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.helperPanel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.newPasswordBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordVerifierText4 = new System.Windows.Forms.Label();
            this.passwordVerifierText3 = new System.Windows.Forms.Label();
            this.helperPanel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.confirmNewPasswordBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.resetPasswordButton = new Guna.UI2.WinForms.Guna2Button();
            this.resendCodeButton = new Guna.UI2.WinForms.Guna2Button();
            this.helperPanel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.expiryTimeText = new System.Windows.Forms.Label();
            this.otpCodeBox = new System.Windows.Forms.MaskedTextBox();
            this.forgotPasswordPanel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.forgotPasswordEmailBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.sendCodeButton = new Guna.UI2.WinForms.Guna2Button();
            this.signinPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.helperPanel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.signinButton = new Guna.UI2.WinForms.Guna2Button();
            this.register = new System.Windows.Forms.Label();
            this.forgotPassword = new System.Windows.Forms.Label();
            this.lUsernameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lPasswordBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.mainAuthPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.createAccountButton = new Guna.UI2.WinForms.Guna2Button();
            this.registrationPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.helperPanel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.passwordVerifierText2 = new System.Windows.Forms.Label();
            this.passwordVerifierText1 = new System.Windows.Forms.Label();
            this.rPasswordBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.rEmailBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.rUsernameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.nicknameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.helperPanel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.registerButton = new Guna.UI2.WinForms.Guna2Button();
            this.backToSignIn = new System.Windows.Forms.Label();
            this.animator = new Guna.UI2.WinForms.Guna2Transition();
            this.animation1 = new ReadCat.Animation();
            this.messageBox = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.validator = new System.Windows.Forms.Timer(this.components);
            this.errorMessageBox = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.expiryCounter = new System.Windows.Forms.Timer(this.components);
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.forgotPasswordPanel2.SuspendLayout();
            this.helperPanel7.SuspendLayout();
            this.helperPanel8.SuspendLayout();
            this.helperPanel6.SuspendLayout();
            this.forgotPasswordPanel1.SuspendLayout();
            this.signinPanel.SuspendLayout();
            this.helperPanel1.SuspendLayout();
            this.mainAuthPanel.SuspendLayout();
            this.registrationPanel.SuspendLayout();
            this.helperPanel3.SuspendLayout();
            this.helperPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.logo);
            this.rightPanel.Controls.Add(this.forgotPasswordPanel2);
            this.rightPanel.Controls.Add(this.forgotPasswordPanel1);
            this.rightPanel.Controls.Add(this.signinPanel);
            this.rightPanel.Controls.Add(this.mainAuthPanel);
            this.rightPanel.Controls.Add(this.registrationPanel);
            this.animator.SetDecoration(this.rightPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(399, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(385, 561);
            this.rightPanel.TabIndex = 3;
            // 
            // logo
            // 
            this.animator.SetDecoration(this.logo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.logo.Image = global::ReadCat.Properties.Resources.ReadCat;
            this.logo.ImageRotate = 0F;
            this.logo.Location = new System.Drawing.Point(0, -1);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(385, 202);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // forgotPasswordPanel2
            // 
            this.forgotPasswordPanel2.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.forgotPasswordPanel2.BorderRadius = 15;
            this.forgotPasswordPanel2.Controls.Add(this.helperPanel7);
            this.forgotPasswordPanel2.Controls.Add(this.helperPanel8);
            this.forgotPasswordPanel2.Controls.Add(this.helperPanel6);
            this.animator.SetDecoration(this.forgotPasswordPanel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.forgotPasswordPanel2.Location = new System.Drawing.Point(0, 195);
            this.forgotPasswordPanel2.Name = "forgotPasswordPanel2";
            this.forgotPasswordPanel2.Size = new System.Drawing.Size(385, 366);
            this.forgotPasswordPanel2.TabIndex = 8;
            this.forgotPasswordPanel2.Visible = false;
            // 
            // helperPanel7
            // 
            this.helperPanel7.Controls.Add(this.newPasswordBox);
            this.helperPanel7.Controls.Add(this.passwordVerifierText4);
            this.helperPanel7.Controls.Add(this.passwordVerifierText3);
            this.animator.SetDecoration(this.helperPanel7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.helperPanel7.Location = new System.Drawing.Point(58, 100);
            this.helperPanel7.Name = "helperPanel7";
            this.helperPanel7.Size = new System.Drawing.Size(270, 50);
            this.helperPanel7.TabIndex = 14;
            // 
            // newPasswordBox
            // 
            this.newPasswordBox.Animated = true;
            this.newPasswordBox.BorderColor = System.Drawing.Color.Gainsboro;
            this.newPasswordBox.BorderRadius = 12;
            this.newPasswordBox.CausesValidation = false;
            this.newPasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator.SetDecoration(this.newPasswordBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.newPasswordBox.DefaultText = "";
            this.newPasswordBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.newPasswordBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.newPasswordBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPasswordBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPasswordBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.newPasswordBox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.newPasswordBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.newPasswordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.newPasswordBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.newPasswordBox.IconLeft = global::ReadCat.Properties.Resources._lock;
            this.newPasswordBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.newPasswordBox.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.newPasswordBox.Location = new System.Drawing.Point(0, 0);
            this.newPasswordBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newPasswordBox.Name = "newPasswordBox";
            this.newPasswordBox.PasswordChar = '\0';
            this.newPasswordBox.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.newPasswordBox.PlaceholderText = "Password";
            this.newPasswordBox.SelectedText = "";
            this.newPasswordBox.Size = new System.Drawing.Size(270, 45);
            this.newPasswordBox.TabIndex = 3;
            this.newPasswordBox.TextOffset = new System.Drawing.Point(0, -1);
            this.newPasswordBox.Enter += new System.EventHandler(this.newPasswordBox_Enter);
            this.newPasswordBox.Leave += new System.EventHandler(this.newPasswordBox_Leave);
            // 
            // passwordVerifierText4
            // 
            this.passwordVerifierText4.AutoSize = true;
            this.animator.SetDecoration(this.passwordVerifierText4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.passwordVerifierText4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordVerifierText4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.passwordVerifierText4.Location = new System.Drawing.Point(5, 65);
            this.passwordVerifierText4.Name = "passwordVerifierText4";
            this.passwordVerifierText4.Size = new System.Drawing.Size(122, 15);
            this.passwordVerifierText4.TabIndex = 5;
            this.passwordVerifierText4.Text = "✓ at least 8 characters";
            // 
            // passwordVerifierText3
            // 
            this.passwordVerifierText3.AutoSize = true;
            this.animator.SetDecoration(this.passwordVerifierText3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.passwordVerifierText3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordVerifierText3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.passwordVerifierText3.Location = new System.Drawing.Point(5, 49);
            this.passwordVerifierText3.Name = "passwordVerifierText3";
            this.passwordVerifierText3.Size = new System.Drawing.Size(170, 15);
            this.passwordVerifierText3.TabIndex = 4;
            this.passwordVerifierText3.Text = "✓ must be at least one number";
            // 
            // helperPanel8
            // 
            this.helperPanel8.Controls.Add(this.confirmNewPasswordBox);
            this.helperPanel8.Controls.Add(this.resetPasswordButton);
            this.helperPanel8.Controls.Add(this.resendCodeButton);
            this.animator.SetDecoration(this.helperPanel8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.helperPanel8.Location = new System.Drawing.Point(58, 154);
            this.helperPanel8.Name = "helperPanel8";
            this.helperPanel8.Size = new System.Drawing.Size(270, 139);
            this.helperPanel8.TabIndex = 15;
            // 
            // confirmNewPasswordBox
            // 
            this.confirmNewPasswordBox.Animated = true;
            this.confirmNewPasswordBox.BorderColor = System.Drawing.Color.Gainsboro;
            this.confirmNewPasswordBox.BorderRadius = 12;
            this.confirmNewPasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator.SetDecoration(this.confirmNewPasswordBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.confirmNewPasswordBox.DefaultText = "";
            this.confirmNewPasswordBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.confirmNewPasswordBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.confirmNewPasswordBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmNewPasswordBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmNewPasswordBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.confirmNewPasswordBox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.confirmNewPasswordBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.confirmNewPasswordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.confirmNewPasswordBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.confirmNewPasswordBox.IconLeft = global::ReadCat.Properties.Resources._lock;
            this.confirmNewPasswordBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmNewPasswordBox.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.confirmNewPasswordBox.Location = new System.Drawing.Point(0, 4);
            this.confirmNewPasswordBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmNewPasswordBox.Name = "confirmNewPasswordBox";
            this.confirmNewPasswordBox.PasswordChar = '\0';
            this.confirmNewPasswordBox.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.confirmNewPasswordBox.PlaceholderText = "Confirm password";
            this.confirmNewPasswordBox.SelectedText = "";
            this.confirmNewPasswordBox.Size = new System.Drawing.Size(270, 45);
            this.confirmNewPasswordBox.TabIndex = 7;
            this.confirmNewPasswordBox.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // resetPasswordButton
            // 
            this.resetPasswordButton.Animated = true;
            this.resetPasswordButton.BorderRadius = 12;
            this.resetPasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.resetPasswordButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.resetPasswordButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(140)))));
            this.resetPasswordButton.DisabledState.ForeColor = System.Drawing.Color.Gainsboro;
            this.resetPasswordButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.resetPasswordButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.resetPasswordButton.ForeColor = System.Drawing.Color.White;
            this.resetPasswordButton.Location = new System.Drawing.Point(0, 65);
            this.resetPasswordButton.Name = "resetPasswordButton";
            this.resetPasswordButton.Size = new System.Drawing.Size(270, 45);
            this.resetPasswordButton.TabIndex = 2;
            this.resetPasswordButton.Text = "Reset password";
            this.resetPasswordButton.Click += new System.EventHandler(this.resetPasswordButton_Click);
            // 
            // resendCodeButton
            // 
            this.resendCodeButton.Animated = true;
            this.resendCodeButton.BorderRadius = 6;
            this.resendCodeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.resendCodeButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.resendCodeButton.DisabledState.FillColor = System.Drawing.Color.White;
            this.resendCodeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(103)))), ((int)(((byte)(98)))));
            this.resendCodeButton.Enabled = false;
            this.resendCodeButton.FillColor = System.Drawing.Color.Empty;
            this.resendCodeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.resendCodeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.resendCodeButton.Location = new System.Drawing.Point(205, 116);
            this.resendCodeButton.Name = "resendCodeButton";
            this.resendCodeButton.Size = new System.Drawing.Size(65, 20);
            this.resendCodeButton.TabIndex = 10;
            this.resendCodeButton.Text = "resend";
            this.resendCodeButton.TextOffset = new System.Drawing.Point(0, -1);
            this.resendCodeButton.Click += new System.EventHandler(this.resendCodeButton_Click);
            // 
            // helperPanel6
            // 
            this.helperPanel6.Controls.Add(this.expiryTimeText);
            this.helperPanel6.Controls.Add(this.otpCodeBox);
            this.animator.SetDecoration(this.helperPanel6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.helperPanel6.Location = new System.Drawing.Point(58, 63);
            this.helperPanel6.Name = "helperPanel6";
            this.helperPanel6.Size = new System.Drawing.Size(270, 30);
            this.helperPanel6.TabIndex = 13;
            // 
            // expiryTimeText
            // 
            this.expiryTimeText.AutoSize = true;
            this.animator.SetDecoration(this.expiryTimeText, Guna.UI2.AnimatorNS.DecorationType.None);
            this.expiryTimeText.Dock = System.Windows.Forms.DockStyle.Right;
            this.expiryTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.expiryTimeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.expiryTimeText.Location = new System.Drawing.Point(221, 0);
            this.expiryTimeText.Name = "expiryTimeText";
            this.expiryTimeText.Padding = new System.Windows.Forms.Padding(0, 9, 10, 0);
            this.expiryTimeText.Size = new System.Drawing.Size(49, 22);
            this.expiryTimeText.TabIndex = 8;
            this.expiryTimeText.Text = "03:00";
            // 
            // otpCodeBox
            // 
            this.otpCodeBox.BackColor = System.Drawing.Color.White;
            this.otpCodeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.animator.SetDecoration(this.otpCodeBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.otpCodeBox.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.otpCodeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.otpCodeBox.Location = new System.Drawing.Point(88, 4);
            this.otpCodeBox.Mask = "000000";
            this.otpCodeBox.Name = "otpCodeBox";
            this.otpCodeBox.PromptChar = '▢';
            this.otpCodeBox.Size = new System.Drawing.Size(100, 24);
            this.otpCodeBox.TabIndex = 6;
            this.otpCodeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // forgotPasswordPanel1
            // 
            this.forgotPasswordPanel1.Controls.Add(this.label1);
            this.forgotPasswordPanel1.Controls.Add(this.forgotPasswordEmailBox);
            this.forgotPasswordPanel1.Controls.Add(this.sendCodeButton);
            this.animator.SetDecoration(this.forgotPasswordPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.forgotPasswordPanel1.Location = new System.Drawing.Point(0, 195);
            this.forgotPasswordPanel1.Name = "forgotPasswordPanel1";
            this.forgotPasswordPanel1.Size = new System.Drawing.Size(385, 366);
            this.forgotPasswordPanel1.TabIndex = 5;
            this.forgotPasswordPanel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.label1.Location = new System.Drawing.Point(233, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "back to sign in";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // forgotPasswordEmailBox
            // 
            this.forgotPasswordEmailBox.Animated = true;
            this.forgotPasswordEmailBox.BorderColor = System.Drawing.Color.Gainsboro;
            this.forgotPasswordEmailBox.BorderRadius = 12;
            this.forgotPasswordEmailBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator.SetDecoration(this.forgotPasswordEmailBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.forgotPasswordEmailBox.DefaultText = "";
            this.forgotPasswordEmailBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.forgotPasswordEmailBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.forgotPasswordEmailBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.forgotPasswordEmailBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.forgotPasswordEmailBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.forgotPasswordEmailBox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.forgotPasswordEmailBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.forgotPasswordEmailBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.forgotPasswordEmailBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.forgotPasswordEmailBox.IconLeft = global::ReadCat.Properties.Resources.email;
            this.forgotPasswordEmailBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.forgotPasswordEmailBox.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.forgotPasswordEmailBox.Location = new System.Drawing.Point(60, 78);
            this.forgotPasswordEmailBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.forgotPasswordEmailBox.Name = "forgotPasswordEmailBox";
            this.forgotPasswordEmailBox.PasswordChar = '\0';
            this.forgotPasswordEmailBox.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.forgotPasswordEmailBox.PlaceholderText = "Email";
            this.forgotPasswordEmailBox.SelectedText = "";
            this.forgotPasswordEmailBox.Size = new System.Drawing.Size(270, 45);
            this.forgotPasswordEmailBox.TabIndex = 0;
            this.forgotPasswordEmailBox.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // sendCodeButton
            // 
            this.sendCodeButton.Animated = true;
            this.sendCodeButton.BorderRadius = 12;
            this.sendCodeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.sendCodeButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sendCodeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(140)))));
            this.sendCodeButton.DisabledState.ForeColor = System.Drawing.Color.Gainsboro;
            this.sendCodeButton.Enabled = false;
            this.sendCodeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.sendCodeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.sendCodeButton.ForeColor = System.Drawing.Color.White;
            this.sendCodeButton.Location = new System.Drawing.Point(60, 130);
            this.sendCodeButton.Name = "sendCodeButton";
            this.sendCodeButton.Size = new System.Drawing.Size(270, 45);
            this.sendCodeButton.TabIndex = 2;
            this.sendCodeButton.Text = "Send code";
            this.sendCodeButton.Click += new System.EventHandler(this.sendCodeButton_Click);
            // 
            // signinPanel
            // 
            this.signinPanel.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.signinPanel.BorderRadius = 15;
            this.signinPanel.Controls.Add(this.helperPanel1);
            this.signinPanel.Controls.Add(this.lUsernameBox);
            this.signinPanel.Controls.Add(this.lPasswordBox);
            this.animator.SetDecoration(this.signinPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.signinPanel.Location = new System.Drawing.Point(0, 195);
            this.signinPanel.Name = "signinPanel";
            this.signinPanel.Size = new System.Drawing.Size(385, 366);
            this.signinPanel.TabIndex = 5;
            this.signinPanel.Visible = false;
            // 
            // helperPanel1
            // 
            this.helperPanel1.Controls.Add(this.signinButton);
            this.helperPanel1.Controls.Add(this.register);
            this.helperPanel1.Controls.Add(this.forgotPassword);
            this.animator.SetDecoration(this.helperPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.helperPanel1.Location = new System.Drawing.Point(60, 148);
            this.helperPanel1.Name = "helperPanel1";
            this.helperPanel1.Size = new System.Drawing.Size(270, 92);
            this.helperPanel1.TabIndex = 7;
            // 
            // signinButton
            // 
            this.signinButton.Animated = true;
            this.signinButton.AnimatedGIF = true;
            this.signinButton.BorderRadius = 12;
            this.signinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.signinButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.signinButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signinButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signinButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.signinButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.signinButton.ForeColor = System.Drawing.Color.White;
            this.signinButton.Location = new System.Drawing.Point(0, 13);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(270, 45);
            this.signinButton.TabIndex = 2;
            this.signinButton.Text = "Sign in";
            this.signinButton.Click += new System.EventHandler(this.signinButton_Click);
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.register, Guna.UI2.AnimatorNS.DecorationType.None);
            this.register.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.register.Location = new System.Drawing.Point(173, 61);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(97, 17);
            this.register.TabIndex = 4;
            this.register.Text = "create account";
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // forgotPassword
            // 
            this.forgotPassword.AutoSize = true;
            this.forgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.forgotPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.forgotPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.forgotPassword.Location = new System.Drawing.Point(1, 61);
            this.forgotPassword.Name = "forgotPassword";
            this.forgotPassword.Size = new System.Drawing.Size(108, 17);
            this.forgotPassword.TabIndex = 3;
            this.forgotPassword.Text = "forgot password";
            this.forgotPassword.Click += new System.EventHandler(this.forgotPassword_Click);
            // 
            // lUsernameBox
            // 
            this.lUsernameBox.Animated = true;
            this.lUsernameBox.BorderColor = System.Drawing.Color.Gainsboro;
            this.lUsernameBox.BorderRadius = 12;
            this.lUsernameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator.SetDecoration(this.lUsernameBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lUsernameBox.DefaultText = "";
            this.lUsernameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lUsernameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lUsernameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lUsernameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lUsernameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.lUsernameBox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.lUsernameBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lUsernameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.lUsernameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.lUsernameBox.IconLeft = global::ReadCat.Properties.Resources.username;
            this.lUsernameBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.lUsernameBox.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.lUsernameBox.Location = new System.Drawing.Point(60, 47);
            this.lUsernameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lUsernameBox.Name = "lUsernameBox";
            this.lUsernameBox.PasswordChar = '\0';
            this.lUsernameBox.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.lUsernameBox.PlaceholderText = "Username or Email";
            this.lUsernameBox.SelectedText = "";
            this.lUsernameBox.Size = new System.Drawing.Size(270, 45);
            this.lUsernameBox.TabIndex = 0;
            this.lUsernameBox.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // lPasswordBox
            // 
            this.lPasswordBox.Animated = true;
            this.lPasswordBox.BorderColor = System.Drawing.Color.Gainsboro;
            this.lPasswordBox.BorderRadius = 12;
            this.lPasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator.SetDecoration(this.lPasswordBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lPasswordBox.DefaultText = "";
            this.lPasswordBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lPasswordBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lPasswordBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lPasswordBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lPasswordBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.lPasswordBox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.lPasswordBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lPasswordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.lPasswordBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.lPasswordBox.IconLeft = global::ReadCat.Properties.Resources._lock;
            this.lPasswordBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.lPasswordBox.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.lPasswordBox.Location = new System.Drawing.Point(60, 100);
            this.lPasswordBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lPasswordBox.Name = "lPasswordBox";
            this.lPasswordBox.PasswordChar = '•';
            this.lPasswordBox.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.lPasswordBox.PlaceholderText = "Password";
            this.lPasswordBox.SelectedText = "";
            this.lPasswordBox.Size = new System.Drawing.Size(270, 45);
            this.lPasswordBox.TabIndex = 1;
            this.lPasswordBox.TextOffset = new System.Drawing.Point(0, -1);
            this.lPasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.disableCapsLockBallon);
            // 
            // mainAuthPanel
            // 
            this.mainAuthPanel.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.mainAuthPanel.BorderRadius = 15;
            this.mainAuthPanel.Controls.Add(this.loginLabel);
            this.mainAuthPanel.Controls.Add(this.createAccountButton);
            this.animator.SetDecoration(this.mainAuthPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.mainAuthPanel.Location = new System.Drawing.Point(0, 195);
            this.mainAuthPanel.Name = "mainAuthPanel";
            this.mainAuthPanel.Size = new System.Drawing.Size(385, 366);
            this.mainAuthPanel.TabIndex = 2;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.loginLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.loginLabel.Location = new System.Drawing.Point(169, 162);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(48, 17);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "sign in";
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // createAccountButton
            // 
            this.createAccountButton.Animated = true;
            this.createAccountButton.BorderRadius = 12;
            this.createAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.createAccountButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.createAccountButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createAccountButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createAccountButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createAccountButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createAccountButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.createAccountButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.createAccountButton.ForeColor = System.Drawing.Color.White;
            this.createAccountButton.Location = new System.Drawing.Point(85, 112);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(219, 45);
            this.createAccountButton.TabIndex = 0;
            this.createAccountButton.Text = "Create account";
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // registrationPanel
            // 
            this.registrationPanel.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.registrationPanel.BorderRadius = 15;
            this.registrationPanel.Controls.Add(this.helperPanel3);
            this.registrationPanel.Controls.Add(this.rEmailBox);
            this.registrationPanel.Controls.Add(this.rUsernameBox);
            this.registrationPanel.Controls.Add(this.nicknameBox);
            this.registrationPanel.Controls.Add(this.helperPanel2);
            this.animator.SetDecoration(this.registrationPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.registrationPanel.Location = new System.Drawing.Point(0, 195);
            this.registrationPanel.Name = "registrationPanel";
            this.registrationPanel.Size = new System.Drawing.Size(385, 366);
            this.registrationPanel.TabIndex = 3;
            this.registrationPanel.Visible = false;
            // 
            // helperPanel3
            // 
            this.helperPanel3.Controls.Add(this.passwordVerifierText2);
            this.helperPanel3.Controls.Add(this.passwordVerifierText1);
            this.helperPanel3.Controls.Add(this.rPasswordBox);
            this.animator.SetDecoration(this.helperPanel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.helperPanel3.Location = new System.Drawing.Point(60, 182);
            this.helperPanel3.Name = "helperPanel3";
            this.helperPanel3.Size = new System.Drawing.Size(270, 50);
            this.helperPanel3.TabIndex = 7;
            // 
            // passwordVerifierText2
            // 
            this.passwordVerifierText2.AutoSize = true;
            this.animator.SetDecoration(this.passwordVerifierText2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.passwordVerifierText2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordVerifierText2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.passwordVerifierText2.Location = new System.Drawing.Point(5, 65);
            this.passwordVerifierText2.Name = "passwordVerifierText2";
            this.passwordVerifierText2.Size = new System.Drawing.Size(122, 15);
            this.passwordVerifierText2.TabIndex = 5;
            this.passwordVerifierText2.Text = "✓ at least 8 characters";
            // 
            // passwordVerifierText1
            // 
            this.passwordVerifierText1.AutoSize = true;
            this.animator.SetDecoration(this.passwordVerifierText1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.passwordVerifierText1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordVerifierText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.passwordVerifierText1.Location = new System.Drawing.Point(5, 49);
            this.passwordVerifierText1.Name = "passwordVerifierText1";
            this.passwordVerifierText1.Size = new System.Drawing.Size(170, 15);
            this.passwordVerifierText1.TabIndex = 4;
            this.passwordVerifierText1.Text = "✓ must be at least one number";
            // 
            // rPasswordBox
            // 
            this.rPasswordBox.Animated = true;
            this.rPasswordBox.BorderColor = System.Drawing.Color.Gainsboro;
            this.rPasswordBox.BorderRadius = 12;
            this.rPasswordBox.CausesValidation = false;
            this.rPasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator.SetDecoration(this.rPasswordBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.rPasswordBox.DefaultText = "";
            this.rPasswordBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.rPasswordBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.rPasswordBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rPasswordBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rPasswordBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.rPasswordBox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.rPasswordBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.rPasswordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.rPasswordBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.rPasswordBox.IconLeft = global::ReadCat.Properties.Resources._lock;
            this.rPasswordBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.rPasswordBox.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.rPasswordBox.Location = new System.Drawing.Point(0, 0);
            this.rPasswordBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rPasswordBox.Name = "rPasswordBox";
            this.rPasswordBox.PasswordChar = '•';
            this.rPasswordBox.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.rPasswordBox.PlaceholderText = "Password";
            this.rPasswordBox.SelectedText = "";
            this.rPasswordBox.Size = new System.Drawing.Size(270, 45);
            this.rPasswordBox.TabIndex = 3;
            this.rPasswordBox.TextOffset = new System.Drawing.Point(0, -1);
            this.rPasswordBox.Enter += new System.EventHandler(this.rPasswordBox_Enter);
            this.rPasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.disableCapsLockBallon);
            this.rPasswordBox.Leave += new System.EventHandler(this.rPasswordBox_Leave);
            // 
            // rEmailBox
            // 
            this.rEmailBox.Animated = true;
            this.rEmailBox.BorderColor = System.Drawing.Color.Gainsboro;
            this.rEmailBox.BorderRadius = 12;
            this.rEmailBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator.SetDecoration(this.rEmailBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.rEmailBox.DefaultText = "";
            this.rEmailBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.rEmailBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.rEmailBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rEmailBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rEmailBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.rEmailBox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.rEmailBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.rEmailBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.rEmailBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.rEmailBox.IconLeft = global::ReadCat.Properties.Resources.email;
            this.rEmailBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.rEmailBox.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.rEmailBox.Location = new System.Drawing.Point(60, 76);
            this.rEmailBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rEmailBox.Name = "rEmailBox";
            this.rEmailBox.PasswordChar = '\0';
            this.rEmailBox.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.rEmailBox.PlaceholderText = "Email";
            this.rEmailBox.SelectedText = "";
            this.rEmailBox.Size = new System.Drawing.Size(270, 45);
            this.rEmailBox.TabIndex = 1;
            this.rEmailBox.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // rUsernameBox
            // 
            this.rUsernameBox.Animated = true;
            this.rUsernameBox.BorderColor = System.Drawing.Color.Gainsboro;
            this.rUsernameBox.BorderRadius = 12;
            this.rUsernameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator.SetDecoration(this.rUsernameBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.rUsernameBox.DefaultText = "";
            this.rUsernameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.rUsernameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.rUsernameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rUsernameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rUsernameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.rUsernameBox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.rUsernameBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.rUsernameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.rUsernameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.rUsernameBox.IconLeft = global::ReadCat.Properties.Resources.username;
            this.rUsernameBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.rUsernameBox.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.rUsernameBox.Location = new System.Drawing.Point(60, 129);
            this.rUsernameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rUsernameBox.Name = "rUsernameBox";
            this.rUsernameBox.PasswordChar = '\0';
            this.rUsernameBox.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.rUsernameBox.PlaceholderText = "Username";
            this.rUsernameBox.SelectedText = "";
            this.rUsernameBox.Size = new System.Drawing.Size(270, 45);
            this.rUsernameBox.TabIndex = 2;
            this.rUsernameBox.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // nicknameBox
            // 
            this.nicknameBox.Animated = true;
            this.nicknameBox.BorderColor = System.Drawing.Color.Gainsboro;
            this.nicknameBox.BorderRadius = 12;
            this.nicknameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator.SetDecoration(this.nicknameBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.nicknameBox.DefaultText = "";
            this.nicknameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nicknameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nicknameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nicknameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nicknameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.nicknameBox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.nicknameBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.nicknameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(157)))));
            this.nicknameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.nicknameBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.nicknameBox.Location = new System.Drawing.Point(60, 23);
            this.nicknameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nicknameBox.Name = "nicknameBox";
            this.nicknameBox.PasswordChar = '\0';
            this.nicknameBox.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.nicknameBox.PlaceholderText = "Nickname (Optional)";
            this.nicknameBox.SelectedText = "";
            this.nicknameBox.Size = new System.Drawing.Size(270, 45);
            this.nicknameBox.TabIndex = 0;
            this.nicknameBox.TextOffset = new System.Drawing.Point(0, -1);
            // 
            // helperPanel2
            // 
            this.helperPanel2.Controls.Add(this.registerButton);
            this.helperPanel2.Controls.Add(this.backToSignIn);
            this.animator.SetDecoration(this.helperPanel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.helperPanel2.Location = new System.Drawing.Point(60, 235);
            this.helperPanel2.Name = "helperPanel2";
            this.helperPanel2.Size = new System.Drawing.Size(270, 70);
            this.helperPanel2.TabIndex = 6;
            // 
            // registerButton
            // 
            this.registerButton.Animated = true;
            this.registerButton.AnimatedGIF = true;
            this.registerButton.BorderRadius = 12;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.registerButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.registerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(144)))), ((int)(((byte)(140)))));
            this.registerButton.DisabledState.ForeColor = System.Drawing.Color.Gainsboro;
            this.registerButton.Enabled = false;
            this.registerButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.registerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.registerButton.ImageOffset = new System.Drawing.Point(25, 1);
            this.registerButton.Location = new System.Drawing.Point(0, 3);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(270, 45);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Create account";
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // backToSignIn
            // 
            this.backToSignIn.AutoSize = true;
            this.backToSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.backToSignIn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.backToSignIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.backToSignIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(200)))), ((int)(((byte)(193)))));
            this.backToSignIn.Location = new System.Drawing.Point(173, 0);
            this.backToSignIn.Name = "backToSignIn";
            this.backToSignIn.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.backToSignIn.Size = new System.Drawing.Size(97, 67);
            this.backToSignIn.TabIndex = 5;
            this.backToSignIn.Text = "back to sign in";
            this.backToSignIn.Click += new System.EventHandler(this.backToSignIn_Click);
            // 
            // animator
            // 
            this.animator.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.animator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.animator.DefaultAnimation = animation2;
            this.animator.TimeStep = 0.1F;
            // 
            // animation1
            // 
            this.animation1.BackColor = System.Drawing.Color.AliceBlue;
            this.animation1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("animation1.BackgroundImage")));
            this.animation1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.animator.SetDecoration(this.animation1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animation1.Dock = System.Windows.Forms.DockStyle.Left;
            this.animation1.Location = new System.Drawing.Point(0, 0);
            this.animation1.Name = "animation1";
            this.animation1.Size = new System.Drawing.Size(400, 561);
            this.animation1.TabIndex = 4;
            // 
            // messageBox
            // 
            this.messageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.messageBox.Caption = "Info";
            this.messageBox.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.messageBox.Parent = null;
            this.messageBox.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.messageBox.Text = null;
            // 
            // validator
            // 
            this.validator.Enabled = true;
            this.validator.Interval = 1;
            this.validator.Tick += new System.EventHandler(this.validator_Tick);
            // 
            // errorMessageBox
            // 
            this.errorMessageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.errorMessageBox.Caption = "Warning";
            this.errorMessageBox.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.errorMessageBox.Parent = null;
            this.errorMessageBox.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.errorMessageBox.Text = null;
            // 
            // expiryCounter
            // 
            this.expiryCounter.Enabled = true;
            this.expiryCounter.Interval = 1000;
            this.expiryCounter.Tick += new System.EventHandler(this.expiryCounter_Tick);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.animation1);
            this.Controls.Add(this.rightPanel);
            this.animator.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.forgotPasswordPanel2.ResumeLayout(false);
            this.helperPanel7.ResumeLayout(false);
            this.helperPanel7.PerformLayout();
            this.helperPanel8.ResumeLayout(false);
            this.helperPanel6.ResumeLayout(false);
            this.helperPanel6.PerformLayout();
            this.forgotPasswordPanel1.ResumeLayout(false);
            this.forgotPasswordPanel1.PerformLayout();
            this.signinPanel.ResumeLayout(false);
            this.helperPanel1.ResumeLayout(false);
            this.helperPanel1.PerformLayout();
            this.mainAuthPanel.ResumeLayout(false);
            this.mainAuthPanel.PerformLayout();
            this.registrationPanel.ResumeLayout(false);
            this.helperPanel3.ResumeLayout(false);
            this.helperPanel3.PerformLayout();
            this.helperPanel2.ResumeLayout(false);
            this.helperPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox logo;
        private Guna.UI2.WinForms.Guna2Panel rightPanel;
        private Guna.UI2.WinForms.Guna2Panel registrationPanel;
        private System.Windows.Forms.Label backToSignIn;
        private Guna.UI2.WinForms.Guna2Button registerButton;
        private Guna.UI2.WinForms.Guna2Panel mainAuthPanel;
        private System.Windows.Forms.Label loginLabel;
        private Guna.UI2.WinForms.Guna2Button createAccountButton;
        private Guna.UI2.WinForms.Guna2TextBox nicknameBox;
        private Guna.UI2.WinForms.Guna2TextBox rPasswordBox;
        private Guna.UI2.WinForms.Guna2TextBox rUsernameBox;
        private Guna.UI2.WinForms.Guna2TextBox rEmailBox;
        private Guna.UI2.WinForms.Guna2Transition animator;
        private Guna.UI2.WinForms.Guna2Panel signinPanel;
        private Guna.UI2.WinForms.Guna2TextBox lUsernameBox;
        private Guna.UI2.WinForms.Guna2TextBox lPasswordBox;
        private System.Windows.Forms.Label forgotPassword;
        private Guna.UI2.WinForms.Guna2Button signinButton;
        private System.Windows.Forms.Label register;
        private Guna.UI2.WinForms.Guna2Panel helperPanel1;
        private Guna.UI2.WinForms.Guna2Panel helperPanel2;
        private Guna.UI2.WinForms.Guna2Panel helperPanel3;
        private Guna.UI2.WinForms.Guna2MessageDialog messageBox;
        private System.Windows.Forms.Timer validator;
        private System.Windows.Forms.Label passwordVerifierText1;
        private System.Windows.Forms.Label passwordVerifierText2;
        private Guna.UI2.WinForms.Guna2MessageDialog errorMessageBox;
        private Guna.UI2.WinForms.Guna2Panel forgotPasswordPanel2;
        private Guna.UI2.WinForms.Guna2Button sendCodeButton;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox forgotPasswordEmailBox;
        private Guna.UI2.WinForms.Guna2Panel forgotPasswordPanel1;
        private System.Windows.Forms.Timer expiryCounter;
        private Guna.UI2.WinForms.Guna2Panel helperPanel7;
        private Guna.UI2.WinForms.Guna2TextBox newPasswordBox;
        private System.Windows.Forms.Label passwordVerifierText4;
        private System.Windows.Forms.Label passwordVerifierText3;
        private Guna.UI2.WinForms.Guna2Panel helperPanel8;
        private Guna.UI2.WinForms.Guna2TextBox confirmNewPasswordBox;
        private Guna.UI2.WinForms.Guna2Button resetPasswordButton;
        private Guna.UI2.WinForms.Guna2Button resendCodeButton;
        private Guna.UI2.WinForms.Guna2Panel helperPanel6;
        private System.Windows.Forms.Label expiryTimeText;
        private System.Windows.Forms.MaskedTextBox otpCodeBox;
        private Animation animation1;
    }
}