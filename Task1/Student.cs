public class Student : Person
{
    public Student(string name) 
    : base(name){}
    public string Study()
    {
        return $"The {Name} is studying";
    }
}