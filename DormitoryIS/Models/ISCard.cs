namespace DormitoryIS.Models
{
    public class ISCard
    {
        public int Id { get; private set; } = 0;
        public int UserId { get; private set; } = 0;
        public string CardNumber { get; private set; } = "";
        public string ExpirationDate { get; private set; } = "";

        public ISCard(int id, int userId, string cardNumber, string expirationDate)
        {
            this.Id = id;
            this.UserId = userId;
            this.CardNumber = cardNumber;
            this.ExpirationDate = expirationDate;
        }
    }
}
