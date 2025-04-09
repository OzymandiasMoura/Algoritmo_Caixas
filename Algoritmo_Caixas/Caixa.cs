namespace Algoritmo_Caixas;

public class Caixa
{
    public string Nome { get; set; }
    public int Largura { get; set; }
    public int Comprimento { get; set; }
    public int Altura { get; set; }
    public int Area { get; set; }
    public int Volume { get; set; }

    public Caixa(string nome, int l, int c, int a)
    {
        Nome = nome;
        Largura = l;
        Comprimento = c;
        Altura = a;
        Area = l * c;
        Volume = c * a * l;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Largura: {Largura}, Comprimento: {Comprimento}, Altura {Altura}, Area: {Area}, Volume: {Volume}";
    }

}
