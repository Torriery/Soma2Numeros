int primeironumero,segundonumero,soma;
Console.WriteLine("Cálculo da soma entre dois números.\n");
Console.Write("digite o primeiro numero....");
primeironumero = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o segundo número: ");
segundonumero=Convert.ToInt32(Console.ReadLine());
soma = primeironumero + segundonumero;
Console.WriteLine($"\nSoma: {soma}");