namespace WindowsFormsApp1
{
    partial class UpdatePartnerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePartnerForm));
            this.label7 = new System.Windows.Forms.Label();
            this.textPartnerPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericPartnerRating = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.comboPartnerType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textPartnerEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textDirectorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPartnerAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textPartnerName = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericPartnerRating)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(282, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "ФИО Директора";
            // 
            // textPartnerPhone
            // 
            this.textPartnerPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPartnerPhone.Location = new System.Drawing.Point(282, 228);
            this.textPartnerPhone.Mask = "000 000 00 00";
            this.textPartnerPhone.Name = "textPartnerPhone";
            this.textPartnerPhone.Size = new System.Drawing.Size(238, 23);
            this.textPartnerPhone.TabIndex = 28;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(714, 419);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(279, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Рейтинг";
            // 
            // numericPartnerRating
            // 
            this.numericPartnerRating.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericPartnerRating.Location = new System.Drawing.Point(282, 412);
            this.numericPartnerRating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericPartnerRating.Name = "numericPartnerRating";
            this.numericPartnerRating.ReadOnly = true;
            this.numericPartnerRating.Size = new System.Drawing.Size(120, 23);
            this.numericPartnerRating.TabIndex = 25;
            this.numericPartnerRating.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(279, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Тип Компании";
            // 
            // comboPartnerType
            // 
            this.comboPartnerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPartnerType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboPartnerType.FormattingEnabled = true;
            this.comboPartnerType.Location = new System.Drawing.Point(279, 106);
            this.comboPartnerType.Name = "comboPartnerType";
            this.comboPartnerType.Size = new System.Drawing.Size(238, 23);
            this.comboPartnerType.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(282, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Email";
            // 
            // textPartnerEmail
            // 
            this.textPartnerEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPartnerEmail.Location = new System.Drawing.Point(282, 350);
            this.textPartnerEmail.Name = "textPartnerEmail";
            this.textPartnerEmail.Size = new System.Drawing.Size(241, 25);
            this.textPartnerEmail.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(282, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Телефон";
            // 
            // textDirectorName
            // 
            this.textDirectorName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textDirectorName.Location = new System.Drawing.Point(282, 288);
            this.textDirectorName.Name = "textDirectorName";
            this.textDirectorName.Size = new System.Drawing.Size(241, 25);
            this.textDirectorName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(282, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Адрес";
            // 
            // textPartnerAddress
            // 
            this.textPartnerAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPartnerAddress.Location = new System.Drawing.Point(282, 166);
            this.textPartnerAddress.Name = "textPartnerAddress";
            this.textPartnerAddress.Size = new System.Drawing.Size(241, 25);
            this.textPartnerAddress.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(279, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Наименование";
            // 
            // textPartnerName
            // 
            this.textPartnerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPartnerName.Location = new System.Drawing.Point(279, 44);
            this.textPartnerName.Name = "textPartnerName";
            this.textPartnerName.Size = new System.Drawing.Size(241, 25);
            this.textPartnerName.TabIndex = 15;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UpdatePartnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textPartnerPhone);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericPartnerRating);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboPartnerType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPartnerEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textDirectorName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPartnerAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPartnerName);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdatePartnerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменить данные партнера";
            ((System.ComponentModel.ISupportInitialize)(this.numericPartnerRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox textPartnerPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericPartnerRating;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboPartnerType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPartnerEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDirectorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPartnerAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPartnerName;
        private System.Windows.Forms.Button btnBack;
    }
}