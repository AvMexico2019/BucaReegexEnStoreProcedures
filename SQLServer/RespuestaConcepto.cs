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
    
    public partial class RespuestaConcepto
    {
        public int IdRespConcepto { get; set; }
        public int Fk_IdAplicacionConcepto { get; set; }
        public int Fk_IdConceptoRespValor { get; set; }
        public decimal ValorResp { get; set; }
        public string Observaciones { get; set; }
        public bool EstatusRegistro { get; set; }
        public int Fk_IdUsuarioRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
    
        public virtual AplicacionConcepto AplicacionConcepto { get; set; }
        public virtual Rel_ConceptoRespValor Rel_ConceptoRespValor { get; set; }
    }
}
