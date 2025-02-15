using HWVMauiApp.Models;
using HWVMauiApp.PageModels;

namespace HWVMauiApp.Pages;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}