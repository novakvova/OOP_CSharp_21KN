using System.Net.Http.Headers;

namespace IncludeClass;

class Prytulok
{
    //Набір тварин у притулку
    private Animal[] animals;

    /// <summary>
    /// Додаємо у притулок нову тварину
    /// </summary>
    /// <param name="animal">Новий пасажир</param>
    public void AddAnimal(Animal animal)
    {
        // || - або хибне значення лише тоді коли двоє разом хибні 
        if (animals == null || animals.Length == 0) 
        {
            animals = new Animal[1];
            animals[0] = animal;
        }
        else
        {
            var tempAnimals = new Animal[this.animals.Length+1];
            int i;
            for (i = 0; i < this.animals.Length; i++)
            {
                tempAnimals[i] = this.animals[i];
            }
            tempAnimals[i] = animal;
            this.animals = tempAnimals;
        }

    }

    public void ShowAnimals()
    {
        foreach (var animal in this.animals)
        {
            Console.WriteLine(animal);
        }
    }
}
