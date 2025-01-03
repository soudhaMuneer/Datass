namespace FirstBlazorPage.Data
{
    public class BudgetBookService
    {
        private static List<Entry> BookList = new List<Entry>();

        public async Task<bool> AddEntry(Entry newentry)
        {
            BookList.Add(newentry);
            return true;
        }

        public async Task<List<Entry>> GetAllEntries()
        {
            return BookList;
        }
    }
}
