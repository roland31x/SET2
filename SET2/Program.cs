using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
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
            throw new NotImplementedException();
        }
        private static void P16()
        {
            throw new NotImplementedException();
        }
        private static void P15()
        {
            throw new NotImplementedException();
        }
        private static void P14()
        {
            throw new NotImplementedException();
        }
        private static void P13()
        {
            throw new NotImplementedException();
        }
        private static void P12()
        {
            throw new NotImplementedException();
        }
        private static void P11()
        {
            throw new NotImplementedException();
        }
        private static void P10()
        {
            throw new NotImplementedException();
        }
        private static void P9()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Fibonacci calculator
        /// </summary>
        private static void P8()
        {
        throw new NotImplementedException();
        }
        private static void P7()
        {
            Console.WriteLine("ex 7. Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. ");
            Console.WriteLine("\nIntroduceti lungimea (n) al secventei: ");
            uint n = N_CHECK();
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
            Console.WriteLine("ex 6. Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.");
            Console.WriteLine("\nIntroduceti lungimea (n) al secventei: ");
            uint n = N_CHECK();
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
            Console.WriteLine("5. Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. \n   Se considera ca primul element din secventa este pe pozitia 0. ");
            Console.WriteLine("\nIntroduceti lungimea (n) al secventei: ");
            uint n = N_CHECK();
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
            Console.WriteLine("4. Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numar 'a'.");
            Console.WriteLine("\nIntroduceti lungimea (n) al secventei: ");
            uint n = N_CHECK();
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
                        Console.Write($"{i} ");
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
            Console.WriteLine("ex 3. Calculati suma si produsul numerelor de la 1 la n.");
            Console.WriteLine("\nIntroduceti 'n' : ");
            ulong n = ulong.Parse(Convert.ToString(N_CHECK()));
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
            Console.WriteLine("ex 2. Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. ");
            Console.WriteLine("\nIntroduceti lungimea (n) al secventei: ");
            uint n = N_CHECK();
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
            Console.WriteLine("ex 1. Se da o secventa de n numere. Sa se determine cate din ele sunt pare.");

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
            // metoda fara tablou ( sper ca split-ul temporar nu se considera tablou )
            Console.WriteLine("\nIntroduceti lungimea (n) al secventei: ");
            uint n = N_CHECK();
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
            Console.WriteLine("8. Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2).");
            Console.WriteLine("9. Sa se determine daca o secventa de n numere este monotona.");
            Console.WriteLine("10. Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa.");
            Console.WriteLine("11. Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere.");
            Console.WriteLine("12. Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. \n    Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.");
            Console.WriteLine("13. Determinati daca o secventa de n numere este o secventa crescatoare rotita. ");
            Console.WriteLine("14. Determinati daca o secventa de n numere este o secventa monotona rotita. ");
            Console.WriteLine("15. Se da o secventa de n numere. Sa se determine daca este bitonica. ");
            Console.WriteLine("16. Se cere sa se determine daca este o secventa bitonica rotita. ");
            Console.WriteLine("17. Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. \n    Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor.");
            Console.WriteLine();

            Console.Write("Introduceti un numar de la 1 la 17 sau 'exit' pentru a iesi din aplicatie: ");
        }
        private static void Finish()
        {
            Console.WriteLine();
            Console.WriteLine("Pentru a reveni la meniul de selectie apasati orice buton.");
            Console.ReadKey();
        }
        private static void Start()
        {
            Console.Clear();
        }
        private static void SEQ_i()
        {
            Console.WriteLine("PENTRU INTRODUCEREA SECVENTEI DE NUMERE SE FOLOSESTE ',' SAU ';' INTRE NUMERE!"); // e important pentru ca spatiile libere sunt eliminate din stringul de introducere, si este mult mai usor de observat si scris o secventa cu caractere de delimitare, mai ales cand ii foarte lung.
        }
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
                Console.WriteLine("O secventa de 0 numere este nula!!!");
                Finish();
            }
            return n;
        }
    }    
} 
