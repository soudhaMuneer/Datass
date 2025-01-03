using ToDoAppBlazorServer.Data;

namespace ToDoAppBlazorServer.Services
{
    public class TodoService : ITodoService
    {
        private readonly IList<ToDoItem> _items;
        public TodoService()
        {
                _items = new List<ToDoItem> { new ToDoItem("Washing Cloths"),new ToDoItem("cleaning cloths")};
        }
        public void Add(ToDoItem item)
        {
            _items.Add(item);

        }

        public IEnumerable<ToDoItem> GetAll()
        {
        return _items.ToList();
        }
    }
}
