using AutoMapperConfiguration;
using PCC.Data.Models.Parts;

namespace PCC.Services.Models.Parts
{
    public class HardDiskServiceModel : PartServiceModel, IMapFrom<HardDisk>, IMapTo<HardDisk>
    {
        public long Capacity { get; set; }

        public long Speed { get; set; }

        public bool IsSSD { get; set; }
    }
}
