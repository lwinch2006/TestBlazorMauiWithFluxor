namespace BlazorHybridApp.FluxorTypes.Actions;

public record IncrementCountAction
{
	public IncrementCountAction()
	{
		Console.WriteLine("Action created");
	}
}