using MainDen.Windows.Interception;
using System;

namespace MainDen.SAMP.Memory.Objects
{
    public class UI : SAMPObject
    {
        public enum Addresses
        {
            Money = 0xB7CE50,
            Radio = 0x8CB7A5,
            Pause = 0xB7CB49,
            Menu = 0xB7CB49,
            MapTarget = 0xBA6774,
            Brightness = 0xBA6784,
            Legend = 0xBA6792,
            RadarMode = 0xBA676C,
            HudeMode = 0xBA6769,
        }
        
        public void FreeMouse()
        {
            var freeBuff = new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
            Memory.Write(0x747FB6, true);
            Memory.Write(0x74805A, true);
            Memory.Write(0x74542B, freeBuff, 0, 8);
            Memory.Write(0x53EA88, freeBuff, 8, 6);
        }

        public void LockMouse()
        {
            var lockBuff = new byte[] { 0x50, 0x51, 0xFF, 0x15, 0x00, 0x83, 0x85, 0x00, 0x0F, 0x84, 0x7B, 0x01, 0x00, 0x00 };
            Memory.Write(0x747FB6, false);
            Memory.Write(0x74805A, false);
            Memory.Write(0x74542B, lockBuff, 0, 8);
            Memory.Write(0x53EA88, lockBuff, 8, 6);
        }
    }
}
