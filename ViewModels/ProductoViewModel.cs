using System.ComponentModel;
using System.Windows.Input;
using ReyesMMProgIII.Models;
using ReyesMMProgIII.Repositories;

namespace ReyesMMProgIII.ViewModels;

public class ProductoViewModel : INotifyPropertyChanged
{
    public string Nombre { get; set; }
    public string Categoria { get; set; }
    public int Cantidad { get; set; } = 1;
    public decimal PrecioEstimado { get; set; }

    public ICommand GuardarCommand { get; }

    public ProductoViewModel()
    {
        GuardarCommand = new Command(Guardar);
    }

    private void Guardar()
    {
        if (Cantidad < 1 && Categoria.ToLower() != "ropa")
        {
            Application.Current.MainPage.DisplayAlert("Error", "La cantidad mínima debe ser 1 (excepto para Ropa)", "OK");
            return;
        }

        SQLiteService.Agregar(new Producto
        {
            Nombre = this.Nombre,
            Categoria = this.Categoria,
            Cantidad = this.Cantidad,
            PrecioEstimado = this.PrecioEstimado
        });

        LogService.AgregarLog(this.Nombre);

        // Limpiar formulario
        Nombre = Categoria = string.Empty;
        Cantidad = 1;
        PrecioEstimado = 0;
        OnPropertyChanged(null);
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string prop = "") => PropertyChanged?.Invoke(this, new(prop));
}
