namespace AutoMechine
{
    partial class Mechine
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.products = new System.Windows.Forms.ComboBox();
            this.productsLable = new System.Windows.Forms.Label();
            this.MoveToPayment = new System.Windows.Forms.Button();
            this.paymentButton = new System.Windows.Forms.Button();
            this.moneyRecived = new System.Windows.Forms.NumericUpDown();
            this.moneyRecivedLable = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Label();
            this.pruductLable = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.bagCheckbox = new System.Windows.Forms.CheckBox();
            this.giftWrapCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.moneyRecived)).BeginInit();
            this.SuspendLayout();
            // 
            // products
            // 
            this.products.FormattingEnabled = true;
            this.products.Location = new System.Drawing.Point(21, 66);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(121, 23);
            this.products.TabIndex = 0;
            this.products.SelectedIndexChanged += new System.EventHandler(this.products_SelectedIndexChanged);
            // 
            // productsLable
            // 
            this.productsLable.AutoSize = true;
            this.productsLable.Location = new System.Drawing.Point(31, 39);
            this.productsLable.Name = "productsLable";
            this.productsLable.Size = new System.Drawing.Size(95, 15);
            this.productsLable.TabIndex = 1;
            this.productsLable.Text = "Choose product:";
            // 
            // MoveToPayment
            // 
            this.MoveToPayment.Location = new System.Drawing.Point(21, 109);
            this.MoveToPayment.Name = "MoveToPayment";
            this.MoveToPayment.Size = new System.Drawing.Size(119, 26);
            this.MoveToPayment.TabIndex = 2;
            this.MoveToPayment.Text = "Move to payment";
            this.MoveToPayment.UseVisualStyleBackColor = true;
            this.MoveToPayment.Click += new System.EventHandler(this.MoveToPayment_Click);
            // 
            // paymentButton
            // 
            this.paymentButton.Location = new System.Drawing.Point(347, 166);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(75, 23);
            this.paymentButton.TabIndex = 3;
            this.paymentButton.Text = "Pay now";
            this.paymentButton.UseVisualStyleBackColor = true;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // moneyRecived
            // 
            this.moneyRecived.Location = new System.Drawing.Point(366, 123);
            this.moneyRecived.Name = "moneyRecived";
            this.moneyRecived.Size = new System.Drawing.Size(41, 23);
            this.moneyRecived.TabIndex = 4;
            this.moneyRecived.ValueChanged += new System.EventHandler(this.moneyRecived_ValueChanged);
            // 
            // moneyRecivedLable
            // 
            this.moneyRecivedLable.AutoSize = true;
            this.moneyRecivedLable.Location = new System.Drawing.Point(347, 93);
            this.moneyRecivedLable.Name = "moneyRecivedLable";
            this.moneyRecivedLable.Size = new System.Drawing.Size(79, 15);
            this.moneyRecivedLable.TabIndex = 5;
            this.moneyRecivedLable.Text = "Insert Money!";
            // 
            // change
            // 
            this.change.AutoSize = true;
            this.change.Location = new System.Drawing.Point(355, 206);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(52, 15);
            this.change.TabIndex = 6;
            this.change.Text = "change: ";
            // 
            // pruductLable
            // 
            this.pruductLable.AutoSize = true;
            this.pruductLable.Location = new System.Drawing.Point(235, 279);
            this.pruductLable.Name = "pruductLable";
            this.pruductLable.Size = new System.Drawing.Size(0, 15);
            this.pruductLable.TabIndex = 7;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(295, 39);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(188, 23);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back to selection mode";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // bagCheckbox
            // 
            this.bagCheckbox.AutoSize = true;
            this.bagCheckbox.Location = new System.Drawing.Point(31, 170);
            this.bagCheckbox.Name = "bagCheckbox";
            this.bagCheckbox.Size = new System.Drawing.Size(46, 19);
            this.bagCheckbox.TabIndex = 9;
            this.bagCheckbox.Text = "bag";
            this.bagCheckbox.UseVisualStyleBackColor = true;
            // 
            // giftWrapCheckBox
            // 
            this.giftWrapCheckBox.AutoSize = true;
            this.giftWrapCheckBox.Location = new System.Drawing.Point(31, 202);
            this.giftWrapCheckBox.Name = "giftWrapCheckBox";
            this.giftWrapCheckBox.Size = new System.Drawing.Size(104, 19);
            this.giftWrapCheckBox.TabIndex = 10;
            this.giftWrapCheckBox.Text = "gift wrap (+2$)";
            this.giftWrapCheckBox.UseVisualStyleBackColor = true;
            this.giftWrapCheckBox.CheckedChanged += new System.EventHandler(this.giftWrapCheckBox_CheckedChanged);
            // 
            // Mechine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.giftWrapCheckBox);
            this.Controls.Add(this.bagCheckbox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pruductLable);
            this.Controls.Add(this.change);
            this.Controls.Add(this.moneyRecivedLable);
            this.Controls.Add(this.moneyRecived);
            this.Controls.Add(this.paymentButton);
            this.Controls.Add(this.MoveToPayment);
            this.Controls.Add(this.productsLable);
            this.Controls.Add(this.products);
            this.Name = "Mechine";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.moneyRecived)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox products;
        private Label productsLable;
        private Button MoveToPayment;
        private Button paymentButton;
        private NumericUpDown moneyRecived;
        private Label moneyRecivedLable;
        private Label change;
        private Label pruductLable;
        private Button backButton;
        private CheckBox bagCheckbox;
        private CheckBox giftWrapCheckBox;
    }
}