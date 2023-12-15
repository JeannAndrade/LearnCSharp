// See https://aka.ms/new-console-template for more information
Func<int, int> square = x => x * x;

Console.WriteLine(square(3));

string[] names = { "Tom", "Dick", "Harry" };

// Include only names of >= 4 characters.
IEnumerable<string> filteredNames = Enumerable.Where(names, n => n.Length >= 4);

filteredNames.ToList().ForEach(x => Console.WriteLine(x));