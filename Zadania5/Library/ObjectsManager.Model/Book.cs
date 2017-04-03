using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsManager.Model
{
    public class Book
    {
        private int id;
        private string bookTitle;
        private string iSBN;

        public int Id { get => id; set => id = value; }
        public string BookTitle { get => bookTitle; set => bookTitle = value; }
        public string ISBN { get => iSBN; set => iSBN = value; }
    }
}
