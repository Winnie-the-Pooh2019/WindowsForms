using System.ComponentModel;

namespace WindowsForms.Forms; 

partial class BookCreate {
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
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.name = new System.Windows.Forms.TextBox();
        this.publisher = new System.Windows.Forms.ComboBox();
        this.category = new System.Windows.Forms.ComboBox();
        this.create = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.Location = new System.Drawing.Point(61, 63);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(66, 23);
        this.label1.TabIndex = 0;
        this.label1.Text = "Name";
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label2.Location = new System.Drawing.Point(61, 122);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(79, 26);
        this.label2.TabIndex = 1;
        this.label2.Text = "Publisher";
        // 
        // label3
        // 
        this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label3.Location = new System.Drawing.Point(61, 180);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(79, 26);
        this.label3.TabIndex = 2;
        this.label3.Text = "Category";
        // 
        // name
        // 
        this.name.Location = new System.Drawing.Point(187, 57);
        this.name.Name = "name";
        this.name.Size = new System.Drawing.Size(144, 20);
        this.name.TabIndex = 3;
        // 
        // publisher
        // 
        this.publisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.publisher.FormattingEnabled = true;
        this.publisher.Location = new System.Drawing.Point(186, 121);
        this.publisher.Name = "publisher";
        this.publisher.Size = new System.Drawing.Size(145, 21);
        this.publisher.TabIndex = 4;
        // 
        // category
        // 
        this.category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.category.FormattingEnabled = true;
        this.category.Location = new System.Drawing.Point(186, 180);
        this.category.Name = "category";
        this.category.Size = new System.Drawing.Size(145, 21);
        this.category.TabIndex = 5;
        // 
        // create
        // 
        this.create.Location = new System.Drawing.Point(127, 286);
        this.create.Name = "create";
        this.create.Size = new System.Drawing.Size(129, 37);
        this.create.TabIndex = 6;
        this.create.Text = "Create";
        this.create.UseVisualStyleBackColor = true;
        this.create.Click += new System.EventHandler(this.create_Click);
        // 
        // BookCreate
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(389, 364);
        this.Controls.Add(this.create);
        this.Controls.Add(this.category);
        this.Controls.Add(this.publisher);
        this.Controls.Add(this.name);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Name = "BookCreate";
        this.Text = "BookCreate";
        this.Load += load;
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox name;
    private System.Windows.Forms.ComboBox publisher;
    private System.Windows.Forms.ComboBox category;
    private System.Windows.Forms.Button create;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

#endregion
}