using YoutubeExplode;

namespace SF.HW03.Task18._4._1.BLL.Commands;

/// <summary>
/// Класс GetVideoInfoCommand реализует команду для получения информации о видео с YouTube.
/// </summary>
public class GetVideoInfoCommand : ICommand
{
    private string VideoUrl;
    private readonly YoutubeClient youtubeClient;

    /// <summary>
    /// Конструктор инициализирует команду с URL видео и клиентом YouTube.
    /// </summary>
    public GetVideoInfoCommand(string videoUrl, YoutubeClient youtubeClient)
    {
        VideoUrl = videoUrl;
        this.youtubeClient = youtubeClient;
    }

    /// <summary>
    /// Метод Execute получает информацию о видео и выводит её в консоль.
    /// </summary>
    public async Task Execute()
    {
        try
        {
            var video = youtubeClient.Videos.GetAsync(VideoUrl).Result;
            Console.Clear();
            Console.WriteLine($"Название: {video.Title}");
            Console.WriteLine($"Описание: {video.Description}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при получении информации о видео: {ex.Message}");
        }
    }
}