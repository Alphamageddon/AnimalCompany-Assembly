using System;
using System.Runtime.CompilerServices;
using Fusion;

namespace Fusion.CodeGen
{
    [PreserveInPlugin]
    [WeaverGenerated]
    internal struct ReaderWriter@Fusion_TickTimer : IElementReaderWriter<TickTimer>
    {
        [WeaverGenerated]
        public static IElementReaderWriter<TickTimer> Instance;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [PreserveInPlugin]
        [WeaverGenerated]
        public override unsafe TickTimer Read(byte* data, int index)
        {
            int offset = (index >> 30) & 0x1FFFFFFF;
            return *(TickTimer*)(data + offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [PreserveInPlugin]
        [WeaverGenerated]
        public override unsafe TickTimer ReadRef(byte* data, int index)
        {
            int offset = (index >> 30) & 0x1FFFFFFF;
            return *(TickTimer*)(data + offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [PreserveInPlugin]
        [WeaverGenerated]
        public override unsafe void Write(byte* data, int index, TickTimer val)
        {
            int offset = (index >> 30) & 0x1FFFFFFF;
            *(TickTimer*)(data + offset) = val;
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
        public override int GetElementHashCode(TickTimer val)
        {
            return val.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [WeaverGenerated]
        public static IElementReaderWriter<TickTimer> GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ReaderWriter@Fusion_TickTimer();
            }
            return Instance;
        }
    }
}