using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anotções_Interface
{
    public class Veiculo : IVeiculos
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public decimal ValorBase { get; set; }



        public virtual decimal CalcularDias(int dias)
        {

            return ValorBase * dias;



        }

        public Veiculo(string modelo, string marca, int ano, decimal valorBase)
        {

            Modelo = modelo;
            Marca = marca;
            Ano = ano;
            ValorBase = valorBase;

        }

        public virtual void ExbibirPedido(int dias)
        {
            Console.WriteLine($"Modelo:_____{Modelo}");
            Console.WriteLine($"Marca:______{Marca}");
            Console.WriteLine($"Ano:________{Ano}");
            Console.WriteLine($"Valor Base 1 dia:________R${ValorBase}");
            Console.WriteLine($"Valor para {dias} dias:________R${CalcularDias(dias)}");
            Console.WriteLine();
            Console.WriteLine();


        }

        //terminar de criar
        public void CadastrarVeiculo()
        {
            Console.WriteLine("1-Carro");
            Console.WriteLine("2-Moto");
            Console.WriteLine("3-Caminhão");
            
            int op = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("Modelo: ");
            string modelo = Console.ReadLine();

            Console.WriteLine("Marca: ");
            string marca = Console.ReadLine();

            Console.WriteLine("Ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor diário: ");
            decimal valorDiario = Convert.ToDecimal(Console.ReadLine());

            if (op == 1)
            {
                new Carro(modelo,marca,ano,valorDiario);

            }
            else if (op == 2)
            {
                new Moto(modelo, marca, ano, valorDiario);
            }

            else
            {
                new Caminhao(modelo, marca, ano, valorDiario);
            }




        }



    }



}
    