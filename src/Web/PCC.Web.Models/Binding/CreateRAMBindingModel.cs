using AutoMapperConfiguration;
using PCC.Services.Models.Parts;

namespace PCC.Web.Models.Binding
{
    public class CreateRAMBindingModel : CreatePartBindingModel, IMapTo<RAMServiceModel>
    {
        public long Capacity { get; set; }

        public string Type { get; set; }

        public long Speed { get; set; }
    }
}
