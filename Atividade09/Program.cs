namespace Atividade09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            string fraseTitle = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(frase);

            Console.WriteLine("Frase em Title Case: " + fraseTitle);
        }
    }
}