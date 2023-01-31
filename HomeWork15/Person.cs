using System;
namespace HomeWork15
{
	public class Person
	{
		const int maxNumberOfPets = 5;
		private string name;
		private int age;

		private Pet[] pets;

		public string Name { get => name; }
		public int Age { get => age; }
		//модификаторы доступа можно задать для set или get отдельно
        public int NumberOfPets { get => numberOfPets; private set => numberOfPets = value; }

        public Pet[] Pets { get => pets; set => pets = value; } //?

        private int numberOfPets;

		public Person(string name, int age)
		{
			this.name = name;
			this.age = age;
			Pets = new Pet[maxNumberOfPets];
		}

		public void AddPet(Pet pet)
		{
			if (NumberOfPets < maxNumberOfPets)
			{
                Pets[NumberOfPets] = pet;
				NumberOfPets++;
            }
		}

		public void RemovePet(string name)
		{
			Pet[] NewPets = new Pet[maxNumberOfPets];
			int index = 0;
			for (int i = 0; i < maxNumberOfPets ; i++)
			{
                if (Pets[i].Name.ToLower().Contains(name.ToLower()))
				{
                    NumberOfPets--;
                    continue;
				}
				NewPets[index] = Pets[i];
				index++;
            }
			Pets = NewPets;
			
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

