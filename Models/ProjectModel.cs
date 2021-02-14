using System.Collections.Generic;
using ProjectExample.Interfaces;

namespace ProjectExample.Models
{
    public class ProjectModel : IShellItem
    {
        public string Path { get; private set; }
        public string Name { get; set; }
        public ProjectModel(string path, string name)
        {
            Path = path;
            Name = name;
            Children = new List<TaskModel>();
        }
        public List<TaskModel> Children { get; set; }
    }
}
