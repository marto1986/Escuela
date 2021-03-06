﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DALEscuela
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Test")]
	public partial class EscuelaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public EscuelaDataContext() : 
				base(global::DALEscuela.Properties.Settings.Default.TestConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public EscuelaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EscuelaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EscuelaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EscuelaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SPAalumnos")]
		public int SPAalumnos([global::System.Data.Linq.Mapping.ParameterAttribute(Name="AlumnoId", DbType="Int")] System.Nullable<int> alumnoId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(50)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ApPaterno", DbType="VarChar(50)")] string apPaterno, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ApMaterno", DbType="VarChar(50)")] string apMaterno, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="VarChar(50)")] string email)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), alumnoId, nombre, apPaterno, apMaterno, email);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SPEalumnos")]
		public int SPEalumnos([global::System.Data.Linq.Mapping.ParameterAttribute(Name="AlumnoId", DbType="Int")] System.Nullable<int> alumnoId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), alumnoId);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SPIalumnos")]
		public int SPIalumnos([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(50)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ApPaterno", DbType="VarChar(50)")] string apPaterno, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ApMaterno", DbType="VarChar(50)")] string apMaterno, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="VarChar(50)")] string email)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombre, apPaterno, apMaterno, email);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SPSalumnos")]
		public ISingleResult<SPSalumnosResult> SPSalumnos()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SPSalumnosResult>)(result.ReturnValue));
		}
	}
	
	public partial class SPSalumnosResult
	{
		
		private int _ClaveAlumno;
		
		private string _Nombre;
		
		private string _ApellidoPaterno;
		
		private string _ApellidoMaterno;
		
		private string _CorreoElectronico;
		
		public SPSalumnosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClaveAlumno", DbType="Int NOT NULL")]
		public int ClaveAlumno
		{
			get
			{
				return this._ClaveAlumno;
			}
			set
			{
				if ((this._ClaveAlumno != value))
				{
					this._ClaveAlumno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApellidoPaterno", DbType="VarChar(50)")]
		public string ApellidoPaterno
		{
			get
			{
				return this._ApellidoPaterno;
			}
			set
			{
				if ((this._ApellidoPaterno != value))
				{
					this._ApellidoPaterno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApellidoMaterno", DbType="VarChar(50)")]
		public string ApellidoMaterno
		{
			get
			{
				return this._ApellidoMaterno;
			}
			set
			{
				if ((this._ApellidoMaterno != value))
				{
					this._ApellidoMaterno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CorreoElectronico", DbType="VarChar(50)")]
		public string CorreoElectronico
		{
			get
			{
				return this._CorreoElectronico;
			}
			set
			{
				if ((this._CorreoElectronico != value))
				{
					this._CorreoElectronico = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
