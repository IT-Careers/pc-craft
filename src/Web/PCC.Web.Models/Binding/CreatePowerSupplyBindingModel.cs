using AutoMapperConfiguration;
using PCC.Services.Models.Parts;

namespace PCC.Web.Models.Binding
{
    public class CreatePowerSupplyBindingModel : CreatePartBindingModel, IMapTo<PowerSupplyServiceModel>
    {
        public int SupportedElectricalPowerConsumption { get; set; }
    }
}
