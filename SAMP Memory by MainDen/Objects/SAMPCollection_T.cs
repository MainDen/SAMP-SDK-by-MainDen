namespace MainDen.SAMP.Memory.Objects
{
    public class SAMPCollection<TSAMPObject> : SAMPCollection where TSAMPObject : SAMPObject
    {
        public new TSAMPObject this[int i]
        {
            get
            {
                return (TSAMPObject)base[i];
            }
            set
            {
                base[i] = value;
            }
        }
    }
}
