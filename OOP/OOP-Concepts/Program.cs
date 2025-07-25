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

    // Abstraction concept is demonstrated by defining a common interface for payment methods,
    // allowing the system to interact with different implementations through a consistent contract.
    case OopPillar.Abstraction:
        Console.WriteLine("=== Abstraction Example ===");
        new AbstractionSample().Execute();
        break;

    // Inheritance concept is demonstrated by creating a base Product class and deriving Beverage and Snack from it,
    // allowing code reuse and enabling specialized behavior through method overriding.
    case OopPillar.Inheritance:
        Console.WriteLine("=== Inheritance Example ===");
        new InheritanceSample().Execute();
        break;

    // Polymorphism concept is demonstrated by applying different promotion strategies through a shared Promotion base class,
    // enabling dynamic behavior without changing the code that applies the promotion.
    case OopPillar.Polymorphism:
        Console.WriteLine("=== Polymorphism Example ===");
        new PolymorphismSample().Execute();
        Console.WriteLine();

        Console.WriteLine("=== Composition Example ===");
        new CompositionSample().Execute();
        break;

    default:
        Console.WriteLine("Pillar not implemented.");
        break;
}

