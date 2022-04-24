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

    internal class Program
    {
        private static IssueList _issueList;

        private static void Main()
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
                        DeleteIssue();
                        break;

                    case Operations.EDIT_ISSUE:
                        EditIssue();
                        Console.WriteLine("Отредактировали задачу");
                        break;

                    case Operations.SET_ISSUE_AS_DONE:
                        SetDoneIssue();
                        break;

                    case Operations.EXIT:
                        IsContinue = false;
                        break;

                    default:
                        Console.WriteLine("Такой команды нет!");
                        break;
                }

                if (IsContinue)
                {
                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        private static void SetDoneIssue()
        {
            int selectedIssueNumber = GetIssueNumber();
            int selectedIssueNumberDone = selectedIssueNumber - 1;
            _issueList.SetDoneIssue(selectedIssueNumberDone);
        }

        private static void DeleteIssue()
        {
            int selectedIssueNumber = GetIssueNumber();
            _issueList.Delete(selectedIssueNumber);

        }

        private static void EditIssue()
        {
            int selectedIssueNumber = GetIssueNumber();

            Console.Write("Введите новое название задачи: ");
            string newTitle = Console.ReadLine();

            _issueList.EditTitle(selectedIssueNumber, newTitle);
        }

        private static void PrintIssues()
        {
            Issue[] issues = _issueList.GetIssues();

            for (int i = 0; i < issues.Length; i++)
            {
                Issue issue = issues[i];
                int issueNumber = (i + 1);

                Console.WriteLine(issueNumber + ") Название: " + issue.Title + ", Cтатус: " + issue.Status);
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

        private static int GetIssueNumber()
        {
            Issue[] issues = _issueList.GetIssues();

            for (int i = 0; i < issues.Length; i++)
            {
                Issue issue = issues[i];
                int issueNumber = (i + 1);

                Console.WriteLine(issueNumber + ") Название: " + issue.Title + ", Cтатус: " + issue.Status);
            }

            bool isSuccess = false;
            int selectedIssueNumber = 0;
            do
            {
                Console.Write("Введите номер задачи: ");
                string userInput = Console.ReadLine();
                isSuccess = int.TryParse(userInput, out selectedIssueNumber);

                if (selectedIssueNumber < 1 || selectedIssueNumber > issues.Length)
                {
                    isSuccess = false;
                }

            } while (!isSuccess);

            return selectedIssueNumber;
        }
    }
}