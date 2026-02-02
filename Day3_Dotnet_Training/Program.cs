using System.Formats.Asn1;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MaxValue);
            bool success = int.TryParse("true", out int result);
            Console.WriteLine(success); //try parse


            double ad = 10.7;
            int bd = (int)ad; // explicit
            Console.WriteLine(bd);

            var arr = new[] { 1, 2, 3, 4 };
            Console.WriteLine(arr[2]); //implicit typed array


            string s = "Hello World";
            Console.WriteLine(s.Substring(0, s.Length - 2));
            Console.WriteLine(s.Length);
            Console.WriteLine(s.ToUpper()); //string methods


            static void Change(int x)
            {
                x = 100;
            }


            int p = 10;
            Change(p);
            Console.WriteLine(p); //type reference




            static int Sum(params int[] nums)
            {
                int sum = 0;
                foreach (int n in nums) sum += n;
                return sum;
            }
            Console.WriteLine(Sum(1, 2, 3, 4)); //params parameter







            long val = long.MaxValue;
            Console.WriteLine(val);
            checked
            {
                int number = (int)val;
                Console.WriteLine(number);
            }                                   //checked and unchecked

            uint a;
            unchecked
            {

                a = uint.MaxValue;
                System.Console.WriteLine(a + 1);
            }

            uint b;
            checked
            {
                b = uint.MaxValue;
                System.Console.WriteLine(b + 1);
            }

            double ar = double.MaxValue;

            int br = unchecked((int)ar);
            Console.WriteLine(br);

            try
            {
                br = checked((int)ar);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }


            



        }
    }
}

