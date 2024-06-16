

using Comex.Modelos;

namespace Comex;

public class Produto

{
    //public Produto(string nome)
    
    //{
        //this.Nome = nome;   Atividade 3
    
    //}




    public string Nome { get; set; }
    public string Descricao { get; set; }
    public double? PrecoUnitario { get; set; }
    public int Quantidade { get; set; }
}



var eletronico = new Eletronico("Celular");
eletronico.Potencia = 2000;
eletronico.Voltagem = 2000;
eletronico.Descricao = ("Celular novo");

Console.Write(Eletronico.Nome)