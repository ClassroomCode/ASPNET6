using LangDemo6;

Console.WriteLine("Hello, World!");

Person? p = new Person()
{ FirstName = "Joe", LastName = "Smith" };

p = null;

Console.WriteLine(p?.FirstName);
