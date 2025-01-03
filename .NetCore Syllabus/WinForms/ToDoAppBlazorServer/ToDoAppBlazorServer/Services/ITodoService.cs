using ToDoAppBlazorServer.Data;

namespace ToDoAppBlazorServer.Services
{
    public interface ITodoService
    {
        public void Add(ToDoItem item);
        public IEnumerable<ToDoItem> GetAll();

    }
}
