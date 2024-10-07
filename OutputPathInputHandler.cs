public class OutputPathInputHandler : IInputHandler
{
    public string GetInput()
    {
        Console.WriteLine("Введите путь для сохранения видео (с расширением .mp4):");
        string path = Console.ReadLine();

        while (string.IsNullOrEmpty(path) || !path.EndsWith(".mp4"))
        {
            Console.WriteLine("Путь должен быть указан и заканчиваться на .mp4. Попробуйте снова:");
            path = Console.ReadLine();
        }

        return path;
    }
}