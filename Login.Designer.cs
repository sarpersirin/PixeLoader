namespace KeyAuth
{
    // Token: 0x02000002 RID: 2
    public partial class Login : global::System.Windows.Forms.Form
    {
        // Token: 0x06000011 RID: 17 RVA: 0x0000215C File Offset: 0x0000035C
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x06000012 RID: 18 RVA: 0x00002194 File Offset: 0x00000394
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.status = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.usernameField = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordField = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.keyField = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailField = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BorderRadius = 10;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(417, 5);
            this.siticoneControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(60, 36);
            this.siticoneControlBox1.TabIndex = 1;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click);
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BorderRadius = 10;
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(356, 5);
            this.siticoneControlBox2.Margin = new System.Windows.Forms.Padding(4);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(60, 36);
            this.siticoneControlBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 26F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 60);
            this.label2.TabIndex = 27;
            this.label2.Text = "PixeLoader";
            // 
            // status
            // 
            this.status.AutoSize = false;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.status.Location = new System.Drawing.Point(0, 446);
            this.status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(482, 56);
            this.status.TabIndex = 38;
            this.status.Text = "Durum: Giriþ Bekleniyor";
            this.status.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameField
            // 
            this.usernameField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.usernameField.BorderRadius = 8;
            this.usernameField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameField.DefaultText = "";
            this.usernameField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameField.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            this.usernameField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameField.Location = new System.Drawing.Point(58, 161);
            this.usernameField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameField.Name = "usernameField";
            this.usernameField.PasswordChar = '\0';
            this.usernameField.PlaceholderText = "Username";
            this.usernameField.SelectedText = "";
            this.usernameField.Size = new System.Drawing.Size(381, 44);
            this.usernameField.TabIndex = 43;
            this.usernameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordField
            // 
            this.passwordField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.passwordField.BorderRadius = 8;
            this.passwordField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordField.DefaultText = "";
            this.passwordField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordField.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            this.passwordField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordField.Location = new System.Drawing.Point(58, 248);
            this.passwordField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '\0';
            this.passwordField.PlaceholderText = "Password";
            this.passwordField.SelectedText = "";
            this.passwordField.Size = new System.Drawing.Size(381, 44);
            this.passwordField.TabIndex = 44;
            this.passwordField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginBtn
            // 
            this.loginBtn.BorderColor = System.Drawing.Color.Gray;
            this.loginBtn.BorderRadius = 8;
            this.loginBtn.BorderThickness = 1;
            this.loginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginBtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.loginBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(58, 377);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(381, 37);
            this.loginBtn.TabIndex = 51;
            this.loginBtn.Text = "Log In";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BorderColor = System.Drawing.Color.Gray;
            this.guna2GradientButton2.BorderRadius = 8;
            this.guna2GradientButton2.BorderThickness = 1;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.Location = new System.Drawing.Point(1078, 560);
            this.guna2GradientButton2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(10, 10);
            this.guna2GradientButton2.TabIndex = 52;
            this.guna2GradientButton2.Text = "Register";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.BorderColor = System.Drawing.Color.Gray;
            this.guna2GradientButton3.BorderRadius = 8;
            this.guna2GradientButton3.BorderThickness = 1;
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.Location = new System.Drawing.Point(1078, 560);
            this.guna2GradientButton3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(10, 10);
            this.guna2GradientButton3.TabIndex = 53;
            this.guna2GradientButton3.Text = "License Only";
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // keyField
            // 
            this.keyField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.keyField.BorderRadius = 8;
            this.keyField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyField.DefaultText = "";
            this.keyField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.keyField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.keyField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.keyField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.keyField.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            this.keyField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.keyField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.keyField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.keyField.Location = new System.Drawing.Point(1078, 560);
            this.keyField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.keyField.Name = "keyField";
            this.keyField.PasswordChar = '\0';
            this.keyField.PlaceholderText = "Key";
            this.keyField.SelectedText = "";
            this.keyField.Size = new System.Drawing.Size(10, 10);
            this.keyField.TabIndex = 45;
            this.keyField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailField
            // 
            this.emailField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.emailField.BorderRadius = 8;
            this.emailField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailField.DefaultText = "";
            this.emailField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailField.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            this.emailField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailField.Location = new System.Drawing.Point(1078, 560);
            this.emailField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailField.Name = "emailField";
            this.emailField.PasswordChar = '\0';
            this.emailField.PlaceholderText = "Email";
            this.emailField.SelectedText = "";
            this.emailField.Size = new System.Drawing.Size(10, 10);
            this.emailField.TabIndex = 46;
            this.emailField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(19, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 18);
            this.label3.TabIndex = 54;
            this.label3.Text = "Boostrap By ImSarperS";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(482, 502);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2GradientButton3);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.keyField);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x04000001 RID: 1
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x04000002 RID: 2
        private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

        // Token: 0x04000004 RID: 4
        private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

        // Token: 0x04000005 RID: 5
        private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

        // Token: 0x0400000A RID: 10
        private global::System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private Siticone.UI.WinForms.SiticoneLabel status;
        private Guna.UI2.WinForms.Guna2TextBox passwordField;
        private Guna.UI2.WinForms.Guna2TextBox usernameField;
        private Guna.UI2.WinForms.Guna2GradientButton loginBtn;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2TextBox keyField;
        private Guna.UI2.WinForms.Guna2TextBox emailField;
        private System.Windows.Forms.Label label3;
    }
}
