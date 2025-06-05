using UnityEngine;

namespace AnimalCompany
{
    public class LeftRoomAction : BaseAction
    {
        public LeftRoomAction()
        {
        }

        public override void Execute(AppState state)
        {
            if (state?.currentRoom != null)
            {
                state.currentRoom.OnPlayerLeft();
                state.currentRoom = null;
            }
        }
    }
}