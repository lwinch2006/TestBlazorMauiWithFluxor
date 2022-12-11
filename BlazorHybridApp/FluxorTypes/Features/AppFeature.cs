using BlazorHybridApp.FluxorTypes.Stores;
using Fluxor;

namespace BlazorHybridApp.FluxorTypes.Features;

public class AppFeature : Feature<AppStore>
{
	public override string GetName() => nameof(AppStore);

	protected override AppStore GetInitialState()
	{
		return new AppStore
		{
			CurrentCount = 0
		};
	}
}