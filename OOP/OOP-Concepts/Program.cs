using OOP_Concepts.Abstraction;
using OOP_Concepts.Encapsulation;
using OOP_Concepts.Enum;
using OOP_Concepts.Inheritance;
using OOP_Concepts.Polymorphism;


Console.WriteLine("Choose OOP Pillar: (0) Encapsulation, (1) Abstraction, (2) Inheritance, (3) Polymorphism");
if (!Enum.TryParse<OopPillar>(Console.ReadLine(), out var selectedPillar))
{
    Console.WriteLine("Invalid selection.");
    return;
}

switch (selectedPillar)
{
    //Encapsulation concept is demonstrated by creating a class that encapsulates the data and behavior related to an order,
    //allowing for better organization and management of the code.
    case OopPillar.Encapsulation:
        Console.WriteLine("=== Procedural Example ===");
        new ProceduralSample().Execute();
        Console.WriteLine();

        Console.WriteLine("=== Encapsulated Example ===");
        new EncapsulatedSample().Execute();
        break;

    //Abstraction
    case OopPillar.Abstraction:
        Console.WriteLine("=== Abstraction Example ===");
        new AbstractionSample().Execute();
        break;

    case OopPillar.Inheritance:
        Console.WriteLine("=== Inheritance Example ===");
        new InheritanceSample().Execute();
        break;

    case OopPillar.Polymorphism:
        Console.WriteLine("=== Polymorphism Example ===");
        new PolymorphismSample().Execute();
        break;

    default:
        Console.WriteLine("Pillar not implemented.");
        break;
}

