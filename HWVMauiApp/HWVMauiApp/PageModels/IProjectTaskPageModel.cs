using CommunityToolkit.Mvvm.Input;
using HWVMauiApp.Models;

namespace HWVMauiApp.PageModels;

public interface IProjectTaskPageModel
{
	IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
	bool IsBusy { get; }
}