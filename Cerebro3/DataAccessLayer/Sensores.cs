//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sensores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sensores()
        {
            this.LecturaSensores = new HashSet<LecturaSensores>();
        }
    
        public int Id { get; set; }
        public string Api { get; set; }
        public int Maximo { get; set; }
        public int Minimo { get; set; }
        public bool Envio_Siempre { get; set; }
        public int Frecuencia { get; set; }
        public bool Activo { get; set; }
        public Nullable<int> Id_Vehiculo { get; set; }
        public string Tipo_Sensor { get; set; }
    
        public virtual Vehiculos Vehiculos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LecturaSensores> LecturaSensores { get; set; }
    }
}