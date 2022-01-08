using System;

namespace MainDen.SAMP.Memory.Objects
{
    public class Matrix : SAMPObject
    {
        public enum Addresses
        {
            XYSin = 0x00,
            YXCos = 0x04,
            Roll = 0x08,
            DirX = 0x10,
            DirY = 0x14,
            DirZ = 0x20,
            X = 0x30,
            Y = 0x34,
            Z = 0x38,
        }
        
        public float Roll
        {
            get => Memory.ReadSingle((int)Addresses.Roll);
            set => Memory.Write((int)Addresses.Roll, value);
        }
        
        public float DirX
        {
            get => Memory.ReadSingle((int)Addresses.DirX);
            set => Memory.Write((int)Addresses.DirX, value);
        }
        
        public float DirY
        {
            get => Memory.ReadSingle((int)Addresses.DirY);
            set => Memory.Write((int)Addresses.DirY, value);
        }
        
        public float DirZ
        {
            get => Memory.ReadSingle((int)Addresses.DirZ);
            set => Memory.Write((int)Addresses.DirZ, value);
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
