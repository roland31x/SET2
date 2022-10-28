using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace SET2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SET2();
            Console.WriteLine("Aplicatia s-a inchis.");
        }

        private static void SET2()
        {
            Console.WriteLine("SET2 de exercitii in ConsoleApp - Fundamentele programarii 2022 - pali roland\n");
            Console.WriteLine("Apasa orice buton pentru a continua spre meniul de alegere al exercitiilor");
            Console.ReadKey();
            while (true)
            {
                MENU();
                string menubrowser = Console.ReadLine();
                switch (menubrowser.ToLower())
                {
                    case "exit":
                        return;
                    case "1":
                        Start();
                        SEQ_i();    
                    P1();
                        Finish();
                        break;
                    case "2":
                        Start();
                        SEQ_i();
                    P2();
                        Finish();
                        break;
                    case "3":
                        Start();
                    P3();
                        Finish();
                        break;
                    case "4":
                        Start();
                        SEQ_i();
                    P4();
                        Finish();
                        break;
                    case "5":
                        Start();
                        SEQ_i();    
                    P5();
                        Finish();
                        break;
                    case "6":
                        Start();
                        SEQ_i();
                    P6();
                        Finish();
                        break;
                    case "7":
                        Start(); 
                        SEQ_i();
                    P7();
                        Finish();
                        break;
                    case "8":
                        Start();
                    P8();
                        Finish();
                        break;
                    case "9":
                        Start();
                        SEQ_i();
                    P9();
                        Finish();
                        break;
                    case "10":
                        Start();
                        SEQ_i();
                    P10();
                        Finish();
                        break;
                    case "11":
                        Start();
                        SEQ_i();
                    P11();
                        Finish();
                        break;
                    case "12":
                        Start();
                        SEQ_i();
                    P12();
                        Finish();
                        break;
                    case "13":
                        Start();
                        SEQ_i();
                    P13();
                        Finish();
                        break;
                    case "14":
                        Start();
                        SEQ_i();
                    P14();
                        Finish();
                        break;
                    case "15":
                        Start();
                        SEQ_i();
                    P15();
                        Finish();
                        break;
                    case "16":
                        Start();
                        SEQ_i();
                    P16();
                        Finish();
                        break;
                    case "17":
                        Start();
                        SEQ_i();
                    P17();
                        Finish();
                        break;
                    default:
                        Console.WriteLine("Valoarea introdusa nu apartine criteriului cerut, apasa orice buton pentru a reveni la meniul de selectie!");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private static void P17()
        {
            Console.WriteLine("ex 17:\n   Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. \n    Determinati daca secventa reprezinta o secventa de paranteze corecta si,\n    daca este, determinati nivelul maxim de incuibare a parantezelor.");
            Console.WriteLine("\nIntroduceti secventa de numere:");
            string secventaintro = Console.ReadLine();
            string secventa = secventaintro.Replace(" ", "");
            int countst = 0; // paranteze deschise
            int countf = 0; // paranteze inchise
            int incuib = 1;
            int incuibaux1 = 0;
            int incuibaux2 = 1;
            char separator = ',';
            string secventalength = secventaintro.Replace(",", "");
            int n = secventalength.Length; // aici nu este necesar o lungime introdusa, fiindca numerele din sir sunt de maxim 1 cifra.
            if (secventa.Contains(';'))
            {
                secventalength = secventaintro.Replace(";", "");
                n = secventalength.Length;
            }           
            try
            {
                for (int i = 0; i < n; i++) // sa verificam daca secventa introdusa este formada doar din 0-uri sau 1-uri
                {
                    int a;
                    a = int.Parse(secventa.Split(separator)[i]);
                    if (a != 0 && a != 1)
                    {
                        Console.WriteLine("Secventa introdusa este incorecta, trebuia sa contina doar 0 sau 1!");
                        return;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    int a;
                    a = int.Parse(secventa.Split(separator)[i]);
                    if ( i == 0 )
                    {
                        if ( a == 1 )
                        {
                            Console.WriteLine("Secventa introdusa este incorecta");
                            return;
                        }
                    }
                    if ( a == 0 )
                    {
                        countst++;
                        incuibaux1++;
                    }
                    if ( a == 1 )
                    {
                        countf++;
                        incuibaux1--;
                    }
                    if (incuibaux1 > 0 && a == 0 )
                    {
                        incuib = incuibaux1;
                        if (incuibaux2 < incuib)
                        {
                            incuibaux2 = incuib;
                        }                       
                    }
                    if (incuibaux1 == 0) incuib = 0;
                }
                if (countst != countf)
                {
                    Console.WriteLine("Secventa introdusa este incorecta");
                    return;
                }
                Console.WriteLine($"Secventa introdusa este corecta si are nivelul maxim de incuibare {incuibaux2}"); // - 1 pentru ca nivel 1 = 1 paranteza intr-o paranteza prin interpretarea mea.
                return;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
        }
        /// <summary>
        /// secventa bitonica rotita
        /// </summary>
        private static void P16()
        {
            Console.WriteLine("ex 16:\n   Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita.");
            Console.WriteLine("\nIntroduceti lungimea (n) al secventei: ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            string secventaintro = Console.ReadLine();
            string secventa = secventaintro.Replace(" ", "");
            int maxval = int.MinValue;
            int minval = int.MaxValue;
            int maxseqvalue = 0, minseqvalue = 0;
            char separator = ',';
            if (secventa.Contains(';'))
            {
                separator = ';';
            }
            try
            {
                for (int j = 0; j < n; j++) // pentru a afla cele doua puncte care determina monotonia
                {
                    int a;
                    a = int.Parse(secventa.Split(separator)[j]);
                    if (j == 0)
                    {
                        maxval = a;
                        minval = a;
                    }
                    if (j > 0)
                    {
                        if (maxval < a)
                        {
                            maxval = a;
                            maxseqvalue = j;
                        }
                        if (minval > a)
                        {
                            minval = a;
                            minseqvalue = j;
                        }
                    }
                }
                if (minseqvalue < maxseqvalue)
                {
                    for (int i = minseqvalue; i < maxseqvalue - 1; i++)
                    {
                        int a, b;
                        a = int.Parse(secventa.Split(separator)[i]);
                        b = int.Parse(secventa.Split(separator)[i + 1]);
                        if (a > b)
                        {
                            Console.WriteLine("Secventa nu este o secventa bitonica rotita.");
                            return;
                        }
                    }
                    for (int i = 0; i < minseqvalue - 1; i++)
                    {
                        int a, b;
                        a = int.Parse(secventa.Split(separator)[i]);
                        b = int.Parse(secventa.Split(separator)[i + 1]);
                        if (a < b)
                        {
                            Console.WriteLine("Secventa nu este o secventa bitonica rotita.");
                            return;
                        }
                    }
                    for (int i = maxseqvalue; i < n - 1; i++)
                    {
                        int a, b;
                        a = int.Parse(secventa.Split(separator)[i]);
                        b = int.Parse(secventa.Split(separator)[i + 1]);
                        if (a < b)
                        {
                            Console.WriteLine("Secventa nu este o secventa bitonica rotita.");
                            return;
                        }
                    }
                    if (int.Parse(secventa.Split(separator)[0]) > int.Parse(secventa.Split(separator)[n - 1])) // continuitate la extremitati
                    {
                        Console.WriteLine("Secventa nu este o secventa bitonica rotita.");
                        return;
                    }
                }
                if (maxseqvalue < minseqvalue) // invers cu monotonia, intre cele 2 maxima descreste, si creste la extremitati
                {
                    for (int i = maxseqvalue; i < minseqvalue - 1; i++)
                    {
                        int a, b;
                        a = int.Parse(secventa.Split(separator)[i]);
                        b = int.Parse(secventa.Split(separator)[i + 1]);
                        if (a < b)
                        {
                            Console.WriteLine("Secventa nu este o secventa bitonica rotita.");
                            return;
                        }
                    }
                    for (int i = 0; i < maxseqvalue - 1; i++)
                    {
                        int a, b;
                        a = int.Parse(secventa.Split(separator)[i]);
                        b = int.Parse(secventa.Split(separator)[i + 1]);
                        if (a > b)
                        {
                            Console.WriteLine("Secventa nu este o secventa bitonica rotita.");
                            return;
                        }
                    }
                    for (int i = minseqvalue; i < n - 1; i++)
                    {
                        int a, b;
                        a = int.Parse(secventa.Split(separator)[i]);
                        b = int.Parse(secventa.Split(separator)[i + 1]);
                        if (a > b)
                        {
                            Console.WriteLine("Secventa nu este o secventa bitonica rotita.");
                            return;
                        }
                    }
                    if (int.Parse(secventa.Split(separator)[0]) < int.Parse(secventa.Split(separator)[n - 1])) // continuitate la extremitati
                    {
                        Console.WriteLine("Secventa nu este o secventa bitonica rotita.");
                        return;
                    }
                }
                Console.WriteLine("Secventa este o secventa bitonica rotita."); // chiar sper ca functioneaza cum trebuie, astea bitonice sunt greu de interpretat
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
        }
        /// <summary>
        /// secventa bitonica
        /// </summary>
        private static void P15()
        {
            Console.WriteLine("ex 15:\n   Se da o secventa de n numere. Sa se determine daca este bitonica. ");
            Console.WriteLine("\nIntroduceti lungimea (n) al secventei: ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            string secventaintro = Console.ReadLine();
            string secventa = secventaintro.Replace(" ", "");
            int countcresc = 0, countdescresc = 0;
            char separator = ',';
            if (secventa.Contains(';'))
            {
                separator = ';';
            }
            try
            {
                for (int i = 0; i < n - 1; i++)
                {
                    int a, b;
                    a = int.Parse(secventa.Split(separator)[i]);
                    b = int.Parse(secventa.Split(separator)[i + 1]);
                    if (countcresc < 1) // secventa bitonica prima data creste, si inca nu a crescut
                    {
                        if (a > b)
                        {
                            Console.WriteLine("Secventa nu este bitonica.");
                            return;
                        }
                        else countcresc++;
                    }
                    if (a < b) countcresc++; 
                    if (a > b) countdescresc++;  // inreg prima descrestere
                    if (countdescresc > 1) // dupa ce a descrescut nu mai are voie sa creasca.
                    {
                        if (a < b)
                        {
                            Console.WriteLine("Secventa nu este bitonica.");
                            return;
                        }
                    }                  
                }
                if (countcresc < 1 || countdescresc < 1) // inseamna ca ii crescatoare / descrescatoare 
                {
                    Console.WriteLine("Secventa nu este bitonica.");
                    return;
                }
                Console.WriteLine("Secventa este bitonica.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
        }
        /// <summary>
        /// secventa monotona rotita
        /// </summary>
        private static void P14()
        {
            Console.WriteLine("ex 14:\n   Determinati daca o secventa de n numere este o secventa monotona rotita. ");
            Console.WriteLine("\nIntroduceti lungimea (n) al secventei: ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            string secventaintro = Console.ReadLine();
            string secventa = secventaintro.Replace(" ", "");
            int countcresc = 0, countdesc = 0;
            int minvalue = int.MaxValue; // n-are importanta dar nu ma lasa sa ii schimb valoare in functia if
            int seqvalue = 0;
            char separator = ',';
            if (secventa.Contains(';'))
            {
                separator = ';';
            }
            try
            {
                for (int i = 0; i < n; i++)
                {
                    int a;
                    a = int.Parse(secventa.Split(separator)[i]);
                    if (i == 0)
                    {
                        minvalue = a;
                    }
                    if (i > 0)
                    {
                        if (minvalue > a)
                        {
                            minvalue = a;
                            seqvalue = i;
                        }
                    }
                }
                int rotire = 0;
                int desc = 0;
                if (seqvalue != 0 && seqvalue != (n - 1))
                {
                    rotire = 1;
                    if (int.Parse(secventa.Split(separator)[seqvalue - 1]) < int.Parse(secventa.Split(separator)[seqvalue + 1])) // verificam la punctul de rotire monotonia secventei.
                    {
                        seqvalue += 1; // ca sa comparam numerele din sir de la cel mai mare la cel mai mic ( seqvalue este locul unde gasim cel mai mic nr )
                        desc = 1; // ca sa stim daca este descrescatoare

                    }
                }
                for (int j = seqvalue; j < n - 1; j++)
                {
                    int a, b;
                    a = int.Parse(secventa.Split(separator)[j]);
                    b = int.Parse(secventa.Split(separator)[j + 1]);
                    if (a <= b) countcresc++;
                    if (a >= b) countdesc++;
                    if (countcresc > 0 && countdesc > 0)
                    {
                        Console.WriteLine("Secventa nu este o secventa monotona rotita.");
                        return;
                    }
                }
                if (seqvalue != 0 && seqvalue != (n - 1))
                {
                    for (int j = 0; j < seqvalue - 1; j++)
                    {                       
                        int a, b;
                        a = int.Parse(secventa.Split(separator)[j]);
                        b = int.Parse(secventa.Split(separator)[j + 1]);
                        if (a <= b) countcresc++;
                        if (a >= b) countdesc++;
                        if (countcresc > 0 && countdesc > 0)
                        {
                            Console.WriteLine("Secventa nu este o secventa monotona rotita.");
                            return;
                        }
                    }
                }
                if (rotire == 1) // daca sirul trebuie rotit trebuie comparat primul cu ultimul numar din sir pentru continuitate.
                {
                    if (desc == 1) // daca e descrescator sirul 
                    {
                        if (int.Parse(secventa.Split(separator)[0]) < int.Parse(secventa.Split(separator)[n - 1]))
                        {
                            Console.WriteLine("Secventa este o secventa monotona rotita.");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Secventa nu este o secventa monotona rotita.");
                            return;
                        }
                    }
                    if (int.Parse(secventa.Split(separator)[0]) < int.Parse(secventa.Split(separator)[n - 1]))
                    {
                        Console.WriteLine("Secventa nu este o secventa monotona rotita.");
                        return;
                    }
                }
                Console.WriteLine("Secventa este o secventa monotona rotita.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
        }
        /// <summary>
        /// secventa crescatoare rotita
        /// </summary>
        private static void P13()
        {
            Console.WriteLine("ex 13:\n   Determinati daca o secventa de n numere este o secventa crescatoare rotita. ");
            Console.WriteLine("\nIntroduceti lungimea (n) al secventei: ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            string secventaintro = Console.ReadLine();
            string secventa = secventaintro.Replace(" ", "");
            int countcresc = 0;
            int minvalue = int.MaxValue; // n-are importanta, trebuie sa aiba o valoare predefinita.
            int seqvalue = 0;
            char separator = ',';
            if (secventa.Contains(';'))
            {
                separator = ';';
            }
            try
            {
                for (int i = 0; i < n; i++) // gasirea numarului la care se va roti
                {
                    int b;
                    b = int.Parse(secventa.Split(separator)[i]);
                    if (i == 0)
                    {
                        minvalue = b;
                    }
                    if (i > 0)
                    {
                        if (minvalue > b)
                        {
                            minvalue = b;
                            seqvalue = i;
                        }
                    }
                }
                for (int j = seqvalue; j < n - 1; j++)
                {
                    int a, b;
                    a = int.Parse(secventa.Split(separator)[j]);
                    b = int.Parse(secventa.Split(separator)[j + 1]);
                    if (a > b) countcresc++; // nu este precizat daca trebuie sa fie strict crescatoare ( daca da atunci a >= b )
                    if (countcresc > 0)
                    {
                        Console.WriteLine("Secventa nu este o secventa crescatoare rotita.");
                        return;
                    }
                }
                if (seqvalue != 0)
                {
                    countcresc = 0;
                    for (int j = 0; j < seqvalue - 1; j++)
                    {
                        int a, b;
                        a = int.Parse(secventa.Split(separator)[j]);
                        b = int.Parse(secventa.Split(separator)[j + 1]);
                        if (a > b) countcresc++;
                        if (countcresc > 0)
                        {
                            Console.WriteLine("Secventa nu este o secventa crescatoare rotita.");
                            return;
                        }
                    }
                    if (int.Parse(secventa.Split(separator)[0]) < int.Parse(secventa.Split(separator)[n - 1]))
                    {
                        Console.WriteLine("Secventa nu este o secventa crescatoare rotita.");
                        return;
                    }
                }
                Console.WriteLine("Secventa este o secventa crescatoare rotita.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
        }
        /// <summary>
        /// grupuri de nr consecutive delimitate de 0
        /// </summary>
        private static void P12()
        {
            // interpretarea mea este ca cautam cate numere reale, dintr-un sir A(n) in care numerele A(n) != 0 formeaza grupul, iar 0 delimita grupurile.
            // nu stiu daca numere consecutive inseamna si numere in ordine crescatoare
            Console.WriteLine("ex 12:\n   Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. \n   Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.");
            Console.WriteLine("\nIntroduceti lungimea (n) al secventei: ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            string secventaintro = Console.ReadLine();
            string secventa = secventaintro.Replace(" ", "");
            int countegal = 0, countgrup = 1;
            char separator = ',';
            if (secventa.Contains(';'))
            {
                separator = ';';
            }
            try
            {
                for (int i = 0; i < n - 1; i++)
                {
                    int a;
                    a = int.Parse(secventa.Split(separator)[i]);
                    if (a != 0)
                    {
                        countegal++;
                    }
                    if (a == 0 && countegal != 0)
                    {
                        if (int.Parse(secventa.Split(separator)[i + 1]) != 0)
                        {
                            countgrup++;
                            countegal = 0;
                        }
                    }                    
                }
                if ( countgrup == 1 && int.Parse(secventa.Split(separator)[0]) != 0 ) countgrup = 0;
                Console.WriteLine($"Secventa contine {countgrup} grupuri de numere consecutive diferite de zero");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
        }
        /// <summary>
        /// suma inverselor ale numerelor dintr-o secventa
        /// </summary>
        private static void P11()
        {
            Console.WriteLine("ex 11:\n   Se da o secventa de n numere. Se cere sa se calculeze suma inverselor acestor numere.");
            Console.WriteLine("\nIntroduceti lungimea (n) al secventei: ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            string secventaintro = Console.ReadLine();
            string secventa = secventaintro.Replace(" ", "");
            long suma = 0;
            char separator = ',';
            if (secventa.Contains(';'))
            {
                separator = ';';
            }
            try
            {
                for (int i = 0; i < n; i++)
                {
                    int a, inv = 0;
                    a = int.Parse(secventa.Split(separator)[i]);
                    while (a != 0)
                    {
                        inv = inv * 10 + a % 10;
                        a /= 10;                        
                    }
                    suma += inv;
                }
                Console.WriteLine($"Suma inverselor numerelor din secventa este: {suma}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
        }
        /// <summary>
        /// nr consecutive egale
        /// </summary>
        private static void P10()
        {  
            Console.WriteLine("ex 10:\n   Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa.");
            Console.WriteLine("\nIntroduceti lungimea (n) al secventei: ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            string secventaintro = Console.ReadLine();
            string secventa = secventaintro.Replace(" ", "");
            int countegal = 0, countmax = 0, countmaxaux = 0;
            char separator = ',';
            if (secventa.Contains(';'))
            {
                separator = ';';
            }
            try
            {
                for (int i = 0; i < n - 1; i++)
                {
                    int a, b;
                    a = int.Parse(secventa.Split(separator)[i]);
                    b = int.Parse(secventa.Split(separator)[i + 1]);
                    if (a == b)
                    {
                        countegal++;
                        countmax = countegal;
                        if (countmaxaux < countmax)
                        {
                            countmaxaux = countmax;
                        }                      
                    }
                    if (a != b) countegal = 0;                   
                }
                Console.WriteLine($"Secventa contine maxim {countmaxaux + 1} numere consecutive egale.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
        }
        /// <summary>
        /// monotonia secventei
        /// </summary>
        private static void P9()
        {
            Console.WriteLine("ex 9:\n   Sa se determine daca o secventa de n numere este monotona.");
            Console.WriteLine("\nIntroduceti lungimea (n) al secventei: ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            string secventaintro = Console.ReadLine();
            string secventa = secventaintro.Replace(" ", "");
            int countcresc = 0, countdescresc = 0;
            char separator = ',';
            if (secventa.Contains(';'))
            {
                separator = ';';
            }
            try
            {
                for (int i = 0; i < n - 1; i++)
                {
                    int a, b;
                    a = int.Parse(secventa.Split(separator)[i]);
                    b = int.Parse(secventa.Split(separator)[i + 1]);
                    if (a > b) countdescresc++; // nu este precizat strict monotonia, pentru strict a >= b 
                    if (a < b) countcresc++; //                                                     sau aici a <= b
                    if (countdescresc > 0 && countcresc > 0)
                    {
                        Console.WriteLine("Secventa nu este monotona.");
                        return;
                    }                  
                }
                Console.WriteLine("Secventa este monotona.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
        }
        /// <summary>
        /// Fibonacci calculator
        /// </summary>
        private static void P8()
        {
            Console.WriteLine("ex 8:\n   Determianti al n-lea numar din sirul lui Fibonacci.\n   Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2).");
            int nr0 = 0;
            int nr1 = 1;
            int nr = 1;
            Console.WriteLine("\nIntroduceti n : ");
            uint n = N_CHECK();
            if (n == 0) return;
            if (n == 1)
            {
                Console.WriteLine("Primul termen din sirul lui fibonacci este 0.");
                return;
            }
            if (n == 2)
            {
                Console.WriteLine("Al 2=lea termen din sirul lui fibonacci este 1.");
                return;
            }
            for (uint i = 3; i <= n; i++) 
            {
                nr = nr0 + nr1;
                nr0 = nr1;
                nr1 = nr;                
               // Console.WriteLine($"\n{nr}");
            }
            Console.WriteLine($"\nAl {n}-lea termen din sirul lui Fibonacci este: {nr}");

        }
        /// <summary>
        /// Valoare minima si maxima dintr-o secventa
        /// </summary>
        private static void P7()
        {
            Console.WriteLine("ex 7:\n   Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. ");
            Console.WriteLine("\nIntroduceti lungimea (n) al secventei: ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            string secventaintro = Console.ReadLine();
            string secventa = secventaintro.Replace(" ", "");
            int min = Int32.MinValue, max = Int32.MaxValue;
            char separator = ',';
            if (secventa.Contains(';'))
            {
                separator = ';';
            }
            try
            {
                for (int i = 0; i < n; i++)
                {
                    int a, b;
                    a = int.Parse(secventa.Split(separator)[i]);
                    b = int.Parse(secventa.Split(separator)[i]);
                    //Console.WriteLine(prevnr);
                    if (i == 0)
                    {
                        max = a;
                        min = b;
                    }
                    if (i > 0)
                    {
                        if ( max < a )
                        {
                            max = a;
                        }
                        if ( min > b )
                        {
                            min = b;
                        }
                    }                                           
                    //Console.WriteLine(a);                  
                }
                Console.WriteLine($"\nValoarea minima din secventa este {min} iar valoarea maxima este {max}.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
        }
        /// <summary>
        /// Test ordine crescatoare
        /// </summary>
        private static void P6()
        {
            Console.WriteLine("ex 6:\n   Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.");
            Console.WriteLine("\nIntroduceti lungimea (n) al secventei: ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            string secventaintro = Console.ReadLine();
            string secventa = secventaintro.Replace(" ", "");
            // int count = 0;
            char separator = ',';
            if (secventa.Contains(';'))
            {
                separator = ';';
            }
            try
            {
                for (int i = 0; i < n; i++)
                {
                    int a, prevnr;
                    a = int.Parse(secventa.Split(separator)[i]);
                    //Console.WriteLine(prevnr);
                    if ( i > 0 )
                    {                        
                        prevnr = int.Parse(secventa.Split(separator)[i-1]);
                        if (prevnr > a)
                        {
                            Console.WriteLine("\nNumerele din secventa nu sunt in ordine crescatoare");
                            return;
                        }                      
                    }                 
                    //Console.WriteLine(a);                  
                }
                Console.WriteLine("\nNumerele din secventa sunt in ordine crescatoare");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
        }
        /// <summary>
        /// Test egalitate numar si pozitie in secventa
        /// </summary>
        private static void P5()
        {
            Console.WriteLine("ex 5:\n   Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. \n   Se considera ca primul element din secventa este pe pozitia 0. ");
            Console.WriteLine("\nIntroduceti lungimea (n) al secventei: ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            string secventaintro = Console.ReadLine();
            string secventa = secventaintro.Replace(" ", "");
            int count = 0;
            char separator = ',';
            if (secventa.Contains(';'))
            {
                separator = ';';
            }
            try
            {
                for (int i = 0; i < n; i++)
                {
                    int a;
                    a = int.Parse(secventa.Split(separator)[i]);
                    if (a == i) count++;
                    //Console.WriteLine(a);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
            Console.WriteLine($"In aceasta secventa sunt {count} numere egale cu pozitia lor in secventa");
        }
        /// <summary>
        /// Pozitia unui numar 'a' dintr-o secventa de n numere.
        /// </summary>
        private static void P4()
        {
            Console.WriteLine("ex 4:\n   Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numar 'a'.");
            Console.WriteLine("\nIntroduceti lungimea (n) al secventei: ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            string secventaintro = Console.ReadLine();
            string secventa = secventaintro.Replace(" ", "");
            int a;
            Console.WriteLine("\nIntroduceti numarul 'a' pe care vreti sa il gasiti in secventa: ");
            var aAsString = Console.ReadLine();
            while (!int.TryParse(aAsString, out a))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                Console.WriteLine();
                Console.Write("a = ");
                aAsString = Console.ReadLine();
            }
            Console.Write($"\nNumarul 'a' din secventa introdusa se afla in pozitia:");
            int count = 0;
            char separator = ',';
            if (secventa.Contains(';'))
            {
                separator = ';';
            }
            try
            {
                for (int i = 0; i < n; i++)
                {
                    int x;
                    x = int.Parse(secventa.Split(separator)[i]);
                    if (x == a)
                    {
                        Console.Write($" {i + 1} ");
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.Write($"-1 ( nu exista in secventa )");
                }

            }          
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
        }
        /// <summary>
        /// Suma si produsul primelor N numere
        /// </summary>
        private static void P3()
        {
            Console.WriteLine("ex 3:\n   Calculati suma si produsul numerelor de la 1 la n.");
            Console.WriteLine("\nIntroduceti 'n' : ");
            ulong n = ulong.Parse(Convert.ToString(N_CHECK()));
            if (n == 0) return;
            if (n < 1)
            {
                Console.WriteLine("'n' trebuie sa fie mai mare decat 1 ca operatia sa aiba sens!!!"); // serios cine nu citeste indicatia
                return;
            }
            ulong suma; // precizie pana la n = 2^33-1
            double produs = 1; // foarte mare cand n > 20
            try
            {
                checked
                {
                    if (n % 2 == 0)
                    {
                        suma = n / 2 * (n + 1);
                    }
                    else suma = ( (n + 1) / 2 ) * n;
                }
                if (n > 170) // la 171 deja are overflow peste limita de double // precis fara punct zecimal pana la n < 18
                {
                    Console.WriteLine($"Pentru numerele de la 1 la {n}:\nSuma lor este: {suma}\nProdusul lor este prea mare sa poata fi calculat ( peste 20 de cifre lung ).");
                    return;
                }
                else
                {
                    for (double i = 2; i <= n; i++)
                    {
                        produs *= i;
                        
                    }
                }
                Console.WriteLine($"Pentru numerele de la 1 la {n}:\nSuma lor este: {suma}\nProdusul lor este: {produs}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Numarul introdus este prea mare pentru a putea fi calculat!!!");
            }

        }
        /// <summary>
        /// Secventa in care se gasesc numere pozitive, negative si 0.
        /// </summary>
        private static void P2()
        {
            Console.WriteLine("ex 2:\n   Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. ");
            Console.WriteLine("\nIntroduceti lungimea (n) al secventei: ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            string secventaintro = Console.ReadLine();
            string secventa = secventaintro.Replace(" ","");
            // Console.WriteLine(secventa);
            int countneg = 0;
            int countzero = 0;
            int countpos = 0;
            char separator = ',';
            if (secventa.Contains(';'))
            {
                separator = ';';
            }
            try
            {
                for (int i = 0; i < n; i++)
                {
                    int a;
                    a = int.Parse(secventa.Split(separator)[i]);
                    if (a < 0 ) countneg++;
                    //Console.WriteLine(a);
                    if (a == 0) countzero++;
                    if (a > 1) countpos++;
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
            Console.Write($"\nIn secventa ");
            if (countpos == 0) Console.Write("nu este nici un numar pozitiv,");
            if (countpos == 1) Console.Write("este 1 numar pozitiv,");
            if (countpos > 1) Console.Write($"sunt {countpos} numere pozitive,");
            if (countzero == 0) Console.Write(" nu este nici un zero,");
            if (countzero == 1) Console.Write(" este 1 zero,");
            if (countzero > 1) Console.Write($" sunt {countzero} zerouri,");
            if (countneg == 0) Console.Write(" nu este nici un numar negativ.");
            if (countneg == 1) Console.Write(" este 1 numar negativ.");
            if (countneg > 1) Console.Write($" sunt {countneg} numere negative.");
        }
        /// <summary>
        /// Secventa in care se gasesc nr pare.
        /// </summary>
        private static void P1()
        {
            Console.WriteLine("ex 1:\n   Se da o secventa de n numere. Sa se determine cate din ele sunt pare.");

            /* // metoda tablou in care nu este necesar sa declaram lungimea secventei de numere inainte sa introducem secventa de numere
            int count = 0;
            string myString = Console.ReadLine();
            char[] chars = { ',', ' ', ';' };
            string[] numbers = myString.Split(chars, StringSplitOptions.RemoveEmptyEntries);
            int[] secventa = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                secventa[i] = int.Parse(numbers[i]);
            }
            for(int i = 0; i < secventa.Length; i++)
            {
                if (secventa[i] % 2 == 0)
                {
                    count++;
                }
            }
            */
            // metoda fara tablou ( sper ca split-ul temporar nu se considera tablou, altfel nu stiu cum s-ar putea cu o secventa de tip: 1,2,3,4,5 )
            Console.WriteLine("\nIntroduceti lungimea (n) al secventei: ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            string secventaintro = Console.ReadLine();
            string secventa = secventaintro.Replace(" ", "");
            int count = 0;
            char separator = ',';
            if (secventa.Contains(';'))
            {
                separator = ';';
            }
            try
            {
                for (int i = 0; i < n; i++)
                {
                    int a;
                    a = int.Parse(secventa.Split(separator)[i]);
                    if (a % 2 == 0) count++;
                    //Console.WriteLine(a);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }           
            catch (OverflowException)
            {                
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;              
            }
            Console.WriteLine($"In secventa sunt {count} numere pare.");            
        }
        private static void MENU()
        {
            Console.Clear();
            Console.WriteLine("SET 2 de exercitii:");
            Console.WriteLine("1. Se da o secventa de n numere. Sa se determine cate din ele sunt pare.");
            Console.WriteLine("2. Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. ");
            Console.WriteLine("3. Calculati suma si produsul numerelor de la 1 la n. ");
            Console.WriteLine("4. Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numar 'a'. \n   Se considera ca primul element din secventa este pe pozitia zero. \n   Daca numarul nu se afla in secventa raspunsul va fi -1. ");
            Console.WriteLine("5. Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. \n   Se considera ca primul element din secventa este pe pozitia 0. ");
            Console.WriteLine("6. Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.");
            Console.WriteLine("7. Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. ");
            Console.WriteLine("8. Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: \n   f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2).");
            Console.WriteLine("9. Sa se determine daca o secventa de n numere este monotona.");
            Console.WriteLine("10. Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa.");
            Console.WriteLine("11. Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere.");
            Console.WriteLine("12. Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. \n    Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.");
            Console.WriteLine("13. Determinati daca o secventa de n numere este o secventa crescatoare rotita. ");
            Console.WriteLine("14. Determinati daca o secventa de n numere este o secventa monotona rotita. ");
            Console.WriteLine("15. Se da o secventa de n numere. Sa se determine daca este bitonica. ");
            Console.WriteLine("16. Se cere sa se determine daca este o secventa bitonica rotita. ");
            Console.WriteLine("17. Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. \n    Determinati daca secventa reprezinta o secventa de paranteze corecta si,\n    daca este, determinati nivelul maxim de incuibare a parantezelor.");
            Console.WriteLine();

            Console.Write("Introduceti un numar de la 1 la 17 sau 'exit' pentru a iesi din aplicatie: ");
        }
        private static void Finish()
        {
            Console.WriteLine();
            Console.WriteLine("Pentru a reveni la meniul de selectie apasati orice buton.");
            Console.ReadKey();
            return;
        }
        private static void Start()
        {
            Console.Clear();
        }
        /// <summary>
        /// mesaj de instructie
        /// </summary>
        private static void SEQ_i()
        {
            Console.WriteLine("PENTRU INTRODUCEREA SECVENTEI DE NUMERE SE FOLOSESTE ',' SAU ';' INTRE NUMERE!"); // e important pentru ca spatiile libere sunt eliminate din stringul de introducere, si este mult mai usor de observat si scris o secventa cu caractere de delimitare, mai ales cand ii foarte lung.
        }
        /// <summary>
        /// Validare de date pentru lungimea secventei
        /// </summary>
        /// <returns>lungimea secventei</returns>
        private static uint N_CHECK()
        {
            uint n;
            var nAsString = Console.ReadLine();
            while (!uint.TryParse(nAsString, out n))
            {
                Console.WriteLine("Trebuie sa introduci un numar pozitiv! Incearca din nou!");
                Console.WriteLine();
                Console.Write("n = ");
                nAsString = Console.ReadLine();
            }
            if (n == 0)
            {
                Console.WriteLine("O secventa de 0 numere nu exista!!!");               
            }
            return n;
        }              
    }    
} 
