using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class DB
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306; username=root;password=; database=master_pol";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }
        public static List<Partner> GetAllPartners()
        {
            List<Partner> partners = new List<Partner>();
            MySqlConnection conn = GetConnection();
            try
            {
                string query = "SELECT partner_id, partners_types.name AS 'type', company_name, director_name, phone_number, rating FROM partners INNER JOIN partners_types ON partner_type_id = partners_types.id;";
                MySqlCommand command = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Partner partner = new Partner
                        {
                            Id = reader.GetInt32("partner_id"),
                            Name = reader.GetString("company_name"),
                            Type = reader.GetString("type"),
                            DirectorName = reader.GetString("director_name"),
                            Rating = reader.GetInt32("rating"),
                            Phone = reader.GetString("phone_number"),
                            TotalQuantity = GetPartnerTotaltotalQuantity(reader.GetInt32("partner_id"))

                        };

                        partners.Add(partner);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении партнеров: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return partners;
        }
        public static int GetPartnerTotaltotalQuantity(int partnerId)
        {
            int totalQuantity = 0;
            MySqlConnection conn = GetConnection();

            try
            {
                string query = "SELECT SUM(quantity) FROM partner_sales_history WHERE partner_id = @partnerId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@partnerId", partnerId);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalQuantity = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return totalQuantity;
        }

    }
}
