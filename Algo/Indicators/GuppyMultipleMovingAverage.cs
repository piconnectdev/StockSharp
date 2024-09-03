﻿namespace StockSharp.Algo.Indicators;

/// <summary>
/// Guppy Multiple Moving Average (GMMA).
/// </summary>
[Display(
	ResourceType = typeof(LocalizedStrings),
	Name = LocalizedStrings.GMMAKey,
	Description = LocalizedStrings.GuppyMultipleMovingAverageKey)]
[Doc("topics/indicators/guppy_multiple_moving_average.html")]
public class GuppyMultipleMovingAverage : BaseComplexIndicator
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GuppyMultipleMovingAverage"/>.
	/// </summary>
	public GuppyMultipleMovingAverage()
	{
		foreach (var length in new[] { 3, 5, 8, 10, 12, 15 }.Concat(new[] { 30, 35, 40, 45, 50, 60 }))
			AddInner(new ExponentialMovingAverage { Length = length });
	}
}