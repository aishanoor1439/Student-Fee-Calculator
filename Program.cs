using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Fee_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int semester, fee;
            double payable = 0;
            Console.WriteLine("Are you from a naval family?");
            bool naval = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("In which semester you want to enroll?");
            semester = Convert.ToInt32(Console.ReadLine());
            fee = 6000;
            if (naval)
            {
                switch (semester)
                {
                    case 1:
                    case 2:
                        payable = 0.6 * fee * 15; break;
                    case 3:
                    case 4:
                        payable = 0.6 * fee * 16; break;
                    case 5:
                    case 6:
                        payable = 0.6 * fee * 17; break;
                    case 7:
                    case 8:
                        payable = 0.6 * fee * 18; break;
                    default: Console.WriteLine("Invalid number."); break;
                }
            }
            else
            {
                switch (semester)
                {
                    case 1:
                    case 2:
                        payable = fee * 15; break;
                    case 3:
                    case 4:
                        payable = fee * 16; break;
                    case 5:
                    case 6:
                        payable = fee * 17; break;
                    case 7:
                    case 8:
                        payable = fee * 18; break;
                    default: Console.WriteLine("Invalid number."); break;
                }

            }
            Console.WriteLine("Tution fee: {0}", payable);
        }
    }
}
