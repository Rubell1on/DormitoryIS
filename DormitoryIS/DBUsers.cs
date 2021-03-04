using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DormitoryIS.Models;

namespace DormitoryIS
{
    public static class DBUsers
    {
        public static ISUser Login(string userName, string password)
        {
            ISUser user = null;
            using (MySqlConnection conn = DBUtils.GetConnection())
            {
                try
                {
                    conn.Open();

                    using (var command = new MySqlCommand($"SELECT * FROM users WHERE username='{userName}' AND password='{password}'", conn))
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = _ReadUserStream(reader);
                            return user;
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

        public static ISUser GetUserById(int userId)
        {
            ISUser user = null;
            using (MySqlConnection conn = DBUtils.GetConnection())
            {
                try
                {
                    conn.Open();

                    using (var command = new MySqlCommand($"SELECT * FROM users WHERE id ='{userId}'", conn))
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = _ReadUserStream(reader);
                            return user;
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

        public static List<ISUser> GetStudents()
        {
            List<ISUser> users = new List<ISUser>();
            using (MySqlConnection conn = DBUtils.GetConnection())
            {
                try
                {
                    conn.Open();

                    using (var command = new MySqlCommand($"SELECT * FROM users WHERE role = 'student'", conn))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ISUser user = _ReadUserStream(reader);
                            users.Add(user);
                        }

                        return users;
                    }

                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err.Message, "Ошибка!");
                }
            }

            return null;
        }

        public static List<ISUser> GetStudents(string searchValue)
        {
            List<ISUser> users = new List<ISUser>();
            using (MySqlConnection conn = DBUtils.GetConnection())
            {
                try
                {
                    conn.Open();

                    using (var command = new MySqlCommand($"SELECT * FROM users WHERE role = 'student' AND fullName REGEXP '{searchValue}'", conn))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ISUser user = _ReadUserStream(reader); ;
                            users.Add(user);
                        }

                        return users;
                    }

                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err.Message, "Ошибка!");
                }
            }

            return null;
        }

        public static bool AddUser(string fullName, string birthDate, string role, string gender, string groupId, string studentTicketId, string userName, int roomId)
        {
            using (MySqlConnection conn = DBUtils.GetConnection())
            {
                try
                {
                    conn.Open();

                    using (var command = new MySqlCommand($"INSERT INTO users SET fullName='{fullName}', dateOfBirth='{birthDate}', role='{role}', gender='{gender}', groupId='{groupId}', studentTicketId='{studentTicketId}', userName='{userName}', password='1111', roomId='{roomId}';", conn))
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

        public static bool RemoveUser(int userId)
        {
            using (MySqlConnection conn = DBUtils.GetConnection())
            {
                try
                {
                    conn.Open();

                    using (var command = new MySqlCommand($"DELETE FROM users WHERE id='{userId}'", conn))
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

        public static bool ChangePassword(int userId, string oldPassword, string newPassword)
        {
            if (IsValidPassword(userId, oldPassword))
            {
                using (MySqlConnection conn = DBUtils.GetConnection())
                {
                    try
                    {
                        conn.Open();

                        using (var command = new MySqlCommand($"UPDATE users SET password={newPassword} WHERE id ='{userId}'", conn))
                        using (var reader = command.ExecuteReader())
                        {
                            return true;
                        }

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Error: " + err.Message, "Ошибка!");
                    }
                }
            } else
            {
                return false;
            }

            return false;
        }

        public static bool IsValidPassword(int userId, string password)
        {
            using (MySqlConnection conn = DBUtils.GetConnection())
            {
                try
                {
                    conn.Open();

                    using (var command = new MySqlCommand($"SELECT * FROM users WHERE id ='{userId}' AND password='{password}'", conn))
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return true;
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err.Message, "Ошибка!");
                }
            }

            return false;
        }

        private static ISUser _ReadUserStream(MySqlDataReader reader)
        {
            int id = Convert.ToInt32(reader[0]);
            string fullName = reader[1].ToString();
            string dateOfBirth = reader[2].ToString();
            ISRoles role = (ISRoles)Enum.Parse(typeof(ISRoles), reader[3].ToString());
            ISGenders gender = (ISGenders)Enum.Parse(typeof(ISGenders), reader[4].ToString());
            string groupId = reader[5].ToString();
            string studTicket = reader[6].ToString();
            int studentTicketId = studTicket.Length > 0 ? Convert.ToInt32(studTicket) : 0;
            string room = reader[9].ToString();
            int roomId = room.Length > 0 ?  Convert.ToInt32(room) : 0;

            return new ISUser(id, fullName, dateOfBirth, role, gender, groupId, studentTicketId, roomId);
        }
    }
}
