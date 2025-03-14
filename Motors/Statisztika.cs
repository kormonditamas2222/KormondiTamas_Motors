using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motors
{
    internal class Statisztika
    {
        List<Motor> motors = [];

        internal List<Motor> Motors { get => motors; }

        public void ReadFromFile(string fileName)
        {
            StreamReader sr = new(fileName);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(";");
                Motor motor = new(line[0], line[1], Convert.ToInt16(line[2]), Convert.ToDouble(line[3]), Convert.ToDouble(line[4]));
                motors.Add(motor);
            }
        }
        public int SumPrices(List<Motor> motors)
        {
            int sum = 0;
            foreach (Motor motor in motors)
            {
                sum += Convert.ToInt32(motor.PriceInEur);
            }
            return sum;
        }
        public bool Contains(string motorName) 
        {
            bool tempBool = false;
            while (tempBool == false)
            {
                foreach (Motor motor in motors)
                {
                    if (motor.Name.Equals(motorName))
                    {
                        tempBool = true;
                    }
                }
            }
            return tempBool;
        }
        public Motor Oldest()
        {
            int min = motors[0].ReleaseYear;
            Motor reMotor = motors[0];
            foreach (Motor motor in motors)
            {
                if (motor.ReleaseYear < min)
                {
                    min = motor.ReleaseYear;
                    reMotor = motor;
                }
            }
            return reMotor;
        }
        public int SumBasedOnBrand(string brandName)
        {
            List<Motor> brandMotors = [];
            foreach (Motor motor in motors)
            {
                if (motor.Name.Equals(brandName))
                {
                    brandMotors.Add(motor);
                }
            }
            return SumPrices(brandMotors);
        }
        public void Sort()
        {
            motors = motors.OrderByDescending(m => m.Performance).ToList();
            foreach (Motor motor in motors)
            {
                Console.WriteLine(motor);
            }
        }
    }
}
