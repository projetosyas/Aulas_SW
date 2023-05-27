namespace exercicio_3;
class Program

static void Main(string[] args){

ContratoPessoaFisica n1 = new ContratoPessoaFisica();
ContratoPessoaJuridica n2 = new ContratoPessoaJuridica();

    n1.Email = "negyasmin@gmail.com";
    n1.Nome = "Yasmin";
        n1.Telefone = "(11) 93355-5717";
        n1.cpf = "246.022.248-30";
        n1.Idade = 16;
        n1.Prazo = 15;


        n2.Email = "Roberta@gmail.com";
        n2.Nome = "Robera";
        n2.Telefone = "(11) 4568-7895";
        n2.cnpj = "22.784.578/0001-00";
        n2.ie = "222.450.190.530";
        n2.NomeEmpresa = "Neg Roupas";
        n2.Prazo = 15;
        

        Console.WriteLine("Os dados Pessoa Física são: " + n1.MostraDados());
        Console.WriteLine("Os dados Pessoa Jurídica são: " + n2.MostraDados());
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("O valor da prestação da Pessoa Física é de: " + n1.calcularPrestacao());
        Console.WriteLine("O valor da prestação da Pessoa Jurídica é de: " + n2.calcularPrestacao());
    }
}
