using System.Collections.ObjectModel;
using System.ComponentModel;
using ReyesMMProgIII.Models;
using ReyesMMProgIII.Repositories;

namespace ReyesMMProgIII.ViewModels;

public class ListaProductosViewModel : INotifyPropertyChanged
{
    public ObservableCollection<Producto> Productos { get; set; } = new();

    public void CargarProductos()
    {
        Productos.Clear();
        foreach (var p in SQLiteService.ObtenerTodos())
            Productos.Add(p);
    }

    public event PropertyChangedEventHandler PropertyChanged;
}
