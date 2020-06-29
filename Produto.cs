using System.IO;

namespace Aula27_28_29_30
{
    public class Produto
    {
      public int Codigo { get; set; } 

      public string Nome { get; set; }

      public float Preco { get; set; } 

      private const string PATH = "Database/produto.csv";

      public Produto(){

          string Pasta = PATH.Split('/')[0];

          if(!Directory.Exists(Pasta)){
              Directory.CreateDirectory(Pasta);
          }

          if(File.Exists(PATH)){
             File.Create(PATH).Close(); 
              }
          }
      

      public void Cadastrar(Produto prod){
        var linha = new string[]  { PrepararLinha(prod)};


          File.AppendAllLines(PATH, linha);


      }


      public string PrepararLinha(Produto p){
          return $"codigo={p.Codigo};nome={p.Nome};preco={p.Preco}";
      }
          
      
    }
}