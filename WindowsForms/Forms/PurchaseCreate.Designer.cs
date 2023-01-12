using System.ComponentModel;

namespace WindowsForms.Forms; 

partial class PurchaseCreate {
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
        this.datePiker = new System.Windows.Forms.DateTimePicker();
        this.clientsCombo = new System.Windows.Forms.ComboBox();
        this.create = new System.Windows.Forms.Button();
        this.label2 = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // datePiker
        // 
        this.datePiker.Location = new System.Drawing.Point(163, 93);
        this.datePiker.Name = "datePiker";
        this.datePiker.Size = new System.Drawing.Size(144, 20);
        this.datePiker.TabIndex = 24;
        // 
        // clientsCombo
        // 
        this.clientsCombo.FormattingEnabled = true;
        this.clientsCombo.Location = new System.Drawing.Point(162, 37);
        this.clientsCombo.Name = "clientsCombo";
        this.clientsCombo.Size = new System.Drawing.Size(145, 21);
        this.clientsCombo.TabIndex = 23;
        // 
        // create
        // 
        this.create.Location = new System.Drawing.Point(107, 166);
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
        this.label2.Location = new System.Drawing.Point(37, 97);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(102, 26);
        this.label2.TabIndex = 20;
        this.label2.Text = "Purchase date";
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.Location = new System.Drawing.Point(37, 38);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(66, 23);
        this.label1.TabIndex = 19;
        this.label1.Text = "Client id";
        this.label1.Click += new System.EventHandler(this.label1_Click);
        // 
        // PurchaseCreate
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(342, 242);
        this.Controls.Add(this.datePiker);
        this.Controls.Add(this.clientsCombo);
        this.Controls.Add(this.create);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Name = "PurchaseCreate";
        this.Text = "PurchaseCreate";
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.DateTimePicker datePiker;
    private System.Windows.Forms.ComboBox clientsCombo;
    private System.Windows.Forms.Button create;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;

#endregion
}