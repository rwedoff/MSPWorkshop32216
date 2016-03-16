using System;


namespace MSPcsExample
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello ACM!");
        //    Console.ReadKey();
        //}
        static void Main(string[] arg)
        {
            RandomNumberStuff rn = new RandomNumberStuff(0, 10);
            string title = "Your random number is: ";
            dynamic dynamicVar = 5;
            Console.WriteLine(dynamicVar);
            dynamicVar = "Hello!";
            Console.WriteLine(dynamicVar);
            Console.WriteLine(title + rn.getRandom());
            Console.ReadKey();
        }
    }
    class RandomNumberStuff
    {
        private int _start;
        private int _end;

        public RandomNumberStuff(int start, int end)
        {
            this._start = start;
            this._end = end;
        }
        public int getRandom()
        {
            Random rnd = new Random();  //Built in!
            return rnd.Next(_start, _end);
        }
    }
}
