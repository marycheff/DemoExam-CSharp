using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

                PartnerControl control = new PartnerControl(partner.Type, partner.Name, partner.DirectorName, partner.Phone, partner.Rating, partner.TotalQuantity);
                flowLayoutPanel1.Controls.Add(control);
            }



        }
    }
}
