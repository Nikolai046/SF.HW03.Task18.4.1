using YoutubeExplode;
using YoutubeExplode.Converter;

public class DownloadVideoCommand : ICommand
{
    public string VideoUrl { get; }
    private string OutputPath { get; }

    private readonly YoutubeClient youtubeClient;

    public DownloadVideoCommand(string videoUrl, string outputPath, YoutubeClient youtubeClient)
    {
        VideoUrl = videoUrl;
        OutputPath = outputPath;
        this.youtubeClient = youtubeClient;
    }

    public async Task ExecuteAsync()
    {
        try
        {
            Console.WriteLine("Начинается скачивание видео...");
            await youtubeClient.Videos.DownloadAsync(VideoUrl, OutputPath);
            Console.WriteLine($"Видео успешно скачано в: {OutputPath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при скачивании видео: {ex.Message}");
        }
    }
}