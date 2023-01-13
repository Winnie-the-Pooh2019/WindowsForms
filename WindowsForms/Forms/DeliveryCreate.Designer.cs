using System.ComponentModel;

namespace WindowsForms.Forms; 

partial class DeliveryCreate {
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
        this.create = new System.Windows.Forms.Button();
        this.label3 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.bookCombo = new System.Windows.Forms.ComboBox();
        this.deliveryPiker = new System.Windows.Forms.DateTimePicker();
        this.booksCount = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.price = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.Location = new System.Drawing.Point(53, 48);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(66, 23);
        this.label1.TabIndex = 7;
        this.label1.Text = "Book Id";
        // 
        // create
        // 
        this.create.Location = new System.Drawing.Point(119, 271);
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
        this.label3.Location = new System.Drawing.Point(53, 165);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(91, 26);
        this.label3.TabIndex = 9;
        this.label3.Text = "Books count";
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label2.Location = new System.Drawing.Point(53, 107);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(102, 26);
        this.label2.TabIndex = 8;
        this.label2.Text = "Delivery date";
        // 
        // bookCombo
        // 
        this.bookCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.bookCombo.FormattingEnabled = true;
        this.bookCombo.Location = new System.Drawing.Point(178, 47);
        this.bookCombo.Name = "bookCombo";
        this.bookCombo.Size = new System.Drawing.Size(145, 21);
        this.bookCombo.TabIndex = 14;
        // 
        // deliveryPiker
        // 
        this.deliveryPiker.Location = new System.Drawing.Point(179, 103);
        this.deliveryPiker.Name = "deliveryPiker";
        this.deliveryPiker.Size = new System.Drawing.Size(144, 20);
        this.deliveryPiker.TabIndex = 15;
        // 
        // booksCount
        // 
        this.booksCount.Location = new System.Drawing.Point(179, 164);
        this.booksCount.Name = "booksCount";
        this.booksCount.Size = new System.Drawing.Size(144, 20);
        this.booksCount.TabIndex = 16;
        // 
        // label4
        // 
        this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label4.Location = new System.Drawing.Point(53, 217);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(91, 26);
        this.label4.TabIndex = 17;
        this.label4.Text = "Price";
        // 
        // price
        // 
        this.price.Location = new System.Drawing.Point(179, 216);
        this.price.Name = "price";
        this.price.Size = new System.Drawing.Size(144, 20);
        this.price.TabIndex = 18;
        // 
        // DeliveryCreate
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(377, 362);
        this.Controls.Add(this.price);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.booksCount);
        this.Controls.Add(this.deliveryPiker);
        this.Controls.Add(this.bookCombo);
        this.Controls.Add(this.create);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Name = "DeliveryCreate";
        this.Text = "DeliveryCreate";
        this.Load += load;
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button create;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox bookCombo;
    private System.Windows.Forms.DateTimePicker deliveryPiker;
    private System.Windows.Forms.TextBox booksCount;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox price;

#endregion
}