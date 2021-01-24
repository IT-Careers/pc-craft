namespace PCC.Data.Models.Parts
{
    public class HardDisk : Part
    {
        public long Capacity { get; set; }

        public long Speed { get; set; }

        public bool IsSSD { get; set; }
    }
}
