using AutoMapperConfiguration;
using PCC.Services.Models.Parts;

namespace PCC.Web.Models.Binding
{
    public class CreateHardDiskBindingModel : CreatePartBindingModel, IMapTo<HardDiskServiceModel> 
    { 
        public long Capacity { get; set; }

        public long Speed { get; set; }

        public bool IsSSD { get; set; }
    }
}
