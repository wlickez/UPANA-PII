using try_catch;

internal class Program
{
    private static void Main(string[] args)
    {
		FileInfo fileInfo = new FileInfo(@"C:\log.txt");
		try
		{
			if (!fileInfo.Exists) 
			{
				throw new CustomException(0, "no existe el archivo");
			}
		}

		catch (CustomException cEx)
		{
			cEx.ImprimirMensajeError();
		}
		catch (PathTooLongException ptlEx)
		{

		}
		catch (UnauthorizedAccessException uEx)
		{

		}
		catch (Exception)
		{

			
		}
    }
}