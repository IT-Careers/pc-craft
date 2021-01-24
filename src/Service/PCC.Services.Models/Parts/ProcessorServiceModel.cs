using AutoMapperConfiguration;
using PCC.Data.Models;

namespace PCC.Services.Models.Parts
{
    public class ProcessorServiceModel : PartServiceModel, IMapFrom<Processor>, IMapTo<Processor>
    {
        public int Cores { get; set; }

        public long Clockspeed { get; set; }

        public string Socket { get; set; }
    }
}
