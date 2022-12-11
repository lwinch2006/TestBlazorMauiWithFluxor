using BlazorHybridApp.FluxorTypes.Actions;
using BlazorHybridApp.FluxorTypes.Stores;
using Fluxor;

namespace BlazorHybridApp.FluxorTypes.Reducers;

public static class AppReducer
{
	[ReducerMethod(typeof(IncrementCountAction))]
	public static AppStore ReduceIncrementCountAction(AppStore appStore)
	{
		Console.WriteLine("Action processed");
		
		return appStore with { CurrentCount = appStore.CurrentCount + 1 };
	}
}