namespace PCC.Data.Models
{
    public class Processor : Part
    {
        public int Cores { get; set; }

        public long Clockspeed { get; set; }

        public string Socket { get; set; }
    }
}
