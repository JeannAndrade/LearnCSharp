// See https://aka.ms/new-console-template for more information
var dic = new Dictionary<int, string>()
{
  [3] = "three",
  [10] = "ten"
};

for (int i = 0; i <= 10; i++)
{
  System.Console.WriteLine($"key {i}, value {dic.GetValueOrDefault(i)}");
}
