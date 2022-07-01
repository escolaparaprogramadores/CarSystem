
using System;

namespace CarSystem
{
    public class Veiculo
    {
        //Propriedades/variavel do veiculo
      public int quantidadePassageiro {get; set; }   
      public string modelo {get; set;}
      public bool iSFlex {get; set;}
      public string anoVeiculo {get; set;}
      public DateTime dataLancamento {get; set;}
      public Decimal valorVeiculo {get; set;}
    }
}