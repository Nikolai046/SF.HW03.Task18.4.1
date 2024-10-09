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

    public void Execute()
    {
        try
        {
            //var video = youtubeClient.Videos.GetAsync(VideoUrl).Result;
            //Console.WriteLine($"Название: {video.Title}");
            //Console.WriteLine($"Описание: {video.Description}");

            Console.WriteLine($"Название: ***");
            Console.WriteLine($"Описание: ***");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при получении информации о видео: {ex.Message}");
        }
    }
}