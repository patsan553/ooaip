namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //объект компьютера
            Computer computer = new Computer();
            // Запускаем первую игру
            computer.LaunchGame("Apex");
            Console.WriteLine($"Текущая игра: {computer.CurrentGame.Name}");
            // Попытка изменить текущую игру
            computer.CurrentGame = Game.GetInstance("Cyberpunk2077");
            Console.WriteLine($"Текущая игра: {computer.CurrentGame.Name}");
            // Еще попытка изменить игру
            computer.LaunchGame("Dota 2");
            Console.WriteLine($"Текущая игра: {computer.CurrentGame.Name}");
            Console.ReadLine();
        }
    }
}