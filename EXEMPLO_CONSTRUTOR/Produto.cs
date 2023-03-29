namespace EXEMPLO_CONSTRUTOR;

class Produto
{
    public Produto(){
        this.Nome = "XPTO";
        this.Preco = 1;
    }

     public Produto(double preco){
        this.Nome = "NÃO INFORMADO";
        this.Preco = preco;
    }

    public Produto(string nome,double desconto){
        this.Nome = nome;
        this.Preco = 10 - 10*desconto/100;
}

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