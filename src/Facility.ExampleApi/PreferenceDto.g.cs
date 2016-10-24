// DO NOT EDIT: generated by fsdgencsharp
using System;
using System.Collections.Generic;
using Facility.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Facility.ExampleApi
{
	/// <summary>
	/// A preference.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public sealed partial class PreferenceDto : ServiceDto<PreferenceDto>
	{
		[JsonProperty("boolean")]
		public bool? IsBoolean { get; set; }

		public IReadOnlyList<bool> Booleans { get; set; }

		public double? Double { get; set; }

		public IReadOnlyList<double> Doubles { get; set; }

		public int? Integer { get; set; }

		public IReadOnlyList<int> Integers { get; set; }

		public string String { get; set; }

		public IReadOnlyList<string> Strings { get; set; }

		public byte[] Bytes { get; set; }

		public IReadOnlyList<byte[]> Byteses { get; set; }

		public WidgetField? WidgetField { get; set; }

		public IReadOnlyList<WidgetField> WidgetFields { get; set; }

		public WidgetDto Widget { get; set; }

		public IReadOnlyList<WidgetDto> Widgets { get; set; }

		public ServiceResult<WidgetDto> Result { get; set; }

		public IReadOnlyList<ServiceResult<WidgetDto>> Results { get; set; }

		public long? BigInteger { get; set; }

		public IReadOnlyList<long> BigIntegers { get; set; }

		public ServiceErrorDto Error { get; set; }

		public IReadOnlyList<ServiceErrorDto> Errors { get; set; }

		public JObject Object { get; set; }

		public IReadOnlyList<JObject> Objects { get; set; }

		public IReadOnlyDictionary<string, string> NamedStrings { get; set; }

		public IReadOnlyDictionary<string, WidgetDto> NamedWidgets { get; set; }

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(PreferenceDto other)
		{
			return other != null &&
				IsBoolean == other.IsBoolean &&
				ServiceDataUtility.AreEquivalentArrays(Booleans, other.Booleans) &&
				Double == other.Double &&
				ServiceDataUtility.AreEquivalentArrays(Doubles, other.Doubles) &&
				Integer == other.Integer &&
				ServiceDataUtility.AreEquivalentArrays(Integers, other.Integers) &&
				String == other.String &&
				ServiceDataUtility.AreEquivalentArrays(Strings, other.Strings) &&
				ServiceDataUtility.AreEquivalentBytes(Bytes, other.Bytes) &&
				ServiceDataUtility.AreEquivalentArrays(Byteses, other.Byteses, ServiceDataUtility.AreEquivalentBytes) &&
				WidgetField == other.WidgetField &&
				ServiceDataUtility.AreEquivalentArrays(WidgetFields, other.WidgetFields) &&
				ServiceDataUtility.AreEquivalentDtos(Widget, other.Widget) &&
				ServiceDataUtility.AreEquivalentArrays(Widgets, other.Widgets, ServiceDataUtility.AreEquivalentDtos) &&
				ServiceDataUtility.AreEquivalentResults(Result, other.Result) &&
				ServiceDataUtility.AreEquivalentArrays(Results, other.Results, ServiceDataUtility.AreEquivalentResults) &&
				BigInteger == other.BigInteger &&
				ServiceDataUtility.AreEquivalentArrays(BigIntegers, other.BigIntegers) &&
				ServiceDataUtility.AreEquivalentDtos(Error, other.Error) &&
				ServiceDataUtility.AreEquivalentArrays(Errors, other.Errors, ServiceDataUtility.AreEquivalentDtos) &&
				ServiceDataUtility.AreEquivalentObjects(Object, other.Object) &&
				ServiceDataUtility.AreEquivalentArrays(Objects, other.Objects, ServiceDataUtility.AreEquivalentObjects) &&
				ServiceDataUtility.AreEquivalentMaps(NamedStrings, other.NamedStrings) &&
				ServiceDataUtility.AreEquivalentMaps(NamedWidgets, other.NamedWidgets, ServiceDataUtility.AreEquivalentDtos);
		}
	}
}
