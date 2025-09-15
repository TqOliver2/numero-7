// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int totPlayers = 0;
int totDealer = 0;
String message = "";
String switckcontrol = "menu";
int num = 0;
//juntar 21 pidiendo cartas o en caso de tener menos
//de 21 igual tener mayor puntacion que la maquina
while (true)
{
    switch (switckcontrol)
    {
        case "menu":
            Console.WriteLine("Bienvenido al Casino");
            Console.WriteLine("Escriba 21 pra jugar al 21");
            switckcontrol = Console.ReadLine();
            break;
        case "21":

            do
            {
                System.Random random = new System.Random();
                num = random.Next(1, 12);
                totPlayers = totPlayers + num;
                Console.WriteLine("Toma tu carta...");
                Console.WriteLine("Tu Carta es: " + num);
                Console.WriteLine("Deseas otra carta? ");
            } while (Console.ReadLine() == "si" || Console.ReadLine() == "Si");

            if (totPlayers > totDealer && totPlayers < 22)
            {
                message = "Venciste al dealer, felicidades";
                switckcontrol = "menu";

            }
            else if (totPlayers < totDealer)
            {
                message = "Perdiste ";
                switckcontrol = "menu";
            }
            else if (totPlayers > 21)
            {
                message = "Perdiste, te pasaste de 21";
                switckcontrol = "menu";
            }
            else
            {
                message = "Condicion no valida";
                switckcontrol = "menu";
            }
            Console.WriteLine(message);
            break;
        default:
            Console.WriteLine("Opcion no valida");
            switckcontrol = "menu";
            break;
        case "exit":
            break;
    }


}

