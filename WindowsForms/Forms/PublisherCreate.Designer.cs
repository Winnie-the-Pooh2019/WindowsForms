using System.ComponentModel;

namespace WindowsForms.Forms; 

partial class PublisherCreate {
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
        this.name = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // create
        // 
        this.create.Location = new System.Drawing.Point(124, 122);
        this.create.Name = "create";
        this.create.Size = new System.Drawing.Size(129, 37);
        this.create.TabIndex = 16;
        this.create.Text = "Create";
        this.create.UseVisualStyleBackColor = true;
        this.create.Click += new System.EventHandler(this.create_Click);
        // 
        // name
        // 
        this.name.Location = new System.Drawing.Point(180, 47);
        this.name.Name = "name";
        this.name.Size = new System.Drawing.Size(144, 20);
        this.name.TabIndex = 15;
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.Location = new System.Drawing.Point(58, 48);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(66, 23);
        this.label1.TabIndex = 14;
        this.label1.Text = "Name";
        // 
        // PublisherCreate
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(372, 219);
        this.Controls.Add(this.create);
        this.Controls.Add(this.name);
        this.Controls.Add(this.label1);
        this.Name = "PublisherCreate";
        this.Text = "PublisherCreate";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button create;
    private System.Windows.Forms.TextBox name;
    private System.Windows.Forms.Label label1;

#endregion
}