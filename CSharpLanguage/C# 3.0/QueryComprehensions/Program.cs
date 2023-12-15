// See https://aka.ms/new-console-template for more information

string[] names = { "Tom", "Dick", "Harry" };

// Using Query comprehension syntax
var filteredNames = from n in names where n.Length >= 4 select n;

filteredNames.ToList().ForEach(x => Console.WriteLine(x));

