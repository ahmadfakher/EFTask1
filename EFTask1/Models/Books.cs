using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask1.Models
{
    internal class Books
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int ISBN { get; set; }
        public int price { get; set; }
        public int Pages { get; set; }
        public int PublishYear { get; set; }
        public bool InStock { get; set; }
    }
}
