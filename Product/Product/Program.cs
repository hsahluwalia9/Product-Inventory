using System;

namespace ProductInventory
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			
			Food Orange = new Food();
			Orange.ID = 1;
			Orange.Name = "Orange";
			Orange.Price = 0.5;
			Orange.FoodType = Food.FoodTypes.Fruit;

			Orange.GetFoodDescription();
			Console.WriteLine(" ");

			Clothes TShirt = new Clothes();
			TShirt.ID = 5;
			TShirt.Name = "Nike T-Shirt";
			TShirt.Price = 20;
			TShirt.ClothesType = Clothes.ClothesTypes.Shirt;

			TShirt.GetClothesDescription();

		}
	}

	class Product
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
	}

	class Food : Product
	{
		public enum FoodTypes { Fruit, Vegetable, Meat, Other };
		public FoodTypes FoodType;

		public Food()
		{
			ID = 0;
			Name = null;
			Price = 0;
		}

		public Food(int _ID, string _Name, double _Price, FoodTypes _FoodType)
		{
			ID = _ID;
			Name = _Name;
			Price = _Price;
			FoodType = _FoodType;
		}

		public void GetFoodDescription()
		{
			Console.WriteLine("ID: " + ID);
			Console.WriteLine("Name: " + Name);
			Console.WriteLine("Price: " + Price);
			Console.WriteLine("Type: " + FoodType);
		}
	}

	class Clothes : Product
	{
		public enum ClothesTypes { Shirt, Pant, Jacket, Sweater, Other };
		public ClothesTypes ClothesType;

		public Clothes() { 
			ID = 0;
			Name = null;
			Price = 0;
		}

		public Clothes(int _ID, string _Name, double _Price, ClothesTypes _ClothesType) { 
			ID = _ID;
			Name = _Name;
			Price = _Price;
			ClothesType = _ClothesType;
		}

		public void GetClothesDescription()
		{
			Console.WriteLine("ID: " + ID);
			Console.WriteLine("Name: " + Name);
			Console.WriteLine("Price: " + Price);
			Console.WriteLine("Type: " + ClothesType);
		}
	}
}
