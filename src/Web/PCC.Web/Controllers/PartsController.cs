using AutoMapperConfiguration;
using Microsoft.AspNetCore.Mvc;
using PCC.Services;
using PCC.Services.Models.Parts;
using PCC.Web.Models.Binding;
using System.Threading.Tasks;

namespace PCC.Web.Controllers
{
    public class PartsController : Controller
    {
        private readonly ICloudinaryService cloudinaryService;

        private readonly IPartsService partsService;

        public PartsController(ICloudinaryService cloudinaryService, IPartsService partsService)
        {
            this.cloudinaryService = cloudinaryService;
            this.partsService = partsService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("/Parts/Create/Processor")]
        public async Task<IActionResult> CreateProcessor(CreateProcessorBindingModel createProcessorBindingModel)
        {
            ProcessorServiceModel serviceModel = createProcessorBindingModel.To<ProcessorServiceModel>();
            
            string url = await this.cloudinaryService.UploadImage(createProcessorBindingModel.FileUpload);

            serviceModel.ImageUrl = url;

            bool result = await this.partsService.CreateProcessorPart(serviceModel);

            return Redirect("/");
        }

        [HttpPost("/Parts/Create/GPU")]
        public async Task<IActionResult> CreateGPU(CreateGPUBindingModel createGPUBindingModel)
        {
            GPUServiceModel serviceModel = createGPUBindingModel.To<GPUServiceModel>();

            string url = await this.cloudinaryService.UploadImage(createGPUBindingModel.FileUpload);

            serviceModel.ImageUrl = url;

            bool result = await this.partsService.CreateGPUPart(serviceModel);

            return Redirect("/");
        }

        [HttpPost("/Parts/Create/RAM")]
        public async Task<IActionResult> CreateRAM(CreateRAMBindingModel createRAMBindingModel)
        {
            RAMServiceModel serviceModel = createRAMBindingModel.To<RAMServiceModel>();

            string url = await this.cloudinaryService.UploadImage(createRAMBindingModel.FileUpload);

            serviceModel.ImageUrl = url;

            bool result = await this.partsService.CreateRAMPart(serviceModel);

            return Redirect("/");
        }

        [HttpPost("/Parts/Create/Motherboard")]
        public async Task<IActionResult> CreateMotherboard(CreateMotherboardBindingModel createMotherboardBindingModel)
        {
            MotherboardServiceModel serviceModel = createMotherboardBindingModel.To<MotherboardServiceModel>();

            string url = await this.cloudinaryService.UploadImage(createMotherboardBindingModel.FileUpload);

            serviceModel.ImageUrl = url;

            bool result = await this.partsService.CreateMotherboardPart(serviceModel);

            return Redirect("/");
        }

        [HttpPost("/Parts/Create/HardDrive")]
        public async Task<IActionResult> CreateHardDrive(CreateHardDiskBindingModel createHardDiskBindingModel)
        {
            HardDiskServiceModel serviceModel = createHardDiskBindingModel.To<HardDiskServiceModel>();

            string url = await this.cloudinaryService.UploadImage(createHardDiskBindingModel.FileUpload);

            serviceModel.ImageUrl = url;

            bool result = await this.partsService.CreateHardDiskPart(serviceModel);

            return Redirect("/");
        }

        [HttpPost("/Parts/Create/PowerSupply")]
        public async Task<IActionResult> CreatePowerSupply(CreatePowerSupplyBindingModel createPowerSupplyBindingModel)
        {
            PowerSupplyServiceModel serviceModel = createPowerSupplyBindingModel.To<PowerSupplyServiceModel>();

            string url = await this.cloudinaryService.UploadImage(createPowerSupplyBindingModel.FileUpload);

            serviceModel.ImageUrl = url;

            bool result = await this.partsService.CreatePowerSupplyPart(serviceModel);

            return Redirect("/");
        }
    }
}
