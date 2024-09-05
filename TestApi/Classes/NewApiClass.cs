using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi
{
    public class NewApiClass
    {
        public int Id;
        public string Name;
        public string DateN;

        public NewApiClass(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
            this.DateN = DateTime.Now.ToString("F");
        }
    }

    public record ApiRecord(int Id, string Name, string? DateN);
}
