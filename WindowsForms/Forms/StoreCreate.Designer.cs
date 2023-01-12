using System.ComponentModel;

namespace WindowsForms.Forms; 

partial class StoreCreate {
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
        this.count = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.create = new System.Windows.Forms.Button();
        this.priceCombo = new System.Windows.Forms.ComboBox();
        this.bookCombo = new System.Windows.Forms.ComboBox();
        this.label3 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // count
        // 
        this.count.Location = new System.Drawing.Point(150, 140);
        this.count.Name = "count";
        this.count.Size = new System.Drawing.Size(145, 20);
        this.count.TabIndex = 25;
        // 
        // label4
        // 
        this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label4.Location = new System.Drawing.Point(25, 141);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(86, 26);
        this.label4.TabIndex = 24;
        this.label4.Text = "Books count";
        // 
        // create
        // 
        this.create.Location = new System.Drawing.Point(91, 201);
        this.create.Name = "create";
        this.create.Size = new System.Drawing.Size(129, 37);
        this.create.TabIndex = 22;
        this.create.Text = "Create";
        this.create.UseVisualStyleBackColor = true;
        this.create.Click += new System.EventHandler(this.create_Click);
        // 
        // priceCombo
        // 
        this.priceCombo.FormattingEnabled = true;
        this.priceCombo.Location = new System.Drawing.Point(150, 95);
        this.priceCombo.Name = "priceCombo";
        this.priceCombo.Size = new System.Drawing.Size(145, 21);
        this.priceCombo.TabIndex = 21;
        // 
        // bookCombo
        // 
        this.bookCombo.FormattingEnabled = true;
        this.bookCombo.Location = new System.Drawing.Point(150, 36);
        this.bookCombo.Name = "bookCombo";
        this.bookCombo.Size = new System.Drawing.Size(145, 21);
        this.bookCombo.TabIndex = 20;
        // 
        // label3
        // 
        this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label3.Location = new System.Drawing.Point(25, 95);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(79, 26);
        this.label3.TabIndex = 19;
        this.label3.Text = "Price id";
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label2.Location = new System.Drawing.Point(25, 37);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(79, 26);
        this.label2.TabIndex = 18;
        this.label2.Text = "Book id";
        // 
        // StoreCreate
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(317, 286);
        this.Controls.Add(this.count);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.create);
        this.Controls.Add(this.priceCombo);
        this.Controls.Add(this.bookCombo);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Name = "StoreCreate";
        this.Text = "StoreCreate";
        this.Load += load;
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.TextBox count;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button create;
    private System.Windows.Forms.ComboBox priceCombo;
    private System.Windows.Forms.ComboBox bookCombo;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;

#endregion
}