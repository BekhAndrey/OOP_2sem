namespace Lab5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TypeField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberField = new System.Windows.Forms.MaskedTextBox();
            this.BalanceField = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BankingNo = new System.Windows.Forms.RadioButton();
            this.BankingYes = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.CreationDate = new System.Windows.Forms.DateTimePicker();
            this.SmsCheckBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.OwnerList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WriteToFileButton = new System.Windows.Forms.Button();
            this.ReadFromFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер";
            // 
            // TypeField
            // 
            this.TypeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeField.Location = new System.Drawing.Point(12, 84);
            this.TypeField.Name = "TypeField";
            this.TypeField.Size = new System.Drawing.Size(157, 27);
            this.TypeField.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип вклада";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Баланс";
            // 
            // NumberField
            // 
            this.NumberField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberField.Location = new System.Drawing.Point(12, 31);
            this.NumberField.Mask = "00000";
            this.NumberField.Name = "NumberField";
            this.NumberField.Size = new System.Drawing.Size(80, 27);
            this.NumberField.TabIndex = 6;
            this.NumberField.ValidatingType = typeof(int);
            this.NumberField.Leave += new System.EventHandler(this.NumberField_Leave);
            // 
            // BalanceField
            // 
            this.BalanceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BalanceField.Location = new System.Drawing.Point(12, 145);
            this.BalanceField.Mask = "000,000$";
            this.BalanceField.Name = "BalanceField";
            this.BalanceField.Size = new System.Drawing.Size(90, 27);
            this.BalanceField.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата создания";
            // 
            // BankingNo
            // 
            this.BankingNo.AutoSize = true;
            this.BankingNo.Location = new System.Drawing.Point(257, 93);
            this.BankingNo.Name = "BankingNo";
            this.BankingNo.Size = new System.Drawing.Size(54, 21);
            this.BankingNo.TabIndex = 15;
            this.BankingNo.TabStop = true;
            this.BankingNo.Text = "Нет";
            this.BankingNo.UseVisualStyleBackColor = true;
            // 
            // BankingYes
            // 
            this.BankingYes.AutoSize = true;
            this.BankingYes.Location = new System.Drawing.Point(257, 66);
            this.BankingYes.Name = "BankingYes";
            this.BankingYes.Size = new System.Drawing.Size(48, 21);
            this.BankingYes.TabIndex = 14;
            this.BankingYes.TabStop = true;
            this.BankingYes.Text = "Да";
            this.BankingYes.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Подключение интернет банкинга";
            // 
            // CreationDate
            // 
            this.CreationDate.Location = new System.Drawing.Point(12, 220);
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.Size = new System.Drawing.Size(231, 22);
            this.CreationDate.TabIndex = 18;
            // 
            // SmsCheckBox
            // 
            this.SmsCheckBox.AutoSize = true;
            this.SmsCheckBox.Location = new System.Drawing.Point(257, 12);
            this.SmsCheckBox.Name = "SmsCheckBox";
            this.SmsCheckBox.Size = new System.Drawing.Size(141, 21);
            this.SmsCheckBox.TabIndex = 24;
            this.SmsCheckBox.Text = "Смс оповещения";
            this.SmsCheckBox.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 47);
            this.button2.TabIndex = 26;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ClearClick);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(331, 195);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(157, 47);
            this.Save.TabIndex = 27;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // OwnerList
            // 
            this.OwnerList.FormattingEnabled = true;
            this.OwnerList.Location = new System.Drawing.Point(257, 158);
            this.OwnerList.Name = "OwnerList";
            this.OwnerList.Size = new System.Drawing.Size(231, 24);
            this.OwnerList.TabIndex = 28;
            this.OwnerList.SelectedIndexChanged += new System.EventHandler(this.OwnerList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Добавить владельца";
            // 
            // WriteToFileButton
            // 
            this.WriteToFileButton.Location = new System.Drawing.Point(13, 261);
            this.WriteToFileButton.Name = "WriteToFileButton";
            this.WriteToFileButton.Size = new System.Drawing.Size(230, 23);
            this.WriteToFileButton.TabIndex = 30;
            this.WriteToFileButton.Text = "Write to file";
            this.WriteToFileButton.UseVisualStyleBackColor = true;
            this.WriteToFileButton.Click += new System.EventHandler(this.WriteToFileButton_Click);
            // 
            // ReadFromFileButton
            // 
            this.ReadFromFileButton.Location = new System.Drawing.Point(260, 261);
            this.ReadFromFileButton.Name = "ReadFromFileButton";
            this.ReadFromFileButton.Size = new System.Drawing.Size(230, 23);
            this.ReadFromFileButton.TabIndex = 31;
            this.ReadFromFileButton.Text = "Read from file";
            this.ReadFromFileButton.UseVisualStyleBackColor = true;
            this.ReadFromFileButton.Click += new System.EventHandler(this.ReadFromFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 304);
            this.Controls.Add(this.ReadFromFileButton);
            this.Controls.Add(this.WriteToFileButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OwnerList);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SmsCheckBox);
            this.Controls.Add(this.CreationDate);
            this.Controls.Add(this.BankingNo);
            this.Controls.Add(this.BankingYes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BalanceField);
            this.Controls.Add(this.NumberField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TypeField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Account_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TypeField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox NumberField;
        private System.Windows.Forms.MaskedTextBox BalanceField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton BankingNo;
        private System.Windows.Forms.RadioButton BankingYes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker CreationDate;
        private System.Windows.Forms.CheckBox SmsCheckBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ComboBox OwnerList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button WriteToFileButton;
        private System.Windows.Forms.Button ReadFromFileButton;
    }
}

