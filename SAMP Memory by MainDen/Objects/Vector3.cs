using System;

namespace MainDen.SAMP.Memory.Objects
{
    public class Vector3 : SAMPObject
    {
        public enum Addresses : int
        {
            X = 0x0000,
            Y = 0x0004,
            Z = 0x0008,
        }
        
        public float X
        {
            get => Memory.ReadSingle((int)Addresses.X);
            set => Memory.Write((int)Addresses.X, value);
        }
        
        public float Y
        {
            get => Memory.ReadSingle((int)Addresses.Y);
            set => Memory.Write((int)Addresses.Y, value);
        }
        
        public float Z
        {
            get => Memory.ReadSingle((int)Addresses.Z);
            set => Memory.Write((int)Addresses.Z, value);
        }
    }
}
