namespace inheritanceone
{
    public class Program
    {
        /*public static void Main(string[] args)
        {
            Car c = new Car();
            c.DisplayInfo("BMW", 200);
            Bike b = new Bike();
            b.DisplayInfo("royal enfield", 100);

        }
        public static void Main(string[] args)
        {
            // Taking input for car details
            Console.WriteLine("Enter the brand of the car:");
            string carBrand = Console.ReadLine();
            Console.WriteLine("Enter the speed of the car:");
            int carSpeed = int.Parse(Console.ReadLine());

            Cars car = new Cars();
            car.DisplayInfo(carBrand, carSpeed);

            // Taking input for bike details
            Console.WriteLine("Enter the brand of the bike:");
            string bikeBrand = Console.ReadLine();
            Console.WriteLine("Enter the speed of the bike:");
            int bikeSpeed = int.Parse(Console.ReadLine());

            Bikes bike = new Bikes();
            bike.DisplayInfo(bikeBrand, bikeSpeed);
        }
        public static void Main(string[] args)
        {
            Manager m = new Manager("John", 200000, 5000);
            Console.WriteLine($"The name of the manager is {m.Name}, the salary of the manager is {m.Salary}, and the bonus of the manager is {m.Bonus}");

        }
        public static void Main(string[] args)
        {
            Dog d = new Dog();
            d.MakeSound();
            Cat c = new Cat();
            c.MakeSound();
        }
        public static void Main(string[] args)
        {
            Robot r = new Robot();
            r.Start();
            r.Move();
        }
        public static void Main(string[] args)
        {
            Account a = new Account();
            a.CalculateInterest();
            SavingsAccount s = new SavingsAccount();
            s.CalculateInterest();
            CurrentAccount c = new CurrentAccount();
            c.CalculateInterest();
        }
        public static void Main(string[] args)
        {
            Duck d = new Duck();
            d.Fly();
            d.Swim();
        }
        public static void Main(string[] args)
        {
            Student s = new Student();
            Person p = s;
            p.Greet();
            //p.Study(); gets erros because the method is not present in the base class.
            Student s1 = (Student)p;
            s1.Study();
            //s1.Greet();doesnt get error because the student class is inherited from parents class
            //so the methods in parent class can be executed by using child class object.
        }
        static void Main(string[] args)
        {
            Product electronic = new ElectronicProduct { Name = "Laptop", Price = 1000 };
            Product clothing = new ClothingProduct { Name = "Jacket", Price = 200 };
            Product product = new Product { Name = "Product", Price = 100 };
            product.GetDiscountedPrice();

            electronic.GetDiscountedPrice();
            clothing.GetDiscountedPrice();
            
        }*/
        static void Main(string[] args)
        {
            SecuritySystem security = new SecuritySystem();
            security.AuthenticateUser();
        }
    }
}
