using System;
namespace CarSystem.Dominio
{
   public class ServicoLocacao1
    {
        //Construtores, constroi objetos
          public ServicoLocacao1
          (
            Decimal vlrDiaria,
            int qtdDiaLocacao
          )
          {
            DataLocacao = DateTime.Now;
            ValorDiaria = vlrDiaria;
            QuantidadeDiaLocacao = qtdDiaLocacao;
            ValorTotalLocacao = (vlrDiaria * qtdDiaLocacao);
          }
        
        public DateTime DataLocacao { get; private set; }
        public decimal ValorDiaria { get; private set; }
        public int QuantidadeDiaLocacao { get; private set; }
        public decimal ValorTotalLocacao { get; private set; }

         //Métodos ou função
        
    }
}
