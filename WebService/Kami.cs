using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
namespace WebService
{


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class ceAgregacionMercancia
    {

        private InformacionUnion arg0Field;

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionUnion arg0
        {
            get
            {
                return this.arg0Field;
            }
            set
            {
                this.arg0Field = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionUnion
    {

        private InformacionOperacionGeneral informacionGeneralField;

        private InformacionDeMercancia[] mercanciaOrigenField;

        private InformacionDeMercancia mercanciaDestinoField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionOperacionGeneral informacionGeneral
        {
            get
            {
                return this.informacionGeneralField;
            }
            set
            {
                this.informacionGeneralField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("mercanciaOrigen", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionDeMercancia[] mercanciaOrigen
        {
            get
            {
                return this.mercanciaOrigenField;
            }
            set
            {
                this.mercanciaOrigenField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionDeMercancia mercanciaDestino
        {
            get
            {
                return this.mercanciaDestinoField;
            }
            set
            {
                this.mercanciaDestinoField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionOperacionGeneral
    {

        private string consecutivoField;

        private string idAsociadoField;

        private System.DateTime fechaRegistroField;

        private long tipoMovimientoField;

        private long detalleMovimientoField;

        private long tipoOperacionField;

        private string cveRecintoFiscalizadoField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string consecutivo
        {
            get
            {
                return this.consecutivoField;
            }
            set
            {
                this.consecutivoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string idAsociado
        {
            get
            {
                return this.idAsociadoField;
            }
            set
            {
                this.idAsociadoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
        public System.DateTime fechaRegistro
        {
            get
            {
                return this.fechaRegistroField;
            }
            set
            {
                this.fechaRegistroField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long tipoMovimiento
        {
            get
            {
                return this.tipoMovimientoField;
            }
            set
            {
                this.tipoMovimientoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long detalleMovimiento
        {
            get
            {
                return this.detalleMovimientoField;
            }
            set
            {
                this.detalleMovimientoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long tipoOperacion
        {
            get
            {
                return this.tipoOperacionField;
            }
            set
            {
                this.tipoOperacionField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cveRecintoFiscalizado
        {
            get
            {
                return this.cveRecintoFiscalizadoField;
            }
            set
            {
                this.cveRecintoFiscalizadoField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    public partial class InformacionTraspaleo
    {

        private InformacionOperacionGeneral informacionGeneralField;

        private string observacionesField;

        private InformacionContenedor contenedorOrigenField;

        private InformacionContenedor contenedorDestinoField;

        private string sellosContenedorField;

        private string selloField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionOperacionGeneral informacionGeneral
        {
            get
            {
                return this.informacionGeneralField;
            }
            set
            {
                this.informacionGeneralField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string observaciones
        {
            get
            {
                return this.observacionesField;
            }
            set
            {
                this.observacionesField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionContenedor contenedorOrigen
        {
            get
            {
                return this.contenedorOrigenField;
            }
            set
            {
                this.contenedorOrigenField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionContenedor contenedorDestino
        {
            get
            {
                return this.contenedorDestinoField;
            }
            set
            {
                this.contenedorDestinoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string sellosContenedor
        {
            get
            {
                return this.sellosContenedorField;
            }
            set
            {
                this.sellosContenedorField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string sello
        {
            get
            {
                return this.selloField;
            }
            set
            {
                this.selloField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionContenedor
    {

        private string inicialesField;

        private string numeroField;

        private string tipoField;

        private string estadoField;

        private InformacionDeSellos[] selloField;

        private InformacionDeMercancia[] mercanciaField;

        private InformacionDePersonas[] personasField;

        private InformacionGuiaHouse[] guiaHouseField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string iniciales
        {
            get
            {
                return this.inicialesField;
            }
            set
            {
                this.inicialesField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tipo
        {
            get
            {
                return this.tipoField;
            }
            set
            {
                this.tipoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string estado
        {
            get
            {
                return this.estadoField;
            }
            set
            {
                this.estadoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("sello", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionDeSellos[] sello
        {
            get
            {
                return this.selloField;
            }
            set
            {
                this.selloField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("mercancia", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionDeMercancia[] mercancia
        {
            get
            {
                return this.mercanciaField;
            }
            set
            {
                this.mercanciaField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("personas", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionDePersonas[] personas
        {
            get
            {
                return this.personasField;
            }
            set
            {
                this.personasField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("guiaHouse", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionGuiaHouse[] guiaHouse
        {
            get
            {
                return this.guiaHouseField;
            }
            set
            {
                this.guiaHouseField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    public partial class InformacionDeSellos
    {

        private string candadoField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string candado
        {
            get
            {
                return this.candadoField;
            }
            set
            {
                this.candadoField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionDeMercancia
    {

        private long secuenciaField;

        private string paisField;

        private string descripcionField;

        private double valorField;

        private string monedaField;

        private double cantidadField;

        private string umcField;

        private double pesoField;

        private string umpField;

        private System.Nullable<double> volumenField;

        private bool volumenFieldSpecified;

        private string observacionesField;

        private InformacionDeVin[] vinField;

        private InformacionDeImo[] imoField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long secuencia
        {
            get
            {
                return this.secuenciaField;
            }
            set
            {
                this.secuenciaField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string pais
        {
            get
            {
                return this.paisField;
            }
            set
            {
                this.paisField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string descripcion
        {
            get
            {
                return this.descripcionField;
            }
            set
            {
                this.descripcionField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double valor
        {
            get
            {
                return this.valorField;
            }
            set
            {
                this.valorField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string moneda
        {
            get
            {
                return this.monedaField;
            }
            set
            {
                this.monedaField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double cantidad
        {
            get
            {
                return this.cantidadField;
            }
            set
            {
                this.cantidadField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string umc
        {
            get
            {
                return this.umcField;
            }
            set
            {
                this.umcField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double peso
        {
            get
            {
                return this.pesoField;
            }
            set
            {
                this.pesoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ump
        {
            get
            {
                return this.umpField;
            }
            set
            {
                this.umpField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public System.Nullable<double> volumen
        {
            get
            {
                return this.volumenField;
            }
            set
            {
                this.volumenField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool volumenSpecified
        {
            get
            {
                return this.volumenFieldSpecified;
            }
            set
            {
                this.volumenFieldSpecified = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string observaciones
        {
            get
            {
                return this.observacionesField;
            }
            set
            {
                this.observacionesField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("vin", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionDeVin[] vin
        {
            get
            {
                return this.vinField;
            }
            set
            {
                this.vinField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("imo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionDeImo[] imo
        {
            get
            {
                return this.imoField;
            }
            set
            {
                this.imoField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    public partial class InformacionDeVin
    {

        private string vinField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string vin
        {
            get
            {
                return this.vinField;
            }
            set
            {
                this.vinField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    public partial class InformacionDeImo
    {

        private string imoField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string imo
        {
            get
            {
                return this.imoField;
            }
            set
            {
                this.imoField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionDePersonas
    {

        private string tipoPersonaField;

        private string nombreField;

        private string calleDomicilioField;

        private string numeroInteriorField;

        private string numeroExteriorField;

        private string cpField;

        private string municipioField;

        private string entidadFederativaField;

        private string paisField;

        private string rfcOTaxIdField;

        private string correoElectronicoField;

        private string ciudadField;

        private string contactoField;

        private System.Nullable<long> telefonoField;

        private bool telefonoFieldSpecified;

        private string correoContactoField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tipoPersona
        {
            get
            {
                return this.tipoPersonaField;
            }
            set
            {
                this.tipoPersonaField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nombre
        {
            get
            {
                return this.nombreField;
            }
            set
            {
                this.nombreField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string calleDomicilio
        {
            get
            {
                return this.calleDomicilioField;
            }
            set
            {
                this.calleDomicilioField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string numeroInterior
        {
            get
            {
                return this.numeroInteriorField;
            }
            set
            {
                this.numeroInteriorField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string numeroExterior
        {
            get
            {
                return this.numeroExteriorField;
            }
            set
            {
                this.numeroExteriorField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string cp
        {
            get
            {
                return this.cpField;
            }
            set
            {
                this.cpField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string municipio
        {
            get
            {
                return this.municipioField;
            }
            set
            {
                this.municipioField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string entidadFederativa
        {
            get
            {
                return this.entidadFederativaField;
            }
            set
            {
                this.entidadFederativaField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string pais
        {
            get
            {
                return this.paisField;
            }
            set
            {
                this.paisField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string rfcOTaxId
        {
            get
            {
                return this.rfcOTaxIdField;
            }
            set
            {
                this.rfcOTaxIdField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string correoElectronico
        {
            get
            {
                return this.correoElectronicoField;
            }
            set
            {
                this.correoElectronicoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string ciudad
        {
            get
            {
                return this.ciudadField;
            }
            set
            {
                this.ciudadField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string contacto
        {
            get
            {
                return this.contactoField;
            }
            set
            {
                this.contactoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public System.Nullable<long> telefono
        {
            get
            {
                return this.telefonoField;
            }
            set
            {
                this.telefonoField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool telefonoSpecified
        {
            get
            {
                return this.telefonoFieldSpecified;
            }
            set
            {
                this.telefonoFieldSpecified = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string correoContacto
        {
            get
            {
                return this.correoContactoField;
            }
            set
            {
                this.correoContactoField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionGuiaHouse
    {

        private string numeroGuiaBlField;

        private string caatField;

        private System.Nullable<double> pesoField;

        private bool pesoFieldSpecified;

        private InformacionDeMercancia[] mercanciaField;

        private InformacionDePersonas[] personasField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string numeroGuiaBl
        {
            get
            {
                return this.numeroGuiaBlField;
            }
            set
            {
                this.numeroGuiaBlField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string caat
        {
            get
            {
                return this.caatField;
            }
            set
            {
                this.caatField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public System.Nullable<double> peso
        {
            get
            {
                return this.pesoField;
            }
            set
            {
                this.pesoField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pesoSpecified
        {
            get
            {
                return this.pesoFieldSpecified;
            }
            set
            {
                this.pesoFieldSpecified = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("mercancia", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionDeMercancia[] mercancia
        {
            get
            {
                return this.mercanciaField;
            }
            set
            {
                this.mercanciaField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("personas", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionDePersonas[] personas
        {
            get
            {
                return this.personasField;
            }
            set
            {
                this.personasField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    public partial class InformacionDesconsolidacion
    {

        private InformacionOperacionGeneral informacionGeneralField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionOperacionGeneral informacionGeneral
        {
            get
            {
                return this.informacionGeneralField;
            }
            set
            {
                this.informacionGeneralField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    public partial class InformacionDeConsolidacion
    {

        private InformacionOperacionGeneral informacionGeneralField;

        private InformacionBlMaster guiaMasterField;

        private InformacionGuiaHouse[] guiaHouseField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionOperacionGeneral informacionGeneral
        {
            get
            {
                return this.informacionGeneralField;
            }
            set
            {
                this.informacionGeneralField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionBlMaster guiaMaster
        {
            get
            {
                return this.guiaMasterField;
            }
            set
            {
                this.guiaMasterField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("guiaHouse", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionGuiaHouse[] guiaHouse
        {
            get
            {
                return this.guiaHouseField;
            }
            set
            {
                this.guiaHouseField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionBlMaster
    {

        private string numeroGuiaBlField;

        private string caatField;

        private long tipoOperacionField;

        private System.Nullable<double> valorDeclaradoField;

        private bool valorDeclaradoFieldSpecified;

        private string monedaField;

        private double pesoField;

        private string umpField;

        private System.Nullable<double> volumenField;

        private bool volumenFieldSpecified;

        private string umvField;

        private System.Nullable<double> piezasField;

        private bool piezasFieldSpecified;

        private string idParcialidadField;

        private System.Nullable<long> secuenciaField;

        private bool secuenciaFieldSpecified;

        private string observacionesField;

        private InformacionDeMercancia[] mercanciaField;

        private InformacionDePersonas[] personasField;

        private InformacionGuiaHouse[] guiaHouseField;

        private InformacionContenedor[] contenedorField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string numeroGuiaBl
        {
            get
            {
                return this.numeroGuiaBlField;
            }
            set
            {
                this.numeroGuiaBlField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string caat
        {
            get
            {
                return this.caatField;
            }
            set
            {
                this.caatField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long tipoOperacion
        {
            get
            {
                return this.tipoOperacionField;
            }
            set
            {
                this.tipoOperacionField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public System.Nullable<double> valorDeclarado
        {
            get
            {
                return this.valorDeclaradoField;
            }
            set
            {
                this.valorDeclaradoField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valorDeclaradoSpecified
        {
            get
            {
                return this.valorDeclaradoFieldSpecified;
            }
            set
            {
                this.valorDeclaradoFieldSpecified = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string moneda
        {
            get
            {
                return this.monedaField;
            }
            set
            {
                this.monedaField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double peso
        {
            get
            {
                return this.pesoField;
            }
            set
            {
                this.pesoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ump
        {
            get
            {
                return this.umpField;
            }
            set
            {
                this.umpField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public System.Nullable<double> volumen
        {
            get
            {
                return this.volumenField;
            }
            set
            {
                this.volumenField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool volumenSpecified
        {
            get
            {
                return this.volumenFieldSpecified;
            }
            set
            {
                this.volumenFieldSpecified = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string umv
        {
            get
            {
                return this.umvField;
            }
            set
            {
                this.umvField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public System.Nullable<double> piezas
        {
            get
            {
                return this.piezasField;
            }
            set
            {
                this.piezasField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool piezasSpecified
        {
            get
            {
                return this.piezasFieldSpecified;
            }
            set
            {
                this.piezasFieldSpecified = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string idParcialidad
        {
            get
            {
                return this.idParcialidadField;
            }
            set
            {
                this.idParcialidadField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public System.Nullable<long> secuencia
        {
            get
            {
                return this.secuenciaField;
            }
            set
            {
                this.secuenciaField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool secuenciaSpecified
        {
            get
            {
                return this.secuenciaFieldSpecified;
            }
            set
            {
                this.secuenciaFieldSpecified = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string observaciones
        {
            get
            {
                return this.observacionesField;
            }
            set
            {
                this.observacionesField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("mercancia", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionDeMercancia[] mercancia
        {
            get
            {
                return this.mercanciaField;
            }
            set
            {
                this.mercanciaField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("personas", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionDePersonas[] personas
        {
            get
            {
                return this.personasField;
            }
            set
            {
                this.personasField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("guiaHouse", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionGuiaHouse[] guiaHouse
        {
            get
            {
                return this.guiaHouseField;
            }
            set
            {
                this.guiaHouseField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("contenedor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionContenedor[] contenedor
        {
            get
            {
                return this.contenedorField;
            }
            set
            {
                this.contenedorField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class ceAgregacionMercanciaResponse
    {

        private Respuesta returnField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Respuesta @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class Respuesta
    {

        private InformacionOperacionGeneral informacionGeneralField;

        private string codigoRespuestaField;

        private string codigoErrorField;

        private string descripcionField;

        private string datosErroneosField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionOperacionGeneral informacionGeneral
        {
            get
            {
                return this.informacionGeneralField;
            }
            set
            {
                this.informacionGeneralField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string codigoRespuesta
        {
            get
            {
                return this.codigoRespuestaField;
            }
            set
            {
                this.codigoRespuestaField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string codigoError
        {
            get
            {
                return this.codigoErrorField;
            }
            set
            {
                this.codigoErrorField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string descripcion
        {
            get
            {
                return this.descripcionField;
            }
            set
            {
                this.descripcionField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string datosErroneos
        {
            get
            {
                return this.datosErroneosField;
            }
            set
            {
                this.datosErroneosField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class ceDesagregacionMercancia
    {

        private InformacionDesUnion arg0Field;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionDesUnion arg0
        {
            get
            {
                return this.arg0Field;
            }
            set
            {
                this.arg0Field = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionDesUnion
    {

        private InformacionOperacionGeneral informacionGeneralField;

        private InformacionDeMercancia mercanciaOrigenField;

        private InformacionDeMercancia[] mercanciaDestinoField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionOperacionGeneral informacionGeneral
        {
            get
            {
                return this.informacionGeneralField;
            }
            set
            {
                this.informacionGeneralField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionDeMercancia mercanciaOrigen
        {
            get
            {
                return this.mercanciaOrigenField;
            }
            set
            {
                this.mercanciaOrigenField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("mercanciaDestino", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionDeMercancia[] mercanciaDestino
        {
            get
            {
                return this.mercanciaDestinoField;
            }
            set
            {
                this.mercanciaDestinoField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class ceDesagregacionMercanciaResponse
    {

        private Respuesta returnField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Respuesta @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class consolidacionMaster
    {

        private InformacionDeConsolidacion arg0Field;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionDeConsolidacion arg0
        {
            get
            {
                return this.arg0Field;
            }
            set
            {
                this.arg0Field = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class consolidacionMasterResponse
    {

        private Respuesta returnField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Respuesta @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class desconsolidacionMaster
    {

        private InformacionDesconsolidacion arg0Field;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionDesconsolidacion arg0
        {
            get
            {
                return this.arg0Field;
            }
            set
            {
                this.arg0Field = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class desconsolidacionMasterResponse
    {

        private Respuesta returnField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Respuesta @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class enviaPendientesP0
    {

        private long[] arg0Field;

        private long arg1Field;

        private bool arg1FieldSpecified;


        [System.Xml.Serialization.XmlElementAttribute("arg0", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long[] arg0
        {
            get
            {
                return this.arg0Field;
            }
            set
            {
                this.arg0Field = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long arg1
        {
            get
            {
                return this.arg1Field;
            }
            set
            {
                this.arg1Field = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool arg1Specified
        {
            get
            {
                return this.arg1FieldSpecified;
            }
            set
            {
                this.arg1FieldSpecified = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class enviaPendientesP0Response
    {

        private bool returnField;

        private bool returnFieldSpecified;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool returnSpecified
        {
            get
            {
                return this.returnFieldSpecified;
            }
            set
            {
                this.returnFieldSpecified = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class Exception
    {

        private string messageField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class generaGuiaHouseP0Resp
    {

        private long arg0Field;

        private bool arg0FieldSpecified;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long arg0
        {
            get
            {
                return this.arg0Field;
            }
            set
            {
                this.arg0Field = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool arg0Specified
        {
            get
            {
                return this.arg0FieldSpecified;
            }
            set
            {
                this.arg0FieldSpecified = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class generaGuiaHouseP0RespResponse
    {

        private OperacionGuiaP0 returnField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OperacionGuiaP0 @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class OperacionGuiaP0
    {

        private InformacionOperacionGeneral informacionGeneralField;

        private InformacionDeTransporte transporteField;

        private InformacionBlMaster guiaMasterField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionOperacionGeneral informacionGeneral
        {
            get
            {
                return this.informacionGeneralField;
            }
            set
            {
                this.informacionGeneralField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionDeTransporte transporte
        {
            get
            {
                return this.transporteField;
            }
            set
            {
                this.transporteField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionBlMaster guiaMaster
        {
            get
            {
                return this.guiaMasterField;
            }
            set
            {
                this.guiaMasterField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionDeTransporte
    {

        private string numeroVueloBuqueViajeImoField;

        private string tipoTransporteField;

        private System.DateTime fechaHoraDeArriboField;

        private string origenVueloBuqueField;

        private string numeroManifiestoField;

        private string caatField;

        private System.Nullable<double> pesoField;

        private bool pesoFieldSpecified;

        private string umpField;

        private System.Nullable<double> piezasField;

        private bool piezasFieldSpecified;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string numeroVueloBuqueViajeImo
        {
            get
            {
                return this.numeroVueloBuqueViajeImoField;
            }
            set
            {
                this.numeroVueloBuqueViajeImoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tipoTransporte
        {
            get
            {
                return this.tipoTransporteField;
            }
            set
            {
                this.tipoTransporteField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime fechaHoraDeArribo
        {
            get
            {
                return this.fechaHoraDeArriboField;
            }
            set
            {
                this.fechaHoraDeArriboField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string origenVueloBuque
        {
            get
            {
                return this.origenVueloBuqueField;
            }
            set
            {
                this.origenVueloBuqueField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string numeroManifiesto
        {
            get
            {
                return this.numeroManifiestoField;
            }
            set
            {
                this.numeroManifiestoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string caat
        {
            get
            {
                return this.caatField;
            }
            set
            {
                this.caatField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public System.Nullable<double> peso
        {
            get
            {
                return this.pesoField;
            }
            set
            {
                this.pesoField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pesoSpecified
        {
            get
            {
                return this.pesoFieldSpecified;
            }
            set
            {
                this.pesoFieldSpecified = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string ump
        {
            get
            {
                return this.umpField;
            }
            set
            {
                this.umpField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public System.Nullable<double> piezas
        {
            get
            {
                return this.piezasField;
            }
            set
            {
                this.piezasField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool piezasSpecified
        {
            get
            {
                return this.piezasFieldSpecified;
            }
            set
            {
                this.piezasFieldSpecified = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class generaGuiaP0Resp
    {

        private long arg0Field;

        private bool arg0FieldSpecified;

        private long arg1Field;

        private bool arg1FieldSpecified;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long arg0
        {
            get
            {
                return this.arg0Field;
            }
            set
            {
                this.arg0Field = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool arg0Specified
        {
            get
            {
                return this.arg0FieldSpecified;
            }
            set
            {
                this.arg0FieldSpecified = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long arg1
        {
            get
            {
                return this.arg1Field;
            }
            set
            {
                this.arg1Field = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool arg1Specified
        {
            get
            {
                return this.arg1FieldSpecified;
            }
            set
            {
                this.arg1FieldSpecified = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class generaGuiaP0RespResponse
    {

        private OperacionGuiaP0 returnField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OperacionGuiaP0 @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class generaP0Resp
    {

        private long arg0Field;

        private bool arg0FieldSpecified;

        private long arg1Field;

        private bool arg1FieldSpecified;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long arg0
        {
            get
            {
                return this.arg0Field;
            }
            set
            {
                this.arg0Field = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool arg0Specified
        {
            get
            {
                return this.arg0FieldSpecified;
            }
            set
            {
                this.arg0FieldSpecified = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long arg1
        {
            get
            {
                return this.arg1Field;
            }
            set
            {
                this.arg1Field = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool arg1Specified
        {
            get
            {
                return this.arg1FieldSpecified;
            }
            set
            {
                this.arg1FieldSpecified = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class generaP0RespResponse
    {

        private OperacionGuiaP0 returnField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OperacionGuiaP0 @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class getBitacora
    {

        private long arg0Field;

        private bool arg0FieldSpecified;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long arg0
        {
            get
            {
                return this.arg0Field;
            }
            set
            {
                this.arg0Field = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool arg0Specified
        {
            get
            {
                return this.arg0FieldSpecified;
            }
            set
            {
                this.arg0FieldSpecified = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class getBitacoraResponse
    {

        private string returnField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class incidenciaMercancia
    {

        private InformacionIncidencia arg0Field;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionIncidencia arg0
        {
            get
            {
                return this.arg0Field;
            }
            set
            {
                this.arg0Field = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionIncidencia
    {

        private InformacionOperacionGeneral informacionGeneralField;

        private long numSecuenciaField;

        private double numPesoField;

        private long numPiezasField;

        private string cveUmPiezasField;

        private string observacionesField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionOperacionGeneral informacionGeneral
        {
            get
            {
                return this.informacionGeneralField;
            }
            set
            {
                this.informacionGeneralField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long numSecuencia
        {
            get
            {
                return this.numSecuenciaField;
            }
            set
            {
                this.numSecuenciaField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double numPeso
        {
            get
            {
                return this.numPesoField;
            }
            set
            {
                this.numPesoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long numPiezas
        {
            get
            {
                return this.numPiezasField;
            }
            set
            {
                this.numPiezasField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cveUmPiezas
        {
            get
            {
                return this.cveUmPiezasField;
            }
            set
            {
                this.cveUmPiezasField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string observaciones
        {
            get
            {
                return this.observacionesField;
            }
            set
            {
                this.observacionesField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class incidenciaMercanciaResponse
    {

        private Respuesta returnField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Respuesta @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class ingresoFlujoAlterno
    {

        private InformacionDeIngresoFlujoAlterno arg0Field;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionDeIngresoFlujoAlterno arg0
        {
            get
            {
                return this.arg0Field;
            }
            set
            {
                this.arg0Field = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionDeIngresoFlujoAlterno
    {

        private InformacionOperacionGeneral informacionGeneralField;

        private InformacionIngreso informacionIngresoField;

        private InformacionDeTransporte transporteField;

        private InformacionBlMaster guiaMasterField;

        private InformacionContenedor[] contenedorField;

        private InformacionGuiaHouse[] guiaHouseField;

        private InformacionDeMercancia[] mercanciaField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionOperacionGeneral informacionGeneral
        {
            get
            {
                return this.informacionGeneralField;
            }
            set
            {
                this.informacionGeneralField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionIngreso informacionIngreso
        {
            get
            {
                return this.informacionIngresoField;
            }
            set
            {
                this.informacionIngresoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionDeTransporte transporte
        {
            get
            {
                return this.transporteField;
            }
            set
            {
                this.transporteField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionBlMaster guiaMaster
        {
            get
            {
                return this.guiaMasterField;
            }
            set
            {
                this.guiaMasterField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("contenedor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionContenedor[] contenedor
        {
            get
            {
                return this.contenedorField;
            }
            set
            {
                this.contenedorField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("guiaHouse", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionGuiaHouse[] guiaHouse
        {
            get
            {
                return this.guiaHouseField;
            }
            set
            {
                this.guiaHouseField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("mercancia", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionDeMercancia[] mercancia
        {
            get
            {
                return this.mercanciaField;
            }
            set
            {
                this.mercanciaField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionIngreso
    {

        private long tipoMercanciaField;

        private System.DateTime fechaInicioCargaField;

        private System.DateTime fechafinCargaField;

        private double pesoField;

        private long condicionCargaField;

        private string observacionesField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long tipoMercancia
        {
            get
            {
                return this.tipoMercanciaField;
            }
            set
            {
                this.tipoMercanciaField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime fechaInicioCarga
        {
            get
            {
                return this.fechaInicioCargaField;
            }
            set
            {
                this.fechaInicioCargaField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime fechafinCarga
        {
            get
            {
                return this.fechafinCargaField;
            }
            set
            {
                this.fechafinCargaField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double peso
        {
            get
            {
                return this.pesoField;
            }
            set
            {
                this.pesoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long condicionCarga
        {
            get
            {
                return this.condicionCargaField;
            }
            set
            {
                this.condicionCargaField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string observaciones
        {
            get
            {
                return this.observacionesField;
            }
            set
            {
                this.observacionesField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class ingresoFlujoAlternoResponse
    {

        private Respuesta returnField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Respuesta @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class ingresoParcial
    {

        private InformacionDeIngresoParcial arg0Field;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionDeIngresoParcial arg0
        {
            get
            {
                return this.arg0Field;
            }
            set
            {
                this.arg0Field = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionDeIngresoParcial
    {

        private InformacionOperacionGeneral informacionGeneralField;

        private InformacionIngresoParcial informacionIngresoParcialField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionOperacionGeneral informacionGeneral
        {
            get
            {
                return this.informacionGeneralField;
            }
            set
            {
                this.informacionGeneralField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionIngresoParcial informacionIngresoParcial
        {
            get
            {
                return this.informacionIngresoParcialField;
            }
            set
            {
                this.informacionIngresoParcialField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionIngresoParcial
    {

        private long tipoMercanciaField;

        private System.DateTime fechaInicioCargaField;

        private System.DateTime fechafinCargaField;

        private double pesoField;

        private System.Nullable<long> totalParcialidadesField;

        private bool totalParcialidadesFieldSpecified;

        private long numeroParcialidadField;

        private System.Nullable<double> cantidadField;

        private bool cantidadFieldSpecified;

        private string umcField;

        private long condicionCargaField;

        private string observacionesField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long tipoMercancia
        {
            get
            {
                return this.tipoMercanciaField;
            }
            set
            {
                this.tipoMercanciaField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime fechaInicioCarga
        {
            get
            {
                return this.fechaInicioCargaField;
            }
            set
            {
                this.fechaInicioCargaField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.DateTime fechafinCarga
        {
            get
            {
                return this.fechafinCargaField;
            }
            set
            {
                this.fechafinCargaField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double peso
        {
            get
            {
                return this.pesoField;
            }
            set
            {
                this.pesoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public System.Nullable<long> totalParcialidades
        {
            get
            {
                return this.totalParcialidadesField;
            }
            set
            {
                this.totalParcialidadesField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalParcialidadesSpecified
        {
            get
            {
                return this.totalParcialidadesFieldSpecified;
            }
            set
            {
                this.totalParcialidadesFieldSpecified = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long numeroParcialidad
        {
            get
            {
                return this.numeroParcialidadField;
            }
            set
            {
                this.numeroParcialidadField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public System.Nullable<double> cantidad
        {
            get
            {
                return this.cantidadField;
            }
            set
            {
                this.cantidadField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cantidadSpecified
        {
            get
            {
                return this.cantidadFieldSpecified;
            }
            set
            {
                this.cantidadFieldSpecified = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string umc
        {
            get
            {
                return this.umcField;
            }
            set
            {
                this.umcField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long condicionCarga
        {
            get
            {
                return this.condicionCargaField;
            }
            set
            {
                this.condicionCargaField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string observaciones
        {
            get
            {
                return this.observacionesField;
            }
            set
            {
                this.observacionesField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class ingresoParcialResponse
    {

        private Respuesta returnField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Respuesta @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class ingresoSimple
    {

        private InformacionDeIngresoSimple arg0Field;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionDeIngresoSimple arg0
        {
            get
            {
                return this.arg0Field;
            }
            set
            {
                this.arg0Field = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionDeIngresoSimple
    {

        private InformacionOperacionGeneral informacionGeneralField;

        private InformacionIngreso informacionIngresoField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionOperacionGeneral informacionGeneral
        {
            get
            {
                return this.informacionGeneralField;
            }
            set
            {
                this.informacionGeneralField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionIngreso informacionIngreso
        {
            get
            {
                return this.informacionIngresoField;
            }
            set
            {
                this.informacionIngresoField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class ingresoSimpleResponse
    {

        private Respuesta returnField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Respuesta @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class ingresoSinID
    {

        private InformacionDeIngresoSinIdAsociado arg0Field;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionDeIngresoSinIdAsociado arg0
        {
            get
            {
                return this.arg0Field;
            }
            set
            {
                this.arg0Field = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionDeIngresoSinIdAsociado
    {

        private InformacionOperacionGeneral informacionGeneralField;

        private InformacionIngreso informacionIngresoField;

        private InformacionDeTransporte transporteField;

        private InformacionBlMaster guiaMasterField;

        private InformacionDeMercancia[] mercanciaField;

        private InformacionDePersonas[] personasField;

        private InformacionGuiaHouse[] guiaHouseField;

        private InformacionContenedor[] contenedorField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionOperacionGeneral informacionGeneral
        {
            get
            {
                return this.informacionGeneralField;
            }
            set
            {
                this.informacionGeneralField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionIngreso informacionIngreso
        {
            get
            {
                return this.informacionIngresoField;
            }
            set
            {
                this.informacionIngresoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionDeTransporte transporte
        {
            get
            {
                return this.transporteField;
            }
            set
            {
                this.transporteField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionBlMaster guiaMaster
        {
            get
            {
                return this.guiaMasterField;
            }
            set
            {
                this.guiaMasterField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("mercancia", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionDeMercancia[] mercancia
        {
            get
            {
                return this.mercanciaField;
            }
            set
            {
                this.mercanciaField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("personas", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionDePersonas[] personas
        {
            get
            {
                return this.personasField;
            }
            set
            {
                this.personasField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("guiaHouse", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionGuiaHouse[] guiaHouse
        {
            get
            {
                return this.guiaHouseField;
            }
            set
            {
                this.guiaHouseField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("contenedor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionContenedor[] contenedor
        {
            get
            {
                return this.contenedorField;
            }
            set
            {
                this.contenedorField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class ingresoSinIDResponse
    {

        private Respuesta returnField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Respuesta @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class notificacionIngresoMercancia
    {

        private OperacionGuiaP0 arg0Field;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OperacionGuiaP0 arg0
        {
            get
            {
                return this.arg0Field;
            }
            set
            {
                this.arg0Field = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class notificacionIngresoMercanciaResponse
    {

        private Respuesta returnField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Respuesta @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class obtenDetalleIdAsociado
    {

        private long idAsociadoField;

        private bool idAsociadoFieldSpecified;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long idAsociado
        {
            get
            {
                return this.idAsociadoField;
            }
            set
            {
                this.idAsociadoField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idAsociadoSpecified
        {
            get
            {
                return this.idAsociadoFieldSpecified;
            }
            set
            {
                this.idAsociadoFieldSpecified = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class obtenDetalleIdAsociadoResponse
    {

        private OperacionGuiaP0 returnField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OperacionGuiaP0 @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class obtenIdAsociados
    {

        private long idRecintoField;

        private bool idRecintoFieldSpecified;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long idRecinto
        {
            get
            {
                return this.idRecintoField;
            }
            set
            {
                this.idRecintoField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idRecintoSpecified
        {
            get
            {
                return this.idRecintoFieldSpecified;
            }
            set
            {
                this.idRecintoFieldSpecified = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class obtenIdAsociadosResponse
    {

        private long[] idAsociadoField;


        [System.Xml.Serialization.XmlElementAttribute("idAsociado", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long[] idAsociado
        {
            get
            {
                return this.idAsociadoField;
            }
            set
            {
                this.idAsociadoField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class rechazo
    {

        private InformacionDeRechazo arg0Field;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionDeRechazo arg0
        {
            get
            {
                return this.arg0Field;
            }
            set
            {
                this.arg0Field = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionDeRechazo
    {

        private InformacionOperacionGeneral informacionGeneralField;

        private InformacionRechazo informacionRechazoField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionOperacionGeneral informacionGeneral
        {
            get
            {
                return this.informacionGeneralField;
            }
            set
            {
                this.informacionGeneralField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionRechazo informacionRechazo
        {
            get
            {
                return this.informacionRechazoField;
            }
            set
            {
                this.informacionRechazoField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionRechazo
    {

        private string clasificacionRechazoField;

        private string descripcionRechazoField;

        private string observacionesField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string clasificacionRechazo
        {
            get
            {
                return this.clasificacionRechazoField;
            }
            set
            {
                this.clasificacionRechazoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string descripcionRechazo
        {
            get
            {
                return this.descripcionRechazoField;
            }
            set
            {
                this.descripcionRechazoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string observaciones
        {
            get
            {
                return this.observacionesField;
            }
            set
            {
                this.observacionesField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class rechazoResponse
    {

        private Respuesta returnField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Respuesta @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class salidaPedimento
    {

        private InformacionSalidaPedimento arg0Field;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionSalidaPedimento arg0
        {
            get
            {
                return this.arg0Field;
            }
            set
            {
                this.arg0Field = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionSalidaPedimento
    {

        private InformacionOperacionGeneral informacionGeneralField;

        private long pedimentoField;

        private long aduanaField;

        private string patenteField;

        private InformacionMercanciaPed[] mercanciaField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionOperacionGeneral informacionGeneral
        {
            get
            {
                return this.informacionGeneralField;
            }
            set
            {
                this.informacionGeneralField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long pedimento
        {
            get
            {
                return this.pedimentoField;
            }
            set
            {
                this.pedimentoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long aduana
        {
            get
            {
                return this.aduanaField;
            }
            set
            {
                this.aduanaField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string patente
        {
            get
            {
                return this.patenteField;
            }
            set
            {
                this.patenteField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("mercancia", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionMercanciaPed[] mercancia
        {
            get
            {
                return this.mercanciaField;
            }
            set
            {
                this.mercanciaField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionMercanciaPed
    {

        private long idMercanciaField;

        private bool idMercanciaFieldSpecified;

        private long idAsociadoField;

        private long numSecuenciaField;

        private long numPiezasField;

        private string cveUmPiezasField;

        private double numPesoField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long idMercancia
        {
            get
            {
                return this.idMercanciaField;
            }
            set
            {
                this.idMercanciaField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idMercanciaSpecified
        {
            get
            {
                return this.idMercanciaFieldSpecified;
            }
            set
            {
                this.idMercanciaFieldSpecified = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long idAsociado
        {
            get
            {
                return this.idAsociadoField;
            }
            set
            {
                this.idAsociadoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long numSecuencia
        {
            get
            {
                return this.numSecuenciaField;
            }
            set
            {
                this.numSecuenciaField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long numPiezas
        {
            get
            {
                return this.numPiezasField;
            }
            set
            {
                this.numPiezasField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cveUmPiezas
        {
            get
            {
                return this.cveUmPiezasField;
            }
            set
            {
                this.cveUmPiezasField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double numPeso
        {
            get
            {
                return this.numPesoField;
            }
            set
            {
                this.numPesoField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class salidaPedimentoResponse
    {

        private Respuesta returnField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Respuesta @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class salidaTransferencia
    {

        private InformacionSalidaTransferencia arg0Field;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionSalidaTransferencia arg0
        {
            get
            {
                return this.arg0Field;
            }
            set
            {
                this.arg0Field = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionSalidaTransferencia
    {

        private InformacionOperacionGeneral informacionGeneralField;

        private string cveRecintoFiscalizadoTransferenciaField;

        private InformacionTransf[] transferenciaField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionOperacionGeneral informacionGeneral
        {
            get
            {
                return this.informacionGeneralField;
            }
            set
            {
                this.informacionGeneralField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cveRecintoFiscalizadoTransferencia
        {
            get
            {
                return this.cveRecintoFiscalizadoTransferenciaField;
            }
            set
            {
                this.cveRecintoFiscalizadoTransferenciaField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("transferencia", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionTransf[] transferencia
        {
            get
            {
                return this.transferenciaField;
            }
            set
            {
                this.transferenciaField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionTransf
    {

        private long idAsociadoField;

        private string numeroGuiaBlField;

        private InformacionMercanciaTrans[] mercanciaField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long idAsociado
        {
            get
            {
                return this.idAsociadoField;
            }
            set
            {
                this.idAsociadoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string numeroGuiaBl
        {
            get
            {
                return this.numeroGuiaBlField;
            }
            set
            {
                this.numeroGuiaBlField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("mercancia", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionMercanciaTrans[] mercancia
        {
            get
            {
                return this.mercanciaField;
            }
            set
            {
                this.mercanciaField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionMercanciaTrans
    {

        private long idMercanciaField;

        private bool idMercanciaFieldSpecified;

        private long numSecuenciaField;

        private long numPiezasField;

        private string cveUmPiezasField;

        private double numPesoField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long idMercancia
        {
            get
            {
                return this.idMercanciaField;
            }
            set
            {
                this.idMercanciaField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idMercanciaSpecified
        {
            get
            {
                return this.idMercanciaFieldSpecified;
            }
            set
            {
                this.idMercanciaFieldSpecified = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long numSecuencia
        {
            get
            {
                return this.numSecuenciaField;
            }
            set
            {
                this.numSecuenciaField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long numPiezas
        {
            get
            {
                return this.numPiezasField;
            }
            set
            {
                this.numPiezasField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cveUmPiezas
        {
            get
            {
                return this.cveUmPiezasField;
            }
            set
            {
                this.cveUmPiezasField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double numPeso
        {
            get
            {
                return this.numPesoField;
            }
            set
            {
                this.numPesoField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class salidaTransferenciaResponse
    {

        private Respuesta returnField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Respuesta @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class subdivisionMercancia
    {

        private InformacionDeSubdivision arg0Field;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionDeSubdivision arg0
        {
            get
            {
                return this.arg0Field;
            }
            set
            {
                this.arg0Field = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionDeSubdivision
    {

        private InformacionOperacionGeneral informacionGeneralField;

        private InformacionMercanciaSub[] mercanciaField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionOperacionGeneral informacionGeneral
        {
            get
            {
                return this.informacionGeneralField;
            }
            set
            {
                this.informacionGeneralField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute("mercancia", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public InformacionMercanciaSub[] mercancia
        {
            get
            {
                return this.mercanciaField;
            }
            set
            {
                this.mercanciaField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class InformacionMercanciaSub
    {

        private long idMercanciaField;

        private bool idMercanciaFieldSpecified;

        private long idAsociadoField;

        private long numSecuenciaField;

        private long numPiezasField;

        private string cveUmPiezasField;

        private double numPesoField;

        private long numSecuenciaDField;

        private bool numSecuenciaDFieldSpecified;

        private long numPiezasDField;

        private string cveUmPiezasDField;

        private double numPesoDField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long idMercancia
        {
            get
            {
                return this.idMercanciaField;
            }
            set
            {
                this.idMercanciaField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idMercanciaSpecified
        {
            get
            {
                return this.idMercanciaFieldSpecified;
            }
            set
            {
                this.idMercanciaFieldSpecified = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long idAsociado
        {
            get
            {
                return this.idAsociadoField;
            }
            set
            {
                this.idAsociadoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long numSecuencia
        {
            get
            {
                return this.numSecuenciaField;
            }
            set
            {
                this.numSecuenciaField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long numPiezas
        {
            get
            {
                return this.numPiezasField;
            }
            set
            {
                this.numPiezasField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cveUmPiezas
        {
            get
            {
                return this.cveUmPiezasField;
            }
            set
            {
                this.cveUmPiezasField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double numPeso
        {
            get
            {
                return this.numPesoField;
            }
            set
            {
                this.numPesoField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long numSecuenciaD
        {
            get
            {
                return this.numSecuenciaDField;
            }
            set
            {
                this.numSecuenciaDField = value;
            }
        }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numSecuenciaDSpecified
        {
            get
            {
                return this.numSecuenciaDFieldSpecified;
            }
            set
            {
                this.numSecuenciaDFieldSpecified = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long numPiezasD
        {
            get
            {
                return this.numPiezasDField;
            }
            set
            {
                this.numPiezasDField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cveUmPiezasD
        {
            get
            {
                return this.cveUmPiezasDField;
            }
            set
            {
                this.cveUmPiezasDField = value;
            }
        }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double numPesoD
        {
            get
            {
                return this.numPesoDField;
            }
            set
            {
                this.numPesoDField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class subdivisionMercanciaResponse
    {

        private Respuesta returnField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Respuesta @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class traspaleoContenedor
    {

        private InformacionTraspaleo arg0Field;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionTraspaleo arg0
        {
            get
            {
                return this.arg0Field;
            }
            set
            {
                this.arg0Field = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class traspaleoContenedorResponse
    {

        private Respuesta returnField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Respuesta @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class traspasoMercancia
    {

        private InformacionTraspaleo arg0Field;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionTraspaleo arg0
        {
            get
            {
                return this.arg0Field;
            }
            set
            {
                this.arg0Field = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class traspasoMercanciaResponse
    {

        private Respuesta returnField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Respuesta @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class validacionGeneral
    {

        private InformacionOperacionGeneral arg0Field;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformacionOperacionGeneral arg0
        {
            get
            {
                return this.arg0Field;
            }
            set
            {
                this.arg0Field = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://service.common.www.ventanillaunica.gob.mx/", IsNullable = false)]
    public partial class validacionGeneralResponse
    {

        private Respuesta returnField;


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Respuesta @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }

}