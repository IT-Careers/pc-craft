using System.Collections.Generic;

namespace PCC.Data.Models
{
    public class Software : BaseEntity
    {
        public string Title { get; set; }

        public int Year { get; set; }

        public string Description { get; set; }

        public bool IsGame { get; set; }

        public string ParamatersId { get; set; }

        public List<ParameterSettings> ParametersPerSetting { get; set; }
    }
}
