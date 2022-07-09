using System;

namespace CarSystem.Dominio
{
    public class Cliente
    {
        //Tipos de dados primitivo     
       int QuantidadeDeFilhos {get; set;}
       string Nome {get; set;}
       string Cpf {get; set;}
       DateTime DataNascimento {get; set;}
       bool ECasado {get; set;}
       Decimal Renda {get; set;} //Double ou Float
       Endereco Endereco {get; set;} // Tipo de objeto
    }
}