public class VideoUrlInputHandler : IInputHandler
{
    public string GetInput()
    {
        Console.WriteLine("Введите ссылку на YouTube видео:");
        string url = Console.ReadLine();

        while (string.IsNullOrEmpty(url))
        {
            Console.WriteLine("URL не может быть пустым. Пожалуйста, введите корректную ссылку:");
            url = Console.ReadLine();
        }

        return url;
    }
}