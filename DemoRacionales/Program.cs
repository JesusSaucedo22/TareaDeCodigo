using NumerosRacionales.Mode;

Console.WriteLine("Demostracion de operaciones con numeros racionales\n");


Racional r1 = new Racional(2, 8);
Racional r2 = new Racional(3, 8);

Console.WriteLine($"{r1.ComoTexto()} como fraccion es {r1.Fraccion()}");
Console.WriteLine($"{r2.ComoTexto()} como fraccion es {r2.Fraccion()}");
if(r1.EsFraccionPropia() == true)
{
    Console.WriteLine($"{r1.ComoTexto()} Si es fraccion propia");
}
else
{
    Console.WriteLine($"{r1.ComoTexto()} No es fraccion propia");
}

Racional r3 = r1.Sumar(r2);
Console.WriteLine($"{r1.ComoTexto()} + {r2.ComoTexto()} = {r3.ComoTexto()}");

Racional r4 = r3.Restar(r2);
Console.WriteLine($"{r3.ComoTexto()} - {r2.ComoTexto()} = {r4.ComoTexto()}");

Racional r5 = r1.Multiplicar(r2);
Console.WriteLine($"{r1.ComoTexto()} X {r2.ComoTexto()} = {r5.ComoTexto()}");

Racional r6 = r1.Dividir(r2);
Console.WriteLine($"{r1.ComoTexto()} / {r2.ComoTexto()} = {r6.ComoTexto()}");

/*
Console.WriteLine($"{r1.GetNumerador}/{r1.GetDenominador}");
r1.SetNumerador(4);
r1.SetDenominador(7);
Console.WriteLine($"{r1.GetNumerador}/{r1.GetDenominador}");

Console.WriteLine($"{r1.Numerador}/{r1.Denominador}");

r1.Numerador = 8;
r1.Denominador = 3;
Console.WriteLine($"{r1.GetNumerador}/{r1.GetDenominador}");
*/