using BlazorHybridApp.FluxorTypes.Actions;
using BlazorHybridApp.FluxorTypes.Stores;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace BlazorHybridApp.Pages;

public partial class Counter
{
	private int _count;	

	[Inject] private IState<AppStore> State { get; set; } = default!;
	
	[Inject] private Fluxor.IDispatcher Dispatcher { get; set; } = default!;

	private AppStore AppStore => State.Value;
	
	private void IncrementCount()
	{
		Console.WriteLine("Before action");
		Dispatcher.Dispatch(new IncrementCountAction());
	}
	
	private void IncrementCountLocalFunction()
	{
		_count++;
	}
}