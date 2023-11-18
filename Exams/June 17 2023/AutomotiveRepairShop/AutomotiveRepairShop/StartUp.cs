namespace AutomotiveRepairShop
{
    public class StartUp
    {
        static void Main(string[] args)
        {           
            RepairShop repairShop = new RepairShop(5);
           
            Vehicle vehicle1 = new Vehicle("1HGCM82633A123456", 50000, "Oil leakage");
            
            Console.WriteLine(vehicle1); 
            
            repairShop.AddVehicle(vehicle1);
           
            Console.WriteLine(repairShop.RemoveVehicle("1HGCM82633A123459")); 
            Console.WriteLine(repairShop.RemoveVehicle("1HGCM82633A123456")); 

            Vehicle vehicle2 = new Vehicle("5YJSA1CN7DFP12345", 80000, "Overheating issue");
            Vehicle vehicle3 = new Vehicle("JM1GJ1W56F1234567", 120000, "Coolant leakage");
            Vehicle vehicle4 = new Vehicle("2C3CDXAT4CH123456", 95000, "Timing belt failure");
            Vehicle vehicle5 = new Vehicle("WAUZZZ8K9FA123456", 66000, "Cylinder misfire");
            Vehicle vehicle6 = new Vehicle("1G1BL52P3RR123456", 150000, "Transmission failure");
            Vehicle vehicle7 = new Vehicle("JTDKB20U993123456", 65000, "Piston damage");

           
            repairShop.AddVehicle(vehicle2);
            repairShop.AddVehicle(vehicle3);
            repairShop.AddVehicle(vehicle4);
            repairShop.AddVehicle(vehicle5);

          
            Console.WriteLine(repairShop.GetCount()); 

            repairShop.AddVehicle(vehicle6);
            repairShop.AddVehicle(vehicle7);

            
            Console.WriteLine(repairShop.GetCount()); 

            
            Console.WriteLine(repairShop.GetLowestMileage()); 

           
            Console.WriteLine(repairShop.Report());
           

        }
    }
}