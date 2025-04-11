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

      static public List<Veiculo> veiculos = new List<Veiculo>
          {
            new Carro("HB20", "Hyundai", 2024, 350.50m),
            new Caminhao("FH 460", "Volvo", 2014, 5000.89m),
            new Caminhao("CG Titan 160", "Honda", 2025, 100.90m),
          };

        public void Veiculos(int dias)
        {
          
            foreach (var veiculo in veiculos)
            {
                veiculo.ExbibirPedido(dias);

            }

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
                Carro carro =new Carro (modelo,marca,ano,valorDiario);
                veiculos.Add(carro);    
            }
            else if (op == 2)
            {
                Moto moto = new(modelo, marca, ano, valorDiario);
                veiculos.Add(moto);
            }

            else
            {
                Caminhao caminhao = new(modelo, marca, ano, valorDiario);
                veiculos.Add(caminhao);
            }


           

        }



       


    }



}
    