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
    public partial class UpdatePartnerForm : Form
    {
        private int PartnerId;
        public UpdatePartnerForm(int partnerId)
        {
            InitializeComponent();
            PartnerId = partnerId;
            Partner partner = DB.GetPartner(PartnerId);
            textPartnerName.Text = partner.Name;
            textDirectorName.Text = partner.DirectorName;
            textPartnerAddress.Text = partner.Address;
            textPartnerEmail.Text = partner.Email;
            textPartnerPhone.Text = partner.Phone;
            numericPartnerRating.Value = partner.Rating;




            List<string> partnersTypes = DB.GetPartnersTypes();
            comboPartnerType.Items.AddRange(partnersTypes.ToArray());
            comboPartnerType.SelectedIndex = partner.TypeId - 1;

        }

        private void btnSave_Click(object sender, EventArgs e)
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

            Partner updatedPartner = new Partner
            {
                Id = PartnerId,
                TypeId = comboPartnerType.SelectedIndex + 1,
                Rating = (int)numericPartnerRating.Value,
                Name = name,
                Address = address,
                Email = email,
                Phone = phone,
                DirectorName = directorName,
                
            };


            DB.UpdatePartner(updatedPartner);
            MessageBox.Show("Данные обновлены", "Обновление данных партнера", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
