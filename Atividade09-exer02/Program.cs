namespace Atividade09_exer02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            int numPalavras = 0;

            foreach (string palavra in frase.Split(' '))
            {
                if (palavra.Length > 0)
                {
                    numPalavras++;
                }
            }

            Console.WriteLine("Número de palavras: " + numPalavras);
        }
    }
}