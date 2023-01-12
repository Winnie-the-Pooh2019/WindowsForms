using System.ComponentModel;

namespace WindowsForms.Forms; 

partial class CutomerCreate {
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
        this.create = new System.Windows.Forms.Button();
        this.label3 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.firstName = new System.Windows.Forms.TextBox();
        this.secondName = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // create
        // 
        this.create.Location = new System.Drawing.Point(100, 198);
        this.create.Name = "create";
        this.create.Size = new System.Drawing.Size(129, 37);
        this.create.TabIndex = 13;
        this.create.Text = "Create";
        this.create.UseVisualStyleBackColor = true;
        this.create.Click += new System.EventHandler(this.create_Click);
        // 
        // label3
        // 
        this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label3.Location = new System.Drawing.Point(34, 92);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(79, 26);
        this.label3.TabIndex = 9;
        this.label3.Text = "Last Name";
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label2.Location = new System.Drawing.Point(34, 34);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(79, 26);
        this.label2.TabIndex = 8;
        this.label2.Text = "First name";
        // 
        // firstName
        // 
        this.firstName.Location = new System.Drawing.Point(153, 33);
        this.firstName.Name = "firstName";
        this.firstName.Size = new System.Drawing.Size(139, 20);
        this.firstName.TabIndex = 14;
        // 
        // secondName
        // 
        this.secondName.Location = new System.Drawing.Point(151, 91);
        this.secondName.Name = "secondName";
        this.secondName.Size = new System.Drawing.Size(141, 20);
        this.secondName.TabIndex = 15;
        // 
        // CutomerCreate
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(331, 281);
        this.Controls.Add(this.secondName);
        this.Controls.Add(this.firstName);
        this.Controls.Add(this.create);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Name = "CutomerCreate";
        this.Text = "CutomerCreate";
        this.Load += new System.EventHandler(this.CutomerCreate_Load);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.TextBox firstName;
    private System.Windows.Forms.TextBox secondName;

    private System.Windows.Forms.Button create;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;

#endregion
}