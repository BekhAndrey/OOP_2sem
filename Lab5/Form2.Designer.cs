namespace Lab5
{
    partial class Form2
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
            this.BirthField = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FIOField = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PassportField = new System.Windows.Forms.MaskedTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.IdField = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BirthField
            // 
            this.BirthField.Location = new System.Drawing.Point(58, 159);
            this.BirthField.Name = "BirthField";
            this.BirthField.Size = new System.Drawing.Size(200, 22);
            this.BirthField.TabIndex = 28;
            this.BirthField.ValueChanged += new System.EventHandler(this.CreationDate_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Номер паспорта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Дата рождения";
            // 
            // FIOField
            // 
            this.FIOField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOField.Location = new System.Drawing.Point(58, 94);
            this.FIOField.Mask = "LLL";
            this.FIOField.Name = "FIOField";
            this.FIOField.Size = new System.Drawing.Size(50, 27);
            this.FIOField.TabIndex = 23;
            this.FIOField.ValidatingType = typeof(int);
            this.FIOField.Leave += new System.EventHandler(this.FIOField_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "ФИО";
            // 
            // PassportField
            // 
            this.PassportField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassportField.Location = new System.Drawing.Point(58, 228);
            this.PassportField.Mask = "LL0000000";
            this.PassportField.Name = "PassportField";
            this.PassportField.Size = new System.Drawing.Size(108, 27);
            this.PassportField.TabIndex = 29;
            this.PassportField.ValidatingType = typeof(int);
            this.PassportField.Leave += new System.EventHandler(this.PassportField_Leave);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(95, 285);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(118, 60);
            this.SaveButton.TabIndex = 30;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveClick);
            // 
            // IdField
            // 
            this.IdField.Location = new System.Drawing.Point(56, 43);
            this.IdField.Mask = "000";
            this.IdField.Name = "IdField";
            this.IdField.Size = new System.Drawing.Size(52, 22);
            this.IdField.TabIndex = 35;
            this.IdField.Leave += new System.EventHandler(this.IdField_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Идентификатор";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 385);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdField);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PassportField);
            this.Controls.Add(this.BirthField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FIOField);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker BirthField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox FIOField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox PassportField;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.MaskedTextBox IdField;
        private System.Windows.Forms.Label label2;
    }
}