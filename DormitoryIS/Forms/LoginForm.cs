using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DormitoryIS.Models;

namespace DormitoryIS.Forms
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void authorizeButton_Click(object sender, EventArgs e)
        {
            if (loginInput.Text != "" && passwordInput.Text != "")
            {
                ISUser user = DBUsers.Login(loginInput.Text, passwordInput.Text);

                if (user != null)
                {
                    switch (user.Role)
                    {
                        case ISRoles.admin:
                            break;

                        case ISRoles.comendant:
                            ComendantMainForm comendantForm = new ComendantMainForm(user);
                            comendantForm.FormClosed += (obj, ev) => Show();
                            Hide();
                            comendantForm.Show();
                            break;

                        case ISRoles.student:
                            StudentMainForm stundetForm = new StudentMainForm(user);
                            stundetForm.FormClosed += (obj, ev) => Show();
                            Hide();
                            stundetForm.Show();
                            break;
                    }
                } else
                {
                    MessageBox.Show("Неправильная пара логин/пароль", "Ошибка!");
                }
            } else
            {
                MessageBox.Show("Необходимо ввести логин и пароль!", "Ошибка!");
            }
        }
    }
}
