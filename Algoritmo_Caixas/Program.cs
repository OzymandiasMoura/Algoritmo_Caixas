//Proposito do projeto: Algoritmo de treino

//Algoritmo deve ler um set de caixas de qualquer tamanho e qualquer formato retangular.
////lista de caixas de qualquer tamanho e qualquer formato retangular criada
//As caixas devem ser empilhadas de forma a maximizar a altura da pilha
//A superficie da caixa de baixo deve ser maior que a caixa de cima
//Tanto a largura quanto o comprimento da caixa de baixo devem ser maiores do que da caixa de cima
//Mais de uma pilha pode ser formada para que todas as caixas possam ser empilhadas
//Nenhuma caixa pode ficar sem uma pilha

namespace Algoritmo_Caixas;

class Program
{
  
    static void Main(string[] args)
    {
        List<Caixa> caixas = new List<Caixa>()
        {
            new Caixa("laranaja", LadoAleatorio(), LadoAleatorio(), LadoAleatorio()),
            new Caixa("roxa", LadoAleatorio(), LadoAleatorio(), LadoAleatorio()),
            new Caixa("rosa", LadoAleatorio(), LadoAleatorio(), LadoAleatorio()),
            new Caixa("amarela", LadoAleatorio(), LadoAleatorio(), LadoAleatorio()),
            new Caixa("vermelha", LadoAleatorio(), LadoAleatorio(), LadoAleatorio()),
            new Caixa("azul", LadoAleatorio(), LadoAleatorio(), LadoAleatorio()),
        };

        OrdenarCaixas ordenarCaixas = new OrdenarCaixas(caixas);

        var caixasOrdenadasArea = ordenarCaixas.OrdenarCaixasPorArea();
        var caixasCompapativeis = ordenarCaixas.RetirarCaixasIncompativeis(caixasOrdenadasArea);

        for(int i = 0; i < caixasOrdenadasArea.Length; i++)
        {
            Console.WriteLine(caixasOrdenadasArea[i]);
        }

        Console.WriteLine();

        for (int i = 0; i < caixasCompapativeis.Length; i++)
        {
            Console.WriteLine(caixasCompapativeis[i]);
        }


    }

    static int LadoAleatorio()
    {
        Random a = new Random();
        int b = a.Next(1, 30);
        return b;
    }


}






