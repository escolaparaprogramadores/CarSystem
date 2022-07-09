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
            ValorDiaria = vlrDiaria;
            QuantidadeDiaLocacao = qtdDiaLocacao;
            TaxaJuros = 10.0M;
            DataInicioLocacao = new DateTime(2022,07,01);
            DataFimLocacao = new DateTime(2022,07,05);
            DataEntregaLocacao = DateTime.Now;
            //QuantidadeDiasEmAtraso    
            //ValorTotalLocacaoComJuros
            //EstaEmAtraso

            CalcularDiasEmAtraso(DataFimLocacao, DataEntregaLocacao);
            CalcularValorTotalLocacao(ValorDiaria, QuantidadeDiaLocacao);
            CalcularValorTotalAPagar();
          }
        
        public DateTime DataInicioLocacao { get; private set; }
        public DateTime DataEntregaLocacao { get; private set; }
        public DateTime DataFimLocacao { get; private set; }
        public decimal ValorDiaria { get; private set; }
        public int QuantidadeDiaLocacao { get; private set; }
        public int QuantidadeDiasEmAtraso { get; private set; }
        public decimal ValorTotalLocacao { get; private set; }
        public decimal ValorTotalLocacaoComJuros { get; private set; }
        public bool EstaEmAtraso { get; set; }
        public decimal TaxaJuros { get; set; }

         //Métodos ou função
        private void CalcularValorTotalLocacao(decimal vlrDiaria, int qtdDiaLocacao)
        {
          ValorTotalLocacao = (vlrDiaria * qtdDiaLocacao);
        }

        private void CalcularDiasEmAtraso(DateTime dtDeveriaTerEntregue, DateTime dtEntrega )
        {
          QuantidadeDiasEmAtraso = dtEntrega.Day - dtDeveriaTerEntregue.Day;  

          if(QuantidadeDiasEmAtraso > 0)
          {
            EstaEmAtraso = true;
          }else
          {
            EstaEmAtraso = false;
          }
        }

        private void CalcularValorTotalAPagar()
        {
          if(EstaEmAtraso == true)
          {
            var valorTotalTaxaDeJuros = (ValorDiaria * TaxaJuros) / 100;  
            ValorTotalLocacaoComJuros = valorTotalTaxaDeJuros * QuantidadeDiasEmAtraso;
          }

          Console.WriteLine($"O valor total a pagar é: {ValorTotalLocacaoComJuros}");
        }
    }
}
