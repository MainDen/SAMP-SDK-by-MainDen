using System;

namespace MainDen.SAMP.Memory.Objects
{
    public class SAMPCollection : SAMPObject
    {
        public int Capacity { get; set; }

        public SAMPObject this[int i]
        {
            get
            {
                if (i < 0 || Capacity <= i)
                    throw new ArgumentOutOfRangeException(nameof(i));

                return new SAMPObject() { ProcessHandle = ProcessHandle, BaseAddress = (IntPtr)Memory.ReadInt32(i * 0x4) };
            }
            set
            {
                if (i < 0 || Capacity <= i)
                    throw new ArgumentOutOfRangeException(nameof(i));
                if (value is null)
                    throw new ArgumentNullException(nameof(value));

                Memory.Write(i * 0x4, (Int32)value.BaseAddress);
            }
        }
    }
}
