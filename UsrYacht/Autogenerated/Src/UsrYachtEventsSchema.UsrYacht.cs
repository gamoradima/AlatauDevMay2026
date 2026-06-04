namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrYachtEventsSchema

	/// <exclude/>
	public class UsrYachtEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrYachtEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrYachtEventsSchema(UsrYachtEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a37041b1-8281-442d-b720-7e3992ed1981");
			Name = "UsrYachtEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d8d5e112-8665-46dc-b522-533b951b354e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,239,107,219,48,16,253,94,232,255,112,248,147,13,65,172,95,219,173,176,164,89,41,148,110,204,78,97,140,125,80,228,139,163,162,31,70,146,211,101,99,255,251,78,82,210,166,78,11,61,108,108,221,61,189,187,247,56,195,53,250,158,11,132,6,157,227,222,174,2,155,89,179,146,221,224,120,144,214,156,158,252,61,61,1,138,193,75,211,65,189,245,1,245,197,97,234,240,162,214,214,188,89,116,200,230,38,200,32,209,191,7,195,230,27,52,97,15,253,153,210,219,148,187,149,52,132,65,87,214,98,141,154,223,145,6,248,4,197,194,187,31,92,172,67,81,253,202,119,250,97,169,164,0,161,184,247,144,74,175,144,192,57,76,185,199,87,42,153,100,39,255,128,207,110,104,96,217,34,108,172,108,225,171,169,249,134,100,148,118,249,128,34,128,71,211,162,155,64,38,156,226,138,52,37,218,207,174,243,128,213,51,221,1,115,140,37,77,193,158,216,246,52,88,93,188,132,101,94,216,70,57,164,186,204,231,42,227,71,216,22,133,212,92,65,239,164,136,22,165,75,236,26,67,179,237,177,157,89,53,104,115,207,213,128,31,119,200,203,50,186,248,45,194,139,113,99,185,130,50,19,93,194,217,135,20,213,75,196,72,80,12,100,55,126,198,141,64,133,45,13,16,220,128,68,123,140,243,193,197,85,160,101,244,188,195,6,117,175,120,136,35,27,124,132,91,43,184,146,127,248,82,97,157,112,101,22,178,240,232,104,89,13,217,78,155,202,190,163,183,131,19,132,177,142,72,38,112,220,38,198,211,158,228,253,42,38,80,28,53,240,44,217,114,227,27,107,167,178,203,167,162,98,141,221,13,80,189,67,5,77,159,19,236,139,117,154,135,114,164,142,26,159,1,185,152,222,69,125,117,228,120,140,176,118,246,49,185,48,255,45,176,143,66,247,60,99,248,191,231,227,238,151,62,244,252,7,129,89,116,210,228,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4ffee622-0f45-2727-161f-faf954a8b278"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("d8d5e112-8665-46dc-b522-533b951b354e"),
				CreatedInSchemaUId = new Guid("a37041b1-8281-442d-b720-7e3992ed1981"),
				ModifiedInSchemaUId = new Guid("a37041b1-8281-442d-b720-7e3992ed1981")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a37041b1-8281-442d-b720-7e3992ed1981"));
		}

		#endregion

	}

	#endregion

}

