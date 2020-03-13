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
            this.InfoBox = new System.Windows.Forms.RichTextBox();
            this.CreateOwnerInfo = new System.Windows.Forms.Button();
            this.LoadAll = new System.Windows.Forms.Button();
            this.SmsCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер";
            // 
            // TypeField
            // 
            this.TypeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeField.Location = new System.Drawing.Point(26, 94);
            this.TypeField.Name = "TypeField";
            this.TypeField.Size = new System.Drawing.Size(157, 27);
            this.TypeField.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип вклада";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Баланс";
            // 
            // NumberField
            // 
            this.NumberField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberField.Location = new System.Drawing.Point(26, 41);
            this.NumberField.Mask = "00000";
            this.NumberField.Name = "NumberField";
            this.NumberField.Size = new System.Drawing.Size(80, 27);
            this.NumberField.TabIndex = 6;
            this.NumberField.ValidatingType = typeof(int);
            // 
            // BalanceField
            // 
            this.BalanceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BalanceField.Location = new System.Drawing.Point(26, 155);
            this.BalanceField.Mask = "000,000$";
            this.BalanceField.Name = "BalanceField";
            this.BalanceField.Size = new System.Drawing.Size(90, 27);
            this.BalanceField.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата создания";
            // 
            // BankingNo
            // 
            this.BankingNo.AutoSize = true;
            this.BankingNo.Location = new System.Drawing.Point(26, 339);
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
            this.BankingYes.Location = new System.Drawing.Point(26, 311);
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
            this.label6.Location = new System.Drawing.Point(23, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Подключение интернет банкинга";
            // 
            // CreationDate
            // 
            this.CreationDate.Location = new System.Drawing.Point(26, 217);
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.Size = new System.Drawing.Size(200, 22);
            this.CreationDate.TabIndex = 18;
            // 
            // InfoBox
            // 
            this.InfoBox.Location = new System.Drawing.Point(266, 94);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(441, 320);
            this.InfoBox.TabIndex = 19;
            this.InfoBox.Text = "";
            // 
            // CreateOwnerInfo
            // 
            this.CreateOwnerInfo.Location = new System.Drawing.Point(266, 12);
            this.CreateOwnerInfo.Name = "CreateOwnerInfo";
            this.CreateOwnerInfo.Size = new System.Drawing.Size(141, 67);
            this.CreateOwnerInfo.TabIndex = 20;
            this.CreateOwnerInfo.Text = "Добавить информацию о владельце";
            this.CreateOwnerInfo.UseVisualStyleBackColor = true;
            this.CreateOwnerInfo.Click += new System.EventHandler(this.CreateOwnerInfo_Click);
            // 
            // LoadAll
            // 
            this.LoadAll.Location = new System.Drawing.Point(582, 12);
            this.LoadAll.Name = "LoadAll";
            this.LoadAll.Size = new System.Drawing.Size(125, 67);
            this.LoadAll.TabIndex = 22;
            this.LoadAll.Text = "Вывести информацию";
            this.LoadAll.UseVisualStyleBackColor = true;
            this.LoadAll.Click += new System.EventHandler(this.LoadAll_Click);
            // 
            // SmsCheckBox
            // 
            this.SmsCheckBox.AutoSize = true;
            this.SmsCheckBox.Location = new System.Drawing.Point(26, 254);
            this.SmsCheckBox.Name = "SmsCheckBox";
            this.SmsCheckBox.Size = new System.Drawing.Size(141, 21);
            this.SmsCheckBox.TabIndex = 24;
            this.SmsCheckBox.Text = "Смс оповещения";
            this.SmsCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 67);
            this.button1.TabIndex = 25;
            this.button1.Text = "Сохранить все";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveAll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 432);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SmsCheckBox);
            this.Controls.Add(this.LoadAll);
            this.Controls.Add(this.CreateOwnerInfo);
            this.Controls.Add(this.InfoBox);
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
        private System.Windows.Forms.RichTextBox InfoBox;
        private System.Windows.Forms.Button CreateOwnerInfo;
        private System.Windows.Forms.Button LoadAll;
        private System.Windows.Forms.CheckBox SmsCheckBox;
        private System.Windows.Forms.Button button1;
    }
}

