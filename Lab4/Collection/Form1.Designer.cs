namespace OOP_Lab01_2
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
            this.inputField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.SortDescBtn = new System.Windows.Forms.Button();
            this.SortAscBtn = new System.Windows.Forms.Button();
            this.MinBtn = new System.Windows.Forms.Button();
            this.MaxBtn = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.LinqBox = new System.Windows.Forms.ListBox();
            this.buttonRange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputField
            // 
            this.inputField.Location = new System.Drawing.Point(348, 57);
            this.inputField.Margin = new System.Windows.Forms.Padding(4);
            this.inputField.Name = "inputField";
            this.inputField.Size = new System.Drawing.Size(203, 22);
            this.inputField.TabIndex = 0;
            this.inputField.TextChanged += new System.EventHandler(this.inputField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(345, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите размер коллекции";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GenerateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GenerateBtn.Location = new System.Drawing.Point(327, 103);
            this.GenerateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(257, 86);
            this.GenerateBtn.TabIndex = 2;
            this.GenerateBtn.Text = "Создать";
            this.GenerateBtn.UseVisualStyleBackColor = false;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateClick);
            // 
            // SortDescBtn
            // 
            this.SortDescBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SortDescBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortDescBtn.Location = new System.Drawing.Point(47, 250);
            this.SortDescBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SortDescBtn.Name = "SortDescBtn";
            this.SortDescBtn.Size = new System.Drawing.Size(166, 70);
            this.SortDescBtn.TabIndex = 3;
            this.SortDescBtn.Text = "Сортировать по убыванию";
            this.SortDescBtn.UseVisualStyleBackColor = false;
            this.SortDescBtn.Click += new System.EventHandler(this.SortDescClick);
            // 
            // SortAscBtn
            // 
            this.SortAscBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SortAscBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortAscBtn.Location = new System.Drawing.Point(47, 147);
            this.SortAscBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SortAscBtn.Name = "SortAscBtn";
            this.SortAscBtn.Size = new System.Drawing.Size(166, 70);
            this.SortAscBtn.TabIndex = 4;
            this.SortAscBtn.Text = "Сортировать по возрастанию";
            this.SortAscBtn.UseVisualStyleBackColor = false;
            this.SortAscBtn.Click += new System.EventHandler(this.SortAscClick);
            // 
            // MinBtn
            // 
            this.MinBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinBtn.Location = new System.Drawing.Point(768, 170);
            this.MinBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(100, 42);
            this.MinBtn.TabIndex = 6;
            this.MinBtn.Text = "Min";
            this.MinBtn.UseVisualStyleBackColor = false;
            this.MinBtn.Click += new System.EventHandler(this.MinClick);
            // 
            // MaxBtn
            // 
            this.MaxBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MaxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxBtn.Location = new System.Drawing.Point(660, 170);
            this.MaxBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(100, 42);
            this.MaxBtn.TabIndex = 7;
            this.MaxBtn.Text = "Max";
            this.MaxBtn.UseVisualStyleBackColor = false;
            this.MaxBtn.Click += new System.EventHandler(this.MaxClick);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(259, 220);
            this.listBox.Margin = new System.Windows.Forms.Padding(4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(195, 100);
            this.listBox.TabIndex = 8;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LinqBox
            // 
            this.LinqBox.FormattingEnabled = true;
            this.LinqBox.ItemHeight = 16;
            this.LinqBox.Location = new System.Drawing.Point(497, 220);
            this.LinqBox.Margin = new System.Windows.Forms.Padding(4);
            this.LinqBox.Name = "LinqBox";
            this.LinqBox.Size = new System.Drawing.Size(203, 100);
            this.LinqBox.TabIndex = 9;
            // 
            // buttonRange
            // 
            this.buttonRange.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRange.Location = new System.Drawing.Point(768, 220);
            this.buttonRange.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRange.Name = "buttonRange";
            this.buttonRange.Size = new System.Drawing.Size(100, 42);
            this.buttonRange.TabIndex = 10;
            this.buttonRange.Text = "Range";
            this.buttonRange.UseVisualStyleBackColor = false;
            this.buttonRange.Click += new System.EventHandler(this.RangeClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(916, 384);
            this.Controls.Add(this.buttonRange);
            this.Controls.Add(this.LinqBox);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.MaxBtn);
            this.Controls.Add(this.MinBtn);
            this.Controls.Add(this.SortAscBtn);
            this.Controls.Add(this.SortDescBtn);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.Button SortDescBtn;
        private System.Windows.Forms.Button SortAscBtn;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Button MaxBtn;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ListBox LinqBox;
        private System.Windows.Forms.Button buttonRange;
    }
}

