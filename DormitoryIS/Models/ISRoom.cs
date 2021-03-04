using System.Collections.Generic;
using System.Linq;
namespace DormitoryIS.Models
{
    public class ISRoom
    {
        public int Id { get; private set; } = 0;
        public string DormitoryName { get; private set; } = "";
        public string Address { get; private set; } = "";
        public string RoomName { get; private set; } = "";

        public ISRoom(int id, string dormitoryName, string roomName, string address)
        {
            this.Id = id;
            this.DormitoryName = dormitoryName;
            this.RoomName = roomName;
            this.Address = address;
        }

        public static ISRoom GetRoomByName(List<ISRoom> rooms, string roomName)
        {
            ISRoom room = rooms.Find(r => r.RoomName == roomName);

            if (room != null)
            {
                return room;
            }

            return null;
        }
    }
}
