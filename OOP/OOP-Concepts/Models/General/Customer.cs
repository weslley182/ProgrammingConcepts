namespace OOP_Concepts.Models.General;

public class Customer
{
    public string Name { get; }
    public virtual string Email { get; set; }

    public Customer(string name)
    {
        Name = name;
    }
    public Customer()
    {

    }
}
