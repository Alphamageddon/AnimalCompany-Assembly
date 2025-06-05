// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    public class JoinedRoomAction : BaseAction
    {
        private string _roomCode;

        public JoinedRoomAction(string roomCode)
        {
            _roomCode = roomCode;
        }

        public override void Execute(AppState state)
        {
            if (state != null && state.RoomState != null && state.RoomState.CurrentRoom != null)
            {
                state.RoomState.CurrentRoom.value = _roomCode;
            }
        }
    }
}