using System;

Console.Write("input yout age >> ");

string s = Console.ReadLine(); // "10"

/*
int n1 = Convert.ToInt32(s);
int n2 = int.Parse(s);

Console.WriteLine($"{n1}, {n2}");
*/

int n3 = 0;

bool b = int.TryParse(s, out n3);
Console.WriteLine($"{b}, {n3}");



