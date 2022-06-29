using System;

namespace CarSystem
{
    public class Cliente
    {
      
        //Tipos de dados      
       int QuantidadeDeFilhos {get; set;}
       string Nome {get; set;}
       string Cpf {get; set;}
       DateTime DataNascimento {get; set;}
       string Cidade {get; set;}
       string Bairro {get; set;}
       string Logradouro {get; set;}
       string Numero {get; set;}
       string Cep {get; set;}
       bool ECasado {get; set;}
       Decimal Renda {get; set;} //Double ou Float
    }
}