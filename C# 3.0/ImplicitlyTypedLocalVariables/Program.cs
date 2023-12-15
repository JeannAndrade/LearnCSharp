// See https://aka.ms/new-console-template for more information
string[] names = ["Tom", "Dick", "Harry"];

var filteredNames = names.Where(n => n.Length == 4);

filteredNames.ToList().ForEach(x => Console.WriteLine(x));
