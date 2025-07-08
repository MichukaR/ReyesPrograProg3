using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReyesMMProgIII.ViewModels;

namespace ReyesMMProgIII.Views;

public partial class FormularioView : ContentPage
{
    public FormularioView()
    {
        InitializeComponent();
        BindingContext = new ProductoViewModel();
    }
}
