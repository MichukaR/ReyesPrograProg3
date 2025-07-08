using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReyesMMProgIII.ViewModels;

namespace ReyesMMProgIII.Views;

public partial class ListaDeProductosView : ContentPage
{
    ListaProductosViewModel vm;
    public ListaDeProductosView()
    {
        InitializeComponent();
        vm = new ListaProductosViewModel();
        BindingContext = vm;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        vm.CargarProductos();
    }
}
