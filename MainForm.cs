using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();     
            RefreshPartners();
        }

        private void RefreshPartners()
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                Control currentControl = flowLayoutPanel1.Controls[0];
                flowLayoutPanel1.Controls.Remove(currentControl);
                flowLayoutPanel1.Controls.Clear();
                currentControl.Dispose();
            }
            List<Partner> partners = DB.GetAllPartners();
            foreach (var partner in partners)
            {
                PartnerControl control = new PartnerControl(partner.Id,partner.Type, partner.Name, partner.DirectorName, partner.Phone, partner.Rating, partner.TotalQuantity);
                flowLayoutPanel1.Controls.Add(control);
                control.Click += Control_Click;
            }

        }

        private void Control_Click(object sender, System.EventArgs e)
        {
            PartnerControl clickedControl = sender as PartnerControl;
            int partnerID = clickedControl.PartnerID;
            UpdatePartnerForm updatePartnerForm = new UpdatePartnerForm(partnerID);
            updatePartnerForm.ShowDialog();
            if (updatePartnerForm.DialogResult == DialogResult.OK)
            {
                RefreshPartners();
            }


        }

        private void btnAddPartner_Click(object sender, System.EventArgs e)
        {
            var addPartnerForm = new AddPartnerForm();
            addPartnerForm.ShowDialog();
            if(addPartnerForm.DialogResult == DialogResult.OK)
            {
                RefreshPartners();
            }
        }
    }
}
