using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////
            //// TYPY WYLICZENIOWE
            ///////////////////////////////////////////////////////////////

            int friday = (int)Enums.Days.Friday; // (int) - rzutowanie z listy wyliczeniowej na konkretną wartośc int

            // Wypisuje zmienną firday
            Console.WriteLine(friday);
            
            // Wypisuje typ zmiennej friday
            Console.WriteLine(friday.GetType() + "\n\n");



            ///////////////////////////////////////////////////////////////
            //// TABLICE
            ///////////////////////////////////////////////////////////////

            // inicjalizacja pustej tablicy
            int[] numbersTab = new int[3];

            // inicjalizacja oraz zdefiniowenie tablicy
            int[] numbersTab2 = { 1, 2, 3 };

            numbersTab[0] = 0;
            numbersTab[1] = 4;
            numbersTab[2] = 7;
            //numbersTab[3] = 3; // czwarty element w trzy elementowej tablicy


            // iterowanie zawartości tablicy
            Console.WriteLine("Zawartośc tablicy: ");
            foreach (int number in numbersTab)
            {
                Console.Write(number + " ");
            }
            

            // zwraca indeks tablicy dla wybranej wartości
            int SzukanaWartosc = 4;
            Console.WriteLine("\n" + "Indeks liczby to: " + Array.BinarySearch(numbersTab, SzukanaWartosc));


            // Zwaraca pierwszy znaleziony indeks szukanej wartości
            int index = Array.IndexOf(numbersTab, SzukanaWartosc);
            Console.WriteLine("\n" + "Szukana liczba znajduje się w indeksie z numerem: " + index);


            
            // funckja czyści zawartość tablicy od zera do końca, ale jej nie usuwa!
            Array.Clear(numbersTab, 0, numbersTab.Length);
            Console.WriteLine("\n" + "Rozmiar tablicy: " + numbersTab.Length);


            // zawartość tablicy po użyciu funkcji clear
            Console.WriteLine("\n" + "Zawartośc tablicy: ");
            foreach (int number in numbersTab)
            {
                Console.Write(number + " ");
            }

            ///////////////////////////////////////////////////////////////
            //// KOLEKCJE
            ///////////////////////////////////////////////////////////////

            //// LISTA
            // Definiuje nową listę posiadającą elementy int
            List<int> numbersList = new List<int>(); // <int> - notacja diamentowa; podajemy typ danych jaki bedzie zawraty w liście

            numbersList.Add(0);
            numbersList.Add(1);
            numbersList.Add(2);
            numbersList.Add(3);

            // Wyślwietla zawartość listy
            Console.WriteLine("\n\n" + "Lista: ");
            foreach (int number in numbersList)
            {
                Console.Write(number + " ");
            }

            // Sprawdza rozmiar listy
            Console.WriteLine("\n" + "Rozmiar listy: " + numbersList.Count);

            // Sprawdza czy obiekt znajduje się w liście
            int SzukanaWartosc2 = 1;
            bool isIn = numbersList.Contains(SzukanaWartosc2);
            Console.WriteLine("\n" + "Czy obiekt znajduje się w liście? " + isIn);

            // Usuwa indeks z listy
            int indeks = 2;
            numbersList.Remove(indeks);
            Console.WriteLine("\n" + "Usunięto z listy element o indeksie: " + indeks);
            Console.WriteLine("\n" + "Nowa lista: ");
            foreach (int number in numbersList)
            {
                Console.Write(number + " ");
            }

          
            //// SŁOWNIK
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(1, "Auto1");
            myDictionary.Add(2, "Auto2");
            myDictionary.Add(3, "Auto3");

            // Sprawdza czy słownik zawiera klucz z indeksem 1
            bool inIn = myDictionary.ContainsKey(1);
            Console.WriteLine("\n" + "Czy słownik zawiera klucz z numerem 1" + isIn);

            // Sprawdza czy słownik zawiera klucz o danej wartości
            isIn = myDictionary.ContainsValue("Auto1");
            Console.WriteLine("\n" + "Czy słownik zawiera klucz o wartości Auto1? " + isIn);

            Console.WriteLine("\n" + "Pod kluczem 1 znajduje się: " + myDictionary[1]);

            // Usuwa indeks z listy
            myDictionary.Remove(1);

            //Podaje liczbę elementów znajdujących się w słowniku
            Console.WriteLine("\n" + "Rozmiar słownika wynosi: " + myDictionary.Count);

            //// KEY VALUE PAIR
            // od słownika różni się tym, że może posiadać jedynie jedną pojedynczą parę
            // słownik składa się z wielu par

            // tworzy nowe pary
            KeyValuePair<int, string> myKeyValue1 = new KeyValuePair<int, string>(1, "Auto1");
            KeyValuePair<int, string> myKeyValue2 = new KeyValuePair<int, string>(1, "Auto2");
            KeyValuePair<int, string> myKeyValue3 = new KeyValuePair<int, string>(1, "Auto3");

            // Tworzy listę składająca sie z wielu par
            List <KeyValuePair <int, string>> myKeyValuePairList = new List<KeyValuePair<int, string>>();
            myKeyValuePairList.Add(myKeyValue1);
            myKeyValuePairList.Add(myKeyValue2);
            myKeyValuePairList.Add(myKeyValue3);

            Console.WriteLine("\n" + "Elementy listy zawierającej KeyValuePairs:  ");
            foreach (var element in myKeyValuePairList)
            {
                Console.Write(element + " ");
            }

            //// STOS
            // first in - last out
            Stack<string> myStack = new Stack<string>();

            // dodaje elementy do stosu
            myStack.Push("Pierwszy element");
            myStack.Push("Drugi element");
            myStack.Push("Trzeci element");
            myStack.Push("Czwarty element");

            // sprawdza co jest na szczycie stosu (first out)
            string stackElement = myStack.Peek();
            Console.WriteLine("\n\n" + "Elemet na szczycie stosu: " + stackElement);

            // zdejmuje elementy ze stosu
            string stackElement2 = myStack.Pop();
            Console.WriteLine("\n" + "Elemet zdjęty ze stosu: " + stackElement2);

            // Podaje rozmiar stosu
            int stackSize = myStack.Count;
            Console.WriteLine("\n" + "Rozmiar stosu: " + stackSize);


            //// KOLEJKA
            // first in - first out
            Queue<string> myQueue = new Queue<string>();

            // dodaje elementy do kolejki
            myQueue.Enqueue("Pierwszy element");
            myQueue.Enqueue("Drugi element");
            myQueue.Enqueue("Trzeci element");
            myQueue.Enqueue("Czwarty element");

            // zwraca pierwszy element znajdujący się na wyjściu z kolejki (first out)
            string queueElement = myQueue.Peek();
            Console.WriteLine("\n" + "Na początku kolejki znajduje się: " + queueElement);

            // uzuwa oraz zwaraca kolejne obiekty z kolejki
            string dequeueElement1 = myQueue.Dequeue();
            string dequeueElement2 = myQueue.Dequeue();

            // zwraca rozmiar kolejki po usunięciu z niej elementów
            Console.WriteLine("\n" + "Rozmiar kolejki wynosi: " + myQueue.Count);

            // czyści kolejkę
            myQueue.Clear();

            // zwraca rozmiar kolejki po wyczyszczeniu jej zawartości
            Console.WriteLine("\n" + "Rozmiar kolejki wynosi: " + myQueue.Count);

            // konsola zamyka sie dopiero po wciśnięciu klawisza
            Console.ReadKey();
        }
    }
}
