using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DormitoryIS
{
    static class DBUtils
    {
        private static string connectionStringPath = "./connectionString.txt";

        public static string GetConnectionString()
        {
            string line = "";

            try
            {
                using (StreamReader sr = new StreamReader(connectionStringPath))
                {
                    line = sr.ReadToEnd();
                }
            }
            catch
            {
                MessageBox.Show("Файл строки подключения не был найден!", "Ошибка!");
            }

            return line;
        }

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(GetConnectionString());
        }
    }
}
