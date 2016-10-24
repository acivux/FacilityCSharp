// DO NOT EDIT: generated by fsdgencsharp
using System;
using System.Collections.Generic;
using Facility.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Facility.ExampleApi
{
	/// <summary>
	/// Request for DeleteWidget.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public sealed partial class DeleteWidgetRequestDto : ServiceDto<DeleteWidgetRequestDto>
	{
		/// <summary>
		/// The widget ID.
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(DeleteWidgetRequestDto other)
		{
			return other != null &&
				Id == other.Id;
		}
	}
}
