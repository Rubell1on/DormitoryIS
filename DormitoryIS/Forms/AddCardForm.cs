using System;
using System.Windows.Forms;
using DormitoryIS.Models;

namespace DormitoryIS.Forms
{
    public partial class AddCardForm : Form
    {
        private ISUser user;
        public AddCardForm(ISUser user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void CheckDigit(object sender, KeyPressEventArgs e)
        {
            Utils.CheckDigit(e);
        }

        private void CheckLetter(object sender, KeyPressEventArgs e)
        {
            Utils.CheckLetter(e);
        }

        private void AddCard(object sender, EventArgs e)
        {

            if (IsValid(numField1.Text, 4) && IsValid(numField2.Text, 4) && IsValid(numField3.Text, 4) && IsValid(numField4.Text, 4))
            {
                int expireMonth = Convert.ToInt32(expiryMonthField.Text);
                int expireYear = Convert.ToInt32(expiryYearField.Text);

                if ((IsValid(expiryMonthField.Text, 2) && expireMonth <= 12 && expireMonth > 0) && IsValid(expiryYearField.Text, 2))
                {
                    DateTime dt = DateTime.Parse($"1.{expireMonth}.{expireYear}");
                    TimeSpan diffDt = dt.Subtract(DateTime.Now);

                    if (diffDt.Days >= 0)
                    {
                        if (ownerField.Text.Length > 0 && IsValid(cvvField.Text, 3))
                        {
                            string cardNumber = $"{numField1.Text} {numField2.Text} {numField3.Text} {numField4.Text}";
                            string expirationDate = $"{expiryMonthField.Text}/{expiryYearField.Text}";
                            if (DBCards.AddCard(user.Id, cardNumber, expirationDate, ownerField.Text, cvvField.Text))
                            {
                                MessageBox.Show("Карта успешно добавлена!", "Успешно!");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("При добавлении карты произошла ошибка!", "Ошибка!");
                                ownerField.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Введен неправильный CVV код или владелец карты!", "Ошибка!");
                            cvvField.Focus();
                        }
                    } else
                    {
                        MessageBox.Show("Введен неправильный срок годности!", "Ошибка!");
                        expiryMonthField.Focus();
                    }
                } else
                {
                    MessageBox.Show("Введен неправильный срок годности!", "Ошибка!");
                    expiryMonthField.Focus();
                }
            } else
            {
                MessageBox.Show("Введен неправильный номер карты!", "Ошибка!");
                numField1.Focus();
            }


            bool IsValid(string numPart, int num)
            {
                return numPart.Length == num ? true : false;
            }
        }
    }
}
