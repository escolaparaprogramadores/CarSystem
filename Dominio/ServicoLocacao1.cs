using System;

namespace CarSystem.Dominio
{
   public class ServicoLocacao1
    {
        //Construtores, constroi objetos
          public ServicoLocacao1
          (
            double vlrDiaria,
            int qtdDiaLocacao,
            Cliente cliente
          )
          {        
            ValorDiaria = vlrDiaria;
            QuantidadeDiaLocacao = qtdDiaLocacao;
            TaxaJuros = 10;
            DataInicioLocacao = new DateTime(2022,07,01);
            DataFimLocacao = new DateTime(2022,07,05);
            DataEntregaLocacao = DateTime.Now;
            Cliente = cliente;

            CalcularDiasEmAtraso(DataFimLocacao, DataEntregaLocacao);
            CalcularValorTotalLocacao(ValorDiaria, QuantidadeDiaLocacao);
            CalcularValorTotalAPagar();
          }
        
        public DateTime DataInicioLocacao { get; private set; }
        public DateTime DataEntregaLocacao { get; private set; }
        public DateTime DataFimLocacao { get; private set; }
        public double ValorDiaria { get; private set; }
        public int QuantidadeDiaLocacao { get; private set; }
        public int QuantidadeDiasEmAtraso { get; private set; }
        public double ValorTotalLocacao { get; private set; }
        public double ValorTotalLocacaoComJuros { get; private set; }
        public bool EstaEmAtraso { get; private set; }
        public double TaxaJuros { get; private set; }
        public Cliente Cliente { get; private set; }



         //Métodos ou função
        private void CalcularValorTotalLocacao(double vlrDiaria, int qtdDiaLocacao)
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
         var txJuros = (TaxaJuros / 100);
         var total = Math.Pow( (1 + txJuros), QuantidadeDiasEmAtraso);
         var resultado = ValorTotalLocacao * total; 

         var resultadoFormatado = Math.Round(resultado, 2);

          Console.WriteLine($"Olá {Cliente.Nome}, o valor total a pagar é: {resultadoFormatado}");
        }
    }
}
