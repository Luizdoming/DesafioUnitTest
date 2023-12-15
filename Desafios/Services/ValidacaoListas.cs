
public class ValidacaoListas
{
    public List<int> RemoverNumerosNegativos(List<int> listaDeNumeros)
    {
        var listaSemNumerosNegativos = listaDeNumeros.Where(numero => numero > 0);
        return listaSemNumerosNegativos.ToList();
    }

    public bool DeveConterDeterminadoNumeroNaLista(List<int> listaNumero, int numero)
    {
        var listaContem = listaNumero.Contains(numero);
        return listaContem;
    }

    public List<int> MultiplicarNumeroLista(List<int> list, int numero)
    {
        var listaMultiplicada = list.Select(num => numero * num).ToList();
        return listaMultiplicada;
    }

    public int MenorNumeroDaLista(List<int> list)
    {
        return list.Min();
    }

    public int MaiorNumeroLista(List<int> list)
    {
        return list.Max();
    }
}