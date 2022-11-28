using Lists_Library;

namespace Lists_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            // Set up some data to work with
            CustomList<SteeringWheel> steeringWheels = new CustomList<SteeringWheel>();

            SteeringWheel citroenSteeringWheel = new SteeringWheel();
            citroenSteeringWheel.Id = 7;
            citroenSteeringWheel.NumberOfSpokes = 2;
            citroenSteeringWheel.TypeOfMaterial = "Acrylic";

            SteeringWheel hrvSteeringWheel = new SteeringWheel();
            hrvSteeringWheel.Id = 2;
            hrvSteeringWheel.NumberOfSpokes = 3;
            hrvSteeringWheel.TypeOfMaterial = "Urethane";

            SteeringWheel typeRSteeringWheel = new SteeringWheel();
            typeRSteeringWheel.Id = 6;
            typeRSteeringWheel.NumberOfSpokes = 3;
            typeRSteeringWheel.TypeOfMaterial = "Leather";

            SteeringWheel dakotaSteeringWheel = new SteeringWheel();
            dakotaSteeringWheel.Id = 4;
            dakotaSteeringWheel.NumberOfSpokes = 4;
            dakotaSteeringWheel.TypeOfMaterial = "Urethane";

            steeringWheels.AddItem(citroenSteeringWheel);
            steeringWheels.AddItem(hrvSteeringWheel);
            steeringWheels.AddItem(dakotaSteeringWheel);
            steeringWheels.AddItem(typeRSteeringWheel);

            // Display the steering wheel prpoerties from steering wheels
            // in the list
            Console.WriteLine("   Info about the Steering Wheels in Our Custom List");
            Console.WriteLine();
            Console.WriteLine("   Id Spokes Material");
            Console.WriteLine("   -- ------ --------");

            for (int i = 0; i < steeringWheels.Count(); i++)
            {
                Console.WriteLine($"   {steeringWheels[i].Id}  " +
                    $"{steeringWheels[i].NumberOfSpokes}      " +
                    $"{steeringWheels[i].TypeOfMaterial}");
            }
            
            Console.WriteLine();

            // Display the steering wheel properties from steering wheels
            // after sorting the list by Id
            List<SteeringWheel> moreSteeringWheels = new List<SteeringWheel>();

            moreSteeringWheels.Add(citroenSteeringWheel);
            moreSteeringWheels.Add(hrvSteeringWheel);
            moreSteeringWheels.Add(dakotaSteeringWheel);
            moreSteeringWheels.Add(typeRSteeringWheel);

            List<SteeringWheel> sortedSteeringWheels = moreSteeringWheels.OrderBy(s => s.Id).ToList();

            Console.WriteLine("   Info about the Steering Wheels in Our Sorted List");
            Console.WriteLine();
            Console.WriteLine("   Id Spokes Material");
            Console.WriteLine("   -- ------ --------");

            foreach (SteeringWheel sw in sortedSteeringWheels)
            {
                Console.WriteLine($"   {sw.Id}  {sw.NumberOfSpokes}      {sw.TypeOfMaterial}");
            }
        }
    }
}