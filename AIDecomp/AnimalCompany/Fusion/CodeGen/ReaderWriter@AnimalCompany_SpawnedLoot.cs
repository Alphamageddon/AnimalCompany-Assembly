using System;
using System.Runtime.CompilerServices;
using Fusion;

namespace Fusion.CodeGen
{
    [PreserveInPlugin]
    [WeaverGenerated]
    internal struct ReaderWriter@AnimalCompany_SpawnedLoot : IElementReaderWriter<AnimalCompany.SpawnedLoot>
    {
        [WeaverGenerated]
        public static IElementReaderWriter<AnimalCompany.SpawnedLoot> Instance;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [PreserveInPlugin]
        [WeaverGenerated]
        public override unsafe AnimalCompany.SpawnedLoot Read(byte* data, int index)
        {
            int offset = index * 3;
            byte* ptr = data + offset;
            return new AnimalCompany.SpawnedLoot
            {
                NetworkObject = *(NetworkObject*)ptr,
                ItemId = *(int*)(ptr + 8)
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [PreserveInPlugin]
        [WeaverGenerated]
        public override unsafe AnimalCompany.SpawnedLoot ReadRef(byte* data, int index)
        {
            int offset = index * 3;
            return *(AnimalCompany.SpawnedLoot*)(data + offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [PreserveInPlugin]
        [WeaverGenerated]
        public override unsafe void Write(byte* data, int index, AnimalCompany.SpawnedLoot val)
        {
            int offset = index * 3;
            byte* ptr = data + offset;
            *(NetworkObject*)ptr = val.NetworkObject;
            *(int*)(ptr + 8) = val.ItemId;
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
        public override int GetElementHashCode(AnimalCompany.SpawnedLoot val)
        {
            return val.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [WeaverGenerated]
        public static IElementReaderWriter<AnimalCompany.SpawnedLoot> GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ReaderWriter@AnimalCompany_SpawnedLoot();
            }
            return Instance;
        }
    }
}