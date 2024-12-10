using AbstractFactory.Fire;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fire Heroes:");
            var fireGame = new GameClient(FireHeroFactory.Instance);
            fireGame.Run();

            Console.WriteLine("\nIce Heroes:");
            var iceGame = new GameClient(IceHeroFactory.Instance);
            iceGame.Run();
        }
    }
}