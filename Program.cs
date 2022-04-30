using System;
using RPG.src.Entities;

namespace RPG;

class Program
{
    static void Main(string[] args)
    {
        //Criar personagens
        Knight arus = new Knight("Arus", 23, 76);
        Wizard jennica = new Wizard("Jennica", 25, 70);

        System.Console.WriteLine("Mostrar informações dos personagens:");
        System.Console.WriteLine(arus.ToString());
        System.Console.WriteLine(jennica.ToString());

        System.Console.WriteLine("\n======================================");
        System.Console.WriteLine("\nAtacando um ao outro:");
        System.Console.WriteLine(jennica.Attack(arus));
        System.Console.WriteLine(arus.Attack(jennica));

        System.Console.WriteLine("\nAtacando usando o ataque especial da classe:");
        System.Console.WriteLine(jennica.SpecialAttack(arus));
        System.Console.WriteLine(arus.SpecialAttack(jennica));

        System.Console.WriteLine("\nMatar uma pessoa, e mostrar casos de validação:");
        System.Console.WriteLine(jennica.Attack(arus));

        System.Console.WriteLine(arus.Attack(jennica));
        System.Console.WriteLine(jennica.Attack(arus));

        System.Console.WriteLine("\n======================================");
        System.Console.WriteLine("\nUsar metódo exclusivo a classe Wizard:");
        System.Console.WriteLine(jennica.DrinkPotion());

        System.Console.WriteLine("\n======================================");

        //Criar novos personagens
        Knight wedge = new Knight("Wedge", 15, 41);
        Wizard topapa = new Wizard("Topapa", 13, 34);

        System.Console.WriteLine("\nMostrar informações dos novos personagens:");
        System.Console.WriteLine(wedge.ToString());
        System.Console.WriteLine(topapa.ToString());

        System.Console.WriteLine("\nCasar Wedge e Topapa:"); 
        System.Console.WriteLine(wedge.Marry(topapa));
        
        System.Console.WriteLine("\nMostrar casos de validação:");
        System.Console.WriteLine(arus.Marry(wedge));
        System.Console.WriteLine(jennica.Marry(topapa));
        System.Console.WriteLine(wedge.Marry(arus));
    }
}