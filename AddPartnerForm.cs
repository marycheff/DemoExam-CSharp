using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddPartnerForm : Form
    {

        public AddPartnerForm()
        {
            InitializeComponent();
            List<string> partnersTypes = DB.GetPartnersTypes();

            // Заполнение выпадающего списка
            comboPartnerType.Items.AddRange(partnersTypes.ToArray()); 
            comboPartnerType.SelectedIndex = 0;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string directorName = textDirectorName.Text.ToString().Trim();
            string email = textPartnerEmail.Text.ToString().Trim();
            string phone = textPartnerPhone.Text.ToString().Trim();
            string address = textPartnerAddress.Text.ToString().Trim();
            string name = textPartnerName.Text.ToString().Trim();

            if (string.IsNullOrEmpty(directorName) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введены не все данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Partner partner = new Partner
            {
                Name = name,
                TypeId = comboPartnerType.SelectedIndex + 1,
                Address = address,
                Phone = phone,
                Rating = (int)numericPartnerRating.Value,
                Email = email,
                DirectorName = directorName
            };

            DB.AddPartner(partner);
            MessageBox.Show("Партнер добавлен", "Добавление партнера", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Закрытие формы, передача результата диалога в родительскую форму
            this.DialogResult = DialogResult.OK;
            this.Close();


        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
