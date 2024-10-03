//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v14.2.0+1b21caa
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Service Item 6</summary>
	[PublishedModel("serviceItem14")]
	public partial class ServiceItem14 : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const string ModelTypeAlias = "serviceItem14";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<ServiceItem14, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public ServiceItem14(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// FooterImage1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerImage1")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops FooterImage1 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "footerImage1");

		///<summary>
		/// FooterImage2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerImage2")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops FooterImage2 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "footerImage2");

		///<summary>
		/// HeaderImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops HeaderImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "headerImage");

		///<summary>
		/// pageTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => this.Value<string>(_publishedValueFallback, "pageTitle");

		///<summary>
		/// Second HeaderText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("secondHeaderText")]
		public virtual string SecondHeaderText => this.Value<string>(_publishedValueFallback, "secondHeaderText");

		///<summary>
		/// Service Left Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceLeftDescription")]
		public virtual string ServiceLeftDescription => this.Value<string>(_publishedValueFallback, "serviceLeftDescription");

		///<summary>
		/// Service Left Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceLeftHeadline")]
		public virtual string ServiceLeftHeadline => this.Value<string>(_publishedValueFallback, "serviceLeftHeadline");

		///<summary>
		/// Service Left Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceLeftImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ServiceLeftImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "serviceLeftImage");

		///<summary>
		/// Service Right Bottom Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceRightBottomImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ServiceRightBottomImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "serviceRightBottomImage");

		///<summary>
		/// Service Right Box2Content1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceRightBox2Content1")]
		public virtual string ServiceRightBox2Content1 => this.Value<string>(_publishedValueFallback, "serviceRightBox2Content1");

		///<summary>
		/// Service Right Box2Content2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceRightBox2Content2")]
		public virtual string ServiceRightBox2Content2 => this.Value<string>(_publishedValueFallback, "serviceRightBox2Content2");

		///<summary>
		/// Service Right Box2Content3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceRightBox2Content3")]
		public virtual string ServiceRightBox2Content3 => this.Value<string>(_publishedValueFallback, "serviceRightBox2Content3");

		///<summary>
		/// Service Right Box Content1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceRightBoxContent1")]
		public virtual string ServiceRightBoxContent1 => this.Value<string>(_publishedValueFallback, "serviceRightBoxContent1");

		///<summary>
		/// Service Right Box Content2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceRightBoxContent2")]
		public virtual string ServiceRightBoxContent2 => this.Value<string>(_publishedValueFallback, "serviceRightBoxContent2");

		///<summary>
		/// Service Right Box Content3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceRightBoxContent3")]
		public virtual string ServiceRightBoxContent3 => this.Value<string>(_publishedValueFallback, "serviceRightBoxContent3");

		///<summary>
		/// Service Right Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceRightHeadline")]
		public virtual string ServiceRightHeadline => this.Value<string>(_publishedValueFallback, "serviceRightHeadline");

		///<summary>
		/// Service Right Headline2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceRightHeadline2")]
		public virtual string ServiceRightHeadline2 => this.Value<string>(_publishedValueFallback, "serviceRightHeadline2");

		///<summary>
		/// Service Right Headline3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceRightHeadline3")]
		public virtual string ServiceRightHeadline3 => this.Value<string>(_publishedValueFallback, "serviceRightHeadline3");

		///<summary>
		/// Service Right Text1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceRightText1")]
		public virtual string ServiceRightText1 => this.Value<string>(_publishedValueFallback, "serviceRightText1");

		///<summary>
		/// Service Right Text2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceRightText2")]
		public virtual string ServiceRightText2 => this.Value<string>(_publishedValueFallback, "serviceRightText2");

		///<summary>
		/// Service Right Text3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceRightText3")]
		public virtual string ServiceRightText3 => this.Value<string>(_publishedValueFallback, "serviceRightText3");

		///<summary>
		/// Service Right Text4
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceRightText4")]
		public virtual string ServiceRightText4 => this.Value<string>(_publishedValueFallback, "serviceRightText4");

		///<summary>
		/// Service Right Text5
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceRightText5")]
		public virtual string ServiceRightText5 => this.Value<string>(_publishedValueFallback, "serviceRightText5");

		///<summary>
		/// Service Right Top Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceRightTopImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ServiceRightTopImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "serviceRightTopImage");
	}
}
