using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaSerasa06
{
     class Program
    {
        static void Main(string[] args)
        {


            int numero, dia;


            Console.WriteLine("Olá!!! Nós somos da agência de viagens Cunha Turismo. Aqui você encontrará os melhores lugares e preços de passagens. Então viagem com a gente!!!");
            Console.WriteLine("\n\n");

            Console.WriteLine("Nós temos três opções de meses para viagem:");
            Console.WriteLine("\n");

           


            Console.WriteLine("1 - Agosto");
            Console.WriteLine("2 - Setembro");
            Console.WriteLine("3 - Outubro");

            Console.WriteLine("Por favor, digite o número da sua escolha:");
            numero  = (int)double.Parse(s: Console.ReadLine());

            if (numero < 4)  {



                Console.WriteLine(" Muito bem! Agora vamos escolher os dias disponíveis de viagem:");



            }
            else 
            {
                Console.WriteLine("Mês inválido");
                return;
            }

            
            Console.WriteLine("Os dias disponíveis são entre 6 e 21. ");
            Console.WriteLine(" Agora digite um dia entre eles: ");
            dia = (int)double.Parse(s: Console.ReadLine());

            if (dia <= 21) 
            {

                Console.WriteLine("É isso ai!!! Estamos quase finalizando o seu pedido");

            }

            else if (dia >= 6
                )
            {
                Console.WriteLine(" Dia inválido");
                return;
            }
           

            string periodo;

            Console.WriteLine(" Agora escreva o período:");
            Console.WriteLine("Manhã");
            Console.WriteLine("Tarde");
            Console.WriteLine("Noite");
            periodo = Console.ReadLine();

            Console.WriteLine("CONCLUÍDO");




            Console.WriteLine($" Sua passagem esta para o dia {dia} do mês da opçaõ {numero} , no período {periodo}. Até mais!!!!");



            Console.ReadKey();


        }
    }
}
