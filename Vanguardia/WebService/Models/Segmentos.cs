//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Segmentos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Segmentos()
        {
            this.Contenidos = new HashSet<Contenidos>();
        }
    
        public int IdT_Segmento { get; set; }
        public int IdF_Curso { get; set; }
        public Nullable<int> Id_SegmentoPadre { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public bool Visible { get; set; }
        public int IdF_Pais { get; set; }
    
        public virtual Cursos Cursos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contenidos> Contenidos { get; set; }
    }
}