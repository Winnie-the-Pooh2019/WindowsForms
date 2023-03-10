using System.ComponentModel;

namespace WindowsForms.Forms {
    partial class AuthForm
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
            private void InitializeComponent() {
                this.label1 = new System.Windows.Forms.Label();
                this.label2 = new System.Windows.Forms.Label();
                this.tbUsername = new System.Windows.Forms.TextBox();
                this.panel1 = new System.Windows.Forms.Panel();
                this.panel3 = new System.Windows.Forms.Panel();
                this.panel2 = new System.Windows.Forms.Panel();
                this.label4 = new System.Windows.Forms.Label();
                this.tbPassword = new System.Windows.Forms.TextBox();
                this.panel4 = new System.Windows.Forms.Panel();
                this.label3 = new System.Windows.Forms.Label();
                this.btnLogin = new System.Windows.Forms.Button();
                this.panel1.SuspendLayout();
                this.panel2.SuspendLayout();
                this.SuspendLayout();
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
                this.label1.Location = new System.Drawing.Point(163, 49);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(254, 37);
                this.label1.TabIndex = 0;
                this.label1.Text = "Login to account";
                // 
                // label2
                // 
                this.label2.AutoSize = true;
                this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
                this.label2.Location = new System.Drawing.Point(55, 20);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(44, 18);
                this.label2.TabIndex = 1;
                this.label2.Text = "Login";
                // 
                // tbUsername
                // 
                this.tbUsername.BackColor = System.Drawing.Color.White;
                this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.tbUsername.ForeColor = System.Drawing.SystemColors.ControlText;
                this.tbUsername.Location = new System.Drawing.Point(169, 21);
                this.tbUsername.Name = "tbUsername";
                this.tbUsername.Size = new System.Drawing.Size(260, 17);
                this.tbUsername.TabIndex = 3;
                this.tbUsername.Text = "Ivashka";
                // 
                // panel1
                // 
                this.panel1.Controls.Add(this.panel3);
                this.panel1.Controls.Add(this.label2);
                this.panel1.Controls.Add(this.tbUsername);
                this.panel1.Location = new System.Drawing.Point(63, 105);
                this.panel1.Name = "panel1";
                this.panel1.Size = new System.Drawing.Size(463, 59);
                this.panel1.TabIndex = 5;
                // 
                // panel3
                // 
                this.panel3.BackColor = System.Drawing.Color.White;
                this.panel3.Location = new System.Drawing.Point(169, 40);
                this.panel3.Name = "panel3";
                this.panel3.Size = new System.Drawing.Size(260, 1);
                this.panel3.TabIndex = 7;
                // 
                // panel2
                // 
                this.panel2.Controls.Add(this.label4);
                this.panel2.Controls.Add(this.tbPassword);
                this.panel2.Controls.Add(this.panel4);
                this.panel2.Location = new System.Drawing.Point(63, 196);
                this.panel2.Name = "panel2";
                this.panel2.Size = new System.Drawing.Size(463, 55);
                this.panel2.TabIndex = 6;
                // 
                // label4
                // 
                this.label4.AutoSize = true;
                this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
                this.label4.Location = new System.Drawing.Point(55, 14);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(75, 18);
                this.label4.TabIndex = 8;
                this.label4.Text = "Password";
                // 
                // tbPassword
                // 
                this.tbPassword.BackColor = System.Drawing.Color.White;
                this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.tbPassword.ForeColor = System.Drawing.SystemColors.ControlText;
                this.tbPassword.Location = new System.Drawing.Point(169, 14);
                this.tbPassword.Name = "tbPassword";
                this.tbPassword.PasswordChar = '*';
                this.tbPassword.Size = new System.Drawing.Size(260, 17);
                this.tbPassword.TabIndex = 7;
                this.tbPassword.Text = "Ivashka";
                // 
                // panel4
                // 
                this.panel4.BackColor = System.Drawing.Color.White;
                this.panel4.Location = new System.Drawing.Point(169, 36);
                this.panel4.Name = "panel4";
                this.panel4.Size = new System.Drawing.Size(260, 1);
                this.panel4.TabIndex = 5;
                // 
                // label3
                // 
                this.label3.AutoSize = true;
                this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
                this.label3.Location = new System.Drawing.Point(276, 327);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(43, 13);
                this.label3.TabIndex = 7;
                this.label3.Text = "Sign up";
                this.label3.Click += new System.EventHandler(this.label3_Click);
                // 
                // btnLogin
                // 
                this.btnLogin.BackColor = System.Drawing.Color.Transparent;
                this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
                this.btnLogin.Location = new System.Drawing.Point(198, 270);
                this.btnLogin.Name = "btnLogin";
                this.btnLogin.Size = new System.Drawing.Size(196, 40);
                this.btnLogin.TabIndex = 8;
                this.btnLogin.Text = "Sign in";
                this.btnLogin.UseVisualStyleBackColor = false;
                this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
                // 
                // AuthForm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.White;
                this.ClientSize = new System.Drawing.Size(588, 349);
                this.Controls.Add(this.btnLogin);
                this.Controls.Add(this.label3);
                this.Controls.Add(this.panel2);
                this.Controls.Add(this.panel1);
                this.Controls.Add(this.label1);
                this.Cursor = System.Windows.Forms.Cursors.Default;
                this.ForeColor = System.Drawing.SystemColors.ButtonFace;
                this.Name = "AuthForm";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Load += new System.EventHandler(this.AuthForm_Load);
                this.panel1.ResumeLayout(false);
                this.panel1.PerformLayout();
                this.panel2.ResumeLayout(false);
                this.panel2.PerformLayout();
                this.ResumeLayout(false);
                this.PerformLayout();
            }

            private System.Windows.Forms.Button btnLogin;

        #endregion

            private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label1;
    }
}