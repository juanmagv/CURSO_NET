#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lunes_26_Alumnos
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="lunes26")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::lunes_26_Alumnos.Properties.Settings.Default.lunes26ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_Actualizar")]
		public int sp_Actualizar([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="NVarChar(30)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DNI", DbType="NVarChar(10)")] string dNI, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Turno", DbType="NVarChar(10)")] string turno, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Sexo", DbType="NVarChar(10)")] string sexo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Repetidor", DbType="Bit")] System.Nullable<bool> repetidor, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Modulo", DbType="NVarChar(10)")] string modulo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Especialidad", DbType="NVarChar(25)")] string especialidad)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombre, dNI, turno, sexo, repetidor, modulo, especialidad);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_Actualizar_por_codigo")]
		public int sp_Actualizar_por_codigo([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Codigo", DbType="Int")] System.Nullable<int> codigo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="NVarChar(30)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DNI", DbType="NVarChar(10)")] string dNI, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Turno", DbType="NVarChar(10)")] string turno, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Sexo", DbType="NVarChar(10)")] string sexo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Repetidor", DbType="Bit")] System.Nullable<bool> repetidor, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Modulo", DbType="NVarChar(10)")] string modulo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Especialidad", DbType="NVarChar(25)")] string especialidad)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), codigo, nombre, dNI, turno, sexo, repetidor, modulo, especialidad);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_Actualizar_por_DNI")]
		public int sp_Actualizar_por_DNI([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="NVarChar(30)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DNI", DbType="NVarChar(10)")] string dNI, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Turno", DbType="NVarChar(10)")] string turno, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Sexo", DbType="NVarChar(10)")] string sexo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Repetidor", DbType="Bit")] System.Nullable<bool> repetidor, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Modulo", DbType="NVarChar(10)")] string modulo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Especialidad", DbType="NVarChar(25)")] string especialidad)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombre, dNI, turno, sexo, repetidor, modulo, especialidad);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_alta")]
		public int sp_alta([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="NVarChar(30)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DNI", DbType="NVarChar(10)")] string dNI, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Turno", DbType="NVarChar(10)")] string turno, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Sexo", DbType="NVarChar(10)")] string sexo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Repetidor", DbType="Bit")] System.Nullable<bool> repetidor, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Modulo", DbType="NVarChar(10)")] string modulo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Especialidad", DbType="NVarChar(25)")] string especialidad)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombre, dNI, turno, sexo, repetidor, modulo, especialidad);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_borrar_por_codigo")]
		public int sp_borrar_por_codigo([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Codigo", DbType="Int")] System.Nullable<int> codigo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), codigo);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_borrar_por_DNI")]
		public int sp_borrar_por_DNI([global::System.Data.Linq.Mapping.ParameterAttribute(Name="DNI", DbType="NVarChar(10)")] string dNI)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), dNI);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_Buscar_por_Codigo")]
		public ISingleResult<sp_Buscar_por_CodigoResult> sp_Buscar_por_Codigo([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Codigo", DbType="Int")] System.Nullable<int> codigo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), codigo);
			return ((ISingleResult<sp_Buscar_por_CodigoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_Buscar_por_DNI")]
		public ISingleResult<sp_Buscar_por_DNIResult> sp_Buscar_por_DNI([global::System.Data.Linq.Mapping.ParameterAttribute(Name="DNI", DbType="NVarChar(10)")] string dNI)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), dNI);
			return ((ISingleResult<sp_Buscar_por_DNIResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ListarTodo")]
		public ISingleResult<ListarTodoResult> ListarTodo()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ListarTodoResult>)(result.ReturnValue));
		}
	}
	
	public partial class sp_Buscar_por_CodigoResult
	{
		
		private int _Codigo;
		
		private string _Nombre;
		
		private string _DNI;
		
		private string _Turno;
		
		private string _Sexo;
		
		private System.Nullable<bool> _Repetidor;
		
		private string _Modulo;
		
		private string _Especialidad;
		
		public sp_Buscar_por_CodigoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Codigo", DbType="Int NOT NULL")]
		public int Codigo
		{
			get
			{
				return this._Codigo;
			}
			set
			{
				if ((this._Codigo != value))
				{
					this._Codigo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNI", DbType="NVarChar(10)")]
		public string DNI
		{
			get
			{
				return this._DNI;
			}
			set
			{
				if ((this._DNI != value))
				{
					this._DNI = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Turno", DbType="NVarChar(10)")]
		public string Turno
		{
			get
			{
				return this._Turno;
			}
			set
			{
				if ((this._Turno != value))
				{
					this._Turno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sexo", DbType="NVarChar(10)")]
		public string Sexo
		{
			get
			{
				return this._Sexo;
			}
			set
			{
				if ((this._Sexo != value))
				{
					this._Sexo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Repetidor", DbType="Bit")]
		public System.Nullable<bool> Repetidor
		{
			get
			{
				return this._Repetidor;
			}
			set
			{
				if ((this._Repetidor != value))
				{
					this._Repetidor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modulo", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string Modulo
		{
			get
			{
				return this._Modulo;
			}
			set
			{
				if ((this._Modulo != value))
				{
					this._Modulo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Especialidad", DbType="NVarChar(25)")]
		public string Especialidad
		{
			get
			{
				return this._Especialidad;
			}
			set
			{
				if ((this._Especialidad != value))
				{
					this._Especialidad = value;
				}
			}
		}
	}
	
	public partial class sp_Buscar_por_DNIResult
	{
		
		private int _Codigo;
		
		private string _Nombre;
		
		private string _DNI;
		
		private string _Turno;
		
		private string _Sexo;
		
		private System.Nullable<bool> _Repetidor;
		
		private string _Modulo;
		
		private string _Especialidad;
		
		public sp_Buscar_por_DNIResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Codigo", DbType="Int NOT NULL")]
		public int Codigo
		{
			get
			{
				return this._Codigo;
			}
			set
			{
				if ((this._Codigo != value))
				{
					this._Codigo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNI", DbType="NVarChar(10)")]
		public string DNI
		{
			get
			{
				return this._DNI;
			}
			set
			{
				if ((this._DNI != value))
				{
					this._DNI = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Turno", DbType="NVarChar(10)")]
		public string Turno
		{
			get
			{
				return this._Turno;
			}
			set
			{
				if ((this._Turno != value))
				{
					this._Turno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sexo", DbType="NVarChar(10)")]
		public string Sexo
		{
			get
			{
				return this._Sexo;
			}
			set
			{
				if ((this._Sexo != value))
				{
					this._Sexo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Repetidor", DbType="Bit")]
		public System.Nullable<bool> Repetidor
		{
			get
			{
				return this._Repetidor;
			}
			set
			{
				if ((this._Repetidor != value))
				{
					this._Repetidor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modulo", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string Modulo
		{
			get
			{
				return this._Modulo;
			}
			set
			{
				if ((this._Modulo != value))
				{
					this._Modulo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Especialidad", DbType="NVarChar(25)")]
		public string Especialidad
		{
			get
			{
				return this._Especialidad;
			}
			set
			{
				if ((this._Especialidad != value))
				{
					this._Especialidad = value;
				}
			}
		}
	}
	
	public partial class ListarTodoResult
	{
		
		private int _Codigo;
		
		private string _Nombre;
		
		private string _DNI;
		
		private string _Turno;
		
		private string _Sexo;
		
		private System.Nullable<bool> _Repetidor;
		
		private string _Modulo;
		
		private string _Especialidad;
		
		public ListarTodoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Codigo", DbType="Int NOT NULL")]
		public int Codigo
		{
			get
			{
				return this._Codigo;
			}
			set
			{
				if ((this._Codigo != value))
				{
					this._Codigo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNI", DbType="NVarChar(10)")]
		public string DNI
		{
			get
			{
				return this._DNI;
			}
			set
			{
				if ((this._DNI != value))
				{
					this._DNI = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Turno", DbType="NVarChar(10)")]
		public string Turno
		{
			get
			{
				return this._Turno;
			}
			set
			{
				if ((this._Turno != value))
				{
					this._Turno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sexo", DbType="NVarChar(10)")]
		public string Sexo
		{
			get
			{
				return this._Sexo;
			}
			set
			{
				if ((this._Sexo != value))
				{
					this._Sexo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Repetidor", DbType="Bit")]
		public System.Nullable<bool> Repetidor
		{
			get
			{
				return this._Repetidor;
			}
			set
			{
				if ((this._Repetidor != value))
				{
					this._Repetidor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modulo", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string Modulo
		{
			get
			{
				return this._Modulo;
			}
			set
			{
				if ((this._Modulo != value))
				{
					this._Modulo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Especialidad", DbType="NVarChar(25)")]
		public string Especialidad
		{
			get
			{
				return this._Especialidad;
			}
			set
			{
				if ((this._Especialidad != value))
				{
					this._Especialidad = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
