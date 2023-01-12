using System.ComponentModel;

namespace WindowsForms.Forms; 

    partial class RegisterForm
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
                this.btnLogin = new System.Windows.Forms.Button();
                this.panel2 = new System.Windows.Forms.Panel();
                this.label3 = new System.Windows.Forms.Label();
                this.tbPassword = new System.Windows.Forms.TextBox();
                this.panel4 = new System.Windows.Forms.Panel();
                this.pictureBox2 = new System.Windows.Forms.PictureBox();
                this.panel1 = new System.Windows.Forms.Panel();
                this.panel3 = new System.Windows.Forms.Panel();
                this.label2 = new System.Windows.Forms.Label();
                this.tbUsername = new System.Windows.Forms.TextBox();
                this.pictureBox1 = new System.Windows.Forms.PictureBox();
                this.label1 = new System.Windows.Forms.Label();
                this.button1 = new System.Windows.Forms.Button();
                this.panel5 = new System.Windows.Forms.Panel();
                this.label4 = new System.Windows.Forms.Label();
                this.tbName = new System.Windows.Forms.TextBox();
                this.panel6 = new System.Windows.Forms.Panel();
                this.pictureBox3 = new System.Windows.Forms.PictureBox();
                this.panel7 = new System.Windows.Forms.Panel();
                this.label5 = new System.Windows.Forms.Label();
                this.tbSurname = new System.Windows.Forms.TextBox();
                this.panel8 = new System.Windows.Forms.Panel();
                this.pictureBox4 = new System.Windows.Forms.PictureBox();
                this.panel2.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
                this.panel1.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
                this.panel5.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
                this.panel7.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
                this.SuspendLayout();
                // 
                // btnLogin
                // 
                this.btnLogin.FlatAppearance.BorderSize = 2;
                this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
                this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.btnLogin.ForeColor = System.Drawing.Color.DarkTurquoise;
                this.btnLogin.Location = new System.Drawing.Point(105, 602);
                this.btnLogin.Name = "btnLogin";
                this.btnLogin.Size = new System.Drawing.Size(215, 41);
                this.btnLogin.TabIndex = 12;
                this.btnLogin.Text = "Зарегистрироваться";
                this.btnLogin.UseVisualStyleBackColor = true;
                this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
                this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
                this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
                // 
                // panel2
                // 
                this.panel2.Controls.Add(this.label3);
                this.panel2.Controls.Add(this.tbPassword);
                this.panel2.Controls.Add(this.panel4);
                this.panel2.Controls.Add(this.pictureBox2);
                this.panel2.Location = new System.Drawing.Point(56, 182);
                this.panel2.Name = "panel2";
                this.panel2.Size = new System.Drawing.Size(463, 55);
                this.panel2.TabIndex = 11;
                // 
                // label3
                // 
                this.label3.AutoSize = true;
                this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.label3.Location = new System.Drawing.Point(55, 19);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(83, 18);
                this.label3.TabIndex = 8;
                this.label3.Text = "Password";
                // 
                // tbPassword
                // 
                this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
                this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.tbPassword.ForeColor = System.Drawing.SystemColors.Info;
                this.tbPassword.Location = new System.Drawing.Point(169, 14);
                this.tbPassword.Name = "tbPassword";
                this.tbPassword.PasswordChar = '*';
                this.tbPassword.Size = new System.Drawing.Size(260, 17);
                this.tbPassword.TabIndex = 7;
                // 
                // panel4
                // 
                this.panel4.BackColor = System.Drawing.Color.White;
                this.panel4.Location = new System.Drawing.Point(169, 36);
                this.panel4.Name = "panel4";
                this.panel4.Size = new System.Drawing.Size(260, 1);
                this.panel4.TabIndex = 5;
                // 
                // pictureBox2
                // 
                this.pictureBox2.Location = new System.Drawing.Point(15, 14);
                this.pictureBox2.Name = "pictureBox2";
                this.pictureBox2.Size = new System.Drawing.Size(34, 34);
                this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                this.pictureBox2.TabIndex = 4;
                this.pictureBox2.TabStop = false;
                // 
                // panel1
                // 
                this.panel1.Controls.Add(this.panel3);
                this.panel1.Controls.Add(this.label2);
                this.panel1.Controls.Add(this.tbUsername);
                this.panel1.Controls.Add(this.pictureBox1);
                this.panel1.Location = new System.Drawing.Point(56, 91);
                this.panel1.Name = "panel1";
                this.panel1.Size = new System.Drawing.Size(463, 59);
                this.panel1.TabIndex = 10;
                // 
                // panel3
                // 
                this.panel3.BackColor = System.Drawing.Color.White;
                this.panel3.Location = new System.Drawing.Point(169, 40);
                this.panel3.Name = "panel3";
                this.panel3.Size = new System.Drawing.Size(260, 1);
                this.panel3.TabIndex = 7;
                // 
                // label2
                // 
                this.label2.AutoSize = true;
                this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.label2.Location = new System.Drawing.Point(55, 24);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(85, 18);
                this.label2.TabIndex = 1;
                this.label2.Text = "Username";
                // 
                // tbUsername
                // 
                this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
                this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.tbUsername.ForeColor = System.Drawing.SystemColors.Info;
                this.tbUsername.Location = new System.Drawing.Point(169, 17);
                this.tbUsername.Name = "tbUsername";
                this.tbUsername.Size = new System.Drawing.Size(260, 17);
                this.tbUsername.TabIndex = 3;
                // 
                // pictureBox1
                // 
                this.pictureBox1.Location = new System.Drawing.Point(15, 17);
                this.pictureBox1.Name = "pictureBox1";
                this.pictureBox1.Size = new System.Drawing.Size(34, 34);
                this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                this.pictureBox1.TabIndex = 4;
                this.pictureBox1.TabStop = false;
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.label1.Location = new System.Drawing.Point(184, 41);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(194, 37);
                this.label1.TabIndex = 9;
                this.label1.Text = "Регистрация";
                // 
                // button1
                // 
                this.button1.FlatAppearance.BorderSize = 2;
                this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
                this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.button1.ForeColor = System.Drawing.Color.DarkTurquoise;
                this.button1.Location = new System.Drawing.Point(359, 602);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(126, 41);
                this.button1.TabIndex = 13;
                this.button1.Text = "Авторизация";
                this.button1.UseVisualStyleBackColor = true;
                this.button1.Click += new System.EventHandler(this.button1_Click);
                this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
                this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
                // 
                // panel5
                // 
                this.panel5.Controls.Add(this.label4);
                this.panel5.Controls.Add(this.tbName);
                this.panel5.Controls.Add(this.panel6);
                this.panel5.Controls.Add(this.pictureBox3);
                this.panel5.Location = new System.Drawing.Point(56, 267);
                this.panel5.Name = "panel5";
                this.panel5.Size = new System.Drawing.Size(463, 55);
                this.panel5.TabIndex = 14;
                // 
                // label4
                // 
                this.label4.AutoSize = true;
                this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.label4.Location = new System.Drawing.Point(55, 19);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(52, 18);
                this.label4.TabIndex = 8;
                this.label4.Text = "Name";
                // 
                // tbName
                // 
                this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
                this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.tbName.ForeColor = System.Drawing.SystemColors.Info;
                this.tbName.Location = new System.Drawing.Point(169, 14);
                this.tbName.Name = "tbName";
                this.tbName.Size = new System.Drawing.Size(260, 17);
                this.tbName.TabIndex = 7;
                // 
                // panel6
                // 
                this.panel6.BackColor = System.Drawing.Color.White;
                this.panel6.Location = new System.Drawing.Point(169, 36);
                this.panel6.Name = "panel6";
                this.panel6.Size = new System.Drawing.Size(260, 1);
                this.panel6.TabIndex = 5;
                // 
                // pictureBox3
                // 
                this.pictureBox3.Location = new System.Drawing.Point(15, 14);
                this.pictureBox3.Name = "pictureBox3";
                this.pictureBox3.Size = new System.Drawing.Size(34, 34);
                this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                this.pictureBox3.TabIndex = 4;
                this.pictureBox3.TabStop = false;
                // 
                // panel7
                // 
                this.panel7.Controls.Add(this.label5);
                this.panel7.Controls.Add(this.tbSurname);
                this.panel7.Controls.Add(this.panel8);
                this.panel7.Controls.Add(this.pictureBox4);
                this.panel7.Location = new System.Drawing.Point(56, 364);
                this.panel7.Name = "panel7";
                this.panel7.Size = new System.Drawing.Size(463, 55);
                this.panel7.TabIndex = 15;
                // 
                // label5
                // 
                this.label5.AutoSize = true;
                this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.label5.Location = new System.Drawing.Point(55, 19);
                this.label5.Name = "label5";
                this.label5.Size = new System.Drawing.Size(75, 18);
                this.label5.TabIndex = 8;
                this.label5.Text = "Surname";
                // 
                // tbSurname
                // 
                this.tbSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
                this.tbSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.tbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.tbSurname.ForeColor = System.Drawing.SystemColors.Info;
                this.tbSurname.Location = new System.Drawing.Point(169, 14);
                this.tbSurname.Name = "tbSurname";
                this.tbSurname.Size = new System.Drawing.Size(260, 17);
                this.tbSurname.TabIndex = 7;
                this.tbSurname.Text = "\r\n";
                // 
                // panel8
                // 
                this.panel8.BackColor = System.Drawing.Color.White;
                this.panel8.Location = new System.Drawing.Point(169, 36);
                this.panel8.Name = "panel8";
                this.panel8.Size = new System.Drawing.Size(260, 1);
                this.panel8.TabIndex = 5;
                // 
                // pictureBox4
                // 
                this.pictureBox4.Location = new System.Drawing.Point(15, 14);
                this.pictureBox4.Name = "pictureBox4";
                this.pictureBox4.Size = new System.Drawing.Size(34, 34);
                this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                this.pictureBox4.TabIndex = 4;
                this.pictureBox4.TabStop = false;
                // 
                // RegisterForm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
                this.ClientSize = new System.Drawing.Size(576, 680);
                this.Controls.Add(this.panel7);
                this.Controls.Add(this.panel5);
                this.Controls.Add(this.button1);
                this.Controls.Add(this.btnLogin);
                this.Controls.Add(this.panel2);
                this.Controls.Add(this.panel1);
                this.Controls.Add(this.label1);
                this.ForeColor = System.Drawing.SystemColors.ButtonFace;
                this.Name = "RegisterForm";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Text = "Регистрация";
                this.Load += new System.EventHandler(this.RegisterForm_Load);
                this.panel2.ResumeLayout(false);
                this.panel2.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
                this.panel1.ResumeLayout(false);
                this.panel1.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
                this.panel5.ResumeLayout(false);
                this.panel5.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
                this.panel7.ResumeLayout(false);
                this.panel7.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
                this.ResumeLayout(false);
                this.PerformLayout();
            }

            private System.Windows.Forms.Panel panel7;
            private System.Windows.Forms.Label label5;
            private System.Windows.Forms.TextBox tbSurname;
            private System.Windows.Forms.Panel panel8;
            private System.Windows.Forms.PictureBox pictureBox4;

            private System.Windows.Forms.Panel panel5;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.TextBox tbName;
            private System.Windows.Forms.Panel panel6;
            private System.Windows.Forms.PictureBox pictureBox3;

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
