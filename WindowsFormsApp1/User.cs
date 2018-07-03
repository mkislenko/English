using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English
{
    public class User
    {
        private string _name;
        
        public string Name
        {
            get { return _name; }
        }

        private List<string> results;

        public User(string name)
        {
            _name = name;
            results = new List<string>();
        }

        public void AddResult(string s)
        {
            results.Add(s);
            results.Sort();
        }

        public List<string> GetResults()
        {
            return results;
        }
    }
}
