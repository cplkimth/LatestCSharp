namespace Client;

public record Person(int Age, string Name)
{
    public Person(int age) : this(age, "")
    {
    }

    public void Deconstruct(out int age, out string name)
    {
        age = Age;
        name = Name;
    }
};