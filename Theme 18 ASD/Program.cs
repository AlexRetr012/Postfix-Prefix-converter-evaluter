using System;

namespace Theme_18_ASD
{
    class Program
    {
        public string InputPrefix()
        {
            Console.Write("Input Prefix form (without space) >> ");
            string spref = Console.ReadLine();
            return spref;
        }
        public string InputPostfix()
        {
            Console.Write("Input Postfix form (without space) >> ");
            string spost = Console.ReadLine();
            return spost;
        }
        public int Choice()
        {
            Console.WriteLine("Please,choose now :");
            Console.WriteLine("1.Calculate Prefix form");
            Console.WriteLine("2.Calculate Postfix form");
            Console.WriteLine("3.Convert Prefix -> Postfix ");
            Console.WriteLine("4.Convert Postfix -> Prefix ");
            Console.Write("Your Choice >> ");
            int choice =Convert.ToInt32(Console.ReadLine());
            return choice;

        }
        static void Main(string[] args)
        {
            int choice = Choice();
        }
    }
}
