using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using Fusion.CodeGen;

namespace Fusion.CodeGen
{
    [PreserveInPlugin]
    [WeaverGenerated]
    internal struct ReaderWriter@UnityEngine_Vector3 : IElementReaderWriter<Vector3>
    {
        [WeaverGenerated]
        public static IElementReaderWriter<Vector3> Instance;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [PreserveInPlugin]
        [WeaverGenerated]
        public override unsafe Vector3 Read(byte* data, int index)
        {
            int offset = index * 3;
            byte* ptr = data + (offset * sizeof(float));
            return new Vector3(
                *(float*)ptr,
                *(float*)(ptr + 4),
                *(float*)(ptr + 8)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [PreserveInPlugin]
        [WeaverGenerated]
        public override unsafe Vector3 ReadRef(byte* data, int index)
        {
            int offset = index * 3;
            return *(Vector3*)(data + (offset * sizeof(float)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [PreserveInPlugin]
        [WeaverGenerated]
        public override unsafe void Write(byte* data, int index, Vector3 val)
        {
            int offset = index * 3;
            byte* ptr = data + (offset * sizeof(float));
            *(float*)ptr = val.x;
            *(float*)(ptr + 4) = val.y;
            *(float*)(ptr + 8) = val.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [PreserveInPlugin]
        [WeaverGenerated]
        public override int GetElementWordCount()
        {
            return 3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [PreserveInPlugin]
        [WeaverGenerated]
        public override int GetElementHashCode(Vector3 val)
        {
            return val.x.GetHashCode() ^ val.y.GetHashCode() ^ val.z.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [WeaverGenerated]
        public static IElementReaderWriter<Vector3> GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ReaderWriter@UnityEngine_Vector3();
            }
            return Instance;
        }
    }
}