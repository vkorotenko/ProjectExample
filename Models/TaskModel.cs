using ProjectExample.Interfaces;
using System.Collections.Generic;

namespace ProjectExample.Models
{
    public class TaskModel : IShellItem
    {
        public TaskModel(string path)
        {
            Path = path;
            Children = new List<TaskModel>();
        }
        public string Path { get; private set; }
        public List<TaskModel> Children { get; set; }
    }
}
