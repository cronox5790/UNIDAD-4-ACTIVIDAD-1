using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlCuentasActividad1.Models;


namespace ControlCuentasActividad1.Repositories
{
    public class UsuarioRepository : Repository<Usuario>
    {
        public UsuarioRepository(controlcuentasContext context) : base(context) { }

        public Usuario GetUsuarioByCorreo(string correo)
        {
            return Context.Usuario.FirstOrDefault(x => x.Correo == correo);
        }

        public override bool Validar(Usuario entidad)
        {
            if (string.IsNullOrEmpty(entidad.Correo))
                throw new Exception("Ingrese su correo electronico");

            return true;
        }
    }
}
