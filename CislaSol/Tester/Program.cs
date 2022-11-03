// See https://aka.ms/new-console-template for more information

using Cisla;

Zlomek z1 = new Zlomek(1, 2);
Zlomek z2 = new Zlomek(1, 2);
Zlomek z3 = z1 + z2;
Zlomek z4 = z3 + 2;
Console.WriteLine(z1.GetHashCode());
Console.WriteLine(z2.GetHashCode());
Console.WriteLine(z3);
Console.WriteLine(z4);

Dictionary<Zlomek,int> pokus = new Dictionary<Zlomek,int>();
pokus[z1] = 10;
pokus[z2] = 20;

Console.WriteLine(pokus[z1]);

//if (z1 == z2)
//{
//    Console.WriteLine("Stejne");
//}
//else
//{
//    Console.WriteLine("Ruzne");
//}
