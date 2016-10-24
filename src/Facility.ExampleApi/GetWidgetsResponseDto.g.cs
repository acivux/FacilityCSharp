// DO NOT EDIT: generated by fsdgencsharp
using System;
using System.Collections.Generic;
using Facility.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

#pragma warning disable 612 // member is obsolete

namespace Facility.ExampleApi
{
	/// <summary>
	/// Response for GetWidgets.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public sealed partial class GetWidgetsResponseDto : ServiceDto<GetWidgetsResponseDto>
	{
		/// <summary>
		/// The widgets.
		/// </summary>
		public IReadOnlyList<WidgetDto> Widgets { get; set; }

		/// <summary>
		/// The total number of widgets.
		/// </summary>
		public long? Total { get; set; }

		/// <summary>
		/// The total weight.
		/// </summary>
		[Obsolete]
		public double? TotalWeight { get; set; }

		/// <summary>
		/// The pending job.
		/// </summary>
		public WidgetJobDto Job { get; set; }

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(GetWidgetsResponseDto other)
		{
			return other != null &&
				ServiceDataUtility.AreEquivalentArrays(Widgets, other.Widgets, ServiceDataUtility.AreEquivalentDtos) &&
				Total == other.Total &&
				TotalWeight == other.TotalWeight &&
				ServiceDataUtility.AreEquivalentDtos(Job, other.Job);
		}
	}
}
