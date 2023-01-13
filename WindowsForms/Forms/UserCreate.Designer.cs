using System.ComponentModel;

namespace WindowsForms.Forms; 

partial class UserCreate {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
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
        this.secondName = new System.Windows.Forms.TextBox();
        this.firstName = new System.Windows.Forms.TextBox();
        this.create = new System.Windows.Forms.Button();
        this.label3 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.login = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.password = new System.Windows.Forms.TextBox();
        this.label5 = new System.Windows.Forms.Label();
        this.role = new System.Windows.Forms.ComboBox();
        this.SuspendLayout();
        // 
        // secondName
        // 
        this.secondName.Location = new System.Drawing.Point(165, 152);
        this.secondName.Name = "secondName";
        this.secondName.Size = new System.Drawing.Size(139, 20);
        this.secondName.TabIndex = 20;
        // 
        // firstName
        // 
        this.firstName.Location = new System.Drawing.Point(165, 104);
        this.firstName.Name = "firstName";
        this.firstName.Size = new System.Drawing.Size(139, 20);
        this.firstName.TabIndex = 19;
        // 
        // create
        // 
        this.create.Location = new System.Drawing.Point(112, 240);
        this.create.Name = "create";
        this.create.Size = new System.Drawing.Size(129, 37);
        this.create.TabIndex = 18;
        this.create.Text = "Create";
        this.create.UseVisualStyleBackColor = true;
        this.create.Click += new System.EventHandler(this.create_Click);
        // 
        // label3
        // 
        this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label3.Location = new System.Drawing.Point(46, 152);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(79, 26);
        this.label3.TabIndex = 17;
        this.label3.Text = "Last Name";
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label2.Location = new System.Drawing.Point(46, 105);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(79, 26);
        this.label2.TabIndex = 16;
        this.label2.Text = "First name";
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.Location = new System.Drawing.Point(46, 27);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(79, 26);
        this.label1.TabIndex = 21;
        this.label1.Text = "Login";
        // 
        // login
        // 
        this.login.Location = new System.Drawing.Point(165, 26);
        this.login.Name = "login";
        this.login.Size = new System.Drawing.Size(139, 20);
        this.login.TabIndex = 22;
        // 
        // label4
        // 
        this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label4.Location = new System.Drawing.Point(46, 65);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(79, 26);
        this.label4.TabIndex = 23;
        this.label4.Text = "Password";
        // 
        // password
        // 
        this.password.Location = new System.Drawing.Point(165, 65);
        this.password.Name = "password";
        this.password.PasswordChar = '*';
        this.password.Size = new System.Drawing.Size(139, 20);
        this.password.TabIndex = 24;
        // 
        // label5
        // 
        this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label5.Location = new System.Drawing.Point(46, 192);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(79, 26);
        this.label5.TabIndex = 25;
        this.label5.Text = "Role";
        // 
        // role
        // 
        this.role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.role.FormattingEnabled = true;
        this.role.Items.AddRange(new object[] { "admin", "user" });
        this.role.Location = new System.Drawing.Point(165, 191);
        this.role.Name = "role";
        this.role.Size = new System.Drawing.Size(139, 21);
        this.role.TabIndex = 26;
        // 
        // UserCreate
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(343, 326);
        this.Controls.Add(this.role);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.password);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.login);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.secondName);
        this.Controls.Add(this.firstName);
        this.Controls.Add(this.create);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Name = "UserCreate";
        this.Text = "UserCreate";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.TextBox secondName;
    private System.Windows.Forms.TextBox firstName;
    private System.Windows.Forms.Button create;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox login;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox password;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox role;

#endregion
}