using AutoMapperConfiguration;
using PCC.Data.Models.Parts;

namespace PCC.Services.Models.Parts
{
    public class GPUServiceModel : PartServiceModel, IMapFrom<GPU>, IMapTo<GPU>
    {
        public long Memory { get; set; }

        public long Clockspeed { get; set; }

        public string Generation { get; set; }
    }
}
