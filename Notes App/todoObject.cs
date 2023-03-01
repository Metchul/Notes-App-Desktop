using Notes_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace Notes_App
{
    public class TodoItem
    {
        public string TaskName { get; set; }
        public Guid TodoId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool CompletedState { get; set; }
        public DateTime CompletedDate { get; set; }

        public TodoItem(string taskName)
        {
            TaskName = taskName;
            CreatedDate = DateTime.Now;
            CompletedState = false;
            TodoId = Guid.NewGuid();
        }
    }

    
}

