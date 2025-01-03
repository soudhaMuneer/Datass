﻿namespace BlazorServerAppDemo
{
	public class Item
	{
		private Guid guid;
		private string v1;
		private string v2;

		public Item(Guid guid, string v1, string v2)
		{
			this.guid = guid;
			this.v1 = v1;
			this.v2 = v2;
		}
        public Item()
        {
            
        }
        public Guid Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}
}
