namespace ReyesMMProgIII.Repositories;

public static class LogService
{
    static string ruta = Path.Combine(FileSystem.AppDataDirectory, "Logs_Reyes.txt");

    public static void AgregarLog(string nombreProducto)
    {
        string log = $"Se incluyó el registro {nombreProducto} el {DateTime.Now:dd/MM/yyyy HH:mm}";
        File.AppendAllText(ruta, log + Environment.NewLine);
    }

    public static List<string> LeerLogs()
    {
        if (!File.Exists(ruta)) return new();
        return File.ReadAllLines(ruta).ToList();
    }
}
