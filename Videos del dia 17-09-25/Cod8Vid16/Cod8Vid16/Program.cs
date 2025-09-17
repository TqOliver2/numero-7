using System;

int totalJugador = 0;
int totalDealer = 0;
int num = 0;
int platziCoins = 0;
string message = "";
string controlOtraCarta = "";
string switchControl = "menu";

System.Random random = new System.Random();

while (true)
{
    Console.WriteLine("Bienvenido al casino ");
    Console.WriteLine("¿Cuántos PlatziCoins deseas? |1 por ronda|");
    platziCoins = int.Parse(Console.ReadLine());

    for (int i = 0; i < platziCoins; i++)
    {
        totalJugador = 0;
        totalDealer = 0;

        switch (switchControl)
        {
            case "menu":
                Console.WriteLine("Escriba ‘21’ para jugar al 21 o ‘exit’ para salir");
                switchControl = Console.ReadLine();
                i--; // No descontar PlatziCoin si solo está en el menú
                break;

            case "21":
                do
                {
                    num = random.Next(1, 12);
                    totalJugador += num;
                    Console.WriteLine($"Toma tu carta, jugador: {num}");
                    Console.WriteLine($"Total actual: {totalJugador}");
                    Console.WriteLine("¿Deseas otra carta? (si/no)");
                    controlOtraCarta = Console.ReadLine().ToLower();
                }
                while (controlOtraCarta == "si" || controlOtraCarta == "yes");

                totalDealer = random.Next(14, 23);
                Console.WriteLine($"El dealer tiene: {totalDealer}");

                if (totalJugador > 21)
                {
                    message = "Te pasaste de 21. ¡Perdiste!";
                }
                else if (totalDealer > 21 || totalJugador > totalDealer)
                {
                    message = "Venciste al dealer, felicidades";
                }
                else if (totalJugador == totalDealer)
                {
                    message = "Empate con el dealer.";
                }
                else
                {
                    message = "Perdiste contra el dealer.";
                }

                Console.WriteLine(message);
                switchControl = "menu";
                break;

            case "exit":
                Console.WriteLine("Gracias por jugar. ¡Hasta la próxima!");
                return;

            default:
                Console.WriteLine("Opción no válida. Regresando al menú...");
                switchControl = "menu";
                i--; 
                break;
        }
    }
}
