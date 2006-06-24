// 
// NHibernate.Mapping.Attributes
// This product is under the terms of the GNU Lesser General Public License.
//
//
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
//
//
// This source code was auto-generated by Refly, Version=2.21.1.0 (modified).
//
namespace NHibernate.Mapping.Attributes
{
	
	
	/// <summary> </summary>
	[System.AttributeUsage(System.AttributeTargets.Property | System.AttributeTargets.Field, AllowMultiple=true)]
	[System.Serializable()]
	public class IndexAttribute : BaseAttribute
	{
		
		private int _length = -1;
		
		private string _type = null;
		
		private string _column = null;
		
		/// <summary> Default constructor (position=0) </summary>
		public IndexAttribute() : 
				base(0)
		{
		}
		
		/// <summary> Constructor taking the position of the attribute. </summary>
		public IndexAttribute(int position) : 
				base(position)
		{
		}
		
		/// <summary> </summary>
		public virtual string Column
		{
			get
			{
				return this._column;
			}
			set
			{
				this._column = value;
			}
		}
		
		/// <summary> </summary>
		public virtual string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		
		/// <summary> </summary>
		public virtual System.Type TypeType
		{
			get
			{
				return System.Type.GetType( this.Type );
			}
			set
			{
				if(value.Assembly == typeof(int).Assembly)
					this.Type = value.FullName.Substring(7);
				else
					this.Type = value.FullName + ", " + value.Assembly.GetName().Name;
			}
		}
		
		/// <summary> </summary>
		public virtual int Length
		{
			get
			{
				return this._length;
			}
			set
			{
				this._length = value;
			}
		}
	}
}
