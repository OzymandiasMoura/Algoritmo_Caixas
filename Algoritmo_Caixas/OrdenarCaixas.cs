using System.ComponentModel;
using System.Linq;

namespace Algoritmo_Caixas;

internal class OrdenarCaixas
{
    private int maxArea = 0;
    private List<Caixa> _caixas = new List<Caixa>();
    private List<Caixa> _sobras = new List<Caixa>();

    public OrdenarCaixas(List<Caixa> caixas)
    {
        _caixas = caixas;
    }

    public Caixa CaixaAreaMaior()
    {
        Caixa caixaMaior = _caixas[0];
        foreach (var caixa in _caixas)
        {
            if (caixa.Area > maxArea)
            {
                maxArea = caixa.Area;
                caixaMaior = caixa;
            }
        }
        return caixaMaior;
    }

    public Caixa[] OrdenarCaixasPorArea()
    {
        Caixa[] caixasOrdenadas = new Caixa[_caixas.Count];

        for (int i = 0; i < _caixas.Count; i++)
        {
            var maiorCaixa = CaixaAreaMaior();
            _caixas.Remove(maiorCaixa);
            caixasOrdenadas[i] = maiorCaixa;
        }

        return caixasOrdenadas;
    }

    public Caixa[] RetirarCaixasIncompativeis(Caixa[] caixas)
    {
        Caixa[] caixasOrdenadas = new Caixa[caixas.Length];

        caixasOrdenadas[0] = caixas[0];
        var ultimaCaixa = caixasOrdenadas[0];

        for (int i = 1; i < caixas.Length; i++)
        {
            ultimaCaixa = caixas[i];

            if (caixas[i].Largura < ultimaCaixa.Largura && caixas[i].Comprimento < ultimaCaixa.Comprimento)
            {
                caixasOrdenadas[i] = caixas[i];                
            }
            else
            {
                _sobras.Add(caixas[i]);
            }
        }
        return caixasOrdenadas;
    }
}
