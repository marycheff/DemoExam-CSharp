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
            string query = "datasource=localhost;port=3306; username=root;password=; database=master_pol";
            MySqlConnection conn = new MySqlConnection(query);
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
                string query = "SELECT partner_id, partners_types.name AS 'type', company_name, director_name, phone_number, rating " +
                    "FROM partners " +
                    "INNER JOIN partners_types ON partner_type_id = partners_types.id " +
                    "ORDER BY partner_id DESC";
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
                string query = "SELECT SUM(quantity) " +
                    "FROM partner_sales_history " +
                    "WHERE partner_id = @partnerId";

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
        public static List<string> GetPartnersTypes()
        {
            MySqlConnection conn = GetConnection();
            List<string> partnersTypes = new List<string>();
            try

            {


                string query = "SELECT name FROM partners_types ORDER BY id";

                MySqlCommand cmd = new MySqlCommand(query, conn);



                using (MySqlDataReader reader = cmd.ExecuteReader())

                {

                    while (reader.Read())

                    {

                        partnersTypes.Add(reader.GetString("name"));

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
            return partnersTypes;
        }

        public static void AddPartner(Partner partner)
        {
            MySqlConnection conn = GetConnection();

            try
            {
                string query = "INSERT INTO partners (partner_type_id, company_name, legal_address, phone_number, email, rating, director_name) " +
                               "VALUES (@partner_type_id, @company_name, @legal_address, @phone_number, @email, @rating, @director_name)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@partner_type_id", partner.TypeId);
                    cmd.Parameters.AddWithValue("@company_name", partner.Name);
                    cmd.Parameters.AddWithValue("@legal_address", partner.Address);
                    cmd.Parameters.AddWithValue("@phone_number", partner.Phone);
                    cmd.Parameters.AddWithValue("@email", partner.Email);
                    cmd.Parameters.AddWithValue("@rating", partner.Rating);
                    cmd.Parameters.AddWithValue("@director_name", partner.DirectorName);


                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении партнера" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public static Partner GetPartner(int partnerId)
        {
            Partner partner = new Partner();
            string query = "SELECT partner_type_id, company_name, legal_address, director_name, phone_number, rating, email from partners " +
                "WHERE partner_id = @partnerId";
            MySqlConnection conn = GetConnection();
            try
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@partnerId", partnerId);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        partner.TypeId = reader.GetInt32("partner_type_id");
                        partner.Name = reader.GetString("company_name");
                        partner.Address = reader.GetString("legal_address");
                        partner.DirectorName = reader.GetString("director_name");
                        partner.Phone = reader.GetString("phone_number");
                        partner.Rating = reader.GetInt32("rating");
                        partner.Email = reader.GetString("email");
                    }
                }

            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка при получении партнера" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return partner;
        }

        public static void UpdatePartner(Partner partner)
        {
            string query = "UPDATE partners SET " +
                           "partner_type_id = @typeId, " +
                           "company_name = @name, " +
                           "legal_address = @address, " +
                           "director_name = @directorName, " +
                           "phone_number = @phone, " +
                           "rating = @rating, " +
                           "email = @email " +
                           "WHERE partner_id = @partnerId";

            MySqlConnection conn = GetConnection();
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@typeId", partner.TypeId);
                command.Parameters.AddWithValue("@name", partner.Name);
                command.Parameters.AddWithValue("@address", partner.Address);
                command.Parameters.AddWithValue("@directorName", partner.DirectorName);
                command.Parameters.AddWithValue("@phone", partner.Phone);
                command.Parameters.AddWithValue("@rating", partner.Rating);
                command.Parameters.AddWithValue("@email", partner.Email);
                command.Parameters.AddWithValue("@partnerId", partner.Id);

                command.ExecuteNonQuery();
            }
        }

    }
}
