using System;
using System.Runtime.CompilerServices;
using Fusion.CodeGen;

namespace Fusion.CodeGen
{
    [PreserveInPlugin]
    [WeaverGenerated]
    internal struct ReaderWriter@System_Boolean : IElementReaderWriter<Boolean>
    {
        [WeaverGenerated]
        public static IElementReaderWriter<Boolean> Instance;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [PreserveInPlugin]
        [WeaverGenerated]
        public override unsafe bool Read(byte* data, int index)
        {
            return *(bool*)(data + (index >> 3));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [PreserveInPlugin]
        [WeaverGenerated]
        public override unsafe bool ReadRef(byte* data, int index)
        {
            throw new NotSupportedException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [PreserveInPlugin]
        [WeaverGenerated]
        public override unsafe void Write(byte* data, int index, bool val)
        {
            *(bool*)(data + (index >> 3)) = val;
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
        public override int GetElementHashCode(bool val)
        {
            return val.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [WeaverGenerated]
        public static IElementReaderWriter<Boolean> GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ReaderWriter@System_Boolean();
            }
            return Instance;
        }
    }
}