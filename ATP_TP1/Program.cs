using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATP_TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int op = 0;

            while (op != 7)
            {
                Console.WriteLine("Pontifícia Universidade Católica - São Gabriel\nAlgoritmos e Técnicas de Programação\nAlex Junio Rodrigues\n\n");
                Console.WriteLine("Pressione:\n\t1 DEC->HEX\n\t2 HEX->DEC\n\t3 DEC->BIN\n\t4 BIN->DEC\n\t5 DEC->OCT\n\t6 OCT->DEC\n\t7 para sair andando");
                op = int.Parse(Console.ReadLine());
                int valor = 0;
                int i = 0;
                string resultadoString = "";
                double resultadoNum=0;
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Digite um valor a ser convertido de decimal para hexadecimal");
                        valor = int.Parse(Console.ReadLine());
                        resultadoString = "";

                        if (valor > 0)
                        {
                            int hex = valor;
                            while (valor > 0)
                            {
                                hex = valor % 16;
                                resultadoString = ConverteDecHex(hex) + resultadoString;
                                valor = valor / 16;
                            }
                        }
                        else
                        {
                            resultadoString = "0";
                        }
                        Console.Write(resultadoString);
                        break;
                    case 2:
                        Console.WriteLine("Digite um valor a ser convertido de hexa para decimal");
                        string valorHex = Console.ReadLine();

                        char[] vetHexChar = valorHex.ToCharArray();

                        resultadoNum = 0;
                        i = 0;

                        while (i < vetHexChar.Length)
                        {
                            int expoente = vetHexChar.Length - 1 - i;
                            double resultadoParcial = ConverteHexDec(vetHexChar[i].ToString()) * Math.Pow(16, expoente);
                            resultadoNum = resultadoNum + resultadoParcial;
                            i++;
                        }
                        Console.Write(resultadoNum);
                        break;
                    case 3:
                        Console.WriteLine("Digite um valor a ser convertido de decimal para binario");
                        valor = int.Parse(Console.ReadLine());
                        resultadoString = "";

                        if (valor > 0)
                        {
                            int bin = valor;
                            while (valor > 0)
                            {
                                bin = valor % 2;
                                resultadoString = bin + resultadoString;
                                valor = valor / 2;
                            }
                        }
                        else
                        {
                            resultadoString = "0";
                        }
                        Console.Write(resultadoString);
                        break;
                    case 4:
                        Console.WriteLine("Digite um valor a ser convertido de binario para decimal");
                        valor = int.Parse(Console.ReadLine());
                        resultadoNum = 0;
                        char[] vetBinChar = valor.ToString().ToCharArray();
                        i = 0;

                        while (i < vetBinChar.Length)
                        {
                            int expoente = vetBinChar.Length - 1 - i;
                            double resultadoParcial = int.Parse(vetBinChar[i].ToString()) * Math.Pow(2, expoente);
                            resultadoNum = resultadoNum + resultadoParcial;
                            i++;
                        }
                        Console.Write(resultadoNum);
                        break;
                    case 5:
                        Console.WriteLine("Digite um valor a ser convertido de decimal para octal");
                        valor = int.Parse(Console.ReadLine());
                        resultadoString = "";
                        if (valor > 0)
                        {
                            int bin = valor;
                            while (valor > 0)
                            {
                                bin = valor % 8;
                                resultadoString = bin + resultadoString;
                                valor = valor / 8;
                            }
                        }
                        else
                        {
                            resultadoString = "0";
                        }
                        Console.Write(resultadoString);
                        break;
                    case 6:
                        Console.WriteLine("Digite um valor a ser convertido de octal para decimal");
                        valor = int.Parse(Console.ReadLine());
                         resultadoNum = 0;
                        char[] vetOctChar = valor.ToString().ToCharArray();
                        i = 0;

                        while (i < vetOctChar.Length)
                        {
                            int expoente = vetOctChar.Length - 1 - i;
                            double resultadoParcial = int.Parse(vetOctChar[i].ToString()) * Math.Pow(8, expoente);
                            resultadoNum = resultadoNum + resultadoParcial;
                            i++;
                        }
                        Console.Write(resultadoNum);
                        break;
                    case 7:
                        Console.WriteLine("vaza");
                        break;
                    default:
                        Console.WriteLine("Opçao Inválida");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static string ConverteDecHex(int hex)
        {
            string resultado;
            switch (hex)
            {
                case (10):
                    resultado = "A";
                    break;
                case (11):
                    resultado = "B";
                    break;
                case (12):
                    resultado = "C";
                    break;
                case (13):
                    resultado = "D";
                    break;
                case (14):
                    resultado = "E";
                    break;
                case (15):
                    resultado = "F";
                    break;
                default:
                    resultado = hex.ToString();
                    break;

            }
            return resultado;
        }
        public static int ConverteHexDec(string hex)
        {
            int resultado;
            switch (hex)
            {
                case ("A"):
                    resultado = 10;
                    break;
                case ("B"):
                    resultado = 11;
                    break;
                case ("C"):
                    resultado = 12;
                    break;
                case ("D"):
                    resultado = 13;
                    break;
                case ("E"):
                    resultado = 14;
                    break;
                case ("F"):
                    resultado = 15;
                    break;
                default:
                    resultado = int.Parse(hex);
                    break;

            }
            return resultado;
        }
    }
}
