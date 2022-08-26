using System;

namespace PJogoDaVelha
{
    internal class Program
    {

        static char[,] tabuleiro = new char[3, 3];
        static int novoJogo = 0;
        static int jogadas = 0;
        static string jog1;
        static string jog2;
        static bool jogs;


        //inicializa o jogo com o char "-"
        static void InicializarMatriz()
        {
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    tabuleiro[l, c] = ' ';
                }
            }
        }
        static void verificaEmpate()
        {
            bool empate = true;
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (tabuleiro[l,c] == ' ') //esta vazio
                    {
                        empate = false;
                        return;
                    }

                }
            }

            if (empate)
            {
                Console.WriteLine("\nDeu velha! Fim de jogo!\n");
                Console.WriteLine("\nJogar novamente?\n1-Sim\n2-Não\n");
                novoJogo = int.Parse(Console.ReadLine());
                if (novoJogo == 1)
                {
                    Console.Clear();
                    DadosJogo();
                    InicializarMatriz();
                    Jogadas1();
                }
                else if (novoJogo == 2)
                {
                    Environment.Exit(0);
                }
            }
        }
        static void Jogadas1()
        //solicita a jogado do primeiro jogador e valida se está dentro dos parâmetros
        {
            do
            {
                Console.WriteLine("\n\t  *MAPA DE POSIÇÕES*\n");
                Console.WriteLine("\t\t1|2|3");
                Console.WriteLine("\t\t4|5|6");
                Console.WriteLine("\t\t7|8|9\n");

                Console.WriteLine($"\n{jog1}, faça sua jogada de acordo com o mapa acima: \n");
                try
                {
                    jogadas = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\nJogada inválida, digite um número entre 1 e 9: \n");
                }
                if (jogadas < 1 || jogadas > 9)
                {
                    Console.WriteLine("\nJogada inválida, digite um número entre 1 e 9: ");
                }
                {

                    //valida se a posição escolhida está vazia e preenche
                    switch (jogadas)
                    {
                        case 1:
                            if (tabuleiro[0, 0] != ' ')
                            {
                                Console.WriteLine("Número já foi escolhido, escolha outro número!");
                            }
                            else
                            {
                                tabuleiro[0, 0] = char.Parse("X");
                                Console.Clear();
                                ImprimeTabuleiro(tabuleiro);
                            }
                            break;
                        case 2:
                            if (tabuleiro[0, 1] != ' ')
                            {
                                Console.WriteLine("Número já foi escolhido, escolha outro número!");
                            }
                            else
                            {
                                tabuleiro[0, 1] = char.Parse("X");
                                Console.Clear();
                                ImprimeTabuleiro(tabuleiro);
                            }
                            break;
                        case 3:
                            if (tabuleiro[0, 2] != ' ')
                            {
                                Console.WriteLine("Número já foi escolhido, escolha outro número!");
                            }
                            else
                            {
                                tabuleiro[0, 2] = char.Parse("X");
                                Console.Clear();
                                ImprimeTabuleiro(tabuleiro);
                            }
                            break;
                        case 4:
                            if (tabuleiro[1, 0] != ' ')
                            {
                                Console.WriteLine("Número já foi escolhido, escolha outro número!");
                            }
                            else
                            {
                                tabuleiro[1, 0] = char.Parse("X");
                                Console.Clear();
                                ImprimeTabuleiro(tabuleiro);
                            }
                            break;
                        case 5:
                            if (tabuleiro[1, 1] != ' ')
                            {
                                Console.WriteLine("Número já foi escolhido, escolha outro número!");
                            }
                            else
                            {
                                tabuleiro[1, 1] = char.Parse("X");
                                Console.Clear();
                                ImprimeTabuleiro(tabuleiro);
                            }
                            break;
                        case 6:
                            if (tabuleiro[1, 2] != ' ')
                            {
                                Console.WriteLine("Número já foi escolhido, escolha outro número!");
                            }
                            else
                            {
                                tabuleiro[1, 2] = char.Parse("X");
                                Console.Clear();
                                ImprimeTabuleiro(tabuleiro);
                            }
                            break;
                        case 7:
                            if (tabuleiro[2, 0] != ' ')
                            {
                                Console.WriteLine("Número já foi escolhido, escolha outro número!");
                            }
                            else
                            {
                                tabuleiro[2, 0] = char.Parse("X");
                                Console.Clear();
                                ImprimeTabuleiro(tabuleiro);
                            }
                            break;
                        case 8:
                            if (tabuleiro[2, 1] != ' ')
                            {
                                Console.WriteLine("Número já foi escolhido, escolha outro número!");
                            }
                            else
                            {
                                tabuleiro[2, 1] = char.Parse("X");
                                Console.Clear();
                                ImprimeTabuleiro(tabuleiro);
                            }
                            break;
                        case 9:
                            if (tabuleiro[2, 2] != ' ')
                            {
                                Console.WriteLine("Número já foi escolhido, escolha outro número!");
                            }
                            else
                            {
                                tabuleiro[2, 2] = char.Parse("X");
                                Console.Clear();
                                ImprimeTabuleiro(tabuleiro);
                            }
                            break;
                    }
                }
            } while (jogadas < 1 || jogadas > 9);
            validacao();
            Jogadas2();
        }

        static void Jogadas2()
        {
            do
            {
                Console.WriteLine("\n\t  *MAPA DE POSIÇÕES*\n");
                Console.WriteLine("\t\t1|2|3");
                Console.WriteLine("\t\t4|5|6");
                Console.WriteLine("\t\t7|8|9\n");

                Console.WriteLine($"\n{jog2}, faça sua jogada de acordo com o mapa acima: \n");
                try
                {
                    jogadas = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\nJogada inválida, digite um número entre 1 e 9: \n");
                }
                if (jogadas < 1 || jogadas > 9)
                {
                    Console.WriteLine("\nJogada inválida, digite um número entre 1 e 9: ");
                }
                else
                {
                    //valida se a posição escolhida está vazia e preenche
                    switch (jogadas)
                    {
                        case 1:
                            if (tabuleiro[0, 0] != ' ')
                            {
                                Console.WriteLine("Número já foi escolhido, escolha outro número!");
                            }
                            else
                            {
                                tabuleiro[0, 0] = char.Parse("O");
                                Console.Clear();
                                ImprimeTabuleiro(tabuleiro);
                            }
                            break;
                        case 2:
                            if (tabuleiro[0, 1] != ' ')
                            {
                                Console.WriteLine("Número já foi escolhido, escolha outro número!");
                            }
                            else
                            {
                                tabuleiro[0, 1] = char.Parse("O");
                                Console.Clear();
                                ImprimeTabuleiro(tabuleiro);
                            }
                            break;
                        case 3:
                            if (tabuleiro[0, 2] != ' ')
                            {
                                Console.WriteLine("Número já foi escolhido, escolha outro número!");
                            }
                            else
                            {
                                tabuleiro[0, 2] = char.Parse("O");
                                Console.Clear();
                                ImprimeTabuleiro(tabuleiro);
                            }
                            break;
                        case 4:
                            if (tabuleiro[1, 0] != ' ')
                            {
                                Console.WriteLine("Número já foi escolhido, escolha outro número!");
                            }
                            else
                            {
                                tabuleiro[1, 0] = char.Parse("O");
                                Console.Clear();
                                ImprimeTabuleiro(tabuleiro);
                            }
                            break;
                        case 5:
                            if (tabuleiro[1, 1] != ' ')
                            {
                                Console.WriteLine("Número já foi escolhido, escolha outro número!");
                            }
                            else
                            {
                                tabuleiro[1, 1] = char.Parse("O");
                                Console.Clear();
                                ImprimeTabuleiro(tabuleiro);
                            }
                            break;
                        case 6:
                            if (tabuleiro[1, 2] != ' ')
                            {
                                Console.WriteLine("Número já foi escolhido, escolha outro número!");
                            }
                            else
                            {
                                tabuleiro[1, 2] = char.Parse("O");
                                Console.Clear();
                                ImprimeTabuleiro(tabuleiro);
                            }
                            break;
                        case 7:
                            if (tabuleiro[2, 0] != ' ')
                            {
                                Console.WriteLine("Número já foi escolhido, escolha outro número!");
                            }
                            else
                            {
                                tabuleiro[2, 0] = char.Parse("O");
                                Console.Clear();
                                ImprimeTabuleiro(tabuleiro);
                            }
                            break;
                        case 8:
                            if (tabuleiro[2, 1] != ' ')
                            {
                                Console.WriteLine("Número já foi escolhido, escolha outro número!");
                            }
                            else
                            {
                                tabuleiro[2, 1] = char.Parse("O");
                                Console.Clear();
                                ImprimeTabuleiro(tabuleiro);
                            }
                            break;
                        case 9:
                            if (tabuleiro[2, 2] != ' ')
                            {
                                Console.WriteLine("Número já foi escolhido, escolha outro número!");
                            }
                            else
                            {
                                tabuleiro[2, 2] = char.Parse("O");
                                Console.Clear();
                                ImprimeTabuleiro(tabuleiro);
                            }
                            break;
                    }

                }
            } while (jogadas < 1 || jogadas > 9);
            validacao();
            Jogadas1();
        }




        static void ImprimeTabuleiro(char[,] tabuleiro)
        {
            for (int l = 0; l < tabuleiro.GetLength(0); l++)
            {
                Console.WriteLine();
                for (int c = 0; c < tabuleiro.GetLength(1); c++)
                {
                    if (c == 0)
                    {
                        Console.Write("\t   " + tabuleiro[l, c]);
                    }
                    else
                    {
                        Console.Write(" | " + tabuleiro[l, c]);
                    }
                }
                Console.WriteLine();
                if (l < 2)
                {
                    Console.Write("\t---------------");
                }
            }
            return;

        }

        static void validacao()
        {


            if ((tabuleiro[0, 0] == 'X' && tabuleiro[0, 1] == 'X' && tabuleiro[0, 2] == 'X') || (tabuleiro[1, 0] == 'X' && tabuleiro[1, 1] == 'X' && tabuleiro[1, 2] == 'X') ||
                (tabuleiro[2, 0] == 'X' && tabuleiro[2, 1] == 'X' && tabuleiro[2, 2] == 'X') || (tabuleiro[0, 0] == 'X' && tabuleiro[1, 0] == 'X' && tabuleiro[2, 0] == 'X') ||
                (tabuleiro[0, 1] == 'X' && tabuleiro[1, 1] == 'X' && tabuleiro[2, 1] == 'X') || ((tabuleiro[2, 0] == 'X' && tabuleiro[2, 1] == 'X' && tabuleiro[2, 2] == 'X')) ||
                (tabuleiro[0, 0] == 'X' && tabuleiro[1, 1] == 'X' && tabuleiro[2, 2] == 'X') || (tabuleiro[0, 2] == 'X' && tabuleiro[1, 1] == 'X' && tabuleiro[2, 0] == 'X'))
            {
                Console.WriteLine($"\nParabéns {jog1}! Você venceu o jogo!");
                Console.WriteLine("Jogar novamente?\n1-Sim\n2-Não");
                novoJogo = int.Parse(Console.ReadLine());
                if (novoJogo == 1)
                {
                    Console.Clear();
                    DadosJogo();
                    InicializarMatriz();
                    Jogadas1();
                }
                else if (novoJogo == 2)
                {
                    Environment.Exit(0);
                }

            }


            else if ((tabuleiro[0, 0] == 'O' && tabuleiro[0, 1] == 'O' && tabuleiro[0, 2] == 'O') || (tabuleiro[1, 0] == 'O' && tabuleiro[1, 1] == 'O' && tabuleiro[1, 2] == 'O') ||
                (tabuleiro[2, 0] == 'O' && tabuleiro[2, 1] == 'O' && tabuleiro[2, 2] == 'O') || (tabuleiro[0, 0] == 'O' && tabuleiro[1, 0] == 'O' && tabuleiro[2, 0] == 'O') ||
                (tabuleiro[0, 1] == 'O' && tabuleiro[1, 1] == 'O' && tabuleiro[2, 1] == 'O') || ((tabuleiro[2, 0] == 'O' && tabuleiro[2, 1] == 'O' && tabuleiro[2, 2] == 'O')) ||
                (tabuleiro[0, 0] == 'O' && tabuleiro[1, 1] == 'O' && tabuleiro[2, 2] == 'O') || (tabuleiro[0, 2] == '0' && tabuleiro[1, 1] == '0' && tabuleiro[2, 0] == '0'))
            {
                Console.WriteLine($"\nParabéns {jog2}! Você venceu o jogo!");
                Console.WriteLine("Jogar novamente?\n1-Sim\n2-Não");
                novoJogo = int.Parse(Console.ReadLine());
                if (novoJogo == 1)
                {
                    Console.Clear();
                    DadosJogo();
                    InicializarMatriz();
                    Jogadas1();
                }
                else if (novoJogo == 2)
                {
                    Environment.Exit(0);
                }
            }

            verificaEmpate();

        }

        static void DadosJogo()
        {
            Console.WriteLine("*JOGO DA VELHA*\n\nRegras do jogo:\n\n O objetivo do jogo é fazer uma sequência de três símbolos iguais, seja em linha vertical,horizontal ou diagonal,\n enquanto tenta impedir que seu adversário faça o mesmo" +
                " Quando um dos participantes faz uma linha, ganha o jogo.\n");
            do
            {
                Console.WriteLine("Digite o nome do jogador 1: \n");
                jog1 = Console.ReadLine();
                if (jog1 == "")
                {
                    jog1 = "Jogador 1";
                }
                jog1 = char.ToUpper(jog1[0]) + jog1.Substring(1);
                Console.WriteLine("\nDigite o nome do jogador 2: \n");
                if (jog2 == "")
                {
                    jog2 = "Jogador2";
                }
                jog2 = Console.ReadLine();
                jog2 = char.ToUpper(jog2[0]) + jog2.Substring(1);
            } while (jog1 == jog2);

            if (jog1 == jog2)
            {
                Console.WriteLine("Os nomes não podem ser iguais!");
            }

            else
            {
                Console.WriteLine($"\nBem vindos ao Jogo Da Velha {jog1} e {jog2}!!\n");

                Console.WriteLine("\nAperte ENTER para começar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void Main(string[] args)
        {
            InicializarMatriz();
            DadosJogo();
            Jogadas1();
        }
    }
}