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
    
    public partial class RIUF
    {
        public RIUF()
        {
            this.Inmueble = new HashSet<Inmueble>();
        }
    
        public int IdRIUF { get; set; }
        public string RIUF1 { get; set; }
        public Nullable<int> Fk_IdEstado { get; set; }
        public Nullable<int> Fk_IdEstadoRIUF { get; set; }
        public int Consecutivo { get; set; }
        public int DigitoVerificador { get; set; }
        public bool EstatusRegistro { get; set; }
        public int Fk_IdUsuarioRegistro { get; set; }
        public string CargoUsuarioRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
    
        public virtual ICollection<Inmueble> Inmueble { get; set; }
    }
}
