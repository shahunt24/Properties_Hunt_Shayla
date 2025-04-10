namespace Properties_Hunt_Shayla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Car class and set its properties
            Car car = new Car();
            car.Make = "Toyota";
            car.Model = "Carmy";

            // Displays the properties of the car
            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}");

            // Creates another instance of the Car class and sets its properties
            Car car2 = new Car();
            car2.Make = "Honda";
            car2.Model = "Civic";

            // Displays the properties of the second car
            Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}");

            // Creates a third instance of the Car class without setting properties
            Car car3 = new Car();
        }
    }
}
