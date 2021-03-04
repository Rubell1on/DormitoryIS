using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DormitoryIS.Models;

namespace DormitoryIS
{
    public static class DBLodgers
    {
        public static ISLodger GetLodgerById(int userId)
        {
            ISLodger lodger = null;

            using (MySqlConnection conn = DBUtils.GetConnection())
            {
                try
                {
                    conn.Open();

                    using (var command = new MySqlCommand($"SELECT * FROM lodgers WHERE userId = {userId}", conn))
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = Convert.ToInt32(reader[0]);
                            int uId = Convert.ToInt32(reader[1]);
                            int currentMoneyAmmount = Convert.ToInt32(reader[2]);
                            string agreementAcceptedDate = reader[3].ToString().Split(' ')[0];
                            int paymentAmmount = Convert.ToInt32(reader[4]);

                            lodger = new ISLodger(id, uId, currentMoneyAmmount, agreementAcceptedDate, paymentAmmount);
                            return lodger;
                        }
                    }

                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err.Message, "Ошибка!");
                }
            }

            return null;
        }
    }
}
