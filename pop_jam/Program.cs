
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
namespace PoPRefactoring;

public class PopProject
{
    public static void Main(string[] args)
    {
        int dia = 3;
        int mes = 1;
        int any = 2024;
        bool validat;

        string actionSelection;

        Console.WriteLine("Introdueix el dia, mes i any");
        validat = valida(dia, mes, any);
        Console.WriteLine(valida(dia, mes, any) ? "La data és correcta" : "El format no és correcte");

        Console.WriteLine("Que vols fer?\nSaltar\nCorrer\nAjupir-se\nAmagar-se");
        actionSelection = Console.ReadLine();
        actionSelection = actionSelection.ToLower();
        performAction(actionSelection);
    }

    public static void performAction(string action)
    {
        if (action == "saltar")
        {
            Console.WriteLine("Salto");
        } else if (action == "correr")
        {
            Console.WriteLine("Corro");
        }
        else if (action == "ajupir-se")
        {
            Console.WriteLine("M'ajupo");
        }
        else if (action == "amagar-se")
        {
            Console.WriteLine("M'amago");
        }

    }
    public static bool valida(int day, int month, int year)
    {

        if (day < 1 || day > 31)

            return false;

        if (month < 1 || month > 12)

            return false;

        // determinem la quantitat de dies del mes:

        int totalDaysMonth = 30;

        switch (month)
        {
            case 2: // verifica l'any de traspàs

                if (year % 4 == 0)
                {
                    totalDaysMonth = 29;
                }
                else totalDaysMonth = 28;
                break;

            case 1:

            case 3: 

            case 5: 

            case 7: 

            case 8: 

            case 10: 

            case 12: totalDaysMonth = 31; break;

        }

        if (day > totalDaysMonth) return false;

        else return true;

    }
}