using System;

internal class Program
{
    static void Main()
    {
        
        // unos cjelobrojnog broja s provjerom
        bool praviUnos = false;
        int cijeliBroj;
        while (!praviUnos)
        {
            Console.Write("Cijeli broj : ");
            praviUnos = Int32.TryParse(Console.ReadLine(), out cijeliBroj);
        }
        Console.WriteLine("\n\n\n");
        

        
        // unos decimanlnog broja s provjerom
        bool praviUnos2 = false;
        while (!praviUnos2)
        {
            Console.Write("Decimalni broj : ");
            praviUnos2 = double.TryParse(Console.ReadLine(), out double decimalniBroj);
        }
        Console.WriteLine("\n\n\n");




        //Unos bez provjere
        Console.Write("Unesi broj : ");
        string input = Console.ReadLine();
        int broj1 = Int32.Parse(input);
        Console.WriteLine("\n\n\n");





        //Zadatak 8
        Console.Write("Unesi broj elemenata u nizu : ");
        int duzinaNiza = Int32.Parse(Console.ReadLine());

        double[] nekiniz = new double[duzinaNiza];

        Random rng = new Random();
        double nasumicnibroj = rng.NextDouble();
        
        for(int brojac = 0; brojac < duzinaNiza; brojac++)
        {
            nekiniz[brojac] = Math.Round(-35 + 95.5 * nasumicnibroj,1);
            nasumicnibroj = rng.NextDouble();
        }

        Console.Write("Članovi niza su : ");
        int indeks = 0;
        foreach(var broj in nekiniz)
        {
            if(indeks == nekiniz.Length - 1)
            {
                Console.WriteLine($"{broj}");
            }
            else
            {
                Console.Write($"{broj}  |  ");
            }
            indeks++;
        }
        Console.WriteLine("\n\n\n");

        double[] kopijaNiza = kopiranjeNiza(nekiniz, duzinaNiza);

        

        Console.Write("Članovi kopiranog niza su : ");
        indeks = 0;
        foreach (var broj in kopijaNiza)
        {
            if (indeks == nekiniz.Length - 1)
            {
                Console.WriteLine($"{broj}");
            }
            else
            {
                Console.Write($"{broj}  |  ");
            }
            indeks++;
        }
        Console.WriteLine("\n\n\n");


        sortiranjeOpadajucegNiza(kopijaNiza);
        Console.WriteLine("\n\n\n");
        ispisNiza(kopijaNiza);
        Console.WriteLine("\n\n\n");

        sortiranjeRastucegNiza(kopijaNiza);
        Console.WriteLine("\n\n\n");
        ispisNiza(kopijaNiza);
        Console.WriteLine("\n\n\n");



        //korisne funkcije
        Array.Sort(nekiniz);
        ispisNiza(nekiniz);
        Console.WriteLine("\n\n\n");

        Array.Reverse(nekiniz);
        ispisNiza(nekiniz);
        Console.WriteLine("\n\n\n");

        //korisno za liste i stringove
        List<string> lista = new List<string>() { "Traveling in a fried-out Kombi; On a hippie trail, head full of zombie;I met a strange lady, she made me nervous;She took me in and gave me breakfast" };
        string a = "jedan";
        string b = "dva";
        string c = "tri,cetiri,pet,sest";

        Console.WriteLine("Broj elemenata u listi je " + lista.Count);
        Console.WriteLine("\n\n\n");

        lista.Add(a); lista.Add(b); lista.Add(c);
        Console.WriteLine("Broj elemenata u listi je " + lista.Count);
        Console.WriteLine("\n\n\n");

        //velika slova
        Console.WriteLine(lista[1].ToUpper());
        Console.WriteLine("\n\n\n");

        //uzimanje samo jednog dijela stringa(5 slova od 2slova)
        Console.WriteLine(lista[3].Substring(2, 5));
        Console.WriteLine("\n\n\n");

        //pravljenje niza stringova od jednog stringa
        string[] tekst = lista[0].Split(';');
        Console.WriteLine("\n\n\n");

        //ispis elemenata stringa
        ispisStringa(tekst);

    }


    //funkcija kopiranja niza
    static double[] kopiranjeNiza(double[] niz, int brojElemenata)
    {
        double[] kopNiz = new double[brojElemenata];
        for (int i = 0; i < brojElemenata; i++)
        {
            kopNiz[i] = niz[i];
        }
        return kopNiz;
    }

    //funkcija sortiranja opadajućeg niza
    static void sortiranjeOpadajucegNiza(double[] niz)
    {
        for(int i = 0; i < niz.Length; i++)
        {
            for(int j = 0; j < niz.Length -1-i; j++)
            {
                if (niz[j] < niz[j + 1])
                {
                    double swap = niz[j];
                    niz[j] = niz[j + 1];
                    niz[j + 1] = swap;
                }
            }
        }

    }

    //funkcija sortiranja rastuceg niza - zazlika u if(j>j+1)
    static void sortiranjeRastucegNiza(double[] niz)
    {
        for (int i = 0; i < niz.Length; i++)
        {
            for (int j = 0; j < niz.Length - 1 - i; j++)
            {
                if (niz[j] > niz[j + 1])
                {
                    double swap = niz[j];
                    niz[j] = niz[j + 1];
                    niz[j + 1] = swap;
                }
            }
        }

    }

    static void ispisNiza(double[] niz)
    {
        Console.WriteLine("Niz nakon sortiranja je :");
        for(int i = 0; i < niz.Length; i++)
        {
            if(i == niz.Length - 1)
            {
                Console.WriteLine($"{niz[i]}");
            }
            else
            {
                Console.Write($"{niz[i]}  |  ");
            }
        }
        }


    // za ispisivanje stringa
    static void ispisStringa(string[] niz)
    {
        Console.WriteLine("Niz nakon sortiranja je :");
        for (int i = 0; i < niz.Length; i++)
        {
            if (i == niz.Length - 1)
            {
                Console.WriteLine($"{niz[i]}");
            }
            else
            {
                Console.Write($"{niz[i]}  |  ");
            }
        }
    }
}




