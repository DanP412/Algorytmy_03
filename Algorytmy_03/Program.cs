using System;

namespace Algorytmy_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Przedmiot miecz = new Przedmiot(60, 4);
            Przedmiot Stalowy_miecz = new Przedmiot(100, 4);
            Przedmiot diament = new Przedmiot(200, 2);
            Przedmiot łuk = new Przedmiot(20, 4);
            Przedmiot łopata = new Przedmiot(5, 4);
            Przedmiot jablko = new Przedmiot(2, 1);


            Przedmiot[] tab = { miecz, Stalowy_miecz, diament, łopata, łuk, jablko };
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine($"Przedmiot:  {tab[i]} Wartosc: {tab[i].wartosc} Waga: {tab[i].miejsce} ");
            }
        }
    }

    class Kufer
    {

    }

    class Przedmiot
    {

        public int wartosc, miejsce;

        public Przedmiot()
        {
            this.wartosc = 1;
            this.miejsce = 1;
        }

        public Przedmiot(int war, int miej)
        {
            this.wartosc = war;
            this.miejsce = miej;
        }
        

        public int CompareTo(Przedmiot other)
        {
            int a = other.wartosc = 

            if (true)
            {

            }
           
        }
      



    }

}
