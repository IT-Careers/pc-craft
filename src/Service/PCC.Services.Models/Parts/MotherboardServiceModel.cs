using AutoMapperConfiguration;
using PCC.Data.Models.Parts;

namespace PCC.Services.Models.Parts
{
    public class MotherboardServiceModel : PartServiceModel, IMapFrom<Motherboard>, IMapTo<Motherboard>
    {
        public string CPUSupport { get; set; }

        public string MemorySupport { get; set; }
    }
}
