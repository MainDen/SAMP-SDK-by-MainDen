using MainDen.SAMP.Memory.Objects;
using MainDen.Windows.Emulation;
using MainDen.Windows.Interception;
using System;

namespace MainDen.SAMP.Context
{
    public class SAMPContext
    {
        public IntPtr WindowHandle { get; set; }

        public IntPtr ProcessHandle { get; set; }

        public EmulationContext Emulation => new EmulationContext { WindowHandle = WindowHandle };

        public MemoryContext Memory => new MemoryContext { ProcessHandle = ProcessHandle };

        public Global Global
        {
            get
            {
                return new Global { ProcessHandle = ProcessHandle };
            }
        }

        public UI UI
        {
            get
            {
                return new UI { ProcessHandle = ProcessHandle };
            }
        }
    }
}
