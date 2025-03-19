namespace ClassificacaoDeTriangulos.ConsoleApp;

public static class ClassificadorDeTriangulos
{
    public static bool MedidasFormamTrianguloValido(int ladoX, int ladoY, int ladoZ)
    {
        bool medidasTrianguloValidas =
            ladoX + ladoY > ladoZ &&
            ladoX + ladoZ > ladoY &&
            ladoY + ladoZ > ladoX;

        return medidasTrianguloValidas;
    }

    // Eqüilátero: Todos os lados iguais
    // Escaleno: Todos os lados diferentes
    // Isósceles: Dois lados iguais
    public static string ClassificarTriangulo(int ladoX, int ladoY, int ladoZ)
    {
        string tipoTriangulo = "Não classificado";

        if (ladoX == ladoY && ladoY == ladoZ)
            tipoTriangulo = "Eqüilátero";

        else if (ladoX != ladoY && ladoY != ladoZ && ladoX != ladoZ)
            tipoTriangulo = "Escaleno";

        else
            tipoTriangulo = "Isósceles";

        return tipoTriangulo;
    }
}