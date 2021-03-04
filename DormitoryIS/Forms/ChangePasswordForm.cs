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
    public partial class ChangePasswordForm : Form
    {
        ISUser user;

        public ChangePasswordForm(ISUser user)
        {
            this.user = user;
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {

        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            string oldPass = oldPasswordField.Text;
            if (oldPass.Length > 0)
            {
                string newPass = newPasswordField.Text;
                if (newPass.Length >= 6)
                {
                    string confNewPass = confirmNewPasswordField.Text;
                    if (confNewPass.Length >= 6)
                    {
                        if (newPass == confNewPass)
                        {
                            if (DBUsers.ChangePassword(user.Id, oldPass, newPass))
                            {
                                MessageBox.Show("Пароль успешно изменен!", "Успех!");
                                this.Close();
                            } else
                            {
                                MessageBox.Show("Старый пароль введен неверно!", "Ошибка!");
                            }
                        } else
                        {
                            MessageBox.Show("Новый пароль и подтверждение должны совпадать!", "Ошибка!");
                            newPasswordField.Focus();
                        }
                    } else
                    {
                        MessageBox.Show("Длина нового пароля должна быть от 6 символов!", "Ошибка!");
                        confirmNewPasswordField.Focus();
                    }
                } else
                {
                    MessageBox.Show("Длина нового пароля должна быть от 6 символов!", "Ошибка!");
                    newPasswordField.Focus();
                }
            } else
            {
                MessageBox.Show("Необходимо ввести старый пароль!", "Ошибка!");
                oldPasswordField.Focus();
            }
        }
    }
}
