using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¿Van a jugar uno o dos jugadores?");
        Console.WriteLine("1) Un jugador");
        Console.WriteLine("2) Dos jugadores");
        string opc = Console.ReadLine();
        Console.Clear();

        if (opc == "1")
        {
            string[] palabras = { "celular", "computador", "mause", "sol", "proyector", "aplicacion", "tijera" };
            Random random = new Random();
            int randow_num = random.Next(0, 7);
            char[] letras = palabras[randow_num].ToCharArray();
            int word_length = letras.Length;
            int[] flagletras = new int[word_length];
            int intentos = 6;
            for (int i = 0; i < word_length; i++)
            {
                flagletras[i] = 0;
            }

            bool gameWon = false; // Agrega una variable para rastrear si el jugador ganó
            do
            {
                int letras_check = 0;
                Console.WriteLine("Intentos restantes: " + intentos);
                for (int h = 0; h < word_length; h++)
                {
                    if (flagletras[h] == 0)
                    {
                        Console.Write(" _ ");
                    }
                    else
                    {
                        Console.Write("" + letras[h] + "");
                        letras_check++;
                    }
                }
                if (letras_check == word_length)
                {
                    gameWon = true; // El jugador ganó
                    Console.WriteLine("\n\n¡Haz ganado el juego!");
                }
                else
                {
                    Console.WriteLine("\n\nIngrese una letra: ");
                    char letr = Convert.ToChar(Console.ReadLine());
                    bool flagcheck = false;
                    for (int x = 0; x < word_length; x++)
                    {
                        if (letr == letras[x])
                        {
                            flagletras[x] = 1;
                            flagcheck = true;
                        }
                    }

                    if (!flagcheck)
                    {
                        intentos--;
                    }

                    if (intentos == 0)
                    {
                        gameWon = true; // El jugador perdió
                        Console.WriteLine("\nGAME OVER");
                    }
                }
            } while (!gameWon); // Sal del bucle cuando el juego se gane o se pierda

            Console.ReadKey(); // Esperar a que el jugador presione una tecla antes de cerrar la consola
        }
        else if (opc == "2")
        {
            Console.WriteLine("Jugador 1 ingrese una palabra que el jugador 2 no la vea");
            string palabra = Console.ReadLine();
            char[] letras = palabra.ToCharArray();
            int word_length = letras.Length;
            int[] flagletras = new int[word_length];
            int intentos = 6;
            for (int i = 0; i < word_length; i++)
            {
                flagletras[i] = 0;
            }

            bool player1Won = false;
            bool player2Won = false;

            do
            {
                int letras_check = 0;
                Console.WriteLine("Intentos restantes: " + intentos);
                for (int h = 0; h < word_length; h++)
                {
                    if (flagletras[h] == 0)
                    {
                        Console.Write(" _ ");
                    }
                    else
                    {
                        Console.Write("" + letras[h] + "");
                        letras_check++;
                    }
                }
                if (letras_check == word_length)
                {
                    player2Won = true; // Jugador 2 ganó
                    Console.WriteLine("\n\n¡Haz ganado jugador 2 el juego!");
                }
                else
                {
                    Console.WriteLine("\n\nIngrese una letra: ");
                    char letr = Convert.ToChar(Console.ReadLine());
                    bool flagcheck = false;
                    for (int x = 0; x < word_length; x++)
                    {
                        if (letr == letras[x])
                        {
                            flagletras[x] = 1;
                            flagcheck = true;
                        }
                    }

                    if (!flagcheck)
                    {
                        intentos--;
                    }

                    if (intentos == 0)
                    {
                        player1Won = true; // Jugador 1 ganó
                        Console.WriteLine("\n\n¡Haz ganado jugador 1!");
                    }
                }
            } while (!player1Won && !player2Won); // Sal del bucle cuando uno de los jugadores gane

            Console.ReadKey(); // Esperar a que el jugador presione una tecla antes de cerrar la consola
        }
    }
}
