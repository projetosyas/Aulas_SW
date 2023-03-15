namespace ExercicioAlunos;
class Program
{
    static void Main(string[] args)
    {

        Aluno aluno1 = new Aluno();
        Console.WriteLine("Digite seu nome: ");
        string? nome = Console.ReadLine();
        Console.WriteLine("Seu nome é: " + nome);
        Console.WriteLine("Digite um número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("O número digitado foi: " + numero1);

        aluno1.nota1 = 4;
        aluno1.nota2 = 7;    

        aluno1.mensagem();   
    }
}
