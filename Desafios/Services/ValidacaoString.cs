
public class ValidacoesDeString
{
    public int RetornarQuantidadeCaracteres(string texto)
    {
        return texto.Length;
    }

    public bool ContemCaractere(string texto, string textoprocurado)
    {
        return texto.Contains(textoprocurado);
    }

    public bool TextoTerminaCom(string texto, string trechoTermina)
    {
        return texto.EndsWith(trechoTermina);
    }

}