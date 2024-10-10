using SF.HW03.Task18._4._1.PLL;
using SF.HW03.Task18._4._1.PLL.Handlers;

namespace SF.HW03.Task18._4._1;

using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Получение ссылки на видео
        var urlHandler = new VideoUrlInputHandler();
        var videoUrl = urlHandler.GetInput();

        // Запуск пользовательского интерфейса
        var ui = new UserInterface(videoUrl);
        ui.Run();
    }
}