// DO NOT EDIT: generated by fsdgencsharp
using System;
using System.Collections.Generic;
using Facility.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Facility.ExampleApi
{
	/// <summary>
	/// A widget job.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public sealed partial class WidgetJobDto : ServiceDto<WidgetJobDto>
	{
		/// <summary>
		/// Creates an instance.
		/// </summary>
		public WidgetJobDto()
		{
		}

		/// <summary>
		/// A unique identifier for the widget job.
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(WidgetJobDto other)
		{
			return other != null &&
				Id == other.Id;
		}
	}
}
