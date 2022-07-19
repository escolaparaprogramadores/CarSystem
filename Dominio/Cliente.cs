using System;

namespace CarSystem.Dominio
{
    public class Cliente
    {
        public Cliente
        (
          int quantidadeDeFilhos, 
          string nome, 
          string cpf, 
          DateTime dataNascimento, 
          bool eCasado, 
          decimal renda, 
          Endereco endereco
        )
        {
            QuantidadeDeFilhos = quantidadeDeFilhos;
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            ECasado = eCasado;
            Renda = renda;
            Endereco = endereco;
        }

        //Tipos de dados primitivo     
      public int QuantidadeDeFilhos {get; private set;}
      public string Nome {get; private set;}
      public string Cpf {get; private set;}
      public DateTime DataNascimento {get; private set;}
      public bool ECasado {get; private set;}
      public Decimal Renda {get; private set;} //Double ou Float
      public Endereco Endereco {get; private set;} // Tipo de objeto
    }
}