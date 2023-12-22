// See https://aka.ms/new-console-template for more information
var dudes = new[]
{
   new { Name = "Bob", Age = 20 },
   new { Name = "Rob", Age = 30 }
};

dudes.ToList().ForEach(x => Console.WriteLine($"name: {x.Name}, age: {x.Age}"));
