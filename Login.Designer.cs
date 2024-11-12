namespace BankingSystem
{
    partial class LoginView
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
            this.idLogin = new System.Windows.Forms.Label();
            this.passLogin = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.comboBoxRoleLogin = new System.Windows.Forms.ComboBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idLogin
            // 
            this.idLogin.AutoSize = true;
            this.idLogin.Location = new System.Drawing.Point(172, 119);
            this.idLogin.Name = "idLogin";
            this.idLogin.Size = new System.Drawing.Size(26, 20);
            this.idLogin.TabIndex = 0;
            this.idLogin.Text = "ID";
            // 
            // passLogin
            // 
            this.passLogin.AutoSize = true;
            this.passLogin.Location = new System.Drawing.Point(172, 161);
            this.passLogin.Name = "passLogin";
            this.passLogin.Size = new System.Drawing.Size(78, 20);
            this.passLogin.TabIndex = 1;
            this.passLogin.Text = "Password";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(258, 119);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(231, 26);
            this.txtId.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(258, 158);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(231, 26);
            this.txtPassword.TabIndex = 3;
            // 
            // comboBoxRoleLogin
            // 
            this.comboBoxRoleLogin.FormattingEnabled = true;
            this.comboBoxRoleLogin.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.comboBoxRoleLogin.Location = new System.Drawing.Point(258, 201);
            this.comboBoxRoleLogin.Name = "comboBoxRoleLogin";
            this.comboBoxRoleLogin.Size = new System.Drawing.Size(121, 28);
            this.comboBoxRoleLogin.TabIndex = 4;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(414, 258);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 37);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 362);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.comboBoxRoleLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.passLogin);
            this.Controls.Add(this.idLogin);
            this.Name = "LoginView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLogin;
        private System.Windows.Forms.Label passLogin;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox comboBoxRoleLogin;
        private System.Windows.Forms.Button buttonLogin;
    }
}

