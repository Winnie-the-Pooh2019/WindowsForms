using System.ComponentModel;

namespace WindowsForms.Forms; 

partial class PurchaseItemCreate {
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
        this.priceCombo = new System.Windows.Forms.ComboBox();
        this.bookCombo = new System.Windows.Forms.ComboBox();
        this.label3 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.purchaseCombo = new System.Windows.Forms.ComboBox();
        this.label4 = new System.Windows.Forms.Label();
        this.count = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // create
        // 
        this.create.Location = new System.Drawing.Point(111, 269);
        this.create.Name = "create";
        this.create.Size = new System.Drawing.Size(129, 37);
        this.create.TabIndex = 13;
        this.create.Text = "Create";
        this.create.UseVisualStyleBackColor = true;
        this.create.Click += new System.EventHandler(this.create_Click);
        // 
        // priceCombo
        // 
        this.priceCombo.FormattingEnabled = true;
        this.priceCombo.Location = new System.Drawing.Point(170, 163);
        this.priceCombo.Name = "priceCombo";
        this.priceCombo.Size = new System.Drawing.Size(145, 21);
        this.priceCombo.TabIndex = 12;
        // 
        // bookCombo
        // 
        this.bookCombo.FormattingEnabled = true;
        this.bookCombo.Location = new System.Drawing.Point(170, 104);
        this.bookCombo.Name = "bookCombo";
        this.bookCombo.Size = new System.Drawing.Size(145, 21);
        this.bookCombo.TabIndex = 11;
        // 
        // label3
        // 
        this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label3.Location = new System.Drawing.Point(45, 163);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(79, 26);
        this.label3.TabIndex = 9;
        this.label3.Text = "Price id";
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label2.Location = new System.Drawing.Point(45, 105);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(79, 26);
        this.label2.TabIndex = 8;
        this.label2.Text = "Book id";
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.Location = new System.Drawing.Point(45, 46);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(86, 23);
        this.label1.TabIndex = 7;
        this.label1.Text = "Purchase id";
        // 
        // purchaseCombo
        // 
        this.purchaseCombo.FormattingEnabled = true;
        this.purchaseCombo.Location = new System.Drawing.Point(170, 45);
        this.purchaseCombo.Name = "purchaseCombo";
        this.purchaseCombo.Size = new System.Drawing.Size(145, 21);
        this.purchaseCombo.TabIndex = 14;
        // 
        // label4
        // 
        this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label4.Location = new System.Drawing.Point(45, 209);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(86, 26);
        this.label4.TabIndex = 15;
        this.label4.Text = "Books count";
        // 
        // count
        // 
        this.count.Location = new System.Drawing.Point(170, 208);
        this.count.Name = "count";
        this.count.Size = new System.Drawing.Size(145, 20);
        this.count.TabIndex = 16;
        // 
        // PurchaseItemCreate
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(353, 352);
        this.Controls.Add(this.count);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.purchaseCombo);
        this.Controls.Add(this.create);
        this.Controls.Add(this.priceCombo);
        this.Controls.Add(this.bookCombo);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Name = "PurchaseItemCreate";
        this.Text = "PurchaseItemCreate";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button create;
    private System.Windows.Forms.ComboBox priceCombo;
    private System.Windows.Forms.ComboBox bookCombo;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox purchaseCombo;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox count;

#endregion
}