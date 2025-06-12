namespace cafe
{
    partial class Register
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
            this.tbUsernameReg = new System.Windows.Forms.TextBox();
            this.tbPasswordReg = new System.Windows.Forms.TextBox();
            this.txtPasswordReg = new System.Windows.Forms.Label();
            this.txtUsernameReg = new System.Windows.Forms.Label();
            this.btnRegisterForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUsernameReg
            // 
            this.tbUsernameReg.Location = new System.Drawing.Point(61, 83);
            this.tbUsernameReg.Name = "tbUsernameReg";
            this.tbUsernameReg.Size = new System.Drawing.Size(142, 20);
            this.tbUsernameReg.TabIndex = 0;
            // 
            // tbPasswordReg
            // 
            this.tbPasswordReg.Location = new System.Drawing.Point(61, 151);
            this.tbPasswordReg.Name = "tbPasswordReg";
            this.tbPasswordReg.Size = new System.Drawing.Size(142, 20);
            this.tbPasswordReg.TabIndex = 1;
            // 
            // txtPasswordReg
            // 
            this.txtPasswordReg.AutoSize = true;
            this.txtPasswordReg.Location = new System.Drawing.Point(61, 132);
            this.txtPasswordReg.Name = "txtPasswordReg";
            this.txtPasswordReg.Size = new System.Drawing.Size(86, 13);
            this.txtPasswordReg.TabIndex = 2;
            this.txtPasswordReg.Text = "Unesite Zaporku";
            // 
            // txtUsernameReg
            // 
            this.txtUsernameReg.AutoSize = true;
            this.txtUsernameReg.Location = new System.Drawing.Point(58, 67);
            this.txtUsernameReg.Name = "txtUsernameReg";
            this.txtUsernameReg.Size = new System.Drawing.Size(115, 13);
            this.txtUsernameReg.TabIndex = 3;
            this.txtUsernameReg.Text = "Unesite Korisničko Ime";
            // 
            // btnRegisterForm
            // 
            this.btnRegisterForm.Location = new System.Drawing.Point(61, 201);
            this.btnRegisterForm.Name = "btnRegisterForm";
            this.btnRegisterForm.Size = new System.Drawing.Size(142, 23);
            this.btnRegisterForm.TabIndex = 4;
            this.btnRegisterForm.Text = "Registruj se";
            this.btnRegisterForm.UseVisualStyleBackColor = true;
            this.btnRegisterForm.Click += new System.EventHandler(this.btnRegisterForm_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 303);
            this.Controls.Add(this.btnRegisterForm);
            this.Controls.Add(this.txtUsernameReg);
            this.Controls.Add(this.txtPasswordReg);
            this.Controls.Add(this.tbPasswordReg);
            this.Controls.Add(this.tbUsernameReg);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsernameReg;
        private System.Windows.Forms.TextBox tbPasswordReg;
        private System.Windows.Forms.Label txtPasswordReg;
        private System.Windows.Forms.Label txtUsernameReg;
        private System.Windows.Forms.Button btnRegisterForm;
    }
}