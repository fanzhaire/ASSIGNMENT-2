using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book
    {
        public int BookId { get; set; } 
        public string Title { get; set; } 
        public string Author { get; set; } 
        public string ISBN { get; set; }  
        public bool IsAvailable { get; set; } = true; 
    }
}
