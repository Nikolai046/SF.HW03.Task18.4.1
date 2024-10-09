using YoutubeExplode;

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

    public void Execute()
    {
        try
        {
            Console.WriteLine("Начинается скачивание видео...");
            // youtubeClient.Videos.DownloadAsync(VideoUrl, OutputPath);
            Console.WriteLine($"Видео успешно скачано в: {OutputPath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при скачивании видео: {ex.Message}");
        }
    }
}