// See https://aka.ms/new-console-template for more information


Console.WriteLine("Bienvenido al programa");
//PI * radio^2
var radio = 0d;
var result = 0d;

Console.WriteLine("Ingrese el radio del círculo:");
 radio =  Convert.ToDouble(Console.ReadLine());  

result = Math.PI * radio * radio;

Console.WriteLine("El área del círculo de radio: " +result) ;
