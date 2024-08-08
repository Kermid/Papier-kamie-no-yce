using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papier_kamien
{
    internal class logikaGry
    {
       public static void kamienPapier(int wylosowanaWartosc, int wyborGracza)
        {
            Console.Write($"{wylosowanaWartosc} ");
           switch(wyborGracza)
            {
                case 1://papier
                    if(wylosowanaWartosc == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Papier na papier.Remis!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (wylosowanaWartosc == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Papier na kamień.Wygrywasz!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (wylosowanaWartosc == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Papier na nożyce.Wygrywa przeciwnik!");
                        Console.ForegroundColor= ConsoleColor.White;
                    }
                        break;
                case 2://kamien
                    if (wylosowanaWartosc == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Kamień na papier.Wygrywa przeciwnik!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (wylosowanaWartosc == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Kamień na kamień.Remis!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (wylosowanaWartosc == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Kamień na nożyce.Wygrywasz!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
                case 3://nozyce
                    if (wylosowanaWartosc == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Nożyce na papier.Wygrywasz!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (wylosowanaWartosc == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Nożyce na kamień.Przegrywasz!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (wylosowanaWartosc == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Nożyce na nożyce.Remis!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
            }

        }
    }
}
