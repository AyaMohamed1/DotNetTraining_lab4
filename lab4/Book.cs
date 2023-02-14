using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Book {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price) {
            ISBN= _ISBN;
            Title= _Title;
            Authors= _Authors;
            PublicationDate= _PublicationDate;
            Price= _Price;
        }
        public override string ToString() {
            StringBuilder res = new($"Book ISBN: {ISBN}\nBook Title: {Title}\nBook Authors: ");
            foreach(var item in Authors) {
                res.Append(item.ToString() + ", ");
            }
            res.Append($"\nBook Publication Date: {PublicationDate}\nBook price: {Price}\n") ;
            return res.ToString() ;
        }
    }
}
