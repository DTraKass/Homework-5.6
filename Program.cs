using System;

class Program
{
	public static void Main(string[] args)
	{
		EnterUser();
	}
	static void EnterUser()
	{
		(string Name, string LastName, bool HasPet, string[] PetNames, string[] FavColors, int Age) User;

		User.HasPet = false;

		Console.WriteLine("Введите имя пользователя");
		User.Name = Console.ReadLine();

		Console.WriteLine("Введите фамилию пользователя");
		User.LastName = Console.ReadLine();

		string age;
		int intAge;

		do
		{
			Console.WriteLine("Введите возраст цифрами");
			age = Console.ReadLine();

		} while (CheckNum(age, out intAge));

		User.Age = intAge;

		Console.WriteLine("Сколько у вас питомцев?");
		int numPet = int.Parse(Console.ReadLine());
		User.PetNames = new string[numPet];

		if (numPet > 1)
		{
			User.HasPet = true;
			Console.WriteLine("Здорово, назовете все клички питомцев?");

			for (int i = 0; i < User.PetNames.Length; i++)
			{
				Console.WriteLine("Введите кличку питомца {0}", i + 1);
				User.PetNames[i] = Console.ReadLine();
			}
		}
		else if (numPet == 1)
		{
			User.HasPet = true;
			Console.WriteLine("Здорово, назовете кличку питомца?");
			User.PetNames[0] = Console.ReadLine();
		}
		else
			Console.WriteLine("Очень жаль, вам стоит завести себе питомца)");

		Console.WriteLine("Введите количество ваших любимых цветов");
		User.FavColors = new string[int.Parse(Console.ReadLine())];

		for (int i = 0; i < User.FavColors.Length; i++)
		{
			Console.WriteLine("Введите название любимого цвета {0}", i + 1);
			User.FavColors[i] = Console.ReadLine();
		}

		UserData(User.Name, User.LastName, User.HasPet, User.PetNames, User.FavColors, User.Age);
	}

	static bool CheckNum(string number, out int corrNumber)
	{
		if (int.TryParse(number, out int intNum))
		{
			if (intNum > 0)
			{
				corrNumber = intNum;
				return false;
			}
		}
		{
			corrNumber = 0;
			return true;
		}
	}

	static void UserData(string Name, string LastName, bool HasPet, string[] PetNames, string[] FavColors, int Age)
	{
		Console.WriteLine($"Ваше имя: {Name}");
		Console.WriteLine($"Ваша фамилия: {LastName}");
		Console.WriteLine($"Ваш возраст: {Age}");

		if (HasPet)
		{
			Console.WriteLine("Какие милые у вас питомцы:");
			for (int i = 0; i < PetNames.Length; i++)
			{
				Console.WriteLine($"Питомец {i + 1}:\t {PetNames[i]}");
			}
		}

		Console.WriteLine("Хмм, наши любимые цвета совпадают:");
		for (int i = 0; i < FavColors.Length; i++)
		{
			Console.WriteLine($"Цвет {i + 1}:\t {FavColors[i]}");
		}

	}
}