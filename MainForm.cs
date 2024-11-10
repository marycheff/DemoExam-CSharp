using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Получение всех данных о партнере при инициализации формы
            RefreshPartners();
        }

        private void RefreshPartners()
        {
            //Очистка педыдущих UserConrol
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                Control currentControl = flowLayoutPanel1.Controls[0];
                flowLayoutPanel1.Controls.Remove(currentControl);
                flowLayoutPanel1.Controls.Clear();
                currentControl.Dispose();
            }

            //Для каждого партнера создается свой UserControl
            List<Partner> partners = DB.GetAllPartners();
            foreach (var partner in partners)
            {
                PartnerControl control = new PartnerControl(partner.Id,partner.Type, partner.Name, partner.DirectorName, partner.Phone, partner.Rating, partner.TotalQuantity);
                flowLayoutPanel1.Controls.Add(control);
                control.Click += Control_Click;
            }

        }
        // Обработка клика на каждого партнера
        private void Control_Click(object sender, System.EventArgs e)
        {
            PartnerControl clickedControl = sender as PartnerControl;
            int partnerID = clickedControl.PartnerID;
            UpdatePartnerForm updatePartnerForm = new UpdatePartnerForm(partnerID);
            updatePartnerForm.ShowDialog();

            // Обновление данных при закрытии дочерней формы
            if (updatePartnerForm.DialogResult == DialogResult.OK)
            {
                RefreshPartners();
            }


        }

        private void BtnAddPartner_Click(object sender, System.EventArgs e)
        {
            AddPartnerForm addPartnerForm = new AddPartnerForm();
            addPartnerForm.ShowDialog();

            // Обновление данных при закрытии дочерней формы
            if(addPartnerForm.DialogResult == DialogResult.OK)
            {
                RefreshPartners();
            }
        }
    }
}
