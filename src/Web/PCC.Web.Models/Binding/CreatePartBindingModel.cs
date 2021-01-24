using Microsoft.AspNetCore.Http;

namespace PCC.Web.Models.Binding
{
    public abstract class CreatePartBindingModel
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public int ElectricalPowerConsumption { get; set; }

        public IFormFile FileUpload { get; set; }
    }
}
