
public class ValidacaoListasTestes
{

    private ValidacaoListas _validarListas = new ValidacaoListas();

    [Fact]
    public void RemoverNumerosNegativos()
    {
        // Arrange
        var lista = new List<int> { -1, -9, -8, 2, 3 };
        var resultadoEsperado = new List<int> { 2, 3 };

        // act
        var resultado = _validarListas.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterNumero12NaLista()
    {
        // Arrange
        var lista = new List<int> { 1, 2, 45, 12, 10 };
        int resultadoEsperado = 12;

        // Act
        var resultado = _validarListas.DeveConterDeterminadoNumeroNaLista(lista, resultadoEsperado);

        // Assert
        Assert.True(resultado);

    }

    [Fact]
    public void NaoDeveCOnterNumero10NaLista()
    {
        // Arrange
        var list = new List<int> { 8, 9, 12, 6 };
        int resultadoEsperado = 10;

        // Act
        var resultado = _validarListas.DeveConterDeterminadoNumeroNaLista(list, resultadoEsperado);

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        // Arrange
        var list = new List<int> { 2, 5, 6, 78, 14, 12 };
        //int numeroMultiplicador = 2;
        var resultadoEsperado = new List<int> { 4, 10, 12, 156, 28, 24 };

        // Act
        var resultado = _validarListas.MultiplicarNumeroLista(list, 2);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);

    }

    [Fact]
    public void Retornar9ComoMaiorNumeroDaLista()
    {
        // Arrange
        var list = new List<int> { 1, 3, 8, 6, 7, 9 };
        int resultadoEsperado = 9;

        // Act
        var resultado = _validarListas.MaiorNumeroLista(list);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        // Arrange
        var list = new List<int> { 1, 2, 3, 16, -7, -8, -1 };
        int resultadoEsperado = -8;

        // Act
        var resultado = _validarListas.MenorNumeroDaLista(list);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);

    }
}