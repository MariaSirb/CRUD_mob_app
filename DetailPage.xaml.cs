using CommunityToolkit.Mvvm.ComponentModel;
using CRUD_mob_app.ViewModels;

namespace CRUD_mob_app;


public partial class DetailPage : ContentPage
{
	public DetailPage()
	{
		InitializeComponent();
        BindingContext = new DetailViewModel();
    }
	
}