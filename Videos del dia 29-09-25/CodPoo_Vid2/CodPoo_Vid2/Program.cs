// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Text;
using CodPoo_Vid2.Models;
using CodPoo_Vid2;

var imprimir = new Impimir();
var poderVolar = new superPower();
poderVolar.name = "Volar";
poderVolar.descripcion = "Poder de volar por los aires";
poderVolar.level = levelPower.levelTwo;

var superFuerza = new superPower();
superFuerza.name = "Super Fuerza";
superFuerza.descripcion = "Poder de tener una fuerza sobre humana";
superFuerza.level = levelPower.levelThree;

var regenereacion = new superPower();
regenereacion.name = "Regeneracion";
regenereacion.level = levelPower.levelThree;

var SuperMan = new SuperHero();
SuperMan.id = 1;
SuperMan.name = "  Superman  ";
SuperMan.secretId = "Clark Kent";
SuperMan.ciudad = "Metropolis";
SuperMan.puedeVolar = true;

imprimir.ImprimirSHeroe(SuperMan);

List<superPower> poderSuperMan = new List<superPower>();
poderSuperMan.Add(poderVolar);
poderSuperMan.Add(superFuerza);
SuperMan.superPower = poderSuperMan;
String result = SuperMan.useSuperPower();
Console.WriteLine(result);
//uso de herencia para llamar el metodo SaveWorld con metodo abtracto
string resultSave = SuperMan.SaveWorld();
Console.WriteLine(resultSave);

var Wolverine = new AntiHero();
Wolverine.id = 5;
Wolverine.name = "Wolverine";
Wolverine.secretId = "Logan";
Wolverine.puedeVolar = false;

imprimir.ImprimirSHeroe(Wolverine);
List<superPower> poderWolverine = new List<superPower>();
poderWolverine.Add(superFuerza);
poderWolverine.Add(regenereacion);
Wolverine.superPower = poderWolverine;
String result2 = Wolverine.useSuperPower();
Console.WriteLine(result2);

//uso de herencia para llamar el metodo IlegalActivity
String actionAntihero = Wolverine.IlegalActivity("Atacar policia");
Console.WriteLine(actionAntihero);

enum levelPower
{
    levelOne,
    levelTwo,
    levelThree,
    levelFour,
    levelFive,
}