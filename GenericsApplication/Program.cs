using Mall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericsApplication
{
	public class Program
	{
		private static ItemInventory<Bicycle> bicycleInventory;
		private static ItemInventory<Shirt> shirtInventory;
		private static ItemInventory<Rifle> rifleInventory;

        static Program()
        {
            bicycleInventory = new ItemInventory<Bicycle>();
			shirtInventory = new ItemInventory<Shirt>();
			rifleInventory = new ItemInventory<Rifle>();
        }
        static void Main(string[] args)
		{
			AddBicyclesToMall();
			AddShirtsToMall();
			AddRiflesToMall();
			DisplayInventories();

			Console.Read();

		}

		private static void DisplayInventories()
		{

			foreach (Bicycle bicycle in bicycleInventory.GetItem())
			{
				Console.WriteLine($"Item: {bicycle.GetType().Name} Brand: {bicycle.Brand}, Gear Count: {bicycle.GearCount}");
			}

			foreach (Shirt shirt in shirtInventory.GetItem())
			{
				Console.WriteLine($"Item: {shirt.GetType().Name} Brand: {shirt.Brand}, Style: {shirt.Style}");
			}

			foreach (Rifle rifle in rifleInventory.GetItem())
			{
				Console.WriteLine($"Item: {rifle.GetType().Name} Caliber: {rifle.Caliber}, Cartridge Capacity: {rifle.CartridgeCapacity}");
			}
		}

		private static void AddShirtsToMall()
		{
			Shirt shirt = new Shirt();
			shirt.Brand = "Lacoste";
			shirt.Style = "Fisherman";

			Shirt shirt1 = new Shirt();
			shirt1.Brand = "Tommy";
			shirt1.Style = "Slimfit";

			Shirt shirt2 = new Shirt();
			shirt2.Brand = "Mavi";
			shirt2.Style = "Summer";

			shirtInventory.AddItem(shirt);
			shirtInventory.AddItem(shirt1);
			shirtInventory.AddItem(shirt2);

		}

		private static void AddRiflesToMall()
		{
			Rifle rifle = new Rifle();
			rifle.Caliber = 5.56m;
			rifle.CartridgeCapacity = 24;
			
			rifleInventory.AddItem(rifle);
		}

		private static void AddBicyclesToMall()
		{
			Bicycle bicycle = new Bicycle();
			bicycle.Brand = "Szuki";
			bicycle.GearCount = 24;

			Bicycle bicycle1 = new Bicycle();
			bicycle1.Brand = "Ferrari";
			bicycle1.GearCount = 21;

			bicycleInventory.AddItem(bicycle);
			bicycleInventory.AddItem(bicycle1);


        }
	}
}
