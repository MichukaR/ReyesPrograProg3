using ReyesMMProgIII.Repositories;
namespace ReyesMMProgIII;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        SQLiteService.Init();
        MainPage = new AppShell();
    }
}

