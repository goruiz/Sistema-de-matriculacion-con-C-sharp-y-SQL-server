//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace matriculacion_proy.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_matricula
    {
        public int idMatricula { get; set; }
        public System.DateTime fechaMatricula { get; set; }
        public string anioMatricula { get; set; }
        public string telefonoMatricula { get; set; }
        public string estadoMatricula { get; set; }
        public Nullable<int> idVehiculo { get; set; }
        public Nullable<int> idAgencia { get; set; }
    
        public virtual tbl_agencia tbl_agencia { get; set; }
        public virtual tbl_vehiculo tbl_vehiculo { get; set; }
    }
}