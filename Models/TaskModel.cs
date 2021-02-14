using ProjectExample.Interfaces;

namespace ProjectExample.Models
{
    public class TaskModel : IShellItem
    {
        public TaskModel(string path)
        {
            Path = path;
        }

        public string Path { get; private set; }
    }
}
