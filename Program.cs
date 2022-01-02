int[] apples = { 1, 2, 3, 4, 5 };
int[] apples2 = new int[5];
List<int> apples3 = new List<int>();

apples3.Add(1);
apples3.Add(8);
apples3.RemoveAt(0);
Console.WriteLine(apples3.Count());
foreach (int apple in apples3)
{
    Console.WriteLine(apple);
}


