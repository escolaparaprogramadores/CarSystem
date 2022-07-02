using System;

namespace CarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obejeto 1
            Veiculo veiculo = new Veiculo();
            veiculo.quantidadePassageiro = 4; //set
            veiculo.modelo = "Celta";
            veiculo.iSFlex = false;
            veiculo.dataLancamento = new DateTime(2022,01,10);
            veiculo.anoVeiculo = "2022";

            // Obejeto 2
            Veiculo veiculo2 = new Veiculo();
            veiculo.quantidadePassageiro = 6; //set
            veiculo.modelo = "Jeep";
            veiculo.iSFlex = true;
            veiculo.dataLancamento = new DateTime(2021,01,10);
            veiculo.anoVeiculo = "2021";
          

            Console.WriteLine("Hello World!");
        }
    }
}
