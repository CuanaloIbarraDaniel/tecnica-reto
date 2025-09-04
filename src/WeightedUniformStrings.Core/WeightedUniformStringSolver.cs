namespace WeightedUniformStrings.Core;

public class WeightedUniformStringSolver
{
    private int CalcularConjuntos(char conjunto)
    {
        string[] cadena_ponderada = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"];

        return 0;
    }


    public List<string> WeightedUniformStrings(string s, List<int> queries)
    {
        // Requisitos
        // tener cadena ponderada
        string[] cadena_ponderada = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"];
        List<int> conjuntos = new List<int>();

        // Separar la string
        char[] cadena_separada = s.ToCharArray();

        // Checar si existen subcadenas
        char letra_actual;
        int valor = 0;
        int valor_sumado = 0;


        for (int A1 = 0; A1 > cadena_separada.Length; A1++)
        {
            letra_actual = cadena_separada[A1];
            valor = Array.IndexOf(cadena_ponderada, letra_actual) + 1;

            // todo checar cuando sea el ultimo valor de la cadena separada
            if (letra_actual == cadena_separada[A1 + 1]) // la siguiente letra es igual
            {
                valor_sumado += valor;
            }
            else // 
            {
                valor = 0;
                valor_sumado = 0;
                conjuntos.Add(valor);
            }
        }

        // Calcular peso

        // Sumar peso

        // Checar si el peso de la subquery existe en el peso de la cadena

        // Returnar el yes si existe o el no

        return new List<string>();
    }
}
