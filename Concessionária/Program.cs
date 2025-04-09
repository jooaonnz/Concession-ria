using System.Security.Cryptography.X509Certificates;

namespace Anotções_Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            Inicio();



        }

        static public void Inicio()
        {

            Veiculo veiculo = new Veiculo("","",0000,0000);

            Console.WriteLine("Veiculos \n");
            Console.WriteLine("Digite a quantidade de dias: ");
            int dias = Convert.ToInt32(Console.ReadLine());

            Veiculos(dias);

            Console.WriteLine("0-Sair");
            Console.WriteLine("1-Calcular dias");
            Console.WriteLine("2-Cadastrar veiculo");

            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 0:
                    break;
                case 1:
                    Console.Clear();
                    Inicio();
                    break;
                case 2:
                    Console.Clear();
                    veiculo.CadastrarVeiculo();
                    break;
                default:
                    throw new Exception("ERRO:INSIRA UM NÚMERO VÁLIDO");

            }





        }


        static public void Veiculos(int dias)
        {
            List<Veiculo> veiculos = new List<Veiculo>
          {
            new Carro("HB20", "Hyundai", 2024, 350.50m),
            new Caminhao("FH 460", "Volvo", 2014, 5000.89m),
            new Caminhao("CG Titan 160", "Honda", 2025, 100.90m),


          };

            foreach (var veiculo in veiculos)
            {
                veiculo.ExbibirPedido(dias);

            }

        }


    }
}