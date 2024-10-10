using YoutubeExplode;
using YoutubeExplode.Converter;

namespace SF.HW03.Task18._4._1.BLL.Commands;

/// <summary>
/// Класс DownloadVideoCommand реализует команду для скачивания видео с YouTube.
/// </summary>
public class DownloadVideoCommand : ICommand
{
    public string VideoUrl { get; }
    private string OutputPath { get; }

    private readonly YoutubeClient youtubeClient;

    /// <summary>
    /// Конструктор инициализирует команду с URL видео, путем сохранения и клиентом YouTube.
    /// </summary>
    public DownloadVideoCommand(string videoUrl, string outputPath, YoutubeClient youtubeClient)
    {
        VideoUrl = videoUrl;
        OutputPath = outputPath;
        this.youtubeClient = youtubeClient;
    }

    /// <summary>
    /// Метод Execute скачивает видео и сохраняет его по указанному пути.
    /// </summary>
    public async Task Execute()
    {
        try
        {
            Console.Clear();
            Console.WriteLine("Начинается скачивание видео...");
            youtubeClient.Videos.DownloadAsync(VideoUrl, OutputPath).GetAwaiter().GetResult();
            Console.WriteLine($"Видео успешно скачано в: {OutputPath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при скачивании видео: {ex.Message}");
        }
    }
}