﻿namespace AutoMockHelper.SampleLogic.OrderProcessor
{
	using System.Collections.Generic;

	public class Order
	{
		public int OrderId { get; set; }
		public List<OrderItem> OrderItems { get; set; }

		public Customer Customer { get; set; }
	}
}