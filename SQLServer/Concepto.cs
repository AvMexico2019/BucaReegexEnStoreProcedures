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
    
    public partial class Concepto
    {
        public Concepto()
        {
            this.Rel_ConceptoRespValor = new HashSet<Rel_ConceptoRespValor>();
        }
    
        public int IdConcepto { get; set; }
        public string DescripcionConcepto { get; set; }
        public string DescripcionAlternaConcepto { get; set; }
        public string FundamentoLegal { get; set; }
        public string Observaciones { get; set; }
        public bool EstatusRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public int Fk_IdUsuarioRegistro { get; set; }
    
        public virtual ICollection<Rel_ConceptoRespValor> Rel_ConceptoRespValor { get; set; }
    }
}
