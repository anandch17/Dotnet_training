namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
           customer c=new customer("Anand",1234,400);
            Console.WriteLine(c);


            try
            {
                c.withdraw(350);
            }
            catch(bankexception e)
            {
                Console.WriteLine("transaction failed");
                e.inform();
            }
        }
    }
}
