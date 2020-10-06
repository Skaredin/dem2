namespace dem2
{
    partial class Avtorisacia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avtorisacia));
            this.LoginText = new System.Windows.Forms.TextBox();
            this.PassvordText = new System.Windows.Forms.TextBox();
            this.AvtorisaciaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginText
            // 
            this.LoginText.Location = new System.Drawing.Point(69, 42);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(195, 20);
            this.LoginText.TabIndex = 0;
            this.LoginText.Text = "admin";
            // 
            // PassvordText
            // 
            this.PassvordText.Location = new System.Drawing.Point(69, 68);
            this.PassvordText.Name = "PassvordText";
            this.PassvordText.Size = new System.Drawing.Size(195, 20);
            this.PassvordText.TabIndex = 1;
            this.PassvordText.Text = "0000";
            // 
            // AvtorisaciaButton
            // 
            this.AvtorisaciaButton.Location = new System.Drawing.Point(169, 94);
            this.AvtorisaciaButton.Name = "AvtorisaciaButton";
            this.AvtorisaciaButton.Size = new System.Drawing.Size(95, 23);
            this.AvtorisaciaButton.TabIndex = 2;
            this.AvtorisaciaButton.Text = "Авторизоваться";
            this.AvtorisaciaButton.UseVisualStyleBackColor = true;
            this.AvtorisaciaButton.Click += new System.EventHandler(this.AvtorisaciaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // Avtorisacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(284, 129);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AvtorisaciaButton);
            this.Controls.Add(this.PassvordText);
            this.Controls.Add(this.LoginText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Avtorisacia";
            this.Text = "Avtorizacia";
            this.Load += new System.EventHandler(this.Avtorisacia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.TextBox PassvordText;
        private System.Windows.Forms.Button AvtorisaciaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

