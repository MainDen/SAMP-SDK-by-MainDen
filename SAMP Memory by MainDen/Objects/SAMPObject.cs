using MainDen.Windows.Interception;
using System;

namespace MainDen.SAMP.Memory.Objects
{
    public class SAMPObject
    {
        public IntPtr ProcessHandle
        {
            get => Memory.ProcessHandle;
            set => Memory.ProcessHandle = value;
        }

        public IntPtr BaseAddress
        {
            get => Memory.BaseAddress;
            set => Memory.BaseAddress = value;
        }

        public MemoryContext Memory { get; } = new MemoryContext();
    }
}
