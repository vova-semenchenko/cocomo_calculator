namespace COCOMO_MODEL
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.codeSizeField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.projectTypeList = new System.Windows.Forms.ComboBox();
            this.effortsLabel = new System.Windows.Forms.Label();
            this.timeToDevelopLabel = new System.Windows.Forms.Label();
            this.personsToDevelop = new System.Windows.Forms.Label();
            this.productivityLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.CadetBlue;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(31, 231);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(228, 48);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Розрахувати";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // codeSizeField
            // 
            this.codeSizeField.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.codeSizeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeSizeField.Location = new System.Drawing.Point(31, 163);
            this.codeSizeField.Name = "codeSizeField";
            this.codeSizeField.Size = new System.Drawing.Size(228, 32);
            this.codeSizeField.TabIndex = 1;
            this.codeSizeField.TextChanged += new System.EventHandler(this.CodeSizeField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кількість рядків коду(тисяч):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Оберіть тип проєкта:";
            // 
            // projectTypeList
            // 
            this.projectTypeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.projectTypeList.FormattingEnabled = true;
            this.projectTypeList.Items.AddRange(new object[] {
            "Розповсюджений",
            "Напівнезалежний",
            "Вбудобваний"});
            this.projectTypeList.Location = new System.Drawing.Point(31, 67);
            this.projectTypeList.Name = "projectTypeList";
            this.projectTypeList.Size = new System.Drawing.Size(228, 33);
            this.projectTypeList.TabIndex = 3;
            this.projectTypeList.SelectedIndexChanged += new System.EventHandler(this.ProjectTypeList_SelectedIndexChanged);
            // 
            // effortsLabel
            // 
            this.effortsLabel.AutoSize = true;
            this.effortsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.effortsLabel.Location = new System.Drawing.Point(479, 74);
            this.effortsLabel.Name = "effortsLabel";
            this.effortsLabel.Size = new System.Drawing.Size(0, 20);
            this.effortsLabel.TabIndex = 2;
            // 
            // timeToDevelopLabel
            // 
            this.timeToDevelopLabel.AutoSize = true;
            this.timeToDevelopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeToDevelopLabel.Location = new System.Drawing.Point(460, 134);
            this.timeToDevelopLabel.Name = "timeToDevelopLabel";
            this.timeToDevelopLabel.Size = new System.Drawing.Size(0, 20);
            this.timeToDevelopLabel.TabIndex = 2;
            // 
            // personsToDevelop
            // 
            this.personsToDevelop.AutoSize = true;
            this.personsToDevelop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personsToDevelop.Location = new System.Drawing.Point(468, 198);
            this.personsToDevelop.Name = "personsToDevelop";
            this.personsToDevelop.Size = new System.Drawing.Size(0, 20);
            this.personsToDevelop.TabIndex = 2;
            // 
            // productivityLabel
            // 
            this.productivityLabel.AutoSize = true;
            this.productivityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productivityLabel.Location = new System.Drawing.Point(497, 246);
            this.productivityLabel.Name = "productivityLabel";
            this.productivityLabel.Size = new System.Drawing.Size(0, 20);
            this.productivityLabel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(357, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Трудоємність:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(357, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Тривалість:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(357, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Розробників:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(357, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Продуктивність:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 321);
            this.Controls.Add(this.projectTypeList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.productivityLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.personsToDevelop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeToDevelopLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.effortsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codeSizeField);
            this.Controls.Add(this.calculateButton);
            this.MaximumSize = new System.Drawing.Size(700, 360);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COCOMO Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox codeSizeField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox projectTypeList;
        private System.Windows.Forms.Label effortsLabel;
        private System.Windows.Forms.Label timeToDevelopLabel;
        private System.Windows.Forms.Label personsToDevelop;
        private System.Windows.Forms.Label productivityLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

