using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ARDMorseDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = ".-";    //2 ---+
            string B = "-...";  //4 -+
            string C = "-.-.";  //4 -+
            string D = "-..";   //3 --+
            string E = ".";     //1 ----+
            string F = "..-.";  //4 -+
            string G = "--.";   //3 --+
            string H = "....";  //4 -+
            string I = "..";    //2 ---+
            string J = ".---";  //4 -+
            string K = "-.-";   //3 --+
            string L = ".-..";  //4 -+
            string M = "--";    //2 ---+
            string N = "-.";    //2 ---+
            string O = "---";   //3 --+
            string P = ".--.";  //4 -+
            string Q = "--.-";  //4 -+
            string R = ".-.";   //3 --+
            string S = "...";   //3 --+
            string T = "-";     //1 ----+
            string U = "..-";   //3 --+
            string V = "...-";  //4 -+
            string W = ".--";   //3 --+
            string X = "-..-";  //4 -+
            string Y = "-.--";  //4 -+
            string Z = "--..";  //4 -+


            /*
            SerialPort port0 = new SerialPort();
            port0.BaudRate = 9600;
            port0.PortName = "COM5";
            port0.Open();

            string received = "";
            while (true)
            {
                received = port0.ReadLine();
            }
            */

            string msg = ".- -... -... -... .-  "; // = ABBBA
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

                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine();
                        Console.WriteLine("End of message");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
