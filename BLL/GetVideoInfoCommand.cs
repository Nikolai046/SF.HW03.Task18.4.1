using YoutubeExplode;

public class GetVideoInfoCommand : ICommand
{
    private string VideoUrl;
    private readonly YoutubeClient youtubeClient;

    public GetVideoInfoCommand(string videoUrl, YoutubeClient youtubeClient)
    {
        VideoUrl = videoUrl;
        this.youtubeClient = youtubeClient;
    }

    public async Task ExecuteAsync()
    {
        try
        {
            var video = youtubeClient.Videos.GetAsync(VideoUrl).Result;
            Console.WriteLine($"Название: {video.Title}");
            Console.WriteLine($"Описание: {video.Description}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при получении информации о видео: {ex.Message}");
        }
    }
}