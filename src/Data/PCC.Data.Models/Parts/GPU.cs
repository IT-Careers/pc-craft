namespace PCC.Data.Models.Parts
{
    public class GPU : Part
    {
        public long Memory { get; set; }

        public long Clockspeed { get; set; }

        public string Generation { get; set; }
    }
}
