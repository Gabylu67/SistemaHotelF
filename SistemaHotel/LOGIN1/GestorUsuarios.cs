using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LOGIN1.Usuario;

namespace LOGIN1
{
    internal class GestorUsuarios
    {
        private List<Usuario> usuarios;

        public GestorUsuarios()
        {
            
            usuarios = new List<Usuario>();

            usuarios.Add(new Usuario("admin", "1234"));
            usuarios.Add(new Usuario("usuario1", "pass1"));
        }

        public bool ValidarUsuario(string nombre, string contraseña)
        {
            foreach (var usuario in usuarios)
            {
                if (usuario.Nombre == nombre && usuario.Contraseña == contraseña)
                {
                    return true;
                }
            }
            return false;
        }

        // Método para agregar usuarios
        public void AgregarUsuario(string nombre, string contraseña)
        {
            usuarios.Add(new Usuario(nombre, contraseña));
        }
    }


}
   
 
