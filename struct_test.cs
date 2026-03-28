
// STRUCT TEST
Student teste = new Student("Ralph");
int variable = teste.GetGrade();
Console.WriteLine($"test1 = {variable}");
unsafe
{
    int* p1 = &variable;
    *p1 = 20;
    //Console.WriteLine($"teste2 = {*p1}");
}
Console.WriteLine($"test2 = {variable}");

// CLASS TEST
Pessoa lorenzo = new Pessoa("lorenzo");
Console.WriteLine($"previous age = {lorenzo.age}");
unsafe
{
    fixed(int* pointerPessoa = &lorenzo.age)
    *pointerPessoa = 24;
}
Console.WriteLine($"loren's age = {lorenzo.getAge()}");

// EXTERN CLASS TEST
Person amanda = new Person("Amanda");
Console.WriteLine($"previous age = {amanda.getAge()}");
amanda.putAge(22);
Console.WriteLine($"amanda age = {amanda.getAge()}");

//=============================================== STRUCT AND CLASS =======================================================
struct Student
{
    public int grade;
    public string name;

    public Student(string name){
        this.name = name;
        this.grade = 10;
    }

    public int GetGrade(){
        return this.grade;
    }
    
}