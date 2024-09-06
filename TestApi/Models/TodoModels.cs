using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TestApi.Models
{
    public class TodoModels
    {
        public int Id;
        public string Title;
        public DateOnly StartedOn;
        public bool IsCompleted;

        public TodoModels(int Id, string Title, DateOnly StartedOn, bool IsCompleted)
        {
            this.Id = Id;
            this.Title = Title;
            this.StartedOn = StartedOn;
            this.IsCompleted = IsCompleted;
        }
    }

}
