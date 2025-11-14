namespace Calculadora_Winforms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtNoIva = new TextBox();
            txtWithIva = new TextBox();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblNoIva = new Label();
            lblWithIva = new Label();
            btnCalculate = new Button();
            chkPartner = new CheckBox();
            grpIva = new GroupBox();
            rbIva0 = new RadioButton();
            rbIva4 = new RadioButton();
            rbIva10 = new RadioButton();
            rbIva21 = new RadioButton();
            grpDiscount = new GroupBox();
            rbD0 = new RadioButton();
            rbD5 = new RadioButton();
            rbD10 = new RadioButton();
            rbD20 = new RadioButton();
            grpIva.SuspendLayout();
            grpDiscount.SuspendLayout();
            SuspendLayout();
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(120, 27);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 4;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(120, 67);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 5;
            // 
            // txtNoIva
            // 
            txtNoIva.Location = new Point(120, 217);
            txtNoIva.Name = "txtNoIva";
            txtNoIva.ReadOnly = true;
            txtNoIva.Size = new Size(100, 23);
            txtNoIva.TabIndex = 6;
            // 
            // txtWithIva
            // 
            txtWithIva.Location = new Point(120, 257);
            txtWithIva.Name = "txtWithIva";
            txtWithIva.ReadOnly = true;
            txtWithIva.Size = new Size(100, 23);
            txtWithIva.TabIndex = 7;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(30, 30);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 0;
            lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(30, 70);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "Quantity";
            // 
            // lblNoIva
            // 
            lblNoIva.AutoSize = true;
            lblNoIva.Location = new Point(30, 220);
            lblNoIva.Name = "lblNoIva";
            lblNoIva.Size = new Size(45, 15);
            lblNoIva.TabIndex = 2;
            lblNoIva.Text = "NO IVA";
            // 
            // lblWithIva
            // 
            lblWithIva.AutoSize = true;
            lblWithIva.Location = new Point(30, 260);
            lblWithIva.Name = "lblWithIva";
            lblWithIva.Size = new Size(52, 15);
            lblWithIva.TabIndex = 3;
            lblWithIva.Text = "With IVA";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(30, 150);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 30);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate";
            btnCalculate.Click += btnCalculate_Click;
            // 
            // chkPartner
            // 
            chkPartner.Location = new Point(200, 150);
            chkPartner.Name = "chkPartner";
            chkPartner.Size = new Size(104, 24);
            chkPartner.TabIndex = 9;
            chkPartner.Text = "Partner (30%)";
            chkPartner.CheckedChanged += chkPartner_CheckedChanged;
            // 
            // grpIva
            // 
            grpIva.Controls.Add(rbIva0);
            grpIva.Controls.Add(rbIva4);
            grpIva.Controls.Add(rbIva10);
            grpIva.Controls.Add(rbIva21);
            grpIva.Location = new Point(250, 30);
            grpIva.Name = "grpIva";
            grpIva.Size = new Size(150, 120);
            grpIva.TabIndex = 10;
            grpIva.TabStop = false;
            grpIva.Text = "IVA";
            // 
            // rbIva0
            // 
            rbIva0.Checked = true;
            rbIva0.Location = new Point(10, 20);
            rbIva0.Name = "rbIva0";
            rbIva0.Size = new Size(104, 24);
            rbIva0.TabIndex = 0;
            rbIva0.TabStop = true;
            rbIva0.Text = "0 %";
            // 
            // rbIva4
            // 
            rbIva4.Location = new Point(10, 40);
            rbIva4.Name = "rbIva4";
            rbIva4.Size = new Size(104, 24);
            rbIva4.TabIndex = 1;
            rbIva4.Text = "4 %";
            // 
            // rbIva10
            // 
            rbIva10.Location = new Point(10, 60);
            rbIva10.Name = "rbIva10";
            rbIva10.Size = new Size(104, 24);
            rbIva10.TabIndex = 2;
            rbIva10.Text = "10 %";
            // 
            // rbIva21
            // 
            rbIva21.Location = new Point(10, 80);
            rbIva21.Name = "rbIva21";
            rbIva21.Size = new Size(104, 24);
            rbIva21.TabIndex = 3;
            rbIva21.Text = "21 %";
            // 
            // grpDiscount
            // 
            grpDiscount.Controls.Add(rbD0);
            grpDiscount.Controls.Add(rbD5);
            grpDiscount.Controls.Add(rbD10);
            grpDiscount.Controls.Add(rbD20);
            grpDiscount.Location = new Point(450, 30);
            grpDiscount.Name = "grpDiscount";
            grpDiscount.Size = new Size(150, 120);
            grpDiscount.TabIndex = 11;
            grpDiscount.TabStop = false;
            grpDiscount.Text = "Discount";
            // 
            // rbD0
            // 
            rbD0.Checked = true;
            rbD0.Location = new Point(10, 20);
            rbD0.Name = "rbD0";
            rbD0.Size = new Size(104, 24);
            rbD0.TabIndex = 0;
            rbD0.TabStop = true;
            rbD0.Text = "0 %";
            // 
            // rbD5
            // 
            rbD5.Location = new Point(10, 40);
            rbD5.Name = "rbD5";
            rbD5.Size = new Size(104, 24);
            rbD5.TabIndex = 1;
            rbD5.Text = "5 %";
            // 
            // rbD10
            // 
            rbD10.Location = new Point(10, 60);
            rbD10.Name = "rbD10";
            rbD10.Size = new Size(104, 24);
            rbD10.TabIndex = 2;
            rbD10.Text = "10 %";
            // 
            // rbD20
            // 
            rbD20.Location = new Point(10, 80);
            rbD20.Name = "rbD20";
            rbD20.Size = new Size(104, 24);
            rbD20.TabIndex = 3;
            rbD20.Text = "20 %";
            // 
            // Form1
            // 
            ClientSize = new Size(650, 300);
            Controls.Add(lblPrice);
            Controls.Add(lblQuantity);
            Controls.Add(lblNoIva);
            Controls.Add(lblWithIva);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtNoIva);
            Controls.Add(txtWithIva);
            Controls.Add(btnCalculate);
            Controls.Add(chkPartner);
            Controls.Add(grpIva);
            Controls.Add(grpDiscount);
            Name = "Form1";
            Text = "IVA Calculator";
            grpIva.ResumeLayout(false);
            grpDiscount.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtNoIva;
        private System.Windows.Forms.TextBox txtWithIva;

        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblNoIva;
        private System.Windows.Forms.Label lblWithIva;

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.CheckBox chkPartner;

        private System.Windows.Forms.GroupBox grpIva;
        private System.Windows.Forms.RadioButton rbIva0;
        private System.Windows.Forms.RadioButton rbIva4;
        private System.Windows.Forms.RadioButton rbIva10;
        private System.Windows.Forms.RadioButton rbIva21;

        private System.Windows.Forms.GroupBox grpDiscount;
        private System.Windows.Forms.RadioButton rbD0;
        private System.Windows.Forms.RadioButton rbD5;
        private System.Windows.Forms.RadioButton rbD10;
        private System.Windows.Forms.RadioButton rbD20;
    }
}
