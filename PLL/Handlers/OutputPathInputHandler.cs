public class OutputPathInputHandler : IInputHandler
{
    public string GetInput()
    {
        while (true)
        {
            Console.Write("\nВведите путь для сохранения видео: ");
            string path = Console.ReadLine();
            Console.WriteLine();

            string[] pathParts = path.Split(new[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar },
                StringSplitOptions.RemoveEmptyEntries);

            // Используем Path.Combine для правильного объединения частей пути
            string directoryPath = pathParts.Aggregate(string.Empty, Path.Combine);

            // Добавляем имя файла к пути
            string fullPath = Path.Combine(directoryPath, "video.mp4");

            // Проверяем, существует ли директория
            if (Directory.Exists(directoryPath))
                return fullPath;
            Console.WriteLine($"Директория {directoryPath} не существует.");
        }
    }
}