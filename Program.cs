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

		Console.WriteLine("������� ��� ������������");
		User.Name = Console.ReadLine();

		Console.WriteLine("������� ������� ������������");
		User.LastName = Console.ReadLine();

		string age;
		int intAge;

		do
		{
			Console.WriteLine("������� ������� �������");
			age = Console.ReadLine();

		} while (CheckNum(age, out intAge));

		User.Age = intAge;

		Console.WriteLine("������� � ��� ��������?");
		int numPet = int.Parse(Console.ReadLine());
		User.PetNames = new string[numPet];

		if (numPet > 1)
		{
			User.HasPet = true;
			Console.WriteLine("�������, �������� ��� ������ ��������?");

			for (int i = 0; i < User.PetNames.Length; i++)
			{
				Console.WriteLine("������� ������ ������� {0}", i + 1);
				User.PetNames[i] = Console.ReadLine();
			}
		}
		else if (numPet == 1)
		{
			User.HasPet = true;
			Console.WriteLine("�������, �������� ������ �������?");
			User.PetNames[0] = Console.ReadLine();
		}
		else
			Console.WriteLine("����� ����, ��� ����� ������� ���� �������)");

		Console.WriteLine("������� ���������� ����� ������� ������");
		User.FavColors = new string[int.Parse(Console.ReadLine())];

		for (int i = 0; i < User.FavColors.Length; i++)
		{
			Console.WriteLine("������� �������� �������� ����� {0}", i + 1);
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
		Console.WriteLine($"���� ���: {Name}");
		Console.WriteLine($"���� �������: {LastName}");
		Console.WriteLine($"��� �������: {Age}");

		if (HasPet)
		{
			Console.WriteLine("����� ����� � ��� �������:");
			for (int i = 0; i < PetNames.Length; i++)
			{
				Console.WriteLine($"������� {i + 1}:\t {PetNames[i]}");
			}
		}

		Console.WriteLine("���, ���� ������� ����� ���������:");
		for (int i = 0; i < FavColors.Length; i++)
		{
			Console.WriteLine($"���� {i + 1}:\t {FavColors[i]}");
		}

	}
}