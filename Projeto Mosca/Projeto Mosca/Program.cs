using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Mosca.classe;

namespace Projeto_Mosca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<jogo> ListaDeJogos = new List<jogo>();
            while (true)
            {
                Console.WriteLine("Obrigado por testar nossa biblioteca de jogos.");
                Console.WriteLine("By: Guilherme Henrique e Ian Marques");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(" BIBLIOTECA        BIBLIOTECA             BIBLIOTECA              ");
                Console.WriteLine(" DE                DE                     DE            ");
                Console.WriteLine(" JOGOS             JOGOS                  JOGOS            ");
                Console.WriteLine("");
                Console.WriteLine("Para adicionar algum jogo novo, aperte 1(Um).");
                Console.WriteLine("Para ver a lista, aperte 2(dois).");
                Console.WriteLine("Para editar um jogo, aperte 3(três).");
                Console.WriteLine("Para excluir um jogo, aperte 4(quatro).");
                Console.WriteLine("");
                Console.Write("Opção: ");

                String opcao = Console.ReadLine();                        
                bool resultado;
                

                switch (opcao)
                 {
                         case "1":
                             resultado = AdicionarJogo(ListaDeJogos);
                            if (resultado == true)
                            {
                                 Console.WriteLine("");
                                 Console.WriteLine("Cadastrado com sucesso!");
                            }
                            else
                            {
                                 Console.WriteLine("");
                                 Console.WriteLine("Erro do cadastro, tente novamente.");
                                 Console.WriteLine("");
                            }
                    break;

                        case "2":
                             resultado = ListarJogos(ListaDeJogos);
                            if (resultado == true)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Listado com sucesso!");
                                Console.WriteLine("");

                            }
                            else
                            {
                                  Console.WriteLine("");
                                  Console.WriteLine("Erro na listagem, tente novamente.");
                                  Console.WriteLine("");
                            }
                    break;
                            
                            
                        case"3":
                             resultado = EditarJogos(ListaDeJogos);
                            if(resultado == true)
                            {
                                 Console.WriteLine("");
                                 Console.WriteLine("Jogo Editado com sucesso!");
                                 Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Erro na edição do jogo, tente novamente.");
                                Console.WriteLine("");
                            }
                    break;


                        case"4":
                             resultado = ExcluirJogo(ListaDeJogos);
                             if (resultado == true)
                             {
                                  Console.WriteLine("");
                                  Console.WriteLine("Jogo excluído com sucesso!");
                                  Console.WriteLine("");
                             }
                             else
                             {
                                  Console.WriteLine("");
                                  Console.WriteLine("Erro, tente novamente.");
                                  Console.WriteLine("");
                             }
                    break;

                     Console.WriteLine("Opção Inválida");
                    
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }   
         public static bool AdicionarJogo(List<jogo> ListaDeJogos)
         {
                Console.Clear();
                Console.WriteLine("");  
                Console.WriteLine("Titulo: ");
                String Titulo = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Ano: ");
                int Ano = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Genêro: ");
                String Genero = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Número de jogadores: ");
                int Maxjog = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Pontuação metacritica: ");
                Console.WriteLine("");
                int Pontmet = Convert.ToInt32(Console.ReadLine());

                if (Titulo == "")
                {
                    return false;
                    Console.WriteLine("Título inválido");
                }
                if (Ano < 1950)
                {
                    return false;
                    Console.WriteLine("Ano inválido");
                }
                if (Maxjog < 1)
                {
                    return false;
                    Console.WriteLine("Número de jogadores inválido");
                }
                if (Pontmet < 0)
                {
                    return false;
                    Console.WriteLine("Pontuação inválido");
                }
                Console.WriteLine("Houve erros");
                jogo novojogo = new jogo(Titulo, Ano, Genero, Maxjog, Pontmet);
                ListaDeJogos.Add(novojogo);

                Console.WriteLine("Jogo salvo com sucesso");
                Console.Clear();
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
                Console.WriteLine("Seu novo jogo adicionado!");
                Console.WriteLine("");
                Console.WriteLine("Título: " + Titulo);
                Console.WriteLine("Ano: " + Ano);
                Console.WriteLine("Genero: " + Genero);
                Console.WriteLine("Número máximo de jogadores: " + Maxjog);
                Console.WriteLine("Pontuação metacritica: " + Pontmet);
                Console.WriteLine("");

             return true;
         }
             public static  bool ListarJogos(List<jogo> ListaJogos)
             {
                foreach (jogo jogo in ListaJogos)
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.Write("Titulo: ");
                    Console.WriteLine(jogo.getTitulo());
                    Console.Write("Ano: ");
                    Console.WriteLine(jogo.getAno());
                    Console.Write("Genero: ");
                    Console.WriteLine(jogo.getGenero());
                    Console.Write("Número maximo de jogadores: ");
                    Console.WriteLine(jogo.getMaxjog());
                    Console.Write("Pontuação metacritica: ");
                    Console.WriteLine(jogo.getPontmet());
                    Console.WriteLine("");
               

                }

                return true;

             }
             public static bool EditarJogos(List<jogo> ListaDeJogos)
             {
                    Console.Clear();
                    Console.Write("Titulo: ");
                    String Titulo = Console.ReadLine();
                foreach (jogo jogo in ListaDeJogos)
                {
                    if(Titulo == jogo.getTitulo())
                    {
                         Console.Clear();
                         Console.WriteLine("");
                         Console.WriteLine("Titulo: ");
                         Titulo = Console.ReadLine();
                         jogo.setTitulo(Titulo);
                         Console.WriteLine("");
                         Console.WriteLine("Ano: ");
                         int Ano = Convert.ToInt32(Console.ReadLine());
                         jogo.setAno(Ano);

                         Console.WriteLine("");
                         Console.WriteLine("Genêro: ");
                         String Genero = Console.ReadLine();
                         jogo.setGenero(Genero);

                         Console.WriteLine("");
                         Console.WriteLine("Número de jogadores: ");
                         int Maxjog = Convert.ToInt32(Console.ReadLine());
                         jogo.setMaxjog(Maxjog);

                         Console.WriteLine("");
                         Console.WriteLine("Pontuação metacritica: ");
                         Console.WriteLine("");
                         int Pontmet = Convert.ToInt32(Console.ReadLine());
                         jogo.setPontmet(Pontmet);

                         return true;

                    }        
                 
                
                   
                   
                 

                }

                   return false;
                    Console.WriteLine("Título inválido");
             }
             public static bool ExcluirJogo(List<jogo> ListaDeJogos)
             {
                Console.Clear();
                Console.Write("Titulo: ");
                String Titulo = Console.ReadLine();
                   foreach (jogo jogo in ListaDeJogos)
                   {
                        if (Titulo == jogo.getTitulo())
                        {
                               ListaDeJogos.Remove(jogo);
                               return true;
                        }
                   }

                        return false;
                
             }


    }
}