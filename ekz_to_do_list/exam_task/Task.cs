using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_task
{
   [Serializable]
    public class Task
    {
        public string Short_describe { get; set; }
        public string Priority { get; set; }
        public string Attached_file { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Comment { get; set; }
        public string Tag { get; set; }
        public Task() { }
        public Task(string short_describe,string priority,string tag,string date,string time,string comment,string attached_file)
        {
            this.Short_describe = short_describe;
			this.Priority = priority;
            this.Tag = tag;
            this.Date = date;
            this.Time = time;
            this.Comment = comment;
            this.Attached_file = attached_file;
        }
        public override string ToString()
        {
            return $"{Short_describe},{Priority},{Date},{Time},{Tag},{Comment} ";
        }
    }
}
