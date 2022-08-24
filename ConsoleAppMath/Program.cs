namespace ConsoleaAppDemo
{
    class program1
    {



        public static void divide(int a, int b, out int rem, out int res)
        {
            rem = a % b;
            res = a / b;

        }

        public static void Main()
        {
            Console.WriteLine("enter a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a:");
            int b = Convert.ToInt32(Console.ReadLine());


            divide(a, b, out int rem, out int res);
            Console.WriteLine($"quotient is {res}, remainder is {rem}");
        }
    }
}