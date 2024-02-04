using System;

class Program
{
	public static void Main(string[] args)
	{
		EnterUser();
	}
	static void EnterUser()
    {
		(string Name, string LastName, bool HasPet, string[] PetNames, string[] favcolors, double Age) User;

		Console.WriteLine("¬ведите им€ пользовател€")
		User.Name = Console.ReadLine();

		Console.WriteLine("¬ведите фамилию пользовател€")
		User.LastName = Console.ReadLine();

		string age;
		int intAge;

        do
        {
			Console.WriteLine("¬ведите возраст цифрами")
			age = Console.ReadLine();

        } while(CheckNum(age, out intAge))

		User.Age = intAge;
	}
	static bool CheckNum(string number, out int corrNumber)
    {
		if(int.TryParse(number out int intNum){
			if(intNum > 0)
            {
				corrNumber = intNum;
				return false;
            }else {
				corrNumber = 0;
				return true;
			}
        }
    }
}