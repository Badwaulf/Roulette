using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            TestInteger joueur = new TestInteger();

            int stackBanque = 666;

            Console.WriteLine("Do you want a play a game??");
            Console.ReadLine();
     
            Console.WriteLine("<-********************************************->");
            Console.WriteLine("<-*******Ceci est le jeu de la roulette*******->");
            Console.WriteLine("<-********************************************->");

            //Choix du joueur de son stack
            var stack = joueur.GetStack(stackBanque);

            while (stackBanque != 0 && stack != 0)
            {
                Random valeur = new Random();
                int aleatoire = valeur.Next(0, 36);
                

                //Choix du joueur du chiffre sur lequel il mise
                var number = joueur.GetNumber();

                //Choix du joueur de la mise
                var mise = joueur.GetMise(stack, number);

                if (number == aleatoire)
                {
                    Console.WriteLine("(°v°) Mazeltof!! Vous avez gagné ... Votre stack augmente maintenant de " + mise * 36);
                    Console.WriteLine("Votre stack est actuellement de ===> " + (stack + (mise * 36)));
                }
                else if (aleatoire == number && number == 0)
                {
                    Console.WriteLine("(°v°) Mazeltof!! Vous avez gagné ... Votre stack augmente maintenant de " + mise * 50);
                    Console.WriteLine("Votre stack est actuellement de ===> " + (stack + (mise * 50)));
                }
                else if (aleatoire % 2 == 0 &&  number %2 == 0)
                {
                    Console.WriteLine("(°v°) Mazeltof!! Vous avez gagné ... Votre stack augmente maintenant de " + mise * 20);
                    Console.WriteLine("Votre stack est actuellement de ===> " + (stack + (mise * 20)));
                }
                else if (aleatoire % 2 != 0 && number %2 != 0)
                {
                    Console.WriteLine("(°v°) Mazeltof!! Vous avez gagné ... Votre stack augmente maintenant de " + mise * 20);
                    Console.WriteLine("Votre stack est actuellement de ===> " + (stack + (mise * 20)));
                }
                else
                    Console.WriteLine("La roulette avait choisis le : " + aleatoire + " Il vous reste : " + (stack = stack - mise) + " dans votre stack " +
                        "\n Même joueur joue encore!");



                Console.ReadKey();
            }
        }
    }
}
