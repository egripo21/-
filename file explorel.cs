using System;
using System.IO;

class FileExplorer
{
    static string currentPath = Directory.GetCurrentDirectory();

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("== Консольный проводник ==");
            Console.WriteLine($"Текущий путь: {currentPath}");
            Console.WriteLine("1. Просмотреть содержимое каталога");
            Console.WriteLine("2. Перейти в подкаталог");
            Console.WriteLine("3. Вернуться назад");
            Console.WriteLine("4. Открыть текстовый файл");
            Console.WriteLine("5. Создать каталог");
            Console.WriteLine("6. Создать текстовый файл");
            Console.WriteLine("7. Удалить файл или папку");
            Console.WriteLine("8. Работа с дисками");
            Console.WriteLine("9. Выход");
            Console.Write("Выбор: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ShowDirectory();
                    break;
                case "2":
                    EnterDirectory();
                    break;
                case "3":
                    GoBack();
                    break;
                case "4":
                    OpenFile();
                    break;
                case "5":
                    CreateDirectory();
                    break;
                case "6":
                    CreateFile();
                    break;
                case "7":
                    DeleteItem();
                    break;
                case "8":
                    DiskMenu();
                    break;
                case "9":
                    return;
            }
        }
    }

    static void ShowDirectory()
    {
        Console.WriteLine("\nСодержимое:");
        foreach (string dir in Directory.GetDirectories(currentPath))
            Console.WriteLine("[DIR] " + Path.GetFileName(dir));
        foreach (string file in Directory.GetFiles(currentPath))
            Console.WriteLine("      " + Path.GetFileName(file));
        Console.WriteLine("\nНажмите любую клавишу...");
        Console.ReadKey();
    }

    static void EnterDirectory()
    {
        Console.Write("Введите имя подкаталога: ");
        string dirName = Console.ReadLine();
        string newPath = Path.Combine(currentPath, dirName);
        if (Directory.Exists(newPath))
            currentPath = newPath;
        else
            Console.WriteLine("Папка не найдена!");
        Console.ReadKey();
    }

    static void GoBack()
    {
        DirectoryInfo parent = Directory.GetParent(currentPath);
        if (parent != null)
            currentPath = parent.FullName;
    }

    static void OpenFile()
    {
        Console.Write("Введите имя файла: ");
        string fileName = Console.ReadLine();
        string filePath = Path.Combine(currentPath, fileName);
        if (File.Exists(filePath))
        {
            Console.Clear();
            Console.WriteLine("Содержимое файла:\n");
            Console.WriteLine(File.ReadAllText(filePath));
        }
        else
            Console.WriteLine("Файл не найден!");
        Console.ReadKey();
    }

    static void CreateDirectory()
    {
        Console.Write("Введите имя нового каталога: ");
        string dirName = Console.ReadLine();
        string path = Path.Combine(currentPath, dirName);
        Directory.CreateDirectory(path);
        Console.WriteLine("Каталог создан.");
        Console.ReadKey();
    }

    static void CreateFile()
    {
        Console.Write("Введите имя файла (с .txt): ");
        string fileName = Console.ReadLine();
        Console.WriteLine("Введите текст для записи в файл (пустая строка — завершить):");
        string line;
        using (StreamWriter sw = new StreamWriter(Path.Combine(currentPath, fileName)))
        {
            while ((line = Console.ReadLine()) != "")
                sw.WriteLine(line);
        }
        Console.WriteLine("Файл создан.");
        Console.ReadKey();
    }

    static void DeleteItem()
    {
        Console.Write("Введите имя файла или папки для удаления: ");
        string name = Console.ReadLine();
        string path = Path.Combine(currentPath, name);
        if (File.Exists(path))
        {
            Console.Write("Удалить файл? (y/n): ");
            if (Console.ReadLine().ToLower() == "y")
                File.Delete(path);
        }
        else if (Directory.Exists(path))
        {
            Console.Write("Удалить каталог и всё содержимое? (y/n): ");
            if (Console.ReadLine().ToLower() == "y")
                Directory.Delete(path, true);
        }
        else
            Console.WriteLine("Не найдено.");
        Console.ReadKey();
    }

    static void DiskMenu()
    {
        Console.Clear();
        DriveInfo[] drives = DriveInfo.GetDrives();
        for (int i = 0; i < drives.Length; i++)
        {
            var d = drives[i];
            Console.WriteLine($"{i + 1}. {d.Name} — {(d.IsReady ? d.VolumeLabel : "Недоступен")}");
        }

        Console.Write("Выберите диск (номер): ");
        if (int.TryParse(Console.ReadLine(), out int choice) &&
            choice >= 1 && choice <= drives.Length)
        {
            DriveInfo selectedDrive = drives[choice - 1];
            if (selectedDrive.IsReady)
            {
                Console.WriteLine($"\nИмя: {selectedDrive.Name}");
                Console.WriteLine($"Тип: {selectedDrive.DriveType}");
                Console.WriteLine($"ФС: {selectedDrive.DriveFormat}");
                Console.WriteLine($"Объём: {selectedDrive.TotalSize / 1024 / 1024} МБ");
                Console.WriteLine($"Свободно: {selectedDrive.AvailableFreeSpace / 1024 / 1024} МБ");
                currentPath = selectedDrive.RootDirectory.FullName;
            }
            else
                Console.WriteLine("Диск не готов.");
        }
        else
        {
            Console.WriteLine("Некорректный ввод.");
        }

        Console.WriteLine("Нажмите любую клавишу...");
        Console.ReadKey();
    }
}