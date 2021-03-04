using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DormitoryIS.Models;

namespace DormitoryIS.Forms
{
    public partial class ComendantMainForm : Form
    {
        private ISUser user;
        private Dictionary<int, Action> pageActions;

        public ComendantMainForm(ISUser user)
        {
            this.user = user;
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            this.Text = $"Аккаут коменданта {user.FullName}";
            pageActions = new Dictionary<int, Action>()
            {
                { 0, SetMainTab},
                { 1, SetStudentsTab}
            };

            tabControl1.Selected += TabSelectionChanged;

            SetMainTab();
        }

        private void SetMainTab()
        {
            user = DBUsers.GetUserById(user.Id);
            _SetMainInfo(user);
        }

        private void _SetMainInfo(ISUser user)
        {
            userIdField.Text = user.Id.ToString();
            birthDateField.Text = user.DateOfBirth.Split(' ')[0];
            fullNameField.Text = user.FullName;
            genderField.Text = user.Gender == ISGenders.male ? "Мужской" : "Женский";
            roleField.Text = Utils.GetRoleString(user.Role);
        }

        private void SetStudentsTab()
        {
            List<ISUser> users = DBUsers.GetStudents();

            _SetUsersGrid(users);
        }

        private void _SetUsersGrid(List<ISUser> users)
        {
            if (usersGrid.Rows.Count > 0) usersGrid.Rows.Clear();

            if (users != null && users.Count > 0)
            {
                for (int i = 0; i < users.Count; i++)
                {
                    ISUser user = users[i];

                    string role = Utils.GetRoleString(user.Role);
                    string dateOfBirth = user.DateOfBirth.Split(' ')[0];
                    string gender = user.Gender == ISGenders.male ? "Мужской" : "Женский";
                    string[] row = new string[] { (i + 1).ToString(), user.Id.ToString(), user.FullName, dateOfBirth, role, gender, user.GroupId, user.RoomId.ToString() };

                    usersGrid.Rows.Add(row);
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchValue = searchField.Text;

            List<ISUser> users = null;

            if (searchValue.Length > 0)
            {
                users = DBUsers.GetStudents(searchValue);               
            } else
            {
                users = DBUsers.GetStudents();
            }

            _SetUsersGrid(users);
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm(this.user);
            addUserForm.FormClosed += (o, ev) => SetMainTab();
            addUserForm.ShowDialog();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить пользователя?", "Удаление пользователя", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    int userId = Convert.ToInt32(usersGrid.Rows[e.RowIndex].Cells[1].Value);
                    if (DBUsers.RemoveUser(userId))
                    {
                        MessageBox.Show("Пользователь успешно удален!", "Успешно!");
                        SetMainTab();
                    }
                }
            }
        }

        private void TabSelectionChanged(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex < pageActions.Count)
            {
                Action action = pageActions[e.TabPageIndex];
                if (action != null) action();
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(user);
            changePasswordForm.FormClosed += (s, ev) => SetMainTab();
            changePasswordForm.ShowDialog();
        }
    }
}
