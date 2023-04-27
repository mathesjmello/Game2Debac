using System;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class RoomManager: MonoBehaviour
    {
        public List<GameObject> rooms;
        private GameObject _currentRoom;

        private void Start()
        {
            _currentRoom = rooms[0];
        }

        public void ChangeRoom(string r)
        {
            foreach (var room in rooms)
            {
                if (room.name == r)
                {
                    _currentRoom.SetActive(false);
                    _currentRoom = room;
                    _currentRoom.SetActive(true);
                    break;
                }
            }
        }
    }
}