using Instituição;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Coloque o nome do Departamento:");
            Departamentos d = new Departamentos();
            d.Nome = Console.ReadLine();
            Instituicao Itau = new Instituicao();
            Itau.Nome = "Itau";
            Itau.Endereço = "Rua do Itau, 123";
            Itau.GerarDepartamentos(d);
            Itau.ListarDepartamentos();
        }
    }
}