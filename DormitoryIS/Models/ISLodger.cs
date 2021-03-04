namespace DormitoryIS.Models
{
    public class ISLodger
    {
        public int Id { get; private set; } = 0;
        public int UserId { get; private set; } = 0;
        public int CurrentMoneyAmmount { get; private set; } = 0;
        public string AgreementAcceptedDate { get; private set; } = "";
        public int PaymentAmmount { get; private set; } = 0;

        public ISLodger(int id, int userId, int currentMoneyAmmount, string agreementAcceptedDate, int paymentAmmount)
        {
            this.Id = id;
            this.UserId = userId;
            this.CurrentMoneyAmmount = currentMoneyAmmount;
            this.AgreementAcceptedDate = agreementAcceptedDate;
            this.PaymentAmmount = paymentAmmount;
        }
    }
}
