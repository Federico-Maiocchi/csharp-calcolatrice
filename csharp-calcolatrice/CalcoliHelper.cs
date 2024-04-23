using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_calcolatrice
{
    //Creare una classe di helper CalcoliHelper.
    //Come visto a lezione, strutturare la classe in modo che non possa essere istanziata e che presenti i seguenti metodi `static`:
    internal static class CalcoliHelper
    {
        //- Somma di due numeri interi
        public static int SumInt(int a, int b)
        {
            int totSumInt = a + b;

            return totSumInt;
        }
        
        //- Somma di due numeri double
        public static double SumDouble(double a, double b)
        {
            double totSumDouble = Math.Round((a + b), 2);

            return totSumDouble;
        }

        //- Differenza tra due numeri interi
        public static int SubInt(int a, int b)
        {
            int totSubInt = a - b;

            return totSubInt;
        }

        //- Differenza tra due numeri double
        public static double SubDouble(double a, double b)
        {
            double totSubDouble = Math.Round((a - b), 2);

            return totSubDouble;
        }

        //- Moltiplicazione di due numeri interi
        public static int MultiplicationInt( int a, int b)
        {
            int totMultiplicationInt = a * b;

            return totMultiplicationInt;
        }

        //- Moltiplicazione di due numeri double
        public static double MultiplicationDouble(double a, double b)
        {
            double totMultiplicationDouble = Math.Round((a * b), 2);

            return totMultiplicationDouble;
        }

        //- Valore assoluto di un numero intero
        public static int AbsoluteValueInt(int a)
        {
            if (a < 0)
            {
                return -a;
            } 
            else
            {
                return a;
            }
        }

        //- Valore assoluto di un numero double
        public static double AbsoluteValueDouble(double a)
        {
            if (a < 0)
            {
                return - a;
            }
            else
            {
                return a;
            }
        }

        //- Minimo tra due numeri interi
        public static int MinimumInt(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else 
            {
                return b;
            }
        }

        //- Minimo tra due numeri double
        public static double MiniumDouble(double a, double b)
        {
            if ( a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        //- Massimo tra due numeri interi
        public static int MaximunInt(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        //- Massimo tra due numeri double
        public static double MaximunDouble(double a, double b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        //Il fatto di dover scrivere lo stesso metodo per tipi di parametro diversi applica nella pratica uno dei principi di programmazione ad oggetti che abbiamo visto oggi…Quale? Scrivetelo in un commento all’interno del codice! :faccia_nerd:
       
        //**BONUS**:
        //Aggiungete il metodo per l’elevamento a potenza che prende come parametri due numeri interi(base ed esponente)
        //e ritorna la base elevata all’esponente.
        //Occhio che sia la base che l’esponente potrebbero essere uguali a zero oppure numeri negativi!
        //(caso esponente = 0 e base = 0 anche se in matematica sarebbe un numero
        //indefinito usiamo l’approccio informatico che lo calcola come 1)
        public static int  ElevatoPotenza(int numeroBase, int esponente) 
        {
            int totPotenza = 1;
            for (int i = 0; i < esponente; i++)
            {
                totPotenza *= numeroBase;
            }

            return totPotenza;
        }
    }
}
