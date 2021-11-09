using System;
using System.Collections.Generic;

namespace Exam
{
    class Create
    {
        public Car CreateOneCar()
        {
            Console.Write("Reg Number: ");
            string regNum = Console.ReadLine();
            Console.Write("Car Age (in years): ");
            string buildYearString = Console.ReadLine();
            
            try 
            {
                int convertTest = Convert.ToInt32(buildYearString);
            }
            catch
            {
                //throw new Exception("!!!!! Invalid Age !!!!!"); // Not acceptable as answer. If question says to return null, you return null.
                Console.WriteLine("!!!!! Invalid Age!!!!!");
                return null;
            }
            
            Car newCar = new Car(regNum, buildYearString);
            Console.WriteLine("Car Created Sucessfully!");
            return newCar;
        }

        public List<Car> CreateThreeCars()
        {
            List <Car> carList = new List<Car>();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Reg Number: ");
                string regNum = Console.ReadLine();
                Console.Write("Car Age (in years): ");
                string buildYearString = Console.ReadLine();
                
                try
                {
                    int buildYear = Convert.ToInt32(buildYearString);
                }
                catch
                {
                    Console.WriteLine("!!!!! Invalid Age!!!!!");
                    return null;
                }

                Car newCar = new Car(regNum, buildYearString);
                Console.WriteLine("Car Created Sucessfully!");
                carList.Add(newCar);
            }
            Console.WriteLine("Car List Created and Returned!");
            return carList;
        }
    }
}
