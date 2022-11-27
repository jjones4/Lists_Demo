using Lists_Library;

namespace Lists_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set up some data to work with
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

            // Create and populate our List
            List<SteeringWheel> steeringWheels = new List<SteeringWheel>();

            steeringWheels.Add(citroenSteeringWheel);
            steeringWheels.Add(hrvSteeringWheel);
            steeringWheels.Add(dakotaSteeringWheel);
            steeringWheels.Add(typeRSteeringWheel);

            // Display the steering wheel prpoerties from the list
            Console.WriteLine("Info about the Steering Wheels in Our List");
            Console.WriteLine("------------------------------------------");

            foreach (SteeringWheel sw in steeringWheels)
            {
                Console.WriteLine($"{sw.Id} {sw.NumberOfSpokes} {sw.TypeOfMaterial}");
            }

            // Return the index of one of our steering wheels
            Console.WriteLine();
            Console.WriteLine($"Index of HRV Steering Wheel: {steeringWheels.IndexOf(hrvSteeringWheel)}");

            // Sort the list of steering wheels by ID
            Console.WriteLine();
            List<SteeringWheel> sortedSteeringWheels = steeringWheels.OrderBy(s => s.Id).ToList();

            // Display the steering wheel properties from the sorted list
            Console.WriteLine("Info about the Steering Wheels in Our Sorted List");
            Console.WriteLine("-------------------------------------------------");

            foreach (SteeringWheel sw in sortedSteeringWheels)
            {
                Console.WriteLine($"{sw.Id} {sw.NumberOfSpokes} {sw.TypeOfMaterial}");
            }
        }
    }
}