using AutoMapperConfiguration;
using PCC.Services.Models.Parts;

namespace PCC.Web.Models.Binding
{
    public class CreateProcessorBindingModel : CreatePartBindingModel, IMapTo<ProcessorServiceModel>
    {
        public int Cores { get; set; }

        public long Clockspeed { get; set; }

        public string Socket { get; set; }
    }
}
