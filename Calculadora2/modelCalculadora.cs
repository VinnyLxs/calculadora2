using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace calculadora 
{
    class ModelCalculadora
    {
        //Declarando variáveis
        private double num1;
        private double num2;

        public ModelCalculadora()
        {
            GetSetNum1 = 0;
            GetSetNum2 = 0;
        }//fim do construtor

        //Métodos Gets e Sets
        public double GetSetNum1
        {
            get { return this.num1; }
            set { this.num1 = value; }
        }//fim do GetSetNum1

        public double GetSetNum2
        {
            get { return this.num2; }
            set { this.num2 = value; }

        }//fim do GetSetNum2

        //Métodos
        public double Somar()
        {
            return GetSetNum1 + GetSetNum2;
        }//fim do método somar

        public double Subtrair()
        {
            return GetSetNum1 - GetSetNum2;
        }//fim do método subtrair

        public double Dividir()
        {
            if (GetSetNum2 <= 0)
            {
                return -1;
            }
            else
            {
                return GetSetNum1 / GetSetNum2;
            }
        }//fim do método dividir

        public double Multiplicar()
        {
            return GetSetNum1 * GetSetNum2;
        }//fim do método multiplicar

        public double Potencia()
        {
            return Math.Pow(GetSetNum1, GetSetNum2);
        }//fim da potência

        public string Raiz()
        {
            string msg = "Raiz do primeiro número: " + Math.Sqrt(GetSetNum1) +
                         "\nRaiz do segundo número: " + Math.Sqrt(GetSetNum2);
            return msg;
        }//fim do método raiz

        public string TabuadaNum1()
        {
            string resultado = "";

            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n" + GetSetNum1 + " * " + i + " = " + (GetSetNum1 * i);
            }//fim do for

            return resultado;
        }//fim do método

        public string TabuadaNum2()
        {
            string resultado = "";

            //Início;Fim;Contagem
            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n" + GetSetNum2 + " * " + i + " = " + (GetSetNum2 * i);
            }//fim do for

            return resultado;
        }//fim do método Tabuada num2

        public double ConverterDecimal(string binario)
        {
            double dec = 0;
            string caract = "";
            int tamanho = binario.Length;
            int pote = tamanho;
            for (int i = 0; i < tamanho; i++)
            {
                pote--;
                caract = binario.Substring(i, 1);
                if (caract == "1")
                {
                    dec += Math.Pow(2, pote);
                }
            }//fim do for
            return dec;
        }//fim do método converter decimal

        public string ConverterBinario(int dec)
        {
            string binario = "";
            int resto = 0;
            do
            {
                resto = dec % 2;
                binario += resto;
                dec = dec / 2;
            } while (dec != 0);
            return new String(binario.Reverse().ToArray());
        }//fim do método Converter para Binario

        public double ConverterHexaDecimal(string hexadecimal)
        {
            double dec = 0;
            string caract = "";
            int num = 0;
            int tamanho = hexadecimal.Length;
            int pote = tamanho;
            for (int i = 0; i < tamanho; i++)
            {
                pote--;
                caract = hexadecimal.Substring(i, 1);
                switch (caract)
                {
                    case "A":
                        num = 10;
                        break;
                    case "B":
                        num = 11;
                        break;
                    case "C":
                        num = 12;
                        break;
                    case "D":
                        num = 13;
                        break;
                    case "E":
                        num = 14;
                        break;
                    case "F":
                        num = 15;
                        break;
                    default:
                        num = Convert.ToInt32(caract);
                        break;
                }//fim do switch
                dec += num * Math.Pow(16, pote);
            }//fim do for
            return dec;
        }//fim do método converter decimal

        public string ConverterDecimalHexa(int dec)
        {
            int resto = 0;
            string hexadecimal = "";

            do
            {
                resto = dec % 16;
                switch (resto)
                {
                    case 10:
                        hexadecimal += "A";
                        break;
                    case 11:
                        hexadecimal += "B";
                        break;
                    case 12:
                        hexadecimal += "C";
                        break;
                    case 13:
                        hexadecimal += "D";
                        break;
                    case 14:
                        hexadecimal += "E";
                        break;
                    case 15:
                        hexadecimal += "F";
                        break;
                    default:
                        hexadecimal += resto;
                        break;
                }//fim do switch
                dec = dec / 16;
            } while (dec != 0);
            return new string(hexadecimal.Reverse().ToArray());
        }//fim do converter

        public string bhaskara(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta <= 0)
            {
                return "Impossível calcular X1 e X2, Delta: " + delta;
            }
            else
            {
                double X1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double X2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return "Delta: " + delta + "\nX1: " + X1 + "\nX2: " + X2;

            }
        }//fim do bhaskara

        ////Grande parte dos exercicios aprendi pelo youtube com alguns jeitos diferentes de se fazer

        //Exercicio 1

        public (int, int) Exc1(int num)
        {
            int doubleNum = num * 2;
            int tripleNum = num * 3;

            return (doubleNum, tripleNum);
        }//fim do Exercicio 1


        //Exercicio 2
        public double CalcularSalarioComAumento(string input)
        {
            if (double.TryParse(input, out double getsetnum1))
            {
                double trinta = getsetnum1 * 0.3;
                double salarioComAumento = getsetnum1 + trinta;
                return salarioComAumento;
            }
            else
            {
                Console.WriteLine("Valor inválido. Certifique-se de digitar um número válido.");
                return -1; 
            }
        }//fim do Exercicio 2

        //Exercicio 3     
        public string VerificarNumero(int num)
        {
            string result = "O número ";

            if (num > 0)
                result += "é positivo ";
            else if (num < 0)
                result += "é negativo ";
            else
                result += "é zero.";

            if (num % 2 == 0)
                result += "e é par.";
            else
                result += "e é ímpar.";

            return result;
        }// fim do Exercicio 3

        //Exercicio 4
        public int CalcularSoma(int comeco, int fim)
        {
            int soma = 0;
            for (int i = comeco; i <= fim; i++)
            {
                soma += i;
            }
            return soma;
        }// fim do Exercicio 4

        //Exercicio 5
        public string Tabuada1N()
        {
            string resultado = "";

            for (int i = 1; i <= GetSetNum1; i++)
            {
                resultado += "\n" + 1 + " * " + i + " = " + (1 * i);
            }//fim do método for

            return resultado;
        }//fim do Exercicio 5

        //Exercicio 6
        public string Contador()
        {
            string resultado = "";

            for (int i = 1; i <= GetSetNum2; i++)
            {
                resultado += "\n" + (GetSetNum1 + (1 * i - GetSetNum1));
            }//fim do método for

            return resultado;
        }//fim do ex6

        //Exercicio 7
        public string NumerosImpares()
        {
            StringBuilder resultado = new StringBuilder();

            for (int num = 101; num < 200; num += 2)
            {
                resultado.Append(num.ToString());
                resultado.Append(" ");
            }

            return resultado.ToString().Trim();
        }//fim do ex7

        //Exercicio 8
        public int SomaDezNumeros()
        {
            int soma = 0;

            Console.WriteLine("Digite 10 números inteiros:");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Número {i}: ");
                int num = Convert.ToInt32(Console.ReadLine());
                soma += num;
            }

            return soma;
        }//fim do ex8

        //Exercicio 9
        public int SomaAteZero()
        {
            int soma = 0;

            Console.WriteLine("Digite números inteiros (digite 0 para parar):");

            while (true)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                    break;

                soma += num;
            }

            return soma;
        }//fim do ex9

        //Exercicio 10
        public double MediaParesAteZero()
        {
            int soma = 0;
            int quantidadePares = 0;

            Console.WriteLine("Digite números inteiros (digite 0 para parar):");

            while (true)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                    break;

                if (num % 2 == 0)
                {
                    soma += num;
                    quantidadePares++;
                }
            }   

            if (quantidadePares == 0)
            {
                Console.WriteLine("Nenhum número par foi digitado.");
                return 0;
            }

            double media = (double)soma / quantidadePares;
            return media;
        }//fim do ex10

        //Exercicio 11
        public (int, int) EncontrarMaiorEMenorAteZero()
        {
            int maior = int.MinValue;
            int menor = int.MaxValue;

            Console.WriteLine("Digite números inteiros (digite 0 para parar):");

            while (true)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                    break;

                if (num > maior)
                    maior = num;

                if (num < menor)
                    menor = num;
            }

            return (maior, menor);
        }//fim do ex11

        //Exercicio 12
        public (int, int) CalcularSomaPositivosEContarNegativos()
        {
            int somaPositivos = 0;
            int quantidadeNegativos = 0;

            Console.WriteLine("Digite 20 números inteiros:");

            for (int i = 1; i <= 20; i++)
            {
                Console.Write($"Número {i}: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num > 0)
                    somaPositivos += num;

                if (num < 0)
                    quantidadeNegativos++;
            }

            return (somaPositivos, quantidadeNegativos);
        }//fim do ex12

        //Exercicio 13  
        public long CalcularFatorial(int numero)
        {
            if (numero < 0)
                throw new ArgumentException("O número não pode ser negativo.");

            if (numero == 0 || numero == 1)
                return 1;

            long fatorial = 1;
            for (int i = 2; i <= numero; i++)
            {
                fatorial *= i;
            }

            return fatorial;
        }//fim do ex13

        //Exercicio 14
        public double CalcularAlturaMediaTime(int numeroJogadores)
        {
            if (numeroJogadores <= 0)
                throw new ArgumentException("O número de jogadores deve ser maior que zero.");

            double somaAlturas = 0;
            for (int i = 1; i <= numeroJogadores; i++)
            {
                Console.Write($"Digite a altura do jogador {i} (em metros): ");
                double altura = Convert.ToDouble(Console.ReadLine());
                somaAlturas += altura;
            }

            double alturaMedia = somaAlturas / numeroJogadores;
            return alturaMedia;
        }//fim do ex14

        //Exercicio 15
        public (string nome, double nota) EncontrarVencedora(string[] nomes, double[] notas)
        {
            if (nomes.Length != notas.Length || nomes.Length == 0)
                throw new ArgumentException("A quantidade de nomes e notas deve ser igual e maior que zero.");

            int indiceVencedora = 0;
            double maiorNota = notas[0];

            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] > maiorNota)
                {
                    maiorNota = notas[i];
                    indiceVencedora = i;
                }
            }

            return (nomes[indiceVencedora], maiorNota);
        }//fim do ex15

        //Exercicio 16
        public string VotosMunicipio()
        {
            double numeroTotal = 0;
            double numeroVB = 0;
            double numeroVN = 0;
            double numeroVV = 0;
            string msg = "";
            double contaVB = 0;
            double contaVN = 0;
            double contaVV = 0;
            double soma = 0;

            Console.WriteLine("Informe o número total de eleitores: ");
            numeroTotal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o número de votos em branco: ");
            numeroVB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o número de votos nulos: ");
            numeroVN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o número de votos válidos: ");
            numeroVV = Convert.ToInt32(Console.ReadLine());

            soma = numeroVB + numeroVN + numeroVV;
            do
            {
                if (soma > numeroTotal)
                {
                    Console.WriteLine("Informe um número menor de votos do que o número de eleitores");
                }

            } while (soma != numeroTotal);

            contaVB = (numeroVB * 100) / numeroTotal;
            contaVN = (numeroVN * 100) / numeroTotal;
            contaVV = (numeroVV * 100) / numeroTotal;

            msg = "O percentual de votos em Branco é de: " + contaVB + "%" +
                  "\nO percentual de votos Nulos é de: " + contaVN + "%" +
                  "\nO percentual de votos Válidos é de: " + contaVV + "%";
            return msg;
        }//fim do ex16

        //Exercicio 17
        public double CalcularCustoFinal(double custoFabrica)
        {
            double porcentagemDistribuidor = 0.28;
            double porcentagemImpostos = 0.45;

            double custoDistribuidor = custoFabrica * porcentagemDistribuidor;
            double custoImpostos = custoFabrica * porcentagemImpostos;
            double custoFinal = custoFabrica + custoDistribuidor + custoImpostos;

            return custoFinal;
        }//fim do ex17




    }//fim da classe
}//fim do projeto