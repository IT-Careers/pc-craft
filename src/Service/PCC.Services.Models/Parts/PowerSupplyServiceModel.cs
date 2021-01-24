using AutoMapperConfiguration;
using PCC.Data.Models.Parts;

namespace PCC.Services.Models.Parts
{
    public class PowerSupplyServiceModel : PartServiceModel, IMapFrom<PowerSupply>, IMapTo<PowerSupply>
    {
        public int SupportedElectricalPowerConsumption { get; set; }
    }
}
