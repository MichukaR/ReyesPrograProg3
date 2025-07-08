using ReyesMMProgIII.Models;

namespace ReyesMMProgIII.Repositories;

public static class SQLiteService
{
    static SQLiteConnection db;

    public static void Init()
    {
        if (db != null) return;

        var ruta = Path.Combine(FileSystem.AppDataDirectory, "productos.db");
        db = new SQLiteConnection(ruta);
        db.CreateTable<Producto>();
    }

    public static void Agregar(Producto p) => db.Insert(p);

    public static List<Producto> ObtenerTodos() => db.Table<Producto>().ToList();
}
