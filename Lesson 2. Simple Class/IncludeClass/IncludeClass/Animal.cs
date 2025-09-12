namespace IncludeClass;

class Animal
{
    private string name;
    private int age;
    private string poroda;

    public void SetName(string name) {  this.name = name; }
    public string GetName() { return this.name; }
    public void SetAge(int age) { this.age = age; }
    public int GetAge() { return this.age; }
    public void SetPoroda(string poroda) { this.poroda = poroda; }
    public string GetPoroda() {  return this.poroda; }
    //override - перевизначаємо метод ToString() - відносно Object 
    public override string ToString()
    {
        string result = $"{name}\t{age}\t{poroda}";
        return result;
    }
}
