using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class IssueList
    {
        private Issue[] _issues;

        public IssueList(int max)
        {
            _issues = new Issue[max];

            _issues[0] = new Issue()
            {
                Title = "Test1",
            };

            _issues[1] = new Issue()
            {
                Title = "Test2"
            };

            _issues[2] = new Issue()
            {
                Title = "Test3"
            };
        }
    }
}
