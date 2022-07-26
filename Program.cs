using System;
using CarSystem.Dominio;

namespace CarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
          var endereco = new Endereco
          (
            cidade: "Niteroi",
            bairro: "Sapê",
            logradouro: "Rua Eraldo Soares",
            numero: "19",
            cep: "24350220",
            pontoReferencia: "Proximo ao Bar Rosa"
          );

         var clienteFlora = new Cliente
          (
            quantidadeDeFilhos: 0,
            nome: "Flora Regina",
            cpf: "11030212755",
            dataNascimento: new DateTime(2022,01,10,12,21,00,00),
            eCasado: false,
            renda: 1000,
            endereco: endereco
          );

          var clienteTon = new Cliente
          (
            quantidadeDeFilhos: 0,
            nome: "Ton Francisco",
            cpf: "11030212755",
            dataNascimento: new DateTime(2022,01,10,12,21,00,00),
            eCasado: false,
            renda: 1000,
            endereco: endereco
          );

          var clienteLola = new Cliente
          (
            quantidadeDeFilhos: 0,
            nome: "Lola Carola",
            cpf: "11030212755",
            dataNascimento: new DateTime(2022,01,10,12,21,00,00),
            eCasado: false,
            renda: 1000,
            endereco: endereco
          );

          var objetoServico = new ServicoLocacao1
          (
            vlrDiaria: 200, 
            qtdDiaLocacao:30,
            cliente: clienteFlora 
          );  

          var objetoServico2 = new ServicoLocacao1
          (
            vlrDiaria: 200, 
            qtdDiaLocacao:29,
            cliente: clienteTon 
          ); 

          var objetoServico3 = new ServicoLocacao1
          (
            vlrDiaria: 200, 
            qtdDiaLocacao:28,
            cliente: clienteLola 
          );       
       
       
          var retornoIdade = CalcularIdade(new DateTime(1985,12,24)); 
          ExibirIdade(retornoIdade);
        }

     private static int CalcularIdade(DateTime dataNascimento)
     {
      int idade = (DateTime.Now.Year - dataNascimento.Year);
      return idade;
     }

    private static void ExibirIdade(int idade)
    {
      Console.WriteLine(idade);
    }
    }
}
