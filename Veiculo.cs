
using System;

namespace CarSystem
{
    public class Veiculo
    {
        public Veiculo
        (
            int quantidadePassageiro,
            string modelo,
            bool iSFlex,
            string anoVeiculo,
            DateTime dataLancamento,
            Decimal valorVeiculo
        )
        {
            QuantidadePassageiro = quantidadePassageiro;
            Modelo = modelo;
            ISFlex = iSFlex;
            AnoVeiculo = anoVeiculo;
            DataLancamento = dataLancamento;
            ValorVeiculo = valorVeiculo;


        }
        //Propriedades/variavel do veiculo
      public int QuantidadePassageiro {get; set; }   
      public string Modelo {get; set;}
      public bool ISFlex {get; set;}
      public string AnoVeiculo {get; set;}
      public DateTime DataLancamento {get; set;}
      public Decimal ValorVeiculo {get; set;}
    }
}