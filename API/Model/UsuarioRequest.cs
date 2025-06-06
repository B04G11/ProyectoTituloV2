﻿namespace API.Model
{
    public class cUsuarioRequest
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int EmpresaId { get; set; }
        public int RolId { get; set; }
        public bool Activo { get; set; }
    }

    public class mUsuarioRequest
    {
        public int? UsuarioId { get; set; }
        public string? Nombre { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int? EmpresaId { get; set; }
        public int? RolId { get; set; }
        public bool? Activo { get; set; }
    }

    public class eUsuarioRequest
    {
        public int UsuarioId { get; set; }
        public bool Activar { get; set; }
    }

}
