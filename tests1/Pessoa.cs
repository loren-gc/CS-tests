public class Pessoa
{
    public int age;
    public string name;

    public Pessoa(string name)
    {
        this.name = name;
        this.age = 35;
    }

    public int getAge()
    {
        return this.age;
    }

}