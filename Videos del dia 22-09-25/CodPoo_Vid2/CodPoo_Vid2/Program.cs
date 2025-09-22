// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Text;
using CodPoo_Vid2.Models;

var poderVolar = new superPower();
poderVolar.name = "Volar";
poderVolar.descripcion = "Poder de volar por los aires";
poderVolar.level = levelPower.levelTwo;

var superFuerza = new superPower();
superFuerza.name = "Super Fuerza";
superFuerza.descripcion = "Poder de tener una fuerza sobre humana";
superFuerza.level = levelPower.levelThree;

var SuperMan = new SuperHero();
SuperMan.id = 1;
SuperMan.name = "Superman";
SuperMan.secretId = "Clark Kent";
SuperMan.ciudad = "Metropolis";
SuperMan.puedeVolar = true;

List<superPower> poderSuperMan = new List<superPower>();
poderSuperMan.Add(poderVolar);
poderSuperMan.Add(superFuerza);
SuperMan.superPower = poderSuperMan;
String result = SuperMan.useSuperPower();
Console.WriteLine(result);


enum levelPower
{
    levelOne,
    levelTwo,
    levelThree,
    levelFour,
    levelFive,
}