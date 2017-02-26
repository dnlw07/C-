using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            // FORMATTING STRINGS

            //// quotes
            //string myString = "My \"so-called\" life";
            //string myString = "What if I need \na new line";

            ////slash
            //string myString = "Go to your c:\\ drive";
            //string myString = @"Go to your c:\ drive";

            //// replacement code
            //string myString = String.Format("{0} = {1}", "First", "Second");
            //string myString = String.Format("{0} = {0}", "First", "Second");
            //string myString = String.Format("{1} = {1}", "First", "Second");
            //string myString = String.Format("{1} = {0}", "First", "Second");

            //// waluta zależnie od ustawień regionalnych w systemie
            //string myString = String.Format("{0:C}", 123.45);

            //// rozdzielenie dużej liczby spacjami (spacj lub przecikni zaleznie od regiony)
            //string myString = String.Format("{0:N}", 1234567890);

            //// procenty
            //string myString = String.Format("{0:P}", 0.1234567890);

            //// customizowany format na przykładzie numeru telefonu
            //// formatowanie zachodzi od prawej do lewej. gdy jest zbyt wiele cyfr  ich nadmiar pojawi sie w nawiasie (#####)
            //string myString = String.Format("{0:(###) ###-####}", 1234567890);

            // MANIPULATING STRINGS

            //string myString = " That summer we took threes across the board  ";

            //// truncating - zacznij od szóstego znaku
            //myString = myString.Substring(6, 14);

            //// Zmiana na wielkie litery
            //myString = myString.ToUpper();

            //// Replace - zamiana znaków
            //myString = myString.Replace(" ", "--");

            //// Usuwa znaki z łańcucha
            //myString = myString.Remove(6, 14);

            //// TRIM - usuwa spacje na początku oraz na końcu łańcucha
            //myString = myString.Format("Length: {0} -- After length {1}", myString.Length, myString.Trim().Length);

            // ToString - dołącza znaki do istniejącego łąńcucha
            // ToString w pętli jest mało wydajny, gdyż każdna poprzednia iteracja jest usuwana z pamięci i w jej miejsce powstaje nowa +1 większa
            //string myString = "";
            //for (int i = 0; i < 100; i++)
            //{
            //    myString += "--" + i.ToString();
            //}

            // ALTERNATYWA DLA ToString jest kalsa StringBuilder.Append
            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                // Najpierw dołącza --, a następnie cyfrę
                myString.Append("--");
                myString.Append(i);
            }
                                     
            
            Console.WriteLine(myString);
            Console.ReadKey();
        }
    }
}
