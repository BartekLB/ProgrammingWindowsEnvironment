using System;

namespace TaskSchedulerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskScheduler scheduler = new TaskScheduler();

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Dodaj zadanie jednorazowe");
                Console.WriteLine("2. Dodaj zadanie cykliczne");
                Console.WriteLine("3. Usuń zadanie");
                Console.WriteLine("4. Wyświetl wszystkie zadania");
                Console.WriteLine("5. Wyświetl szczegóły zadania");
                Console.WriteLine("6. Uruchom zadanie ręcznie");
                Console.WriteLine("7. Wyjście");
                Console.Write("Wybierz opcję: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddOneTimeTask(scheduler);
                        break;
                    case "2":
                        AddRecurringTask(scheduler);
                        break;
                    case "3":
                        RemoveTask(scheduler);
                        break;
                    case "4":
                        DisplayTasks(scheduler);
                        break;
                    case "5":
                        DisplayTaskDetails(scheduler);
                        break;
                    case "6":
                        RunTaskManually(scheduler);
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                        break;
                }
            }
        }

        static void AddOneTimeTask(TaskScheduler scheduler)
        {
            Console.WriteLine("Podaj nazwę zadania: ");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj sposób określenia czasu rozpoczęcia:");
            Console.WriteLine("1. Aktualny czas");
            Console.WriteLine("2. Określony czas (yyyy-MM-dd HH:mm)");
            Console.WriteLine("3. Za ile minut");
            string timeOption = Console.ReadLine();
            DateTime startTime;

            switch (timeOption)
            {
                case "1":
                    startTime = DateTime.Now;
                    break;
                case "2":
                    Console.WriteLine("Podaj datę i godzinę rozpoczęcia (yyyy-MM-dd HH:mm): ");
                    startTime = DateTime.Parse(Console.ReadLine());
                    break;
                case "3":
                    Console.WriteLine("Podaj ilość minut do rozpoczęcia: ");
                    int minutes = int.Parse(Console.ReadLine());
                    startTime = DateTime.Now.AddMinutes(minutes);
                    break;
                default:
                    Console.WriteLine("Nieprawidłowa opcja. Zadanie nie zostało dodane.");
                    return;
            }

            Console.WriteLine("Podaj czas trwania zadania w minutach: ");
            int durationMinutes = int.Parse(Console.ReadLine());

            scheduler.AddTask(new ScheduledTask(name, () => Console.WriteLine($"Wykonywanie zadania: {name}"), startTime, durationMinutes));
            Console.WriteLine("Zadanie dodane pomyślnie.");
        }

        static void AddRecurringTask(TaskScheduler scheduler)
        {
            Console.WriteLine("Podaj nazwę zadania: ");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj sposób określenia czasu rozpoczęcia:");
            Console.WriteLine("1. Aktualny czas");
            Console.WriteLine("2. Określony czas (yyyy-MM-dd HH:mm)");
            Console.WriteLine("3. Za ile minut");
            string timeOption = Console.ReadLine();
            DateTime startTime;

            switch (timeOption)
            {
                case "1":
                    startTime = DateTime.Now;
                    break;
                case "2":
                    Console.WriteLine("Podaj datę i godzinę rozpoczęcia (yyyy-MM-dd HH:mm): ");
                    startTime = DateTime.Parse(Console.ReadLine());
                    break;
                case "3":
                    Console.WriteLine("Podaj ilość minut do rozpoczęcia: ");
                    int minutes = int.Parse(Console.ReadLine());
                    startTime = DateTime.Now.AddMinutes(minutes);
                    break;
                default:
                    Console.WriteLine("Nieprawidłowa opcja. Zadanie nie zostało dodane.");
                    return;
            }

            Console.WriteLine("Podaj interwał minutowy: ");
            int intervalMinutes = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj czas trwania zadania w minutach: ");
            int durationMinutes = int.Parse(Console.ReadLine());

            scheduler.AddTask(new ScheduledTask(name, () => Console.WriteLine($"Wykonywanie zadania: {name}"), startTime, durationMinutes, true, intervalMinutes));
            Console.WriteLine("Zadanie cykliczne dodane pomyślnie.");
        }

        static void RemoveTask(TaskScheduler scheduler)
        {
            Console.WriteLine("Podaj nazwę zadania do usunięcia: ");
            string name = Console.ReadLine();
            if (scheduler.RemoveTask(name))
            {
                Console.WriteLine("Zadanie usunięte pomyślnie.");
            }
            else
            {
                Console.WriteLine("Zadanie o podanej nazwie nie istnieje.");
            }
        }

        static void DisplayTasks(TaskScheduler scheduler)
        {
            var tasks = scheduler.GetTasks();
            foreach (var task in tasks)
            {
                Console.WriteLine(
                    $"Zadanie: {task.Name}, Start: {task.StartTime}, Status: {task.Status}, Ostatnie uruchomienie: {task.LastRunTime}, Powtarzanie co: {task.IntervalMinutes} minut, Czas trwania: {task.DurationMinutes} minut, Liczba uruchomień: {task.RunCount}, Sukcesy: {task.SuccessCount}");
            }
        }

        static void DisplayTaskDetails(TaskScheduler scheduler)
        {
            Console.WriteLine("Podaj nazwę zadania: ");
            string name = Console.ReadLine();
            var task = scheduler.GetTask(name);
            if (task != null)
            {
                var info = task.GetInfo();
                Console.WriteLine($"Nazwa zadania: {info.Name}");
                Console.WriteLine($"Data i godzina rozpoczęcia: {info.StartTime}");
                Console.WriteLine($"Ostatnie uruchomienie: {info.LastRunTime}");
                Console.WriteLine($"Status: {info.Status}");
                if (info.IntervalMinutes.HasValue)
                {
                    Console.WriteLine($"Interwał minutowy: {info.IntervalMinutes}");
                }

                Console.WriteLine($"Czas trwania: {info.DurationMinutes} minut");
                Console.WriteLine($"Liczba uruchomień: {info.RunCount}");
                Console.WriteLine($"Liczba sukcesów: {info.SuccessCount}");
            }
            else
            {
                Console.WriteLine("Zadanie o podanej nazwie nie istnieje.");
            }
        }

        static void RunTaskManually(TaskScheduler scheduler)
        {
            Console.WriteLine("Podaj nazwę zadania do uruchomienia: ");
            string name = Console.ReadLine();
            var task = scheduler.GetTask(name);
            if (task != null)
            {
                task.RunAsync().ConfigureAwait(false);
                Console.WriteLine("Zadanie uruchomione ręcznie.");
            }
            else
            {
                Console.WriteLine("Zadanie o podanej nazwie nie istnieje.");
            }
        }
    }
}
