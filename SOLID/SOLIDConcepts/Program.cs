using SOLIDConcepts.Enum;
using SOLIDConcepts.LSP;
using SOLIDConcepts.OCP;
using SOLIDConcepts.SRP;


Console.WriteLine("Choose SOLID Principle: (0) SRP, (1) OCP, (2) LSP, (3) ISP, (4) DIP");
if (!Enum.TryParse<SolidPrinciple>(Console.ReadLine(), out var selectedPrinciple))
{
    Console.WriteLine("Invalid selection.");
    return;
}

switch (selectedPrinciple)
{
    //A class should have one and only one reason to change, meaning that a class should have only one job.
    case SolidPrinciple.SRP:
        Console.WriteLine("=== Single Responsability Principle ===");
        new SRPSample().Execute();
        break;

    //Objects or entities should be open for extension but closed for modification.
    case SolidPrinciple.OCP:
        Console.WriteLine("=== Open/Closed Principle ===");
        new OCPSample().Execute();
        break;

    //Let q(x) be a property provable about objects of x of type T.Then q(y) should be provable for objects y of type S where S is a subtype of T.
    //This means that every subclass or derived class should be substitutable for their base or parent class.
    case SolidPrinciple.LSP:
        Console.WriteLine("=== Liskov Substitution Principle ===");
        new LSPSample().Execute();

        break;

    //A client should never be forced to implement an interface that it doesn’t use, or clients shouldn’t be forced to depend on methods they do not use
    case SolidPrinciple.ISP:
        Console.WriteLine("=== Interface Segregation Principle ===");

        break;
    //Entities must depend on abstractions, not on concretions.
    //It states that the high-level module must not depend on the low-level module, but they should depend on abstractions.
    case SolidPrinciple.DIP:
        Console.WriteLine("=== Dependency Inversion Principle ===");

        break;

    default:
        Console.WriteLine("Principle not implemented.");
        break;
}