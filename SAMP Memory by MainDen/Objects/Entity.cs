using System;

namespace MainDen.SAMP.Memory.Objects
{
    public class Entity : Placeable
    {
        public new enum Addresses
        {
            Clump = 0x18,
            EntityFlags = 0x1C,
            ModelId = 0x22,
            Interior = 0x2F,
            EntityType = 0x36,
        }
        
        public SAMPObject Clump
        {
            get => new SAMPObject { ProcessHandle = ProcessHandle, BaseAddress = (IntPtr)Memory.ReadInt32((int)Addresses.Clump) };
            set => Memory.Write((int)Addresses.Clump, value?.Memory.BaseAddress ?? IntPtr.Zero);
        }
        
        public UInt32 EntityFlags
        {
            get => Memory.ReadUInt32((int)Addresses.EntityFlags);
            set => Memory.Write((int)Addresses.EntityFlags, value);
        }
        
        public UInt16 ModelId
        {
            get => Memory.ReadUInt16((int)Addresses.ModelId);
            set => Memory.Write((int)Addresses.ModelId, value);
        }
        
        public Byte Interior
        {
            get => Memory.ReadByte((int)Addresses.Interior);
            set => Memory.Write((int)Addresses.Interior, value);
        }
        
        public UInt32 EntityType
        {
            get => Memory.ReadUInt32((int)Addresses.EntityType);
            set => Memory.Write((int)Addresses.EntityType, value);
        }
    }
}
