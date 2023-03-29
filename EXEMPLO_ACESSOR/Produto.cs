namespace EXEMPLO_ACESSOR;

class Produto
{

    private string? Nome {get;set;}
    
    private double Preco {get;set;}

    public void MostraDados(){
        Console.WriteLine("Nome: " + this.Nome );
        Console.WriteLine("Preço: " + this.Preco);
    }

    public void AlterarPreco(double preco){
        if(preco >=0){
            this.Preco = preco; 
        }else{
            Console.WriteLine("VALOR INVÁLIDO!");
        }

    }

    public void AlterarNome(string nome){
        this.Nome = nome;
    }


}