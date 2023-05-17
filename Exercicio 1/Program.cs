namespace exercicio_1;
class Program
{
    static void Main(string[] args)
    {
        Cao Spyke = new Cao();
        Gato Billy = new Gato();
        Homem anderson = new Homem();

        Console.WriteLine("Chamei o gato e ele: " + Billy.Fala());
        Console.WriteLine("Chamei o cao e ele: " + Spyke.Fala());
        Console.WriteLine("Chamei o homem e ele: " + anderson.Fala());
    }
}
