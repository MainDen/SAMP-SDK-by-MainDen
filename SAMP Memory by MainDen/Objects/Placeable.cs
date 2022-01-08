using System;

namespace MainDen.SAMP.Memory.Objects
{
    public class Placeable : SAMPObject
    {
        public enum Addresses
        {
            VirtualMethodsTable = 0x0000,
            Position = 0x0004,
            Angle = 0x0010,
            Transform = 0x0014,
        }
        
        public SAMPObject VirtualMethodsTable
        {
            get => new SAMPObject { ProcessHandle = ProcessHandle, BaseAddress = (IntPtr)Memory.ReadInt32((int)Addresses.VirtualMethodsTable) };
            set => Memory.Write((int)Addresses.VirtualMethodsTable, value?.Memory.BaseAddress ?? IntPtr.Zero);
        }
        
        public Vector3 Position
        {
            get => new Vector3 { ProcessHandle = ProcessHandle, BaseAddress = BaseAddress + (int)Addresses.Transform };
        }
        
        public Single Angle
        {
            get => Memory.ReadSingle((int)Addresses.Angle);
            set => Memory.Write((int)Addresses.Angle, value);
        }
        
        public Matrix Transform
        {
            get => new Matrix { ProcessHandle = ProcessHandle, BaseAddress = (IntPtr)Memory.ReadInt32((int)Addresses.Transform) };
            set => Memory.Write((int)Addresses.Transform, value?.Memory.BaseAddress ?? IntPtr.Zero);
        }
    }
}
