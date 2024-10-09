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
            string fullPath = pathParts.Aggregate(string.Empty, Path.Combine);

            // Проверяем, существует ли директория
            if (Directory.Exists(fullPath))
                return fullPath;
            Console.WriteLine($"Директория {fullPath} не существует.");
        }
    }
}