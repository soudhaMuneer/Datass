namespace ToDoAppBlazorServer.Data
{
    public class ToDoItem
    {
        public ToDoItem(string text)
        {
            Text = text; 
        }

        public string Text { get; set; }
        public bool compleated {  get; set; }
    }
}
