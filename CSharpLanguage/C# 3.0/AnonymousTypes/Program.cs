// See https://aka.ms/new-console-template for more information
string[] names = { "Tom", "Dick", "Harry" };

var query = from n in names
            where n.Length >= 4
            select new
            {
              Name = n,
              n.Length
            };

query.ToList().ForEach(name => Console.WriteLine($"Name: {name.Name}, length: {name.Length}"));
