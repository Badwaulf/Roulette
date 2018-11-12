using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class TestInteger
    {
        
        public int GetStack(int stackBanque)
        {
            int NombreStack = 0;
            bool choix = false;

            while (choix == false)
            {
                Console.WriteLine("\n =^.^= Choisir votre stack entre 0 et 666 =^.^=");
                string NbreSaisiStack = Console.ReadLine();

                if (int.TryParse(NbreSaisiStack, out NombreStack))
                {
                    choix = true;
                    if (NombreStack >= 0 && NombreStack <= stackBanque)
                    {
                        Console.WriteLine("Vous avez choisis d'avoir " + NombreStack + " dans votre stack");
                        return NombreStack;

                    }
                    else
                    {
                        Console.WriteLine("Merci de faire une demande de stack entre 0 et 666 =^.^=");
                        choix = false;
                    }

                }
                else
                {
                    choix = false;
                    Console.WriteLine("Erreur! le nombre saisie n'est pas un chiffre entier!:!:!:!");


                }



            }
            return NombreStack;

        }
        
        /********************************************************************************************/


        public int GetNumber()
        {
            int NombreChoisi = 0;
            bool choixnombre = false;

            while (choixnombre == false)
            {
                Console.WriteLine("\n =^.^= Choisir le chiffre sur lequel miser entre 0 et 36  =^.^=");
                string NbreSaisiChoisi = Console.ReadLine();

                if (int.TryParse(NbreSaisiChoisi, out NombreChoisi))
                {
                    choixnombre = true;
                    if (NombreChoisi >= 0 && NombreChoisi <= 36)
                    {
                        Console.WriteLine("Vous avez choisis de miser sur " + NombreChoisi );
                        return NombreChoisi;

                    }
                    else
                    {
                        Console.WriteLine("Merci de faire une mise entre 0 et 36 =^.^=");
                        choixnombre = false;
                    }

                }
                else
                {
                    choixnombre = false;
                    Console.WriteLine("Erreur! le nombre saisie n'est pas un chiffre entier!:!:!:!");


                }



            }
            return NombreChoisi;
        }

        /********************************************************************************************/


        public int GetMise(int stack, int number)
        {
            int NombreMise = 0;
            bool choixmise = false;

            while (choixmise == false)
            {
                Console.WriteLine("\n =^.^= Choisir le montant de votre mise =^.^=");
                string NbreSaisiMise = Console.ReadLine();

                if (int.TryParse(NbreSaisiMise, out NombreMise))
                {
                    choixmise = true;
                    if (NombreMise <= stack)
                    {
                        Console.WriteLine("\n Vous avez choisis de miser " + NombreMise +" sur " + number);
                        
                        return NombreMise;

                    }
                    else
                    {
                        Console.WriteLine("Merci de faire une mise entre 0 et " + stack +" =^.^=");
                        choixmise = false;
                    }

                }
                else
                {
                    choixmise = false;
                    Console.WriteLine("Erreur! le nombre de la mise n'est pas un chiffre entier!:!:!:!");


                }



            }
            return NombreMise;
        }


    }
}
