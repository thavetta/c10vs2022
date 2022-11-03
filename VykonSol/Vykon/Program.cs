// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using BenchmarkDotNet.Running;
using Vykon;

//var summary = BenchmarkRunner.Run<Md5VsSha256>();

Osoba o = new Osoba() {Jmeno = "Tomas", Mesto = "Brno", Plat = 30_000};

byte[] utf8Json = JsonSerializer.SerializeToUtf8Bytes(o, MyJsonContext.Default.Osoba);

o = JsonSerializer.Deserialize(utf8Json, MyJsonContext.Default.Osoba);

Console.WriteLine(o.Jmeno + " " + o.Mesto);