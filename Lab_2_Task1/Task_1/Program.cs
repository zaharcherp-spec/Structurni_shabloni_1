class Program
{
    static void Main()
    {
        var manager = new UniversityManager();

        while (true)
        {
            Console.WriteLine("1. Додати факультет");
            Console.WriteLine("2. Додати курс до факультету");
            Console.WriteLine("3. Додати потік до курсу");
            Console.WriteLine("4. Додати групу до потоку");
            Console.WriteLine("5. Додати студента до групи");
            Console.WriteLine("6. Додати оцінку студенту");
            Console.WriteLine("7. Вивести всю структуру та середні бали");
            Console.WriteLine("0. Вийти");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Назва факультету:");
                    manager.AddFaculty(Console.ReadLine());
                    break;
                case "2":
                    Console.WriteLine("Назва існуючого факультету:");
                    string fName = Console.ReadLine();
                    Console.WriteLine("Назва нового курсу:");
                    manager.AddCourse(fName, Console.ReadLine());
                    break;
                case "3":
                    Console.WriteLine("Назва існуючого курсу:");
                    string cName = Console.ReadLine();
                    Console.WriteLine("Назва нового потоку:");
                    manager.AddStream(cName, Console.ReadLine());
                    break;
                case "4":
                    Console.WriteLine("Назва існуючого потоку:");
                    string sName = Console.ReadLine();
                    Console.WriteLine("Назва нової групи:");
                    manager.AddGroup(sName, Console.ReadLine());
                    break;
                case "5":
                    Console.WriteLine("Назва існуючої групи:");
                    string gName = Console.ReadLine();
                    Console.WriteLine("Ім'я студента:");
                    manager.AddStudent(gName, Console.ReadLine());
                    break;
                case "6":
                    Console.WriteLine("Ім'я студента:");
                    string stName = Console.ReadLine();
                    Console.WriteLine("Оцінка:");
                    if (int.TryParse(Console.ReadLine(), out int grade))
                    {
                        manager.AddGradeToStudent(stName, grade);
                    }
                    break;
                case "7":
                    Console.WriteLine();
                    manager.DisplayUniversity();
                    Console.WriteLine();
                    break;
                case "0":
                    return;
            }
        }
    }
}

