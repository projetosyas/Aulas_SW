namespace EXEMPLO_ACESSOR;
class Program
{
    static void Main(string[] args)
    {
        Produto p1 = new Produto();

        p1.AlterarPreco(15);
        p1.AlterarNome("PARAFUSO");
        p1.MostraDados();

    }
    
}
