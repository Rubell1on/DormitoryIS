using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DormitoryIS.Models;
using MySql.Data.MySqlClient;

namespace DormitoryIS.Forms
{
    public static class DBCards
    {
        public static List<ISCard> GetCardsById(int userId)
        {
            List<ISCard> cards = new List<ISCard>();

            using (MySqlConnection conn = DBUtils.GetConnection())
            {
                try
                {
                    conn.Open();

                    using (var command = new MySqlCommand($"SELECT id, userId, cardNumber, expirationDate FROM cards WHERE userId = {userId}", conn))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader[0]);
                            int uId = Convert.ToInt32(reader[1]);
                            string cardNumber = reader[2].ToString();
                            string expirationDate = reader[3].ToString();

                            cards.Add(new ISCard(id, uId, cardNumber, expirationDate));
                        }

                        return cards;
                    }

                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err.Message, "Ошибка!");
                }
            }

            return null;
        }

        public static bool AddCard(int userId, string cardNumber, string expirationDate, string cardOwner, string cvv)
        {
            using (MySqlConnection conn = DBUtils.GetConnection())
            {
                try
                {
                    conn.Open();

                    using (var command = new MySqlCommand($"insert into cards set userId = '{userId}', cardNumber='{cardNumber}', expirationDate='{expirationDate}', cardOwner='{cardOwner}', cvv='{cvv}';", conn))
                    using (var reader = command.ExecuteReader())
                    {
                        return true;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err.Message, "Ошибка!");
                    return false;
                }
            }
        }

        public static bool RemoveCard(int cardId)
        {
            using (MySqlConnection conn = DBUtils.GetConnection())
            {
                try
                {
                    conn.Open();

                    using (var command = new MySqlCommand($"DELETE FROM cards WHERE id = '{cardId}'", conn))
                    using (var reader = command.ExecuteReader())
                    {
                        return true;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err.Message, "Ошибка!");
                    return false;
                }
            }
        }
    }
}
