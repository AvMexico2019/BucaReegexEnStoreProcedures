//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SQLServer
{
    using System;
    using System.Collections.Generic;
    
    public partial class VW_DWH_CONTRATORIUF
    {
        public Nullable<int> IdRIUF { get; set; }
        public int FolioContratoArrto { get; set; }
        public string DescripcionTipoArrendamiento { get; set; }
        public string DescripcionTipoContrato { get; set; }
        public decimal AreaOcupadaM2 { get; set; }
        public decimal MontoPagoMensual { get; set; }
        public System.DateTime FechaInicioOcupacion { get; set; }
        public System.DateTime FechaFinOcupacion { get; set; }
        public string PropietarioInmueble { get; set; }
        public string Arrendatario { get; set; }
        public string Secuencial { get; set; }
        public Nullable<int> SMOI { get; set; }
    }
}