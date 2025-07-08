using System.Collections.ObjectModel;
using System.ComponentModel;
using ReyesMMProgIII.Repositories;

namespace ReyesMMProgIII.ViewModels;

public class LogsViewModel : INotifyPropertyChanged
{
    public ObservableCollection<string> Logs { get; set; } = new();

    public void CargarLogs()
    {
        Logs.Clear();
        foreach (var l in LogService.LeerLogs())
            Logs.Add(l);
    }

    public event PropertyChangedEventHandler PropertyChanged;
}
