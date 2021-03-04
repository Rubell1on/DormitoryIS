using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DormitoryIS.Models;

namespace DormitoryIS
{
    public static class Utils
    {
        private static Dictionary<ISRoles, string> ISRoleToStr = new Dictionary<ISRoles, string>()
        {
            { ISRoles.admin, "Администратор" },
            { ISRoles.comendant, "Комендант" },
            { ISRoles.student, "Студент" }
        };

        private static Dictionary<string, ISRoles> StrToISRole = new Dictionary<string, ISRoles>()
        {
            { "Администратор", ISRoles.admin },
            { "Комендант", ISRoles.comendant },
            { "Студент", ISRoles.student }
        };

        private static Dictionary<string, ISGenders> StrToISGender = new Dictionary<string, ISGenders>()
        {
            { "Мужской", ISGenders.male },
            { "Женский", ISGenders.female }
        };

        public static string GetRoleString(ISRoles role)
        {
            return ISRoleToStr[role];
        }

        public static ISRoles GetRoleEnum(string role)
        {
            return StrToISRole[role];
        }

        public static ISGenders GetGenderEnum(string gender)
        {
            return StrToISGender[gender];
        }

        public static void CheckDigit(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        public static void CheckLetter(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && number != 8 && number != 32) // цифры, клавиши BackSpace и пробел
            {
                e.Handled = true;
            }
        }
    }
}
