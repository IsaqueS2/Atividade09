namespace Atividade09_exer05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            // Imprimir a frase em letras maiúsculas
            Console.WriteLine("Frase em letras maiúsculas: {0}", frase.ToUpper());

            // Imprimir a frase em letras minúsculas
            Console.WriteLine("Frase em letras minúsculas: {0}", frase.ToLower());

            // Imprimir a quantidade de caracteres da frase
            Console.WriteLine("Quantidade de caracteres da frase: {0}", frase.Length);

            // Imprimir a primeira palavra da frase
            string primeiraPalavra = frase.Substring(0, frase.IndexOf(' '));
            Console.WriteLine("Primeira palavra da frase: {0}", primeiraPalavra);

            // Imprimir a última palavra da frase
            string[] palavras = frase.Split(' ');
            string ultimaPalavra = palavras[palavras.Length - 1];
            Console.WriteLine("Última palavra da frase: {0}", ultimaPalavra);

            Console.ReadKey();
        }
    }
}