namespace WindowsFormsApp1
{
    partial class PartnerControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PartnerName = new System.Windows.Forms.Label();
            this.DirectorName = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PartnerName
            // 
            this.PartnerName.AutoSize = true;
            this.PartnerName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PartnerName.Location = new System.Drawing.Point(27, 11);
            this.PartnerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PartnerName.Name = "PartnerName";
            this.PartnerName.Size = new System.Drawing.Size(232, 20);
            this.PartnerName.TabIndex = 0;
            this.PartnerName.Text = "Тип |  Наименование партнера";
            // 
            // DirectorName
            // 
            this.DirectorName.AutoSize = true;
            this.DirectorName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectorName.Location = new System.Drawing.Point(28, 31);
            this.DirectorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DirectorName.Name = "DirectorName";
            this.DirectorName.Size = new System.Drawing.Size(60, 15);
            this.DirectorName.TabIndex = 1;
            this.DirectorName.Text = "Директор";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phone.Location = new System.Drawing.Point(28, 46);
            this.Phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(93, 15);
            this.Phone.TabIndex = 2;
            this.Phone.Text = "+7 999 999 99 99";
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rating.Location = new System.Drawing.Point(28, 61);
            this.Rating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(69, 15);
            this.Rating.TabIndex = 3;
            this.Rating.Text = "Рейтинг: 10";
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discount.Location = new System.Drawing.Point(691, 11);
            this.Discount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(45, 20);
            this.Discount.TabIndex = 4;
            this.Discount.Text = "100%";
            // 
            // PartnerControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.DirectorName);
            this.Controls.Add(this.PartnerName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PartnerControl";
            this.Size = new System.Drawing.Size(760, 85);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PartnerName;
        private System.Windows.Forms.Label DirectorName;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.Label Discount;
    }
}
