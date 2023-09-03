namespace AutomotiveRepairShop
{
    public class Vehicle
    {
        public Vehicle(string? vIN, int milage, string? damage)
        {
            this.VIN = vIN;
            this.Milage = milage;
            this.Damage = damage;
        }

        public string? VIN { get; set; }
        public int Milage { get; set; }
        public string? Damage { get; set; }

        public override string ToString()
        {
            return $"Damage: {this.Damage}, Vehicle: {this.VIN} ({this.Milage} km)";
        }
    }
}
