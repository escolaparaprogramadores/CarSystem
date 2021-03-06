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
        string cep 
    )
    {
        Cidade = cidade;
        Bairro = bairro;
        Logradouro = logradouro;
        Numero = numero;
        Cep = cep;
    }

    public Endereco
    (
        string cidade,
        string bairro
    )
    {
        Cidade = cidade;
        Bairro = bairro;
    }

     public string Cidade {get; private set;}
     public  string Bairro {get; private set;}
     public  string Logradouro {get; private set;}
     public  string Numero {get; private set;}
     public  string Cep {get; private set;}
    }
}