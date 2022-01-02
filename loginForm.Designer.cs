
namespace Recreation_Center
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbUserType = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.ttUserType = new System.Windows.Forms.ToolTip(this.components);
            this.pbIllustration = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblUsertype = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIllustration)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(396, 63);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(170, 27);
            this.tbUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(393, 38);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 23);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(393, 106);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 23);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(396, 130);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(170, 27);
            this.tbPassword.TabIndex = 0;
            // 
            // cbUserType
            // 
            this.cbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserType.FormattingEnabled = true;
            this.cbUserType.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.cbUserType.Location = new System.Drawing.Point(397, 198);
            this.cbUserType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbUserType.Name = "cbUserType";
            this.cbUserType.Size = new System.Drawing.Size(169, 31);
            this.cbUserType.TabIndex = 2;
            this.ttUserType.SetToolTip(this.cbUserType, "Select user type to login.");
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(396, 248);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(170, 35);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // ttUserType
            // 
            this.ttUserType.ForeColor = System.Drawing.SystemColors.Info;
            // 
            // pbIllustration
            // 
            this.pbIllustration.Image = global::Recreation_Center.Properties.Resources.login;
            this.pbIllustration.Location = new System.Drawing.Point(-1, -2);
            this.pbIllustration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbIllustration.Name = "pbIllustration";
            this.pbIllustration.Size = new System.Drawing.Size(396, 396);
            this.pbIllustration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIllustration.TabIndex = 4;
            this.pbIllustration.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(396, 294);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblUsertype
            // 
            this.lblUsertype.AutoSize = true;
            this.lblUsertype.Location = new System.Drawing.Point(393, 174);
            this.lblUsertype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsertype.Name = "lblUsertype";
            this.lblUsertype.Size = new System.Drawing.Size(68, 23);
            this.lblUsertype.TabIndex = 1;
            this.lblUsertype.Text = "Usertype";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(585, 376);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbUserType);
            this.Controls.Add(this.lblUsertype);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.pbIllustration);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbIllustration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ComboBox cbUserType;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ToolTip ttUserType;
        private System.Windows.Forms.PictureBox pbIllustration;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblUsertype;
    }
}

