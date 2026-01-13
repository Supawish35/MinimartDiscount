namespace MinimartDiscount;

partial class Form1 {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        txtPurchaseInput = new System.Windows.Forms.TextBox();
        calculateBtn = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        ckbMember = new System.Windows.Forms.CheckBox();
        groupBox1 = new System.Windows.Forms.GroupBox();
        groupBox2 = new System.Windows.Forms.GroupBox();
        label6 = new System.Windows.Forms.Label();
        txtSuggestion = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        txtTotalAmount = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        txtDiscount = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        txtLevel = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        txtPurchase = new System.Windows.Forms.TextBox();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // txtPurchaseInput
        // 
        txtPurchaseInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtPurchaseInput.Location = new System.Drawing.Point(87, 26);
        txtPurchaseInput.Name = "txtPurchaseInput";
        txtPurchaseInput.Size = new System.Drawing.Size(518, 27);
        txtPurchaseInput.TabIndex = 0;
        // 
        // calculateBtn
        // 
        calculateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        calculateBtn.Location = new System.Drawing.Point(624, 24);
        calculateBtn.Name = "calculateBtn";
        calculateBtn.Size = new System.Drawing.Size(82, 31);
        calculateBtn.TabIndex = 1;
        calculateBtn.Text = "Calculate";
        calculateBtn.UseVisualStyleBackColor = true;
        calculateBtn.Click += button1_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(17, 30);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(64, 23);
        label1.TabIndex = 2;
        label1.Text = "ยอดซื้อ";
        // 
        // ckbMember
        // 
        ckbMember.Location = new System.Drawing.Point(87, 59);
        ckbMember.Name = "ckbMember";
        ckbMember.Size = new System.Drawing.Size(104, 24);
        ckbMember.TabIndex = 3;
        ckbMember.Text = "Member";
        ckbMember.UseVisualStyleBackColor = true;
        // 
        // groupBox1
        // 
        groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        groupBox1.Controls.Add(ckbMember);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(calculateBtn);
        groupBox1.Controls.Add(txtPurchaseInput);
        groupBox1.Location = new System.Drawing.Point(12, 18);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(733, 110);
        groupBox1.TabIndex = 4;
        groupBox1.TabStop = false;
        groupBox1.Text = "Input";
        // 
        // groupBox2
        // 
        groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        groupBox2.Controls.Add(label6);
        groupBox2.Controls.Add(txtSuggestion);
        groupBox2.Controls.Add(label5);
        groupBox2.Controls.Add(txtTotalAmount);
        groupBox2.Controls.Add(label4);
        groupBox2.Controls.Add(txtDiscount);
        groupBox2.Controls.Add(label3);
        groupBox2.Controls.Add(txtLevel);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(txtPurchase);
        groupBox2.Location = new System.Drawing.Point(12, 134);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(733, 289);
        groupBox2.TabIndex = 5;
        groupBox2.TabStop = false;
        groupBox2.Text = "Result";
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(39, 158);
        label6.Name = "label6";
        label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        label6.Size = new System.Drawing.Size(111, 23);
        label6.TabIndex = 10;
        label6.Text = "แนะนำ";
        // 
        // txtSuggestion
        // 
        txtSuggestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtSuggestion.Location = new System.Drawing.Point(156, 158);
        txtSuggestion.Name = "txtSuggestion";
        txtSuggestion.ReadOnly = true;
        txtSuggestion.Size = new System.Drawing.Size(550, 27);
        txtSuggestion.TabIndex = 9;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(39, 125);
        label5.Name = "label5";
        label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        label5.Size = new System.Drawing.Size(111, 23);
        label5.TabIndex = 8;
        label5.Text = "ราคาที่ต้องจ่าย";
        // 
        // txtTotalAmount
        // 
        txtTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtTotalAmount.Location = new System.Drawing.Point(156, 125);
        txtTotalAmount.Name = "txtTotalAmount";
        txtTotalAmount.ReadOnly = true;
        txtTotalAmount.Size = new System.Drawing.Size(550, 27);
        txtTotalAmount.TabIndex = 7;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(39, 92);
        label4.Name = "label4";
        label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        label4.Size = new System.Drawing.Size(111, 23);
        label4.TabIndex = 6;
        label4.Text = "ส่วนลดที่ได้รับ";
        // 
        // txtDiscount
        // 
        txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtDiscount.Location = new System.Drawing.Point(156, 92);
        txtDiscount.Name = "txtDiscount";
        txtDiscount.ReadOnly = true;
        txtDiscount.Size = new System.Drawing.Size(550, 27);
        txtDiscount.TabIndex = 5;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(39, 59);
        label3.Name = "label3";
        label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        label3.Size = new System.Drawing.Size(111, 23);
        label3.TabIndex = 4;
        label3.Text = "ได้รับส่วนลดระดับ";
        // 
        // txtLevel
        // 
        txtLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtLevel.Location = new System.Drawing.Point(156, 59);
        txtLevel.Name = "txtLevel";
        txtLevel.ReadOnly = true;
        txtLevel.Size = new System.Drawing.Size(550, 27);
        txtLevel.TabIndex = 3;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(39, 26);
        label2.Name = "label2";
        label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        label2.Size = new System.Drawing.Size(111, 23);
        label2.TabIndex = 2;
        label2.Text = "ยอดซื้อ";
        // 
        // txtPurchase
        // 
        txtPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        txtPurchase.Location = new System.Drawing.Point(156, 26);
        txtPurchase.Name = "txtPurchase";
        txtPurchase.ReadOnly = true;
        txtPurchase.Size = new System.Drawing.Size(550, 27);
        txtPurchase.TabIndex = 0;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(757, 450);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Text = "Form1";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtSuggestion;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtLevel;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtDiscount;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtTotalAmount;

    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtPurchase;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.CheckBox ckbMember;

    private System.Windows.Forms.TextBox txtPurchaseInput;
    private System.Windows.Forms.Button calculateBtn;
    private System.Windows.Forms.Label label1;

    #endregion
}