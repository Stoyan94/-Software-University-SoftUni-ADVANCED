namespace Vehicle_Catalogue_OOP_2._0
{
    public class Program
    {
        static void Main(string[] args)
        {      
            List<CatalogVehicles> catalog = new List<CatalogVehicles>();

            string vehicleInfo;

            while ((vehicleInfo = Console.ReadLine()!) !="End")
            {
                string[] inputInfo = vehicleInfo.Split();

                string typeVehicle = inputInfo[0];
                string model = inputInfo[1];
                string color  = inputInfo[2];
                int horsePower = int.Parse(inputInfo[3]);

                if (typeVehicle == "car") 
                {
                    CatalogVehicles car = new CatalogVehicles (typeVehicle,model,color,horsePower);
                    catalog.Add(car);
                }
                else if (typeVehicle == "truck")
                {
                    CatalogVehicles truck = new CatalogVehicles(typeVehicle,model,color, horsePower);
                    catalog.Add(truck);
                }
            }

           
            string vehiclelModel;
            List<CatalogVehicles> getByModel =  new List<CatalogVehicles> ();

            while ((vehiclelModel = Console.ReadLine()!)!= "Close the Catalogue")
            {
               CatalogVehicles findModel = catalog.Find(x=>x.Model == vehiclelModel)!;   
               
              getByModel.Add(findModel);
            }            
        
         
            foreach (var vehicles in getByModel)
            {
                Console.WriteLine($"{vehicles}");
            }
            

            var carsCount = catalog.FindAll(x => x.Type == "car").Average(x=>x.HorsePower);
            var trucksCount = catalog.FindAll(x => x.Type == "truck").Average(x=>x.HorsePower);
            
            
            Console.WriteLine($"Cars have average horsepower of: {carsCount:f2}");
            Console.WriteLine($"Trucks have average horsepower of: {trucksCount:f2}");
        }
    }
}