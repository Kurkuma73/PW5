namespace PW5
{
    interface IHello
    {
        void SayHello();
    }

    class GermanHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Guten Tag");
        }
    }
    class EnglishHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
    class LuxembourgishHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Merci");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IHello> hellos = new List<IHello>();
            hellos.Add(new GermanHello());
            hellos.Add(new EnglishHello());
            hellos.Add(new LuxembourgishHello());

            foreach (var hello in hellos)
            {
                SayHello(hello);
            }

            Console.ReadKey();
        }
        static void SayHello(IHello hello)
        {
            hello.SayHello();
        }
    }
}