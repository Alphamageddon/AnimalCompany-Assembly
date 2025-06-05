using System;
using System.Runtime.CompilerServices;
using Fusion;

namespace Fusion.CodeGen
{
    [PreserveInPlugin]
    [WeaverGenerated]
    internal struct ReaderWriter@Fusion_NetworkId : IElementReaderWriter<NetworkId>
    {
        [WeaverGenerated]
        public static IElementReaderWriter<NetworkId> Instance;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [PreserveInPlugin]
        [WeaverGenerated]
        public override unsafe NetworkId Read(byte* data, int index)
        {
            int offset = (index >> 30) & 0x1FFFFFFF;
            return *(NetworkId*)(data + offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [PreserveInPlugin]
        [WeaverGenerated]
        public override unsafe NetworkId ReadRef(byte* data, int index)
        {
            int offset = (index >> 30) & 0x1FFFFFFF;
            return *(NetworkId*)(data + offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [PreserveInPlugin]
        [WeaverGenerated]
        public override unsafe void Write(byte* data, int index, NetworkId val)
        {
            int offset = (index >> 30) & 0x1FFFFFFF;
            *(NetworkId*)(data + offset) = val;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [PreserveInPlugin]
        [WeaverGenerated]
        public override int GetElementWordCount()
        {
            return 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [PreserveInPlugin]
        [WeaverGenerated]
        public override int GetElementHashCode(NetworkId val)
        {
            return val.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [WeaverGenerated]
        public static IElementReaderWriter<NetworkId> GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ReaderWriter@Fusion_NetworkId();
            }
            return Instance;
        }
    }
}