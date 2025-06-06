﻿namespace API.Model
{
    
    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class LoginResponse
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public int EmpresaId { get; set; }
        public int RolId { get; set; }
        public bool Activo { get; set; }
        public string Mensaje { get; set; }
        public bool Exito { get; set; }
    }


}
