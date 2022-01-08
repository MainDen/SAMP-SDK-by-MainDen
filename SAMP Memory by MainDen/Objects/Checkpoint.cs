using System;

namespace MainDen.SAMP.Memory.Objects
{
    public class Checkpoint : SAMPObject
    {
        public enum Addresses
        {
            Type = 0x0,
            R = 0x8,
            G = 0x9,
            B = 0xA,
            X = 0x10,
            Y = 0x14,
            Z = 0x18,
            RotX = 0x1C,
            RotY = 0x20,
            RotZ = 0x24,
            Size = 0x2C,
            Pool = 0xC7F158,
        }
        
        public const int PoolSize = 32;
        
        public const int SingleSize = 56;
    }
}
