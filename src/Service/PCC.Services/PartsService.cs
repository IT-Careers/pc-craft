using AutoMapperConfiguration;
using PCC.Data;
using PCC.Data.Models;
using PCC.Data.Models.Parts;
using PCC.Services.Models.Parts;
using System;
using System.Threading.Tasks;

namespace PCC.Services
{
    public class PartsService : IPartsService
    {
        private readonly PCCDbContext pCCDbContext;

        public PartsService(PCCDbContext pCCDbContext)
        {
            this.pCCDbContext = pCCDbContext;
        }

        public async Task<bool> CreateProcessorPart(ProcessorServiceModel processorServiceModel)
        {
            Processor processorEntity = processorServiceModel.To<Processor>();

            processorEntity.Id = Guid.NewGuid().ToString();

            bool result = await this.pCCDbContext.AddAsync(processorEntity) != null;

            await this.pCCDbContext.SaveChangesAsync();

            return result;
        }

        public async Task<bool> CreateGPUPart(GPUServiceModel gPUServiceModel)
        {
            GPU gPUEntity = gPUServiceModel.To<GPU>();

            gPUEntity.Id = Guid.NewGuid().ToString();

            bool result = await this.pCCDbContext.AddAsync(gPUEntity) != null;

            await this.pCCDbContext.SaveChangesAsync();

            return result;
        }

        public async Task<bool> CreateRAMPart(RAMServiceModel rAMServiceModel)
        {
            RAM rAMEntity = rAMServiceModel.To<RAM>();

            rAMEntity.Id = Guid.NewGuid().ToString();

            bool result = await this.pCCDbContext.AddAsync(rAMEntity) != null;

            await this.pCCDbContext.SaveChangesAsync();

            return result;
        }

        public async Task<bool> CreateMotherboardPart(MotherboardServiceModel motherboardServiceModel)
        {
            Motherboard motherboardEntity = motherboardServiceModel.To<Motherboard>();

            motherboardEntity.Id = Guid.NewGuid().ToString();

            bool result = await this.pCCDbContext.AddAsync(motherboardEntity) != null;

            await this.pCCDbContext.SaveChangesAsync();

            return result;
        }

        public async Task<bool> CreateHardDiskPart(HardDiskServiceModel hardDiskServiceModel)
        {
            HardDisk hardDiskEntity = hardDiskServiceModel.To<HardDisk>();

            hardDiskEntity.Id = Guid.NewGuid().ToString();

            bool result = await this.pCCDbContext.AddAsync(hardDiskEntity) != null;

            await this.pCCDbContext.SaveChangesAsync();

            return result;
        }

        public async Task<bool> CreatePowerSupplyPart(PowerSupplyServiceModel powerSupplyServiceModel)
        {
            PowerSupply powerSupplyEntity = powerSupplyServiceModel.To<PowerSupply>();

            powerSupplyEntity.Id = Guid.NewGuid().ToString();

            bool result = await this.pCCDbContext.AddAsync(powerSupplyEntity) != null;

            await this.pCCDbContext.SaveChangesAsync();

            return result;
        }
    }
}
