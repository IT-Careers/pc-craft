namespace PCC.Data.Models
{
    public abstract class Part : BaseEntity
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public int ElectricalPowerConsumption { get; set; }

        public string ImageUrl { get; set; }
    }
}
