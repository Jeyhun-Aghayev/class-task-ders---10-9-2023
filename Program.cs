namespace class_task_ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region car
            /*bool t = true;
            Console.WriteLine("Modeli daxil edin:");
            string brand = Console.ReadLine();
            Console.WriteLine("Model daxil edin:");
            string model = Console.ReadLine();
            double CurrentFuel=0;
            while (t)
            {
                Console.WriteLine("Masinizin hazirki benzin miqdari:");
            CurrentFuel = Convert.ToDouble(Console.ReadLine());
                if (CurrentFuel >= 0)
                {
                    t = false;
                }
            }
            t = true;
            double FuelFor1Km = 0;
            while (t)
            {
                Console.WriteLine("masini bir km ucun xerclediyi benzin:");
            FuelFor1Km = Convert.ToDouble(Console.ReadLine());
                if (FuelFor1Km >= 0)
                {
                    t = false;
                }
            }

            double Millage =0;

            while (t) { 
            Console.WriteLine("Masinin bu vaxtadek surulduyu km:");
            Millage = Convert.ToDouble(Console.ReadLine());
                if (Millage >= 0) 
                { 
                t = false;
                }
            }
            Car car= new Car(brand, model,ref CurrentFuel,ref FuelFor1Km,ref Millage);

            car.GetAllElement( brand,  model,  CurrentFuel ,  Millage);

            while (true) { 
            Console.WriteLine("\nNe qeder surmek isteyirsiz:");
            int WantKm = Convert.ToInt32(Console.ReadLine());
            car.Drive(WantKm);
            }
*/
            #endregion
            #region Student
            /*Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Group:");
            string group = Console.ReadLine();
            Console.WriteLine("Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Point:");
            double point = Convert.ToDouble(Console.ReadLine());
            
            Student student = new Student(name, surname, group, age, point) ;
            Console.WriteLine(student.Age);*/
            #endregion
            #region PRAKTIKA-1           
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Salary:");
            double salary = Convert.ToDouble(Console.ReadLine());
            bool HasCertificate = false;
            Employee employee = new Employee(name: name, surname: surname, salary: salary, HasCertificate);
            /*Console.WriteLine("\n\nSecond Name:");
            string name1 = Console.ReadLine();
            Console.WriteLine("Second Surname:");
            string surname1 = Console.ReadLine();
            Console.WriteLine("Second Salary:");
            double salary1 = Convert.ToDouble(Console.ReadLine());
            bool HasCertificate1 = false;
            Employee employee1 = new Employee(name: name1, surname: surname1, salary: salary1, HasCertificate1);*/



            Employee[] array = { employee/*, employee1*/ };
            foreach (var item in array)
            {
                Console.WriteLine("\n");
                item.GetNameSurname();

            }


            #endregion



        }
    }
}