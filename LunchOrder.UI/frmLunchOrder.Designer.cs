namespace LunchOrder.UI
{
    partial class frmLunchOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbMain = new System.Windows.Forms.GroupBox();
            this.grbAddOn = new System.Windows.Forms.GroupBox();
            this.grbTotal = new System.Windows.Forms.GroupBox();
            this.radHamburger = new System.Windows.Forms.RadioButton();
            this.radPizza = new System.Windows.Forms.RadioButton();
            this.radSalad = new System.Windows.Forms.RadioButton();
            this.chkAdd1 = new System.Windows.Forms.CheckBox();
            this.chkAdd2 = new System.Windows.Forms.CheckBox();
            this.chkAdd3 = new System.Windows.Forms.CheckBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSubDisplay = new System.Windows.Forms.Label();
            this.lblTaxDisplay = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblOrderTotalDisplay = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbMain.SuspendLayout();
            this.grbAddOn.SuspendLayout();
            this.grbTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMain
            // 
            this.grbMain.Controls.Add(this.radSalad);
            this.grbMain.Controls.Add(this.radPizza);
            this.grbMain.Controls.Add(this.radHamburger);
            this.grbMain.Location = new System.Drawing.Point(14, 14);
            this.grbMain.Name = "grbMain";
            this.grbMain.Size = new System.Drawing.Size(186, 167);
            this.grbMain.TabIndex = 0;
            this.grbMain.TabStop = false;
            this.grbMain.Text = "Main Course";
            // 
            // grbAddOn
            // 
            this.grbAddOn.Controls.Add(this.chkAdd3);
            this.grbAddOn.Controls.Add(this.chkAdd2);
            this.grbAddOn.Controls.Add(this.chkAdd1);
            this.grbAddOn.Location = new System.Drawing.Point(236, 14);
            this.grbAddOn.Name = "grbAddOn";
            this.grbAddOn.Size = new System.Drawing.Size(234, 167);
            this.grbAddOn.TabIndex = 1;
            this.grbAddOn.TabStop = false;
            this.grbAddOn.Text = "Add-on Items ($ Each)";
            // 
            // grbTotal
            // 
            this.grbTotal.Controls.Add(this.lblOrderTotalDisplay);
            this.grbTotal.Controls.Add(this.lblOrderTotal);
            this.grbTotal.Controls.Add(this.lblTaxDisplay);
            this.grbTotal.Controls.Add(this.lblTax);
            this.grbTotal.Controls.Add(this.lblSubDisplay);
            this.grbTotal.Controls.Add(this.lblSubtotal);
            this.grbTotal.Location = new System.Drawing.Point(14, 207);
            this.grbTotal.Name = "grbTotal";
            this.grbTotal.Size = new System.Drawing.Size(258, 180);
            this.grbTotal.TabIndex = 1;
            this.grbTotal.TabStop = false;
            this.grbTotal.Text = "Order Total";
            // 
            // radHamburger
            // 
            this.radHamburger.AutoSize = true;
            this.radHamburger.Location = new System.Drawing.Point(23, 35);
            this.radHamburger.Name = "radHamburger";
            this.radHamburger.Size = new System.Drawing.Size(129, 19);
            this.radHamburger.TabIndex = 0;
            this.radHamburger.TabStop = true;
            this.radHamburger.Text = "Hamburger - $6.95";
            this.radHamburger.UseVisualStyleBackColor = true;
            this.radHamburger.CheckedChanged += new System.EventHandler(this.radHamburger_CheckedChanged);
            // 
            // radPizza
            // 
            this.radPizza.AutoSize = true;
            this.radPizza.Location = new System.Drawing.Point(23, 73);
            this.radPizza.Name = "radPizza";
            this.radPizza.Size = new System.Drawing.Size(96, 19);
            this.radPizza.TabIndex = 1;
            this.radPizza.TabStop = true;
            this.radPizza.Text = "Pizza - $5.95";
            this.radPizza.UseVisualStyleBackColor = true;
            this.radPizza.CheckedChanged += new System.EventHandler(this.radPizza_CheckedChanged);
            // 
            // radSalad
            // 
            this.radSalad.AutoSize = true;
            this.radSalad.Location = new System.Drawing.Point(23, 112);
            this.radSalad.Name = "radSalad";
            this.radSalad.Size = new System.Drawing.Size(98, 19);
            this.radSalad.TabIndex = 2;
            this.radSalad.TabStop = true;
            this.radSalad.Text = "Salad - $4.95";
            this.radSalad.UseVisualStyleBackColor = true;
            this.radSalad.CheckedChanged += new System.EventHandler(this.radSalad_CheckedChanged);
            // 
            // chkAdd1
            // 
            this.chkAdd1.AutoSize = true;
            this.chkAdd1.Location = new System.Drawing.Point(26, 34);
            this.chkAdd1.Name = "chkAdd1";
            this.chkAdd1.Size = new System.Drawing.Size(75, 19);
            this.chkAdd1.TabIndex = 0;
            this.chkAdd1.Text = "Add-on 1";
            this.chkAdd1.UseVisualStyleBackColor = true;
            this.chkAdd1.CheckedChanged += new System.EventHandler(this.chkAdd1_CheckedChanged);
            // 
            // chkAdd2
            // 
            this.chkAdd2.AutoSize = true;
            this.chkAdd2.Location = new System.Drawing.Point(26, 74);
            this.chkAdd2.Name = "chkAdd2";
            this.chkAdd2.Size = new System.Drawing.Size(75, 19);
            this.chkAdd2.TabIndex = 1;
            this.chkAdd2.Text = "Add-on 2";
            this.chkAdd2.UseVisualStyleBackColor = true;
            this.chkAdd2.CheckedChanged += new System.EventHandler(this.chkAdd2_CheckedChanged);
            // 
            // chkAdd3
            // 
            this.chkAdd3.AutoSize = true;
            this.chkAdd3.Location = new System.Drawing.Point(26, 114);
            this.chkAdd3.Name = "chkAdd3";
            this.chkAdd3.Size = new System.Drawing.Size(75, 19);
            this.chkAdd3.TabIndex = 2;
            this.chkAdd3.Text = "Add-on 3";
            this.chkAdd3.UseVisualStyleBackColor = true;
            this.chkAdd3.CheckedChanged += new System.EventHandler(this.chkAdd3_CheckedChanged);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(49, 38);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(55, 15);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSubDisplay
            // 
            this.lblSubDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubDisplay.Location = new System.Drawing.Point(110, 33);
            this.lblSubDisplay.Name = "lblSubDisplay";
            this.lblSubDisplay.Size = new System.Drawing.Size(121, 25);
            this.lblSubDisplay.TabIndex = 1;
            this.lblSubDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTaxDisplay
            // 
            this.lblTaxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTaxDisplay.Location = new System.Drawing.Point(110, 84);
            this.lblTaxDisplay.Name = "lblTaxDisplay";
            this.lblTaxDisplay.Size = new System.Drawing.Size(121, 25);
            this.lblTaxDisplay.TabIndex = 3;
            this.lblTaxDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(28, 89);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(76, 15);
            this.lblTax.TabIndex = 2;
            this.lblTax.Text = "Tax (7.75%):";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOrderTotalDisplay
            // 
            this.lblOrderTotalDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrderTotalDisplay.Location = new System.Drawing.Point(110, 135);
            this.lblOrderTotalDisplay.Name = "lblOrderTotalDisplay";
            this.lblOrderTotalDisplay.Size = new System.Drawing.Size(121, 25);
            this.lblOrderTotalDisplay.TabIndex = 5;
            this.lblOrderTotalDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Location = new System.Drawing.Point(33, 140);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(71, 15);
            this.lblOrderTotal.TabIndex = 4;
            this.lblOrderTotal.Text = "Order Total:";
            this.lblOrderTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(301, 287);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(112, 33);
            this.btnPlaceOrder.TabIndex = 2;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(301, 338);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 33);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLunchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 406);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.grbTotal);
            this.Controls.Add(this.grbAddOn);
            this.Controls.Add(this.grbMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmLunchOrder";
            this.Text = "Lunch Order";
            this.grbMain.ResumeLayout(false);
            this.grbMain.PerformLayout();
            this.grbAddOn.ResumeLayout(false);
            this.grbAddOn.PerformLayout();
            this.grbTotal.ResumeLayout(false);
            this.grbTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMain;
        private System.Windows.Forms.GroupBox grbAddOn;
        private System.Windows.Forms.GroupBox grbTotal;
        private System.Windows.Forms.RadioButton radSalad;
        private System.Windows.Forms.RadioButton radPizza;
        private System.Windows.Forms.RadioButton radHamburger;
        private System.Windows.Forms.CheckBox chkAdd3;
        private System.Windows.Forms.CheckBox chkAdd2;
        private System.Windows.Forms.CheckBox chkAdd1;
        private System.Windows.Forms.Label lblOrderTotalDisplay;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblTaxDisplay;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubDisplay;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
    }
}

