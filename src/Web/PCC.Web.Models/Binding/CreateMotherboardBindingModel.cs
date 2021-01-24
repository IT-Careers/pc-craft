using AutoMapperConfiguration;
using PCC.Services.Models.Parts;

namespace PCC.Web.Models.Binding
{
    public class CreateMotherboardBindingModel : CreatePartBindingModel, IMapTo<MotherboardServiceModel>
    {
        public string CPUSupport { get; set; }

        public string MemorySupport { get; set; }
    }
}
