namespace Expert_systems
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
            this.Hypothesis_1 = new System.Windows.Forms.Button();
            this.Hypothesis_2 = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.dgKonstanty = new System.Windows.Forms.DataGridView();
            this.dgVariables = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgKonstanty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVariables)).BeginInit();
            this.SuspendLayout();
            // 
            // Hypothesis_1
            // 
            this.Hypothesis_1.Location = new System.Drawing.Point(13, 13);
            this.Hypothesis_1.Name = "Hypothesis_1";
            this.Hypothesis_1.Size = new System.Drawing.Size(96, 37);
            this.Hypothesis_1.TabIndex = 0;
            this.Hypothesis_1.Text = "Гипотеза 1";
            this.Hypothesis_1.UseVisualStyleBackColor = true;
            this.Hypothesis_1.Click += new System.EventHandler(this.Hypothesis1Click);
            // 
            // Hypothesis_2
            // 
            this.Hypothesis_2.Location = new System.Drawing.Point(115, 13);
            this.Hypothesis_2.Name = "Hypothesis_2";
            this.Hypothesis_2.Size = new System.Drawing.Size(96, 37);
            this.Hypothesis_2.TabIndex = 1;
            this.Hypothesis_2.Text = "Гипотеза 2";
            this.Hypothesis_2.UseVisualStyleBackColor = true;
            this.Hypothesis_2.Click += new System.EventHandler(this.Hypothesis2Click);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(850, 8);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(96, 36);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Вычислить";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.CalculateClick);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(998, 17);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(300, 20);
            this.result.TabIndex = 3;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(1205, 577);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(93, 23);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.ExitClick);
            // 
            // dgKonstanty
            // 
            this.dgKonstanty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKonstanty.Location = new System.Drawing.Point(13, 57);
            this.dgKonstanty.Name = "dgKonstanty";
            this.dgKonstanty.Size = new System.Drawing.Size(676, 511);
            this.dgKonstanty.TabIndex = 6;
            // 
            // dgVariables
            // 
            this.dgVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVariables.Location = new System.Drawing.Point(695, 57);
            this.dgVariables.Name = "dgVariables";
            this.dgVariables.Size = new System.Drawing.Size(605, 511);
            this.dgVariables.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(952, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ответ:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 606);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgVariables);
            this.Controls.Add(this.dgKonstanty);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Hypothesis_2);
            this.Controls.Add(this.Hypothesis_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKonstanty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVariables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hypothesis_1;
        private System.Windows.Forms.Button Hypothesis_2;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridView dgKonstanty;
        private System.Windows.Forms.DataGridView dgVariables;
        private System.Windows.Forms.Label label1;
    }
}

