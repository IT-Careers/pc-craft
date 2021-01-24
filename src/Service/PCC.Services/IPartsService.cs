using PCC.Services.Models.Parts;
using System.Threading.Tasks;

namespace PCC.Services
{
    public interface IPartsService
    {
        Task<bool> CreateProcessorPart(ProcessorServiceModel processorServiceModel);

        Task<bool> CreateGPUPart(GPUServiceModel gPUServiceModel);

        Task<bool> CreateRAMPart(RAMServiceModel rAMServiceModel);

        Task<bool> CreateMotherboardPart(MotherboardServiceModel motherboardServiceModel);

        Task<bool> CreateHardDiskPart(HardDiskServiceModel hardDiskServiceModel);

        Task<bool> CreatePowerSupplyPart(PowerSupplyServiceModel powerSupplyServiceModel);
    }
}
