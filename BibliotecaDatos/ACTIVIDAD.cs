//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BibliotecaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class ACTIVIDAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACTIVIDAD()
        {
            this.REPORTE = new HashSet<REPORTE>();
        }
    
        public int Cod_actividad { get; set; }
        public string Nombre_actividad { get; set; }
        public string Centro_formacion_actividad { get; set; }
        public string Proposito_actividad { get; set; }
        public string Objetivo_estrategico_actividad { get; set; }
        public string Objetivo_operativo_actividad { get; set; }
        public string Fecha_actividad { get; set; }
        public string Ciudad_actividad { get; set; }
        public int Identificacion_encargado { get; set; }
    
        public virtual ENCARGADO ENCARGADO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REPORTE> REPORTE { get; set; }
    }
}
