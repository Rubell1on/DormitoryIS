namespace DormitoryIS.Models
{
    public enum ISRoles { student, admin, comendant };
    public enum ISGenders { male, female };

    public class ISUser
    {
        public int Id { get; private set; } = 0;
        public string FullName { get; private set; } = "";
        public string DateOfBirth { get; private set; } = "";
        public ISRoles Role { get; private set; }
        public ISGenders Gender { get; private set; }
        public string GroupId { get; private set; } = "";
        public int StudentTicketId { get; private set; } = 0;
        public int RoomId { get; private set; } = 0;

        public ISUser(int id, string fullName, string dateOfBirth, ISRoles role, ISGenders gender, string groupId, int studentTicketId, int roomId)
        {
            this.Id = id;
            this.FullName = fullName;
            this.DateOfBirth = dateOfBirth;
            this.Role = role;
            this.Gender = gender;
            this.GroupId = groupId;
            this.StudentTicketId = studentTicketId;
            this.RoomId = roomId;
        }
    }
}
