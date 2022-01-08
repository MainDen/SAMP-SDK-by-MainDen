using System;

namespace MainDen.SAMP.Memory.Objects
{
    public class Global : SAMPObject
    {
        public enum Addresses
        {
            Player = 0xB6F5F0,
            Gravity = 0x863984,
            GameSpeed = 0xB7CB64,
        }

        public Ped Player
        {
            get
            {
                return new Ped { ProcessHandle = ProcessHandle, BaseAddress = (IntPtr)Memory.ReadInt32((IntPtr)Addresses.Player) };
            }
        }

        public Single GameSpeed
        {
            get => Memory.ReadSingle((IntPtr)Addresses.GameSpeed);
            set => Memory.Write((IntPtr)Addresses.GameSpeed, value);
        }

        public Single Gravity
        {
            get => Memory.ReadSingle((IntPtr)Addresses.Gravity);
            set => Memory.Write((IntPtr)Addresses.Gravity, value);
        }
    }
}
