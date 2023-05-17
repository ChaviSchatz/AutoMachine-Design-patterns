namespace AutoMachine
{
    partial class Machine
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
            products = new ComboBox();
            productsLable = new Label();
            MoveToPayment = new Button();
            paymentButton = new Button();
            moneyRecived = new NumericUpDown();
            moneyRecivedLable = new Label();
            change = new Label();
            pruductLable = new Label();
            backButton = new Button();
            bagCheckbox = new CheckBox();
            giftWrapCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)moneyRecived).BeginInit();
            SuspendLayout();
            // 
            // products
            // 
            products.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            products.FormattingEnabled = true;
            products.Location = new Point(21, 66);
            products.Name = "products";
            products.Size = new Size(121, 25);
            products.TabIndex = 0;
            products.SelectedIndexChanged += products_SelectedIndexChanged;
            // 
            // productsLable
            // 
            productsLable.AutoSize = true;
            productsLable.Location = new Point(31, 39);
            productsLable.Name = "productsLable";
            productsLable.Size = new Size(95, 15);
            productsLable.TabIndex = 1;
            productsLable.Text = "Choose product:";
            // 
            // MoveToPayment
            // 
            MoveToPayment.Location = new Point(21, 109);
            MoveToPayment.Name = "MoveToPayment";
            MoveToPayment.Size = new Size(119, 26);
            MoveToPayment.TabIndex = 2;
            MoveToPayment.Text = "Move to payment";
            MoveToPayment.UseVisualStyleBackColor = true;
            MoveToPayment.Click += MoveToPayment_Click;
            // 
            // paymentButton
            // 
            paymentButton.Location = new Point(347, 166);
            paymentButton.Name = "paymentButton";
            paymentButton.Size = new Size(75, 23);
            paymentButton.TabIndex = 3;
            paymentButton.Text = "Pay now";
            paymentButton.UseVisualStyleBackColor = true;
            paymentButton.Click += paymentButton_Click;
            // 
            // moneyRecived
            // 
            moneyRecived.Location = new Point(366, 123);
            moneyRecived.Name = "moneyRecived";
            moneyRecived.Size = new Size(41, 23);
            moneyRecived.TabIndex = 4;
            moneyRecived.ValueChanged += moneyRecived_ValueChanged;
            // 
            // moneyRecivedLable
            // 
            moneyRecivedLable.AutoSize = true;
            moneyRecivedLable.Location = new Point(347, 93);
            moneyRecivedLable.Name = "moneyRecivedLable";
            moneyRecivedLable.Size = new Size(79, 15);
            moneyRecivedLable.TabIndex = 5;
            moneyRecivedLable.Text = "Insert Money!";
            // 
            // change
            // 
            change.AutoSize = true;
            change.Location = new Point(355, 206);
            change.Name = "change";
            change.Size = new Size(52, 15);
            change.TabIndex = 6;
            change.Text = "change: ";
            // 
            // pruductLable
            // 
            pruductLable.AutoSize = true;
            pruductLable.Location = new Point(235, 279);
            pruductLable.Name = "pruductLable";
            pruductLable.Size = new Size(0, 15);
            pruductLable.TabIndex = 7;
            // 
            // backButton
            // 
            backButton.Location = new Point(295, 39);
            backButton.Name = "backButton";
            backButton.Size = new Size(188, 23);
            backButton.TabIndex = 8;
            backButton.Text = "Back to selection mode";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += button1_Click;
            // 
            // bagCheckbox
            // 
            bagCheckbox.AutoSize = true;
            bagCheckbox.Location = new Point(31, 170);
            bagCheckbox.Name = "bagCheckbox";
            bagCheckbox.Size = new Size(46, 19);
            bagCheckbox.TabIndex = 9;
            bagCheckbox.Text = "bag";
            bagCheckbox.UseVisualStyleBackColor = true;
            // 
            // giftWrapCheckBox
            // 
            giftWrapCheckBox.AutoSize = true;
            giftWrapCheckBox.Location = new Point(31, 202);
            giftWrapCheckBox.Name = "giftWrapCheckBox";
            giftWrapCheckBox.Size = new Size(104, 19);
            giftWrapCheckBox.TabIndex = 10;
            giftWrapCheckBox.Text = "gift wrap (+2$)";
            giftWrapCheckBox.UseVisualStyleBackColor = true;
            giftWrapCheckBox.CheckedChanged += giftWrapCheckBox_CheckedChanged;
            // 
            // Machine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(giftWrapCheckBox);
            Controls.Add(bagCheckbox);
            Controls.Add(backButton);
            Controls.Add(pruductLable);
            Controls.Add(change);
            Controls.Add(moneyRecivedLable);
            Controls.Add(moneyRecived);
            Controls.Add(paymentButton);
            Controls.Add(MoveToPayment);
            Controls.Add(productsLable);
            Controls.Add(products);
            Name = "Machine";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)moneyRecived).EndInit();
            ResumeLayout(false);
            PerformLayout();
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