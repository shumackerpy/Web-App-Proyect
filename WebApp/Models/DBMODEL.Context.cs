﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBMODELS : DbContext
    {
        public DBMODELS()
            : base("name=DBMODELS")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alumnos> Alumnos { get; set; }
        public virtual DbSet<Asistencia> Asistencia { get; set; }
        public virtual DbSet<Cursos> Cursos { get; set; }
        public virtual DbSet<Historico_Cursos_Alumnos> Historico_Cursos_Alumnos { get; set; }
        public virtual DbSet<tabla> tabla { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
    }
}
