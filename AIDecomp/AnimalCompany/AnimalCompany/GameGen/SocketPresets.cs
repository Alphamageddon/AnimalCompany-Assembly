// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany.GameGen
{
    public static class SocketPresets
    {
        public static Vector2 GetSocketSize(SocketType doorway)
        {
            switch (doorway)
            {
                case SocketType.Door:
                    return new Vector2(1f, 2f);
                default:
                    return Vector2.zero;
            }
        }
    }
}