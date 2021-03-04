using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DormitoryIS.Models;

namespace DormitoryIS
{
    public static class DBRooms
    {
        public static ISRoom GetRoomData(int userId)
        {
            ISRoom room;
            using (MySqlConnection conn = DBUtils.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = $"select rooms.id, rooms.roomName, dormitories.name as dormitoryName, address from users join rooms on users.roomId = rooms.id join dormitories on dormitories.id = rooms.dormitoryId where users.id = '{userId}'";
                    using (var command = new MySqlCommand(query, conn))
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = Convert.ToInt32(reader[0]);
                            string roomName = reader[1].ToString();
                            string dormitoryName = reader[2].ToString();
                            string address = reader[3].ToString();

                            room = new ISRoom(id, dormitoryName, roomName, address);
                            return room;
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
        public static List<ISUser> GetRoomMates(ISUser user)
        {
            List<ISUser> roomMates = new List<ISUser>();
            using (MySqlConnection conn = DBUtils.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = $"SELECT * FROM users WHERE id != '{user.Id}' AND roomId = '{user.RoomId}'";
                    using (var command = new MySqlCommand(query, conn))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader[0]);
                            string fullName = reader[1].ToString();
                            string dateOfBirth = reader[2].ToString();
                            ISRoles role = (ISRoles)Enum.Parse(typeof(ISRoles), reader[3].ToString());
                            ISGenders gender = (ISGenders)Enum.Parse(typeof(ISGenders), reader[4].ToString());
                            string groupId = reader[5].ToString();
                            int studentTicketId = Convert.ToInt32(reader[6]);
                            int roomId = Convert.ToInt32(reader[9]);

                            roomMates.Add(new ISUser(id, fullName, dateOfBirth, role, gender, groupId, studentTicketId, roomId));
                        }
                    }

                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err.Message, "Ошибка!");
                }
            }

            return roomMates;
        }

        public static List<ISRoom> GetRooms()
        {
            List<ISRoom> rooms = new List<ISRoom>();
            using (MySqlConnection conn = DBUtils.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = $"SELECT rooms.id, rooms.roomName, dormitories.name, dormitories.address FROM rooms JOIN dormitories ON dormitoryId=dormitories.id";
                    using (var command = new MySqlCommand(query, conn))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader[0]);
                            string roomName = reader[1].ToString();
                            string dormitoryName = reader[2].ToString();
                            string address = reader[3].ToString();

                            rooms.Add(new ISRoom(id, dormitoryName, roomName, address));
                        }
                    }

                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err.Message, "Ошибка!");
                }
            }

            return rooms;
        }
    }
}
