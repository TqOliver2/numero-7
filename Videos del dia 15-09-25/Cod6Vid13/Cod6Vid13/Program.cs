// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int  totPlayers = 15;
int totDealer = 15;
String message = "";
//juntar 21 pidiendo cartas o en caso de tener menos
//de 21 igual tener mayor puntacion que la maquina

if (totPlayers > totDealer && totPlayers < 22)
{
    message = "Venciste al dealer, felicidades";
} else if (totPlayers < totDealer) {
    message = "Perdiste ";
} else if (totPlayers > 21)
{
    message = "Perdiste, te pasaste de 21";
}
else
{
    message = "Condicion no valida";
}
Console.WriteLine(message);