internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        DataAccesFile dataAccesFile = null;

        if (variable)
            dataAccesFile = new AdminAcces();
        else
            dataAccesFile = new RegularAcces();
    }
}
interface IDataAccess
{
    void Borrar();
    void Copiar();
}
class DataAccesFile //clase padre
{
    public string path;

    
    public virtual void ReadFile()
    {
        System.Console.WriteLine("Metodo propio");
    }

    public virtual void WriteFile()
    {

    }
}

//clase hija
class AdminAcces : DataAccesFile
{
    public override void ReadFile()
    {
        var internalPath = "";
        internalPath = "Esto es un ejemplo";

        System.Console.WriteLine(internalPath);
    }
}


//clase hija
class RegularAcces : DataAccesFile
{
    public override void ReadFile()
    {
        var otroPath = "";
        otroPath = "Otra prueba";
        System.Console.WriteLine(otroPath);
    }
}