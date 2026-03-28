public class Person
{
    public int age;
    public string name;

    public Person(string name)
    {
        this.name = name;
        this.age = 35;
    }

    public int getAge()
    {
        return this.age;
    }

    public void putAge(int age)
    {
        this.age = age;
        return;
    }

}