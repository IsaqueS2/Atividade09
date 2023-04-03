namespace Atividade09_exer03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um texto a ser criptografado: ");
            string texto = Console.ReadLine();

            Console.Write("Digite o número de posições para deslocar as letras: ");
            int deslocamento = int.Parse(Console.ReadLine());

            string textoCriptografado = Criptografar(texto, deslocamento);

            Console.WriteLine("Texto criptografado: " + textoCriptografado);
        }

        static string Criptografar(string texto, int deslocamento)
        {
            char[] letras = texto.ToCharArray();

            for (int i = 0; i < letras.Length; i++)
            {
                if (char.IsLetter(letras[i]))
                {
                    char letraCriptografada = (char)(letras[i] + deslocamento);

                    if ((char.IsUpper(letras[i]) && letraCriptografada > 'Z')
                            || (char.IsLower(letras[i]) && letraCriptografada > 'z'))
                    {
                        letraCriptografada = (char)(letraCriptografada - 26);
                    }

                    letras[i] = letraCriptografada;
                }
            }

            return new string(letras);
        }
    }
}