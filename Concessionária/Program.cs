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

            while (true)
            {
                Veiculo veiculo = new Veiculo("", "", 0000, 0000);

                Console.WriteLine("Veiculos \n");
                Console.WriteLine("Digite a quantidade de dias: ");
                int dias = Convert.ToInt32(Console.ReadLine());

                veiculo.Veiculos(dias);

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
                    case 3:
                        veiculo.Veiculos(dias);
                        break;

                    default:
                        throw new Exception("ERRO:INSIRA UM NÚMERO VÁLIDO");

                }

            }



        }


     


    }
}