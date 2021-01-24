namespace PCC.Services.Models.Parts
{
    public abstract class PartServiceModel
    {
        public string Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public int ElectricalPowerConsumption { get; set; }

        public string ImageUrl { get; set; }
    }
}
