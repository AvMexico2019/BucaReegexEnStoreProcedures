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
    
    public partial class JustipreciacionArrto
    {
        public int IdJustipreciacion { get; set; }
        public Nullable<int> Fk_IdContratoArrto { get; set; }
        public string Secuencial { get; set; }
        public string SuperficieDictaminada { get; set; }
        public Nullable<System.DateTime> FechaDictamen { get; set; }
        public decimal MontoDictaminado { get; set; }
        public string EstatusAtencion { get; set; }
        public string NoGenerico { get; set; }
        public string UnidadMedidaSupRentableDictaminada { get; set; }
        public bool EstatusRegistro { get; set; }
        public int Fk_IdUsuarioRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
    
        public virtual ContratoArrto ContratoArrto { get; set; }
    }
}
