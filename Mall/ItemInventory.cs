using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mall
{
	public class ItemInventory<T>
	{
		private List<T> Items;
		public void AddItem(T item)
		{
			if (Items == null)
			{
				Items = new List<T>();
			}
			Items.Add(item);
		}

		public IEnumerable<T> GetItem()
		{
			return Items;
		}

	}
}
