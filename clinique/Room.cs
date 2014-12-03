using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinique
{
    class Room
    {
        public int RoomID { get; private set; }
        public string RoomName { get; private set; }

        public Room(int roomID, string roomName)
        {
            RoomID = roomID;
            RoomName = roomName;
        }

    }
}
