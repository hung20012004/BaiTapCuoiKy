using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Search
    {
        private static Search instance=new Search();
        public static Search Instance { 
            get { return instance; } 
        }
        public bool ContainsString(string source, string target)
        {
            source=NormalizeString(source);
            target=NormalizeString(target);
            return source.Contains(target);
        }
        public string NormalizeString(string input)
        {
            string trimmedString = "";
            if (input != null)
            {
                 trimmedString = input.Trim();
            }
            string normalizedString = string.Join(" ", trimmedString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            return normalizedString.ToLower();
        }
    }
}
