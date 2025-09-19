using Bogus;
using static Bogus.DataSets.Name;

namespace ExampleStatic;

//Це означає,що усі методи і поля цього класу є статичними
public static class ManService
{
    public static Man[] GetRandomMan(int count)
    {
        Man[] list = new Man[count];
        Faker faker = new Faker("uk");
        for (int i = 0; i < count; i++)
        {
            Gender gender = faker.PickRandom<Gender>();
            string lastName = faker.Name.LastName(gender); //Прізвище 
            string firstName = faker.Name.FirstName(gender); //Ім'я
            int age = faker.Random.Int(18, 60); //Вік від 18 до 60 років
            list[i] = new Man(firstName, lastName, age);
        }
        return list;
    }
}
