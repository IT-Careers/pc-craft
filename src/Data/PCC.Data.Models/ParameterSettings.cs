namespace PCC.Data.Models
{
    public class ParameterSettings : BaseEntity
    {
        public long RecommendedRAM { get; set; }

        public string RecommendedRAMType { get; set; }

        public long RecommendedRAMSpeed { get; set; }

        public long RecommendedProcessorClockspeed { get; set; }

        public long RecommendedProcessorCores { get; set; }

        public string RecommendedProcessorGeneration { get; set; }

        public long RecommendedStorageSpace { get; set; }

        public long RecommendedVideoMemory { get; set; }

        public long RecommendedVideoClockspeed { get; set; }

        public string RecommendedVideoGeneration { get; set; }

        public string SettingId { get; set; }

        public Setting Setting { get; set; }

        public string SoftwareId { get; set; }

        public Software Software { get; set; }
    }
}
