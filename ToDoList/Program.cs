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
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            IssueList issueList = new IssueList(100);

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
                        Issue[] issues = issueList.GetIssues();

                        for (int i = 0; i < issues.Length; i++)
                        {
                            Issue issue = issues[i];

                            Console.WriteLine("Название: " + issue.Title + ", Cтатус: " + issue.Status);
                        }

                        break;

                    case Operations.ADD_NEW_ISSUE:
                        Issue newIssue = new Issue();

                        issueList.Add(newIssue);
                        Console.WriteLine("Добавили задачу");
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
    }
}