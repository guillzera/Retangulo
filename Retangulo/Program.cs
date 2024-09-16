using Retangulo.Models;
using System.Globalization;

Retan retangulo = new Retan();

Console.WriteLine("Entre a largura e altura do retangulo:");
retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("AREA = " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PERIMETRO = " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL = " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));


