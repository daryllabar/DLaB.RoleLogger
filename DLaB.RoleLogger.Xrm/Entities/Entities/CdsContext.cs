//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// Created via this command line: "C:\Users\DarylLaBar\AppData\Roaming\MscrmTools\XrmToolBox\Plugins\DLaB.EarlyBoundGenerator\crmsvcutil.exe" /url:"https://dlabdev.api.crm.dynamics.com/XRMServices/2011/Organization.svc" /namespace:"DLaB.RoleLogger.Xrm.Entities" /out:"C:\Temp\DLaB.RoleLogger\DLaB.RoleLogger.Xrm\Entities\Entities\CdsContext.cs" /servicecontextname:"CdsContext" /SuppressGeneratedCodeAttribute /codecustomization:"DLaB.CrmSvcUtilExtensions.Entity.CustomizeCodeDomService,DLaB.CrmSvcUtilExtensions" /codegenerationservice:"DLaB.CrmSvcUtilExtensions.Entity.CustomCodeGenerationService,DLaB.CrmSvcUtilExtensions" /codewriterfilter:"DLaB.CrmSvcUtilExtensions.Entity.CodeWriterFilterService,DLaB.CrmSvcUtilExtensions" /namingservice:"DLaB.CrmSvcUtilExtensions.NamingService,DLaB.CrmSvcUtilExtensions" /metadataproviderservice:"DLaB.CrmSvcUtilExtensions.Entity.MetadataProviderService,DLaB.CrmSvcUtilExtensions" /username:"daryl@gapintegrity.com" /password:"***************" 
//------------------------------------------------------------------------------

