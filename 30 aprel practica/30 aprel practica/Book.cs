using System;
using System.Collections.Generic;
using System.Text;

namespace _30_aprel_practica
{
    class Book
    {
        public static int Counter =10;
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string  Code { get; set; }
       
        public Book(string name,string authorname, int pagecount)
        {
            Counter++;
            Name =name;
            AuthorName = authorname;
            PageCount = pagecount;
            Code = Name.Substring(0, 2).ToUpper() + Counter;
        }
    }
}
