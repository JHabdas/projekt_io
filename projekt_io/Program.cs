using projekt_io;

Console.WriteLine("Hello, World!");
Console.WriteLine("Podaj imie: ");
string imie = Console.ReadLine();
Console.WriteLine("Witaj " + imie);

student Student1 = new student("Tomasz", "Kowalski");
Console.WriteLine("imie i nazwisko studenta: " + Student1.imie + Student1.nazwisko);
