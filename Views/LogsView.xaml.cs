using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReyesMMProgIII.ViewModels;

namespace ReyesMMProgIII.Views;

public partial class LogsView : ContentPage
{
    LogsViewModel vm;
    public LogsView()
    {
        InitializeComponent();
        vm = new LogsViewModel();
        BindingContext = vm;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        vm.CargarLogs();
    }
}
