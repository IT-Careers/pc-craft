using AutoMapperConfiguration;
using PCC.Services.Models.Parts;

namespace PCC.Web.Models.Binding
{
    public class CreateGPUBindingModel : CreatePartBindingModel, IMapTo<GPUServiceModel>
    {
        public long Memory { get; set; }

        public long Clockspeed { get; set; }

        public string Generation { get; set; }
    }
}
