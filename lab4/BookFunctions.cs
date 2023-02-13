using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class BookFunctions {
        public static string GetTitle(Book B) {
            return B.Title;
        }
        public static string GetAuthors(Book B) {
            string res = "Book Authors: ";
            foreach (var item in B.Authors) { res += item.ToString() + ", "; }
            return res;
        }
        public static string GetPrice(Book B) {
            return B.Price.ToString();
        }
    }
}
