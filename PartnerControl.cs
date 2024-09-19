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
    public partial class PartnerControl : UserControl
    {
        public PartnerControl(string partnerType, string partnerName, string directorName, string phone, int rating, int totalQuantity)
        {
            InitializeComponent();
            PartnerName.Text = partnerType + " " + partnerName;
            DirectorName.Text = directorName;
            Phone.Text =  $"+7 {phone}";
            Rating.Text = $"Рейтинг: {rating.ToString()}";
            Discount.Text = (CalculateDiscount(totalQuantity) * 100).ToString() + '%';


        }

        private void Discount_Click(object sender, EventArgs e)
        {

        }
        public static float CalculateDiscount(int totalQuantity)
        {
            float discount = 0;

            if (totalQuantity >= 10000 && totalQuantity <= 50000)
            {
                discount = 0.05f; 
            }
            else if (totalQuantity > 50000 && totalQuantity <= 300000)
            {
                discount = 0.10f; 
            }
            else if (totalQuantity > 300000)
            {
                discount = 0.15f; 
            }

            return discount;
        }


    }
}
