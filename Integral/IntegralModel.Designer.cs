﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("integralDataModel", "FK_Montos_0", "Disciplinas", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Integral.Disciplina), "Montos", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Integral.Monto), true)]
[assembly: EdmRelationshipAttribute("integralDataModel", "FK_Montos_1", "Pagos", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Integral.Pago), "Montos", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Integral.Monto), true)]
[assembly: EdmRelationshipAttribute("integralDataModel", "FK_Pagos_0", "Socios", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Integral.Socio), "Pagos", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Integral.Pago), true)]
[assembly: EdmRelationshipAttribute("integralDataModel", "SocioDisciplina", "Disciplinas", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Integral.Disciplina), "Socios", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Integral.Socio))]

#endregion

namespace Integral
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class integralDataEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new integralDataEntities object using the connection string found in the 'integralDataEntities' section of the application configuration file.
        /// </summary>
        public integralDataEntities() : base("name=integralDataEntities", "integralDataEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new integralDataEntities object.
        /// </summary>
        public integralDataEntities(string connectionString) : base(connectionString, "integralDataEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new integralDataEntities object.
        /// </summary>
        public integralDataEntities(EntityConnection connection) : base(connection, "integralDataEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Disciplina> Disciplinas
        {
            get
            {
                if ((_Disciplinas == null))
                {
                    _Disciplinas = base.CreateObjectSet<Disciplina>("Disciplinas");
                }
                return _Disciplinas;
            }
        }
        private ObjectSet<Disciplina> _Disciplinas;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Monto> Montos
        {
            get
            {
                if ((_Montos == null))
                {
                    _Montos = base.CreateObjectSet<Monto>("Montos");
                }
                return _Montos;
            }
        }
        private ObjectSet<Monto> _Montos;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Pago> Pagos
        {
            get
            {
                if ((_Pagos == null))
                {
                    _Pagos = base.CreateObjectSet<Pago>("Pagos");
                }
                return _Pagos;
            }
        }
        private ObjectSet<Pago> _Pagos;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Socio> Socios
        {
            get
            {
                if ((_Socios == null))
                {
                    _Socios = base.CreateObjectSet<Socio>("Socios");
                }
                return _Socios;
            }
        }
        private ObjectSet<Socio> _Socios;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Disciplinas EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDisciplinas(Disciplina disciplina)
        {
            base.AddObject("Disciplinas", disciplina);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Montos EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMontos(Monto monto)
        {
            base.AddObject("Montos", monto);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Pagos EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPagos(Pago pago)
        {
            base.AddObject("Pagos", pago);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Socios EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToSocios(Socio socio)
        {
            base.AddObject("Socios", socio);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="integralDataModel", Name="Disciplina")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Disciplina : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Disciplina object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="nombre">Initial value of the Nombre property.</param>
        /// <param name="habilitada">Initial value of the Habilitada property.</param>
        public static Disciplina CreateDisciplina(global::System.Int64 id, global::System.String nombre, global::System.Boolean habilitada)
        {
            Disciplina disciplina = new Disciplina();
            disciplina.Id = id;
            disciplina.Nombre = nombre;
            disciplina.Habilitada = habilitada;
            return disciplina;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int64 _Id;
        partial void OnIdChanging(global::System.Int64 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                OnNombreChanging(value);
                ReportPropertyChanging("Nombre");
                _Nombre = StructuralObject.SetValidValue(value, false, "Nombre");
                ReportPropertyChanged("Nombre");
                OnNombreChanged();
            }
        }
        private global::System.String _Nombre;
        partial void OnNombreChanging(global::System.String value);
        partial void OnNombreChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Double> Cuota
        {
            get
            {
                return _Cuota;
            }
            set
            {
                OnCuotaChanging(value);
                ReportPropertyChanging("Cuota");
                _Cuota = StructuralObject.SetValidValue(value, "Cuota");
                ReportPropertyChanged("Cuota");
                OnCuotaChanged();
            }
        }
        private Nullable<global::System.Double> _Cuota;
        partial void OnCuotaChanging(Nullable<global::System.Double> value);
        partial void OnCuotaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Profesor
        {
            get
            {
                return _Profesor;
            }
            set
            {
                OnProfesorChanging(value);
                ReportPropertyChanging("Profesor");
                _Profesor = StructuralObject.SetValidValue(value, true, "Profesor");
                ReportPropertyChanged("Profesor");
                OnProfesorChanged();
            }
        }
        private global::System.String _Profesor;
        partial void OnProfesorChanging(global::System.String value);
        partial void OnProfesorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ContactoProfesor
        {
            get
            {
                return _ContactoProfesor;
            }
            set
            {
                OnContactoProfesorChanging(value);
                ReportPropertyChanging("ContactoProfesor");
                _ContactoProfesor = StructuralObject.SetValidValue(value, true, "ContactoProfesor");
                ReportPropertyChanged("ContactoProfesor");
                OnContactoProfesorChanged();
            }
        }
        private global::System.String _ContactoProfesor;
        partial void OnContactoProfesorChanging(global::System.String value);
        partial void OnContactoProfesorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Habilitada
        {
            get
            {
                return _Habilitada;
            }
            set
            {
                OnHabilitadaChanging(value);
                ReportPropertyChanging("Habilitada");
                _Habilitada = StructuralObject.SetValidValue(value, "Habilitada");
                ReportPropertyChanged("Habilitada");
                OnHabilitadaChanged();
            }
        }
        private global::System.Boolean _Habilitada;
        partial void OnHabilitadaChanging(global::System.Boolean value);
        partial void OnHabilitadaChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("integralDataModel", "FK_Montos_0", "Montos")]
        public EntityCollection<Monto> Montos
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Monto>("integralDataModel.FK_Montos_0", "Montos");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Monto>("integralDataModel.FK_Montos_0", "Montos", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("integralDataModel", "SocioDisciplina", "Socios")]
        public EntityCollection<Socio> Socios
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Socio>("integralDataModel.SocioDisciplina", "Socios");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Socio>("integralDataModel.SocioDisciplina", "Socios", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="integralDataModel", Name="Monto")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Monto : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Monto object.
        /// </summary>
        /// <param name="pagoId">Initial value of the PagoId property.</param>
        /// <param name="disciplinaId">Initial value of the DisciplinaId property.</param>
        /// <param name="montoParcial">Initial value of the MontoParcial property.</param>
        /// <param name="id">Initial value of the Id property.</param>
        public static Monto CreateMonto(global::System.Int64 pagoId, global::System.Int64 disciplinaId, global::System.Double montoParcial, global::System.Int64 id)
        {
            Monto monto = new Monto();
            monto.PagoId = pagoId;
            monto.DisciplinaId = disciplinaId;
            monto.MontoParcial = montoParcial;
            monto.Id = id;
            return monto;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 PagoId
        {
            get
            {
                return _PagoId;
            }
            set
            {
                OnPagoIdChanging(value);
                ReportPropertyChanging("PagoId");
                _PagoId = StructuralObject.SetValidValue(value, "PagoId");
                ReportPropertyChanged("PagoId");
                OnPagoIdChanged();
            }
        }
        private global::System.Int64 _PagoId;
        partial void OnPagoIdChanging(global::System.Int64 value);
        partial void OnPagoIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 DisciplinaId
        {
            get
            {
                return _DisciplinaId;
            }
            set
            {
                OnDisciplinaIdChanging(value);
                ReportPropertyChanging("DisciplinaId");
                _DisciplinaId = StructuralObject.SetValidValue(value, "DisciplinaId");
                ReportPropertyChanged("DisciplinaId");
                OnDisciplinaIdChanged();
            }
        }
        private global::System.Int64 _DisciplinaId;
        partial void OnDisciplinaIdChanging(global::System.Int64 value);
        partial void OnDisciplinaIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double MontoParcial
        {
            get
            {
                return _MontoParcial;
            }
            set
            {
                OnMontoParcialChanging(value);
                ReportPropertyChanging("MontoParcial");
                _MontoParcial = StructuralObject.SetValidValue(value, "MontoParcial");
                ReportPropertyChanged("MontoParcial");
                OnMontoParcialChanged();
            }
        }
        private global::System.Double _MontoParcial;
        partial void OnMontoParcialChanging(global::System.Double value);
        partial void OnMontoParcialChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int64 _Id;
        partial void OnIdChanging(global::System.Int64 value);
        partial void OnIdChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("integralDataModel", "FK_Montos_0", "Disciplinas")]
        public Disciplina Disciplina
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Disciplina>("integralDataModel.FK_Montos_0", "Disciplinas").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Disciplina>("integralDataModel.FK_Montos_0", "Disciplinas").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Disciplina> DisciplinaReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Disciplina>("integralDataModel.FK_Montos_0", "Disciplinas");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Disciplina>("integralDataModel.FK_Montos_0", "Disciplinas", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("integralDataModel", "FK_Montos_1", "Pagos")]
        public Pago Pago
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Pago>("integralDataModel.FK_Montos_1", "Pagos").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Pago>("integralDataModel.FK_Montos_1", "Pagos").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Pago> PagoReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Pago>("integralDataModel.FK_Montos_1", "Pagos");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Pago>("integralDataModel.FK_Montos_1", "Pagos", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="integralDataModel", Name="Pago")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Pago : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Pago object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="mesPago">Initial value of the MesPago property.</param>
        /// <param name="montoTotal">Initial value of the MontoTotal property.</param>
        /// <param name="fecha">Initial value of the Fecha property.</param>
        /// <param name="socioId">Initial value of the SocioId property.</param>
        public static Pago CreatePago(global::System.Int64 id, global::System.DateTime mesPago, global::System.Double montoTotal, global::System.DateTime fecha, global::System.Int64 socioId)
        {
            Pago pago = new Pago();
            pago.Id = id;
            pago.MesPago = mesPago;
            pago.MontoTotal = montoTotal;
            pago.Fecha = fecha;
            pago.SocioId = socioId;
            return pago;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int64 _Id;
        partial void OnIdChanging(global::System.Int64 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime MesPago
        {
            get
            {
                return _MesPago;
            }
            set
            {
                OnMesPagoChanging(value);
                ReportPropertyChanging("MesPago");
                _MesPago = StructuralObject.SetValidValue(value, "MesPago");
                ReportPropertyChanged("MesPago");
                OnMesPagoChanged();
            }
        }
        private global::System.DateTime _MesPago;
        partial void OnMesPagoChanging(global::System.DateTime value);
        partial void OnMesPagoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double MontoTotal
        {
            get
            {
                return _MontoTotal;
            }
            set
            {
                OnMontoTotalChanging(value);
                ReportPropertyChanging("MontoTotal");
                _MontoTotal = StructuralObject.SetValidValue(value, "MontoTotal");
                ReportPropertyChanged("MontoTotal");
                OnMontoTotalChanged();
            }
        }
        private global::System.Double _MontoTotal;
        partial void OnMontoTotalChanging(global::System.Double value);
        partial void OnMontoTotalChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime Fecha
        {
            get
            {
                return _Fecha;
            }
            set
            {
                OnFechaChanging(value);
                ReportPropertyChanging("Fecha");
                _Fecha = StructuralObject.SetValidValue(value, "Fecha");
                ReportPropertyChanged("Fecha");
                OnFechaChanged();
            }
        }
        private global::System.DateTime _Fecha;
        partial void OnFechaChanging(global::System.DateTime value);
        partial void OnFechaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 SocioId
        {
            get
            {
                return _SocioId;
            }
            set
            {
                OnSocioIdChanging(value);
                ReportPropertyChanging("SocioId");
                _SocioId = StructuralObject.SetValidValue(value, "SocioId");
                ReportPropertyChanged("SocioId");
                OnSocioIdChanged();
            }
        }
        private global::System.Int64 _SocioId;
        partial void OnSocioIdChanging(global::System.Int64 value);
        partial void OnSocioIdChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("integralDataModel", "FK_Montos_1", "Montos")]
        public EntityCollection<Monto> Montos
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Monto>("integralDataModel.FK_Montos_1", "Montos");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Monto>("integralDataModel.FK_Montos_1", "Montos", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("integralDataModel", "FK_Pagos_0", "Socios")]
        public Socio Socio
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Socio>("integralDataModel.FK_Pagos_0", "Socios").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Socio>("integralDataModel.FK_Pagos_0", "Socios").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Socio> SocioReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Socio>("integralDataModel.FK_Pagos_0", "Socios");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Socio>("integralDataModel.FK_Pagos_0", "Socios", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="integralDataModel", Name="Socio")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Socio : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Socio object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="nombre">Initial value of the Nombre property.</param>
        /// <param name="fechaInscripcion">Initial value of the FechaInscripcion property.</param>
        /// <param name="edad">Initial value of the Edad property.</param>
        public static Socio CreateSocio(global::System.Int64 id, global::System.String nombre, global::System.DateTime fechaInscripcion, global::System.Int64 edad)
        {
            Socio socio = new Socio();
            socio.Id = id;
            socio.Nombre = nombre;
            socio.FechaInscripcion = fechaInscripcion;
            socio.Edad = edad;
            return socio;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int64 _Id;
        partial void OnIdChanging(global::System.Int64 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                OnNombreChanging(value);
                ReportPropertyChanging("Nombre");
                _Nombre = StructuralObject.SetValidValue(value, false, "Nombre");
                ReportPropertyChanged("Nombre");
                OnNombreChanged();
            }
        }
        private global::System.String _Nombre;
        partial void OnNombreChanging(global::System.String value);
        partial void OnNombreChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime FechaInscripcion
        {
            get
            {
                return _FechaInscripcion;
            }
            set
            {
                OnFechaInscripcionChanging(value);
                ReportPropertyChanging("FechaInscripcion");
                _FechaInscripcion = StructuralObject.SetValidValue(value, "FechaInscripcion");
                ReportPropertyChanged("FechaInscripcion");
                OnFechaInscripcionChanged();
            }
        }
        private global::System.DateTime _FechaInscripcion;
        partial void OnFechaInscripcionChanging(global::System.DateTime value);
        partial void OnFechaInscripcionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Edad
        {
            get
            {
                return _Edad;
            }
            set
            {
                OnEdadChanging(value);
                ReportPropertyChanging("Edad");
                _Edad = StructuralObject.SetValidValue(value, "Edad");
                ReportPropertyChanged("Edad");
                OnEdadChanged();
            }
        }
        private global::System.Int64 _Edad;
        partial void OnEdadChanging(global::System.Int64 value);
        partial void OnEdadChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Direccion
        {
            get
            {
                return _Direccion;
            }
            set
            {
                OnDireccionChanging(value);
                ReportPropertyChanging("Direccion");
                _Direccion = StructuralObject.SetValidValue(value, true, "Direccion");
                ReportPropertyChanged("Direccion");
                OnDireccionChanged();
            }
        }
        private global::System.String _Direccion;
        partial void OnDireccionChanging(global::System.String value);
        partial void OnDireccionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String TelCel
        {
            get
            {
                return _TelCel;
            }
            set
            {
                OnTelCelChanging(value);
                ReportPropertyChanging("TelCel");
                _TelCel = StructuralObject.SetValidValue(value, true, "TelCel");
                ReportPropertyChanged("TelCel");
                OnTelCelChanged();
            }
        }
        private global::System.String _TelCel;
        partial void OnTelCelChanging(global::System.String value);
        partial void OnTelCelChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String EmergenciaMedica
        {
            get
            {
                return _EmergenciaMedica;
            }
            set
            {
                OnEmergenciaMedicaChanging(value);
                ReportPropertyChanging("EmergenciaMedica");
                _EmergenciaMedica = StructuralObject.SetValidValue(value, true, "EmergenciaMedica");
                ReportPropertyChanged("EmergenciaMedica");
                OnEmergenciaMedicaChanged();
            }
        }
        private global::System.String _EmergenciaMedica;
        partial void OnEmergenciaMedicaChanging(global::System.String value);
        partial void OnEmergenciaMedicaChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("integralDataModel", "FK_Pagos_0", "Pagos")]
        public EntityCollection<Pago> Pagos
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Pago>("integralDataModel.FK_Pagos_0", "Pagos");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Pago>("integralDataModel.FK_Pagos_0", "Pagos", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("integralDataModel", "SocioDisciplina", "Disciplinas")]
        public EntityCollection<Disciplina> Disciplinas
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Disciplina>("integralDataModel.SocioDisciplina", "Disciplinas");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Disciplina>("integralDataModel.SocioDisciplina", "Disciplinas", value);
                }
            }
        }

        #endregion

    }

    #endregion

}
