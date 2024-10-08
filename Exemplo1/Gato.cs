namespace Exemplo1;

public class Gato : IAnimal
{
    public void SomAnimal()
    {
        Console.WriteLine("Miauu...");
    }

    public void Brincar()
    {
        Console.WriteLine("Brincando na caixa de area...");
    }

    public void Comer()
    {
        Console.WriteLine("Comendo um peixe...");
    }
}
