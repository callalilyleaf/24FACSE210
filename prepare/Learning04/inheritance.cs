public class Person
{
    private string _name;
    public Person(string name)
    {
        _name = name;
    }   
    public string GetName()
    {
        return _name;
    }
}
    // a child class called Student
    public class Student : Person
{
    private string _number;
    // calling the parent constructor using "base"!
    public Student(string name, string number) : base(name)
    //Student(string name, string number) is the constructor of the child class
    // :base(name) is the constructor of the parent class, which is Person(string name)
    // No need to bring the datatype of name in the child class constructor again

    {
     _number = number;
    }
    public string GetNumber()
    {   
        return _number;
    }
}