using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DormitoryIS;
using DormitoryIS.Models;

namespace DormitoryIS.Forms
{
    public partial class StudentMainForm : Form
    {
        private ISUser user;
        private Dictionary<int, Action> pageActions;

        public StudentMainForm(ISUser user)
        {
            this.user = user;
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            this.Text = $"Аккаут пользователя {user.FullName}";

            pageActions = new Dictionary<int, Action>()
            {
                { 0, SetMainTab},
                { 1, SetRoomTab},
                { 2, SetLodgerTab}
            };

            tabControl1.Selected += TabSelectionChanged;

            SetMainTab();
        }

        private void SetLodgerTab()
        {
            ISLodger lodger = DBLodgers.GetLodgerById(user.Id);
            _SetLodgerInfo(lodger);

            List<ISCard> cards = DBCards.GetCardsById(user.Id);
            if (cardsGrid.Rows.Count > 0) cardsGrid.Rows.Clear();

            if (cards.Count > 0)
            {
                for (int i = 0; i < cards.Count; i++)
                {
                    ISCard c = cards[i];
                    int id = c.Id;
                    string cardNumber = c.CardNumber;
                    string expirationDate = c.ExpirationDate;

                    cardsGrid.Rows.Add(new string[] { (i + 1).ToString(), id.ToString(), cardNumber, expirationDate });
                }
            }
        }

        private void _SetLodgerInfo(ISLodger lodger)
        {
            lodgerIdField.Text = lodger.Id.ToString();
            agreementAcceptedDateField.Text = lodger.AgreementAcceptedDate;
            currentMoneyAmmountField.Text = lodger.CurrentMoneyAmmount.ToString();
            paymentAmmountField.Text = lodger.PaymentAmmount.ToString();

            notEnougthMoneyField.Visible = lodger.CurrentMoneyAmmount < lodger.PaymentAmmount ? true : false;
        }

        private void TabSelectionChanged(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex < pageActions.Count)
            {
                Action action = pageActions[e.TabPageIndex];
                if (action != null) action();
            }
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
            groupIdField.Text = user.GroupId;
            studentTicketIdField.Text = user.StudentTicketId.ToString();
        }

        private void SetRoomTab()
        {
            ISRoom room = DBRooms.GetRoomData(user.Id);
            List<ISUser> roomMates = DBRooms.GetRoomMates(user);
            _SetRoomInfo(room, roomMates);
        }

        private void _SetRoomInfo(ISRoom room, List<ISUser> roomMates)
        {
            dormitoryNameField.Text = room.DormitoryName;
            roomNumField.Text = room.RoomName;
            addressField.Text = room.Address;

            if (roomMatesGrid.Rows.Count > 0) roomMatesGrid.Rows.Clear();

            if (roomMates.Count > 0)
            {
                for (int i = 0; i < roomMates.Count; i++)
                {
                    ISUser u = roomMates[i];
                    string[] row = new string[3] { (i + 1).ToString(), u.FullName, u.GroupId };
                    roomMatesGrid.Rows.Add(row);
                }
            }
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void cardsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить карту?", "Удаление карты", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    int cardId = Convert.ToInt32(cardsGrid.Rows[e.RowIndex].Cells[1].Value);
                    if (DBCards.RemoveCard(cardId))
                    {
                        MessageBox.Show("Карта успешно удалена!", "Успешно!");
                        SetLodgerTab();
                    }
                }
            }
        }

        private void addCardButton_Click(object sender, EventArgs e)
        {
            AddCardForm addCardForm = new AddCardForm(user);
            addCardForm.FormClosed += (s, ev) => SetLodgerTab();
            addCardForm.ShowDialog();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(user);
            changePasswordForm.FormClosed += (s, ev) => SetMainTab();
            changePasswordForm.ShowDialog();
        }
    }
}
