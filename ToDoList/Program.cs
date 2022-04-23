using System.Text;

namespace ToDoList
{
    /*
    Список задач
    + Добавить задачу
    + Удалить задачу
    + Пометить задачу как выполненая
    + Редактировать задачу

    Задача
    + Название
    + Дата
    + Статус

    Статусы
    + Новая
    + Выполненая
    */

    class Program
    {
        private static IssueList _issueList;

        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            _issueList = new IssueList(100);

            bool IsContinue = true;

            while (IsContinue)
            {

                Console.WriteLine("1 - Вывести список задач");
                Console.WriteLine("2 - Добавить задачу");
                Console.WriteLine("3 - Удалить задачу");
                Console.WriteLine("4 - Редактировать задачу");
                Console.WriteLine("5 - Отметить задачу как выполненую");
                Console.WriteLine("X - выход");

                string operation = Console.ReadLine();

                switch (operation.ToLower())
                {
                    case Operations.SHOW_ISSUES_LIST:
                        PrintIssues();
                        break;

                    case Operations.ADD_NEW_ISSUE:
                        CreateNewIssue();
                        break;

                    case Operations.REMOVE_ISSUE:
                        Console.WriteLine("Удалили задачу");
                        break;

                    case Operations.EDIT_ISSUE:
                        Console.WriteLine("Отредактировали задачу");
                        break;

                    case Operations.SET_ISSUE_AS_DONE:
                        Console.WriteLine("Выполнение задачи");
                        break;

                    case Operations.EXIT:
                        IsContinue = false;
                        break;

                    default:
                        Console.WriteLine("Такой команды нет!");
                        break;
                }
            }
        }

        private static void PrintIssues()
        {
            Issue[] issues = _issueList.GetIssues();

            for (int i = 0; i < issues.Length; i++)
            {
                Issue issue = issues[i];

                Console.WriteLine("Название: " + issue.Title + ", Cтатус: " + issue.Status);
            }
        }

        private static void CreateNewIssue()
        {
            Console.Write("Наберите название задачи: ");
            string title = Console.ReadLine();

            Issue newIssue = new Issue { Title = title };

            _issueList.Add(newIssue);
            Console.WriteLine("Добавили новую задачу");
        }
    }
}