﻿using AppFakeStore.Views;
using CommunityToolkit.Mvvm.Input;

namespace AppFakeStore.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    public MainViewModel()
    {
        this.Title = "";
    }

    [RelayCommand]
    public async Task GoToProductoLista()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new ProductoListaPage());
    }

    [RelayCommand]
    public async Task GoToAcerca()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new AcercaPage());
    }

    [RelayCommand]
    public async Task GoToUsuarios()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new Usuarios());
    }

    [RelayCommand]
    public async Task Exit()
    {
        await OnSalirButtonClicked();
    }

    private async Task OnSalirButtonClicked()
    {
        bool respuesta = await Application.Current.MainPage.DisplayAlert("Salir", "¿Desea terminar la sesión y salir?", "Aceptar", "Cancelar");

        if (respuesta)
        {
            Application.Current.MainPage = new NavigationPage(new Login());
        }
    }
}
