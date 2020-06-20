namespace WindowsFormsApp2
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ArgAbsLabel = new System.Windows.Forms.Label();
            this.RightNumberText = new System.Windows.Forms.Label();
            this.LeftNumberText = new System.Windows.Forms.Label();
            this.ResultText = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ActionList = new System.Windows.Forms.ComboBox();
            this.RightNumber = new System.Windows.Forms.TextBox();
            this.LeftNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Модуль числа 1",
            "Аргумент числа 1"});
            this.comboBox1.Location = new System.Drawing.Point(140, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.Text = "Модуль числа 1";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.Location = new System.Drawing.Point(540, 311);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 18);
            this.ResultLabel.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Рассчитать\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ArgAbsLabel
            // 
            this.ArgAbsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArgAbsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ArgAbsLabel.Location = new System.Drawing.Point(137, 235);
            this.ArgAbsLabel.Name = "ArgAbsLabel";
            this.ArgAbsLabel.Size = new System.Drawing.Size(138, 23);
            this.ArgAbsLabel.TabIndex = 23;
            this.ArgAbsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RightNumberText
            // 
            this.RightNumberText.AutoSize = true;
            this.RightNumberText.Location = new System.Drawing.Point(543, 175);
            this.RightNumberText.Name = "RightNumberText";
            this.RightNumberText.Size = new System.Drawing.Size(48, 13);
            this.RightNumberText.TabIndex = 22;
            this.RightNumberText.Text = "Число 2";
            // 
            // LeftNumberText
            // 
            this.LeftNumberText.AutoSize = true;
            this.LeftNumberText.Location = new System.Drawing.Point(403, 121);
            this.LeftNumberText.Name = "LeftNumberText";
            this.LeftNumberText.Size = new System.Drawing.Size(48, 13);
            this.LeftNumberText.TabIndex = 21;
            this.LeftNumberText.Text = "Число 1";
            // 
            // ResultText
            // 
            this.ResultText.AutoSize = true;
            this.ResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultText.Location = new System.Drawing.Point(542, 277);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(93, 20);
            this.ResultText.TabIndex = 20;
            this.ResultText.Text = "Результат:";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateButton.Location = new System.Drawing.Point(543, 236);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(121, 23);
            this.CalculateButton.TabIndex = 19;
            this.CalculateButton.Text = "Рассчитать";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click_1);
            // 
            // ActionList
            // 
            this.ActionList.FormattingEnabled = true;
            this.ActionList.Items.AddRange(new object[] {
            "Сложить",
            "Вычесть",
            "Умножить",
            "Поделить"});
            this.ActionList.Location = new System.Drawing.Point(543, 139);
            this.ActionList.Name = "ActionList";
            this.ActionList.Size = new System.Drawing.Size(117, 21);
            this.ActionList.TabIndex = 18;
            this.ActionList.Text = "Сложить";
            // 
            // RightNumber
            // 
            this.RightNumber.Location = new System.Drawing.Point(543, 194);
            this.RightNumber.Name = "RightNumber";
            this.RightNumber.Size = new System.Drawing.Size(117, 20);
            this.RightNumber.TabIndex = 17;
            // 
            // LeftNumber
            // 
            this.LeftNumber.Location = new System.Drawing.Point(369, 140);
            this.LeftNumber.Name = "LeftNumber";
            this.LeftNumber.Size = new System.Drawing.Size(117, 20);
            this.LeftNumber.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ArgAbsLabel);
            this.Controls.Add(this.RightNumberText);
            this.Controls.Add(this.LeftNumberText);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ActionList);
            this.Controls.Add(this.RightNumber);
            this.Controls.Add(this.LeftNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ArgAbsLabel;
        private System.Windows.Forms.Label RightNumberText;
        private System.Windows.Forms.Label LeftNumberText;
        private System.Windows.Forms.Label ResultText;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.ComboBox ActionList;
        private System.Windows.Forms.TextBox RightNumber;
        private System.Windows.Forms.TextBox LeftNumber;
    }
}

