namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fire Heroes:");
            var fireGame = new GameClient(new FireHeroFactory());
            fireGame.Run();

            Console.WriteLine("\nIce Heroes:");
            var iceGame = new GameClient(new IceHeroFactory());
            iceGame.Run();
        }
    }
}