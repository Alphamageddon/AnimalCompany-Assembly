// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    public static class Extensions
    {
        public static Vector3 Flatten(this Vector3 v)
        {
            return new Vector3(v.x, 0f, v.z);
        }
    }
}