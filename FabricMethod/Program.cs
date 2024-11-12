namespace FabricMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new GameClient();

            Console.WriteLine("Fire Heroes:");
            client.Run(new FireHeroCreator());

            Console.WriteLine("\nIce Heroes:");
            client.Run(new IceHeroCreator());
        }
    }
}