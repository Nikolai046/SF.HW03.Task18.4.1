using YoutubeExplode;

public class GetVideoInfoCommand : ICommand
{
    private readonly string _videoUrl;
    private readonly YoutubeClient _youtubeClient;

    public GetVideoInfoCommand(string videoUrl, YoutubeClient youtubeClient)
    {
        _videoUrl = videoUrl;
        _youtubeClient = youtubeClient;
    }

    public void Execute()
    {
        try
        {
            var video = _youtubeClient.Videos.GetAsync(_videoUrl).Result;
            Console.WriteLine($"Название: {video.Title}");
            Console.WriteLine($"Описание: {video.Description}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при получении информации о видео: {ex.Message}");
        }
    }
}