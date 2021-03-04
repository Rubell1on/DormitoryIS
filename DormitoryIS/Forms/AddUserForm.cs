using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DormitoryIS.Models;

namespace DormitoryIS.Forms
{
    public partial class AddUserForm : Form
    {
        private ISUser user;
        private List<ISRoom> rooms;

        public AddUserForm(ISUser user)
        {
            this.user = user;
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            genderField.SelectedIndex = 0;
            roleField.SelectedIndex = 0;

            _SetRoomNameField();

            if (user.Role != ISRoles.student)
            {
                if (user.Role == ISRoles.comendant)
                {
                    roleField.Enabled = false;
                }
            } else
            {
                MessageBox.Show("У вас нет прав для этого действия!", "Ошибка!");
                this.Close();
            }
            
        }

        private void _SetRoomNameField()
        {
            rooms = DBRooms.GetRooms();

            if (rooms.Count > 0)
            {
                roomIdField.Items.Clear();
                rooms.ForEach(r => roomIdField.Items.Add(r.RoomName));
            }

            roomIdField.SelectedIndex = 0;
        }

        private void fullNameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.CheckLetter(e);
        }

        private void roomIdField_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.CheckLetter(e);
        }

        private void studTicketIdField_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.CheckDigit(e);
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            string name = fullNameField.Text;
            string birthDate = birthDateField.Value.ToString("yyyy-MM-dd");
            ISGenders gender = Utils.GetGenderEnum(genderField.Text);
            string genderStr = Enum.GetName(typeof(ISGenders), gender);
            string groupId = groupIdField.Text;
            ISRoles role = Utils.GetRoleEnum(roleField.Text);
            string roleStr = Enum.GetName(typeof(ISRoles), role);
            string studTicketId = studTicketIdField.Text;
            string userName = userNameField.Text;
            ISRoom room = ISRoom.GetRoomByName(rooms, roomIdField.Text);

            if (name.Length > 0)
            {
                if (birthDate.Length > 0)
                {
                    if (genderStr.Length > 0)
                    {
                        if (groupId.Length > 0)
                        {
                            if (roleStr.Length > 0)
                            {
                                if (studTicketId.Length > 0)
                                {
                                    if (userName.Length > 0)
                                    {
                                        if (room.Id > 0)
                                        {
                                            if (DBUsers.AddUser(name, birthDate, roleStr, genderStr, groupId, studTicketId, userName, room.Id))
                                            {
                                                MessageBox.Show("Пользователь успешно добавлен!", "Успех!");
                                                this.Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Произошла ошибка");
                                            }
                                        } else
                                        {
                                            MessageBox.Show("Необходимо выбрать комнату!", "Ошибка!");
                                            userNameField.Focus();

                                        }
                                    } else
                                    {
                                        MessageBox.Show("Необходимо ввести имя пользователя!", "Ошибка!");
                                        userNameField.Focus();
                                    }
                                } else
                                {
                                    MessageBox.Show("Необходимо ввести номер студенческого билета!", "Ошибка!");
                                    studTicketIdField.Focus();
                                }
                            } else
                            {
                                MessageBox.Show("Необходимо выбрать роль!", "Ошибка!");
                                roleField.Focus();
                            }
                        } else
                        {
                            MessageBox.Show("Необходимо ввести название группы!", "Ошибка!");
                            groupIdField.Focus();
                        }
                    } else
                    {
                        MessageBox.Show("Необходимо выбрать пол!", "Ошибка!");
                        genderField.Focus();
                    }
                } else
                {
                    MessageBox.Show("Необходимо выбрать день роджения!", "Ошибка!");
                    birthDateField.Focus();
                }
            } else
            {
                MessageBox.Show("Необходимо ввести ФИО", "Ошибка!");
                fullNameField.Focus();
            }
        }
    }
}
