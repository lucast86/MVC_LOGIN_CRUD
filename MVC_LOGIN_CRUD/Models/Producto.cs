//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_LOGIN_CRUD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        public int id_producto { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> cantidad { get; set; }
        public Nullable<double> precio { get; set; }
        public Nullable<int> id_rubro { get; set; }
    
        public virtual Rubro Rubro { get; set; }
    }
}
