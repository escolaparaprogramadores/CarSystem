namespace CarSystem.Dominio
{
    public class Endereco
    {
        //Regras para construtor
        //1) publico
        //2) Mesmo nome da classe
        //3) Recebe valor por parametro
    public Endereco
    (
        string cidade,
        string bairro,
        string logradouro,
        string numero,
        string cep,
        string pontoReferencia
    )
    {
        Cidade = cidade;
        Bairro = bairro;
        Logradouro = logradouro;
        Numero = numero;
        Cep = cep;
        PontoReferencia = pontoReferencia;
    }

     public string Cidade {get; private set;}
     public  string Bairro {get; private set;}
     public  string Logradouro {get; private set;}
     public  string Numero {get; private set;}
     public  string Cep {get; private set;}
     public  string PontoReferencia {get; private set;}
    }
}