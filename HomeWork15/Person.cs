using System;
namespace HomeWork15
{
	public class Person
	{
		private string name;
		private int age;

		private Pet[] pets;

		public string Name { get => name; }
		public int Age { get => age; }
        public int NumberOfPets { get => numberOfPets; set => numberOfPets = value; }

        public Pet[] Pets { get => pets; set => pets = value; } //?

        private int numberOfPets;

		public Person(string name, int age)
		{
			this.name = name;
			this.age = age;
			Pets = new Pet[5];
		}

		public void AddPet(Pet pet)
		{
			if (NumberOfPets < 5)
			{
                Pets[NumberOfPets] = pet;
				NumberOfPets++;
            }
		}

		public void RemovePet(string name)
		{
			Pet[] NewPets = new Pet[NumberOfPets - 1];
			int index = 0;
			for (int i = 0; i < NumberOfPets ; i++)
			{
                if (Pets[i].Name.ToLower().Contains(name.ToLower()))
				{
					continue;
				}
				else
				{
					NewPets[index] = Pets[i];
					index++;
				}
            }
			Pets = NewPets;
			NumberOfPets--;
		}

		public Pet[] GetAllPets()
		{
			Pet[] result = new Pet[NumberOfPets];
			for (int i = 0; i < NumberOfPets ; i++)
			{
				result[i] = Pets[i]; 
			}
			return result;
		}
	}
}