[assembly: Microsoft.Xrm.Sdk.Client.ProxyTypesAssemblyAttribute()]
[assembly: System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.70")]

namespace DLaB.RoleLogger.Xrm.Entities
{
	
	/// <summary>
	/// Represents a source of entities bound to a CRM service. It tracks and manages changes made to the retrieved entities.
	/// </summary>
	public partial class CdsContext : Microsoft.Xrm.Sdk.Client.OrganizationServiceContext
	{
		
		/// <summary>
		/// Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public CdsContext(Microsoft.Xrm.Sdk.IOrganizationService service) : 
				base(service)
		{
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="DLaB.RoleLogger.Xrm.Entities.Account"/> entities.
		/// </summary>
		public System.Linq.IQueryable<DLaB.RoleLogger.Xrm.Entities.Account> AccountSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<DLaB.RoleLogger.Xrm.Entities.Account>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="DLaB.RoleLogger.Xrm.Entities.BusinessUnit"/> entities.
		/// </summary>
		public System.Linq.IQueryable<DLaB.RoleLogger.Xrm.Entities.BusinessUnit> BusinessUnitSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<DLaB.RoleLogger.Xrm.Entities.BusinessUnit>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="DLaB.RoleLogger.Xrm.Entities.Competitor"/> entities.
		/// </summary>
		public System.Linq.IQueryable<DLaB.RoleLogger.Xrm.Entities.Competitor> CompetitorSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<DLaB.RoleLogger.Xrm.Entities.Competitor>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="DLaB.RoleLogger.Xrm.Entities.Contact"/> entities.
		/// </summary>
		public System.Linq.IQueryable<DLaB.RoleLogger.Xrm.Entities.Contact> ContactSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<DLaB.RoleLogger.Xrm.Entities.Contact>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="DLaB.RoleLogger.Xrm.Entities.Lead"/> entities.
		/// </summary>
		public System.Linq.IQueryable<DLaB.RoleLogger.Xrm.Entities.Lead> LeadSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<DLaB.RoleLogger.Xrm.Entities.Lead>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="DLaB.RoleLogger.Xrm.Entities.Post"/> entities.
		/// </summary>
		public System.Linq.IQueryable<DLaB.RoleLogger.Xrm.Entities.Post> PostSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<DLaB.RoleLogger.Xrm.Entities.Post>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="DLaB.RoleLogger.Xrm.Entities.Product"/> entities.
		/// </summary>
		public System.Linq.IQueryable<DLaB.RoleLogger.Xrm.Entities.Product> ProductSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<DLaB.RoleLogger.Xrm.Entities.Product>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="DLaB.RoleLogger.Xrm.Entities.Role"/> entities.
		/// </summary>
		public System.Linq.IQueryable<DLaB.RoleLogger.Xrm.Entities.Role> RoleSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<DLaB.RoleLogger.Xrm.Entities.Role>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="DLaB.RoleLogger.Xrm.Entities.Site"/> entities.
		/// </summary>
		public System.Linq.IQueryable<DLaB.RoleLogger.Xrm.Entities.Site> SiteSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<DLaB.RoleLogger.Xrm.Entities.Site>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="DLaB.RoleLogger.Xrm.Entities.SystemUser"/> entities.
		/// </summary>
		public System.Linq.IQueryable<DLaB.RoleLogger.Xrm.Entities.SystemUser> SystemUserSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<DLaB.RoleLogger.Xrm.Entities.SystemUser>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="DLaB.RoleLogger.Xrm.Entities.SystemUserRoles"/> entities.
		/// </summary>
		public System.Linq.IQueryable<DLaB.RoleLogger.Xrm.Entities.SystemUserRoles> SystemUserRolesSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<DLaB.RoleLogger.Xrm.Entities.SystemUserRoles>();
			}
		}
	}
	
	internal sealed class EntityOptionSetEnum
	{
		
		[System.Diagnostics.DebuggerNonUserCode()]
		public static System.Nullable<int> GetEnum(Microsoft.Xrm.Sdk.Entity entity, string attributeLogicalName)
		{
			if (entity.Attributes.ContainsKey(attributeLogicalName))
			{
				Microsoft.Xrm.Sdk.OptionSetValue value = entity.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>(attributeLogicalName);
				if (value != null)
				{
					return value.Value;
				}
			}
			return null;
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		public static System.Collections.Generic.IEnumerable<T> GetMultiEnum<T>(Microsoft.Xrm.Sdk.Entity entity, string attributeLogicalName)
		
		{
			Microsoft.Xrm.Sdk.OptionSetValueCollection value = entity.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValueCollection>(attributeLogicalName);
			System.Collections.Generic.List<T> list = new System.Collections.Generic.List<T>();
			if (value == null)
			{
				return list;
			}
			list.AddRange(System.Linq.Enumerable.Select(value, v => (T)(object)v.Value));
			return list;
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		public static Microsoft.Xrm.Sdk.OptionSetValueCollection GetMultiEnum<T>(Microsoft.Xrm.Sdk.Entity entity, string attributeLogicalName, System.Collections.Generic.IEnumerable<T> values)
		
		{
			Microsoft.Xrm.Sdk.OptionSetValueCollection collection = new Microsoft.Xrm.Sdk.OptionSetValueCollection();
			collection.AddRange(System.Linq.Enumerable.Select(values, v => new Microsoft.Xrm.Sdk.OptionSetValue((int)(object)v)));
			return collection;
		}
	}
	
	/// <summary>
	/// Attribute to handle storing the OptionSet's Metadata.
	/// </summary>
	[System.AttributeUsageAttribute(System.AttributeTargets.Field)]
	public sealed class OptionSetMetadataAttribute : System.Attribute
	{
		
		/// <summary>
		/// Color of the OptionSetValue.
		/// </summary>
		public string Color { get; set; }
		
		/// <summary>
		/// Description of the OptionSetValue.
		/// </summary>
		public string Description { get; set; }
		
		/// <summary>
		/// Display order index of the OptionSetValue.
		/// </summary>
		public int DisplayIndex { get; set; }
		
		/// <summary>
		/// External value of the OptionSetValue.
		/// </summary>
		public string ExternalValue { get; set; }
		
		/// <summary>
		/// Name of the OptionSetValue.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		/// Initializes a new instance of the <see cref="OptionSetMetadataAttribute"/> class.
		/// </summary>
		/// <param name="name">Name of the value.</param>
		/// <param name="displayIndex">Display order index of the value.</param>
		/// <param name="color">Color of the value.</param>
		/// <param name="description">Description of the value.</param>
		/// <param name="externalValue">External value of the value.</param>
		[System.Diagnostics.DebuggerNonUserCode()]
		public OptionSetMetadataAttribute(string name, int displayIndex, string color = null, string description = null, string externalValue = null)
		{
			this.Color = color;
			this.Description = description;
			this.ExternalValue = externalValue;
			this.DisplayIndex = displayIndex;
			this.Name = name;
		}
	}
	
	/// <summary>
	/// Extension class to handle retrieving of OptionSetMetadataAttribute.
	/// </summary>
	public static class OptionSetExtension
	{
		
		/// <summary>
		/// Returns the OptionSetMetadataAttribute for the given enum value
		/// </summary>
		/// <typeparam name="T">OptionSet Enum Type</typeparam>
		/// <param name="value">Enum Value with OptionSetMetadataAttribute</param>
		[System.Diagnostics.DebuggerNonUserCode()]
		public static OptionSetMetadataAttribute GetMetadata<T>(this T value)
			where T :  struct, System.IConvertible
		{
			System.Type enumType = typeof(T);
			if (!enumType.IsEnum)
			{
				throw new System.ArgumentException("T must be an enum!");
			}
			System.Reflection.MemberInfo[] members = enumType.GetMember(value.ToString());
			for (int i = 0; (i < members.Length); i++
			)
			{
				System.Attribute attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(members[i], typeof(OptionSetMetadataAttribute));
				if (attribute != null)
				{
					return ((OptionSetMetadataAttribute)(attribute));
				}
			}
			throw new System.ArgumentException("T must be an enum adorned with an OptionSetMetadataAttribute!");
		}
	}
}