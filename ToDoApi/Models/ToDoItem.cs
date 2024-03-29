﻿using System;
namespace ToDoApi.Models
{
	public class ToDoItem
	{
		public long Id { get; set; }
		public string? Name { get; set; }
		public bool IsComplete { get; set; }

		// DTO approach to prevent over-posting
		public string? Secret { get; set; }
	}
	public class ToDoItemDTO
	{
		public long Id { get; set; }
		public string? Name { get; set; }
		public bool IsComplete { get; set; }
	}
}

