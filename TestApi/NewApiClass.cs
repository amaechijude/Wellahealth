using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi
{
    public class NewApiClass
    {
        public int Id { get; set; }
        public string? NameN { get; set; }
        public string DateN = DateTime.Now.ToString("F");
    }
}