using System.ComponentModel;

namespace WindowsForms.Forms; 

partial class PriceCreate {
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
        this.price = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.datePiker = new System.Windows.Forms.DateTimePicker();
        this.create = new System.Windows.Forms.Button();
        this.label2 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // price
        // 
        this.price.Location = new System.Drawing.Point(160, 126);
        this.price.Name = "price";
        this.price.Size = new System.Drawing.Size(144, 20);
        this.price.TabIndex = 27;
        // 
        // label4
        // 
        this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label4.Location = new System.Drawing.Point(37, 127);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(91, 26);
        this.label4.TabIndex = 26;
        this.label4.Text = "Price";
        // 
        // datePiker
        // 
        this.datePiker.Location = new System.Drawing.Point(160, 63);
        this.datePiker.Name = "datePiker";
        this.datePiker.Size = new System.Drawing.Size(144, 20);
        this.datePiker.TabIndex = 24;
        // 
        // create
        // 
        this.create.Location = new System.Drawing.Point(103, 181);
        this.create.Name = "create";
        this.create.Size = new System.Drawing.Size(129, 37);
        this.create.TabIndex = 22;
        this.create.Text = "Create";
        this.create.UseVisualStyleBackColor = true;
        this.create.Click += new System.EventHandler(this.create_Click);
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label2.Location = new System.Drawing.Point(34, 48);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(102, 35);
        this.label2.TabIndex = 20;
        this.label2.Text = "Price change date";
        // 
        // PriceCreate
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(345, 269);
        this.Controls.Add(this.price);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.datePiker);
        this.Controls.Add(this.create);
        this.Controls.Add(this.label2);
        this.Name = "PriceCreate";
        this.Text = "PriceCreate";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.TextBox price;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DateTimePicker datePiker;
    private System.Windows.Forms.Button create;
    private System.Windows.Forms.Label label2;

#endregion
}