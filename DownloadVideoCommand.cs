using YoutubeExplode;
using YoutubeExplode.Converter;

public class DownloadVideoCommand : ICommand
{
    private readonly string _videoUrl;
    private readonly string _outputPath;
    private readonly YoutubeClient _youtubeClient;

    public DownloadVideoCommand(string videoUrl, string outputPath, YoutubeClient youtubeClient)
    {
        _videoUrl = videoUrl;
        _outputPath = outputPath;
        _youtubeClient = youtubeClient;
    }

    public void Execute()
    {
        try
        {
            Console.WriteLine("Начинается скачивание видео...");
            _youtubeClient.Videos.DownloadAsync(_videoUrl, _outputPath);
            Console.WriteLine($"Видео успешно скачано в: {_outputPath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при скачивании видео: {ex.Message}");
        }
    }
}