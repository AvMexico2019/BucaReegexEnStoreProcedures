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
    
    public partial class DatosAdicionalesInmueble
    {
        public int Fk_IdInmuebleArrendamiento { get; set; }
        public string CodigoPostal { get; set; }
        public string Estado { get; set; }
        public string Ciudad { get; set; }
        public string Municipio { get; set; }
        public bool EstatusRegistro { get; set; }
        public int Fk_IdUsuarioRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
    
        public virtual InmuebleArrendamiento InmuebleArrendamiento { get; set; }
    }
}
