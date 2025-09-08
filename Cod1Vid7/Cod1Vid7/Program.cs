// See https://aka.ms/new-console-template for more information
//Creo una applicación para calcular el area de un rectangulo


var ladoA = 0d; var ladoB = 0d; var result = 0d;//declaramos las variables 
//0d es para decir que es un numero decimal
Console.WriteLine("Calcula el area de un rectangulo");

Console.WriteLine("Ingrese el valor del lado A: ");
ladoA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el valor del lado B: ");
ladoB = Convert.ToDouble(Console.ReadLine());

//se explica diferentes formas aritmeticas
result = ladoA * ladoB;
Console.WriteLine("El lado A es: " + ladoA + " El lado B es: " + ladoB + " El resultado es: " + result);