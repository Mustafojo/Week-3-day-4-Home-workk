public class Teacher : Person
{
    public Teacher(string name) 
    : base(name){}
    public string Explain()
    {
        return $"The {Name} is expleining";
    }
}