namespace BudgetBook.Data
{
    public class BudgetBookServices
    {
        private static List<Entry> mockDb = new List<Entry>()
        {
            new Entry(){Description="Test",Amount=4.99m}
        
        };

        public async Task<bool> AddEntry(Entry newEntry)
        {
            mockDb.Add(newEntry);
            return true;
        }
        public async Task<List<Entry>> GetAllEntries()
        {
            return mockDb;
        }

    }
}
