
public class ValidacoesStrigTestes
{
    private ValidacoesDeString _validarString = new();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        // Arrange
        string texto = "Matrix";
        int resultadoEsperado = 6;

        // Act
        var resultado = _validarString.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);

    }


    [Fact]
    public void NaoDeveConterApalavraNoTexto()
    {
        // Arrange
        string texto = "Hoje eu Estou procurando aprender mais sobre TDD";
        string textoProcurado = "DDD";


        // Act
        var resultado = _validarString.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.False(resultado);

    }


    [Fact]
    public void TextoDeveterminarComApalavaraProcurada()
    {
        // Arrange
        string texto = "Testes Unitarios é muito importante no desenvolvimento de um software.";
        string resultadoEsperado = "software.";

        // Act
        var resultado = _validarString.TextoTerminaCom(texto, resultadoEsperado);

        // Assert
        Assert.True(resultado);

    }


    [Fact]
    public void DeveConterApalavraNoTexto()
    {
        // Arrange
        string texto = "POO é Formado por 4 pilares que são -> Herança, Encapsulamento, Polimorfismo e Abstração";
        string resultadoEsperado = "Herança";

        // Act
        var resultado = _validarString.ContemCaractere(texto, resultadoEsperado);

        // Asserte
        Assert.True(resultado);
    }

}// Fim Class