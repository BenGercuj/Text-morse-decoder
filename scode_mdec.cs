using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARDMorseDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = ".-";    
            string B = "-...";  
            string C = "-.-.";  
            string D = "-..";   
            string E = ".";     
            string F = "..-.";  
            string G = "--.";   
            string H = "....";  
            string I = "..";    
            string J = ".---";  
            string K = "-.-";   
            string L = ".-..";  
            string M = "--";    
            string N = "-.";    
            string O = "---";   
            string P = ".--.";  
            string Q = "--.-";  
            string R = ".-.";   
            string S = "...";   
            string T = "-";     
            string U = "..-";   
            string V = "...-";  
            string W = ".--";   
            string X = "-..-";  
            string Y = "-.--";  
            string Z = "--..";  

            Console.WriteLine("Insert morse code");
            string msg1 = Console.ReadLine();
            string msg = string.Format("{0}  ", msg1);

            string[] msgarr = new string[msg.Length];

            for (int i = 0; i < msg.Length; i++)
            {
                msgarr[i] = Convert.ToString(msg[i]);
            }

            for (int i = 0; i < msgarr.Length; i++)
            {
                if (msgarr.Length - ((i + 1) + 2) == 0)
                {
                    break;
                }

                else
                {
                    try
                    {
                        bool compl = false;

                        if (msgarr[i] == " ")
                        {
                            //Console.WriteLine("BenGercuj");
                        }

                        if (msgarr[i] + msgarr[i + 1] + msgarr[i + 2] + msgarr[i + 3] == B && compl == false)
                        {
                            Console.Write("B");
                            i++;
                            i++;
                            i++;
                            compl = true;
                        }

                        if (msgarr[i] + msgarr[i + 1] + msgarr[i + 2] + msgarr[i + 3] == C && compl == false)
                        {
                            Console.Write("C");
                            i++;
                            i++;
                            i++;
                            compl = true;
                        }

                        if (msgarr[i] + msgarr[i + 1] + msgarr[i + 2] + msgarr[i + 3] == F && compl == false)
                        {
                            Console.Write("F");
                            i++;
                            i++;
                            i++;
                            compl = true;
                        }

                        if (msgarr[i] + msgarr[i + 1] + msgarr[i + 2] + msgarr[i + 3] == H && compl == false)
                        {
                            Console.Write("H");
                            i++;
                            i++;
                            i++;
                            compl = true;
                        }

                        if (msgarr[i] + msgarr[i + 1] + msgarr[i + 2] + msgarr[i + 3] == J && compl == false)
                        {
                            Console.Write("J");
                            i++;
                            i++;
                            i++;
                            compl = true;
                        }

                        if (msgarr[i] + msgarr[i + 1] + msgarr[i + 2] + msgarr[i + 3] == L && compl == false)
                        {
                            Console.Write("L");
                            i++;
                            i++;
                            i++;
                            compl = true;
                        }

                        if (msgarr[i] + msgarr[i + 1] + msgarr[i + 2] + msgarr[i + 3] == P && compl == false)
                        {
                            Console.Write("P");
                            i++;
                            i++;
                            i++;
                            compl = true;
                        }

                        if (msgarr[i] + msgarr[i + 1] + msgarr[i + 2] + msgarr[i + 3] == Q && compl == false)
                        {
                            Console.Write("Q");
                            i++;
                            i++;
                            i++;
                            compl = true;
                        }

                        if (msgarr[i] + msgarr[i + 1] + msgarr[i + 2] + msgarr[i + 3] == V && compl == false)
                        {
                            Console.Write("V");
                            i++;
                            i++;
                            i++;
                            compl = true;
                        }

                        if (msgarr[i] + msgarr[i + 1] + msgarr[i + 2] + msgarr[i + 3] == X && compl == false)
                        {
                            Console.Write("X");
                            i++;
                            i++;
                            i++;
                            compl = true;
                        }

                        if (msgarr[i] + msgarr[i + 1] + msgarr[i + 2] + msgarr[i + 3] == Y && compl == false)
                        {
                            Console.Write("Y");
                            i++;
                            i++;
                            i++;
                            compl = true;
                        }

                        if (msgarr[i] + msgarr[i + 1] + msgarr[i + 2] + msgarr[i + 3] == Z && compl == false)
                        {
                            Console.Write("Z");
                            i++;
                            i++;
                            i++;
                            compl = true;
                        }

                        if (msgarr[i] + msgarr[i + 1] + msgarr[i + 2] == D && compl == false)
                        {
                            Console.Write("D");
                            i++;
                            i++;
                            compl = true;
                        }

                        if (msgarr[i] + msgarr[i + 1] + msgarr[i + 2] == G && compl == false)
                        {
                            Console.Write("G");
                            i++;
                            i++;
                            compl = true;
                        }

                        if (msgarr[i] + msgarr[i + 1] + msgarr[i + 2] == K && compl == false)
                        {
                            Console.Write("K");
                            i++;
                            i++;
                            compl = true;
                        }

                        if (msgarr[i] + msgarr[i + 1] + msgarr[i + 2] == O && compl == false)
                        {
                            Console.Write("O");
                            i++;
                            i++;
                            compl = true;
                        }

                        if (msgarr[i] + msgarr[i + 1] + msgarr[i + 2] == R && compl == false)
                        {
                            Console.Write("R");
                            i++;
                            i++;
                            compl = true;
                        }

                        if (msgarr[i] + msgarr[i + 1] + msgarr[i + 2] == S && compl == false)
                        {
                            Console.Write("S");
                            i++;
                            i++;
                            compl = true;
                        }

                        if (msgarr[i] + msgarr[i + 1] + msgarr[i + 2] == U && compl == false)
                        {
                            Console.Write("U");
                            i++;
                            i++;
                            compl = true;
                        }

                        if (msgarr[i] + msgarr[i + 1] + msgarr[i + 2] == W && compl == false)
                        {
                            Console.Write("W");
                            i++;
                            i++;
                            compl = true;
                        }

                        if (msgarr[i] + msgarr[i + 1] == A && compl == false)
                        {
                            Console.Write("A");
                            i++;
                            compl = true;
                        }

                        if (msgarr[i] + msgarr[i + 1] == I && compl == false)
                        {
                            Console.Write("I");
                            i++;
                            compl = true;
                        }

                        if (msgarr[i] + msgarr[i + 1] == M && compl == false)
                        {
                            Console.Write("M");
                            i++;
                            compl = true;
                        }

                        if (msgarr[i] + msgarr[i + 1] == N && compl == false)
                        {
                            Console.Write("N");
                            i++;
                            compl = true;
                        }

                        if (msgarr[i] == E && compl == false)
                        {
                            Console.Write("E");
                            compl = true;
                        }

                        if (msgarr[i] == T && compl == false)
                        {
                            Console.Write("T");
                            compl = true;
                        }
                    }
                    catch (IndexOutOfRangeException) { }
                }
            }
            Console.ReadKey();
        }
    }
}
