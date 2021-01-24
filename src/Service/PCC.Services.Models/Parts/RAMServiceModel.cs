using AutoMapperConfiguration;
using PCC.Data.Models.Parts;

namespace PCC.Services.Models.Parts
{
    public class RAMServiceModel : PartServiceModel, IMapFrom<RAM>, IMapTo<RAM>
    {
        public long Capacity { get; set; }

        public string Type { get; set; }

        public long Speed { get; set; }
    }
}
