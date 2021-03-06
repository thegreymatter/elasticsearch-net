﻿using System.Collections.Generic;

namespace Nest
{

	public class PercentileItem
	{
		public double Percentile { get; internal set; }
		public double Value { get; internal set; }
	}
	public class PercentilesMetric : IMetricAggregation
	{
		public PercentilesMetric()
		{
			this.Items = new List<PercentileItem>();
		}
		public IList<PercentileItem> Items { get; internal set; }
	}
}