namespace BlazorServerAppDemo
{
	public class ItemService
	{
		private List<Item> items= new List<Item> { new Item(new Guid(),"fttg","sdfsfseg") };
		public List<Item> GetItems()
		{
			return items;
		}
		public void AddItem(Item item)
		{
			item.Id = Guid.NewGuid();
			items.Add(item);
		}
		public void UpdateItem(Item item)
		{
			var existingItem = items.FirstOrDefault(i => i.Id == item.Id);
			if (existingItem != null)
			{
				existingItem.Name = item.Name;
				existingItem.Description = item.Description;
			}
		}
		public void DeleteItem(Guid id)
		{
			var item = items.FirstOrDefault(i => i.Id == id);
			if (item != null)
			{
				items.Remove(item);
			}
		}

	}
}
