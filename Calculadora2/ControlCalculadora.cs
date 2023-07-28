using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static calculadora.ModelCalculadora;

namespace calculadora
{
    class ControlCalculadora
    {
        //Criando um objeto calculadora na memória
        ModelCalculadora calculadora;

        public ControlCalculadora()
        {
            this.calculadora = new ModelCalculadora();
        }//fim do construtor

        public void Coletar()
        {
            Console.WriteLine("Informe um número: ");
            this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe outro número: ");
            this.calculadora.GetSetNum2 = Convert.ToDouble(Console.ReadLine());
        }//fim do coletar

        public void ColetarRaiz()
        {
            Console.WriteLine("Informe um numero: ");
            this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
        }//fim do coletar raiz

        public int Menu()
        {
            Console.WriteLine("------------------ Menu ------------------" +
                              "\n0. Sair"                                  +
                              "\n1. Somar"                                 +
                              "\n2. Subtrair"                              +
                              "\n3. Dividir"                               +
                              "\n4. Multiplicar"                           +
                              "\n5. Potência"                              +
                              "\n6. Raiz"                                  +
                              "\n7. Tabuada"                               +
                              "\n8. Conversão de binário para decimal"     +
                              "\n9. Conversão de decimal para binário"     +
                              "\n10. Hexadecimal para decimal "            +
                              "\n11. Decimal para Hexadecimal"             +
                              "\n12. Bhaskara"                             +
                              "\n13. Ex1"                                  +
                              "\n14. Ex2"                                  +
                              "\n15. Ex3"                                  +
                              "\n16. Ex4"                                  +
                              "\n17. Ex5"                                  +
                              "\n18. Ex6"                                  +
                              "\n19. Ex7"                                  +
                              "\n20. Ex8"                                  +
                              "\n21. Ex9"                                  +
                              "\n22. Ex10"                                 +
                              "\n23. Ex11"                                 +
                              "\n24. Ex12"                                 +                                              
                              "\n25. Ex13"                                 +
                              "\n26. Ex14"                                 +
                              "\n27. Ex15"                                 +
                              "\n28. Ex16"                                 +
                              "\n29. Ex17"                                 +
                              "\n30. Ex18"                                 +
                              "\n31. Ex19"                                 +
                              "\n32. Ex20"                                 +
                              "\n\nEscolha uma das opções acima: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }//fim do método Menu

        public void Operacao()
        {
            int opcao = 0;
            do
            {
                opcao = Menu();
                Console.Clear();//Limpa a tela
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;

                    case 1:
                        Coletar();
                        Console.WriteLine("Soma: " + this.calculadora.Somar());
                        break;

                    case 2:
                        Coletar();
                        Console.WriteLine("Subtração: " + this.calculadora.Subtrair());
                        break;

                    case 3:
                        Coletar();
                        if (this.calculadora.Dividir() == -1)
                        {
                            Console.WriteLine("Impossível dividir!");
                        }
                        else
                        {
                            Console.WriteLine("Divisão: " + this.calculadora.Dividir());
                        }
                        break;

                    case 4:
                        Coletar();
                        Console.WriteLine("Multiplicar: " + this.calculadora.Multiplicar());
                        break;

                    case 5:
                        Coletar();
                        Console.WriteLine("Potência: " + this.calculadora.Potencia());
                        break;

                    case 6:
                        Coletar();
                        Console.WriteLine(this.calculadora.Raiz());
                        break;

                    case 7:
                        Console.WriteLine("Informe um número: ");
                        this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaNum1());
                        break;

                    case 8:
                        Console.WriteLine("Informe um valor em binário: ");
                        Console.WriteLine(this.calculadora.ConverterDecimal(Console.ReadLine()));
                        break;

                    case 9:
                        Console.WriteLine("Informe um valor em decimal: ");
                        Console.WriteLine(this.calculadora.ConverterBinario(Convert.ToInt32(Console.ReadLine())));
                        break;

                    case 10:
                        Console.WriteLine("Informe um valor em Hexadecimal: ");
                        Console.WriteLine(this.calculadora.ConverterHexaDecimal(Console.ReadLine()));
                        break;

                    case 11:
                        Console.WriteLine("Informe um valor em Decimal: ");
                        Console.WriteLine(this.calculadora.ConverterDecimalHexa(Convert.ToInt32(Console.ReadLine())));
                        break;

                    case 12:
                        Console.WriteLine("Informe A: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe B: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe C: ");
                        double c = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.bhaskara(a, b, c));
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é valida");
                        break;

                    //Exercicios


                    //ex1
                    case 13:
                        Console.Write("Digite um número: ");
                        int num = int.Parse(Console.ReadLine());
                        ModelCalculadora calculadora = new ModelCalculadora();
                        (int doubleNum, int tripleNum) = calculadora.Exc1(num);
                        Console.WriteLine($"O dobro de {num} é: {doubleNum}");
                        Console.WriteLine($"O triplo de {num} é: {tripleNum}");
                        break;

                    //ex2
                    case 14:
                        Console.Write("Digite o salário: ");
                        string input = Console.ReadLine();
                        ModelCalculadora calculadora1 = new ModelCalculadora();
                        double salarioComAumento = this.calculadora.CalcularSalarioComAumento(input);

                        if (salarioComAumento >= 0)
                        {
                            Console.WriteLine($"Salário com aumento: {salarioComAumento}");
                        }
                break;

                    //ex3
                    case 15:
                        Console.Write("Digite um número: ");
                        int number = int.Parse(Console.ReadLine());
                        ModelCalculadora numberHelper = new ModelCalculadora();
                        string result = numberHelper.VerificarNumero(number);
                        Console.WriteLine(result);
                        break;

                    //ex4
                    case 16:
                        ModelCalculadora modelCalculadora = new ModelCalculadora();
                        int start = 1;
                        int end = 100;
                        int sum = modelCalculadora.CalcularSoma(start, end);
                        Console.WriteLine($"A soma dos números de {start} a {end} é: {sum}");

                        break;

                    //ex5
                    case 17:
                        ColetarRaiz();
                        Console.WriteLine(this.calculadora.Tabuada1N());

                        break;

                    //ex6
                    case 18:
                        Coletar();
                        Console.WriteLine(this.calculadora.Contador());
                    
                        break;

                    //ex7
                    case 19:
                        Console.WriteLine("Números ímpares entre 100 e 200: " + this.calculadora.NumerosImpares());
                        break;

                    //ex8
                    case 20:
                        Console.WriteLine("Soma dos 10 números inteiros: " + this.calculadora.SomaDezNumeros());
                        break;

                    //ex9
                    case 21:
                        Console.WriteLine("Soma dos números até digitar 0: " + this.calculadora.SomaAteZero());
                        break;

                    //ex10
                    case 22:
                        double media = this.calculadora.MediaParesAteZero();
                        if (media != 0)
                            Console.WriteLine("Média dos números pares: " + media);
                        break;

                    //ex11
                    case 23:
                        var (maior, menor) = this.calculadora.EncontrarMaiorEMenorAteZero();
                        Console.WriteLine("Maior valor: " + maior);
                        Console.WriteLine("Menor valor: " + menor);
                        break;

                    //ex12
                    case 24:
                        var (somaPositivos, quantidadeNegativos) = this.calculadora.CalcularSomaPositivosEContarNegativos();
                        Console.WriteLine("Soma dos números positivos: " + somaPositivos);
                        Console.WriteLine("Quantidade de valores negativos: " + quantidadeNegativos);
                        break;

                    //ex13
                    case 25:
                        Console.Write("Digite um número inteiro não negativo: ");
                        int numero = Convert.ToInt32(Console.ReadLine());

                        try
                        {
                            long fatorial = this.calculadora.CalcularFatorial(numero);
                            Console.WriteLine($"{numero}! = {fatorial}");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine("Erro: " + ex.Message);
                        }
                        break;

                    //ex14
                    case 26:
                        Console.Write("Digite o número de jogadores do time: ");
                        int numeroJogadores = Convert.ToInt32(Console.ReadLine());

                        try
                        {
                            double alturaMedia = this.calculadora.CalcularAlturaMediaTime(numeroJogadores);
                            Console.WriteLine($"Altura média do time: {alturaMedia:F2} metros");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine("Erro: " + ex.Message);
                        }
                        break;

                    //ex15
                    case 27:
                        string[] nomes = new string[16];
                        double[] notas = new double[16];

                        for (int i = 0; i < 16; i++)
                        {
                            Console.Write($"Digite o nome da candidata {i + 1}: ");
                            nomes[i] = Console.ReadLine();

                            Console.Write($"Digite a nota da candidata {i + 1} (0 a 10): ");
                            notas[i] = Convert.ToDouble(Console.ReadLine());

                            if (notas[i] < 0 || notas[i] > 10)
                            {
                                Console.WriteLine("Nota inválida. Digite uma nota entre 0 e 10.");
                                i--; 
                            }
                        }

                        try
                        {
                            (string nomeVencedora, double notaVencedora) = this.calculadora.EncontrarVencedora(nomes, notas);
                            Console.WriteLine($"Vencedora: {nomeVencedora}, Nota: {notaVencedora:F2}");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine("Erro: " + ex.Message);
                        }
                        break;

                    //ex16
                    case 28:
                        Console.WriteLine(this.calculadora.VotosMunicipio());
                        break;  

                    case 29:
                        Console.WriteLine(this.calculadora.CustoDoCarro());
                        break;

                }//fim do switch

            } while (opcao != 0);//fim do Do...while
        }//fim do operacao
    }//fim da classe
}//fim do projeto
