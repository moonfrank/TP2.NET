using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Business.Entities;

namespace UI.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            new Usuarios().Menu();
        }
    }

    public class Usuarios
    {
        public Business.Logic.UsuarioLogic UsuarioNegocio { get; set; }

        public Usuarios()
        {
            this.UsuarioNegocio = new Business.Logic.UsuarioLogic();
        }

        public void Menu()
        {
            int opt=1;
            while (opt != 6)
            {
                Console.WriteLine("Elija una de las siguientes opciones: ");
                Console.WriteLine("\t\t1- Listado General");
                Console.WriteLine("\t\t2- Consulta");
                Console.WriteLine("\t\t3- Agregar");
                Console.WriteLine("\t\t4- Modificar");
                Console.WriteLine("\t\t5- Eliminar");
                Console.WriteLine("\t\t6- Salir");
                while (!int.TryParse(Console.ReadLine(), out opt)||opt>6||opt<1) Console.WriteLine("Ingreso erróneo de datos!");
                switch(opt)
                {
                    case 1:
                        {
                            ListadoGeneral();
                            break;
                        }
                    case 2:
                        {
                            Consultar();
                            break;
                        }
                    case 3:
                        {
                            Modificar();
                            break;
                        }
                    case 4:
                        {
                            Agregar();
                            break;
                        }
                    case 5:
                        {
                            Eliminar();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }
        }

        public void ListadoGeneral()
        {
            foreach (Usuario usuario in UsuarioNegocio.GetAll())
                MostrarDatos(usuario);
        }

        public void MostrarDatos(Usuario usuario)
        {
            Console.WriteLine("Usuario: "+usuario.ID);
            Console.WriteLine("\t\tNombre: "+usuario.Nombre);
            Console.WriteLine("\t\tApellido: "+usuario.Apellido);
            Console.WriteLine("\t\tNombre de Usuario: "+usuario.NombreUsuario);
            Console.WriteLine("\t\tClave: "+usuario.Clave);
            Console.WriteLine("\t\tEmail: "+usuario.Email);
            Console.WriteLine("\t\tHabilitado: "+usuario.Habilitado);
            Console.WriteLine();
        }

        void Consultar()
        {
            Console.WriteLine("Ingrese ID de usuario a consultar: ");
            int ID = 0;
            while (!int.TryParse(Console.ReadLine(), out ID)) Console.WriteLine("Ingreso de datos erróneo!");
            this.MostrarDatos(UsuarioNegocio.GetOne(ID));
        }

        public void Modificar()
        {
            try
            {
                Console.Write("Ingrese el ID del usuario a modificar: ");
                int ID = int.Parse(Console.ReadLine());
                Usuario usuario = UsuarioNegocio.GetOne(ID);
                Console.Write("Ingrese Nombre: ");
                usuario.Nombre = Console.ReadLine();
                Console.Write("Ingrese Apellido: ");
                usuario.Apellido = Console.ReadLine();
                Console.Write("Ingrese Nombre de Usuario: ");
                usuario.NombreUsuario = Console.ReadLine();
                Console.Write("Ingrese Clave: ");
                usuario.Clave = Console.ReadLine();
                Console.Write("Ingrese Email: ");
                usuario.Email = Console.ReadLine();
                Console.Write("Ingrese Habilitación de Usuario (1-Sí/otro-No): ");
                usuario.Habilitado = (Console.ReadLine()=="1");
                usuario.State = BusinessEntity.States.Modified;
                UsuarioNegocio.Save(usuario);
            }
            catch(FormatException)
            {
                Console.WriteLine("\nLa ID ingresada debe ser un número entero");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Agregar()
        {
            Usuario usuario = new Usuario();
            Console.Write("Ingrese Nombre: ");
            usuario.Nombre = Console.ReadLine();
            Console.Write("Ingrese Apellido: ");
            usuario.Apellido = Console.ReadLine();
            Console.Write("Ingrese Nombre de Usuario: ");
            usuario.NombreUsuario = Console.ReadLine();
            Console.Write("Ingrese Clave: ");
            usuario.Clave = Console.ReadLine();
            Console.Write("Ingrese Email: ");
            usuario.Email = Console.ReadLine();
            Console.Write("Ingrese Habilitación de Usuario (1-Sí/otro-No): ");
            usuario.Habilitado = (Console.ReadLine()=="1");
            usuario.State = BusinessEntity.States.New;
            UsuarioNegocio.Save(usuario);
            Console.WriteLine("\nID: " + usuario.ID);
        }

        public void Eliminar()
        {
            try
            {
                Console.Write("Ingrese el ID del usuario a eliminar");
                int ID = int.Parse(Console.ReadLine());
                UsuarioNegocio.Delete(ID);
            }
            catch(FormatException)
            {
                Console.WriteLine("\nLa ID ingresada debe ser un número entero");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
