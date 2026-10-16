using Xunit;
using System;

namespace Teste_CARDIO_xUnit;

public class UnitTest1
{
    // --- TESTES DE CAMINHO FELIZ (VALIDAÇÃO DAS FÓRMULAS) ---

    [Fact]
    public void Teste_FórmulaTradicional_Idade20_DeveRetornar200()
    {
                int idade = 20;
        int resultadoEsperado = 200; // 220 - 20

       
        int resultadoObtido = 220 - idade;

       
        Assert.Equal(resultadoEsperado, resultadoObtido);
    }

    [Fact]
    public void Teste_EquaçãoTanaka_Idade20_DeveRetornar194()
    {
    
        int idade = 20;
        double resultadoEsperado = 194.0; 

        
        double resultadoObtido = 208 - (0.7 * idade);

      
        Assert.Equal(resultadoEsperado, resultadoObtido, 1);
    }

    [Fact]
    public void Teste_EquaçãoTanaka_Idade35_DeveRetornar183_5()
    {
        
        int idade = 35;
        double resultadoEsperado = 183.60; // 208 - (0.7 * 35)

       
        double resultadoObtido = 208 - (0.7 * idade);

        
        Assert.Equal(resultadoEsperado, resultadoObtido, 1);
    }
}

   