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
    
    public partial class tbl_color
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_color()
        {
            this.tbl_vehiculo = new HashSet<tbl_vehiculo>();
        }
    
        public int idColor { get; set; }
        public string descripcionColor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_vehiculo> tbl_vehiculo { get; set; }
    }
}
