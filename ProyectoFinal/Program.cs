using System;

namespace ProyectoFinal
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //Creacion de objeto de la clase biblioteca
      Biblioteca biblioteca = new Biblioteca(); 


      //Creacion de objetos de libros
      //***************************************
      Libro libro1 = new Libro("Don Quijote de la Mancha", "Miguel de Cervantes", "Akal", 2013, "4ta", "978-84-376-0494-7");
      biblioteca.AgregarLibro(libro1);

      Libro libro2 = new Libro("Cien Años de Soledad", "Gabriel García Márquez", "Alba", 2004, "0ro", "978-84-376-0492-3");
      biblioteca.AgregarLibro(libro2);
      //***************************************


      //Creacion de objetos de usuarios
      //***************************************
      Usuario usuario1 = new Usuario("Juan", "Perez", "Calle de embuste 1224", "sebanoob@preca.com", "123-456-7890", "001", "Estudiante");
      biblioteca.AgregarPersona(usuario1);

      Usuario usuario2 = new Usuario("María", "García", "Calle Dos Pepsi 432", "miabuela@ok.com", "098-765-4321", "002", "Profesora");
      biblioteca.AgregarPersona(usuario2);
      //***************************************


      //Creacion de objeto de bibliotecario
      //***************************************
      Bibliotecario bibliotecario1 = new Bibliotecario("Carlos", "Sánchez", "Peo road 456", "megustanloslibros@mac.com", "000-123-7890", "101", "Administrador");
      biblioteca.AgregarPersona(bibliotecario1);
      //***************************************


      //Mensaje de bienvenida, recoje la opcion de inicializar el programa
      //***************************************
      string contestacion;
      Console.WriteLine("*******************************************************************************************");
      Console.WriteLine("Bienvenidos a la biblioteca de C#");

      Console.Write("Desea inicializar el programa? y/n: ");
      contestacion = Console.ReadLine();
      //***************************************


      //If de filtracion de datos ingreados.
      //Verifica si realmente se ingresaron los datos correctos.
      //Si no, mas adelante se encuentra un else que indica que 
      //se ingreso el dato incorrectamente
      if (contestacion == "y" || contestacion == "n") //Verifica:
      {
        //Comienza el programa:

        //Si la contestacion es si (y), entonces sigue
        if(contestacion == "y")
        {
          //Ciclo for infinito, esto hace que el programa se sienta interactivo
          for(;;)
          {
            //Captura el valor y menu de seleccion
            //*************************************************
            int numero = 0;
            Console.WriteLine();
            Console.WriteLine("***********************************************************************************");
            Console.Write("* ");
            Console.Write("1: Estado del libro, 2: Mostrar informacion, 3: Agregar, 4: Eliminar, 5: Cerrar");
            Console.WriteLine(" *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine();
            Console.Write("Ingrese su opcion: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //*************************************************

            //Si la opcion es Estado del libro
            //*************************************************
            if (numero == 1)
            {
              //Variable
              int contestacion1;
              Console.WriteLine();


              //Menu de seleccion
              //*************************************************
              Console.WriteLine("****************************");
              Console.Write("* ");
              Console.Write($"1: {libro1.Titulo}");
              Console.WriteLine(" *");

              
              Console.Write("* ");
              Console.Write($"2: {libro2.Titulo}");
              Console.WriteLine(" *");

              Console.Write("* ");
              Console.Write("3: Ninguno");
              Console.WriteLine(" *");
              Console.WriteLine("****************************");
              //*************************************************


              //Del menu de seleccion, cual libro deseas editar/alterar
              //*************************************************
              Console.WriteLine();
              Console.Write("Que libro deseas alterar?: ");
              contestacion1 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine();
              //*************************************************


              //En este caso, si eliges 1 modifica el libro1
              //*************************************************
              if (contestacion1 == 1)
              {
                //Menu de seleccion
                //***********************************************
                //Variable para la contestacion del menu
                int contestacion2;
                Console.WriteLine();
                Console.WriteLine("***********************************");
                Console.Write("* ");
                Console.Write("Desea marcar el libro: ");
                Console.WriteLine(" *");

                Console.Write("* ");
                Console.Write("1: Prestado, 2: Devuelto, 3: Nada");
                Console.WriteLine(" *");
                Console.WriteLine("***********************************");
                Console.WriteLine();
                //***********************************************


                //Captura la contestacion del usuario
                Console.Write("Ingrese su opcion: ");
                contestacion2 = Convert.ToInt32(Console.ReadLine());


                //Realiza lo siguiente dependiendo del valor
                //***********************************************
                if (contestacion1 == 1)
                {
                  //llamada al metodo
                  Console.WriteLine();
                  biblioteca.PrestarLibro(libro1, usuario1);
                }
                else if (contestacion1 == 2)
                {
                  //llamada al metodo
                  Console.WriteLine();
                  biblioteca.DevolverLibro(libro1, usuario1);
                }
                else if (contestacion1 == 3)
                {
                  Console.WriteLine();
                  Console.WriteLine("No se hara nada");
                }
                else
                {
                  Console.WriteLine();
                  Console.WriteLine("Opcion invalida");
                }
                //***********************************************
              }
              //*************************************************


              //Si la opcion es 2, modifica el libro 2
              //*************************************************
              else if (contestacion1 == 2)
              {
                //Menu de seleccion
                //***********************************************
                //Variable para la contestacion del menu
                int contestacion2;
                Console.WriteLine("***********************************");
                Console.Write("* ");
                Console.Write("Desea marcar el libro: ");
                Console.WriteLine(" *");

                Console.Write("* ");
                Console.Write("1: Prestado, 2: Devuelto, 3: Nada");
                Console.WriteLine(" *");
                Console.WriteLine("***********************************");
                //***********************************************


                //Captura la contestacion del usuario
                Console.Write("Ingrese su opcion: ");
                contestacion2 = Convert.ToInt32(Console.ReadLine());

                //Realiza lo siguiente dependiendo del valor
                //***********************************************
                if (contestacion1 == 1)
                {
                  //Llamada al metodo
                  Console.WriteLine();
                  biblioteca.PrestarLibro(libro2, usuario2);
                }
                else if (contestacion1 == 2)
                {
                  //Llamada al metodo
                  Console.WriteLine();
                  biblioteca.DevolverLibro(libro2, usuario2);
                }
                else if (contestacion1 == 3)
                {
                  Console.WriteLine();
                  Console.WriteLine("No se hara nada");
                }
                else
                {
                  Console.WriteLine();
                  Console.WriteLine("Opcion invalida");
                }
                //***********************************************
              }
              //*************************************************


              //Si el usuario elige que no o ingresa algo invalido
              //*************************************************
              else if (contestacion1 == 3)
              {
                Console.WriteLine();
                Console.WriteLine("No se hara nada");
              }

              else
              {
                Console.WriteLine();
                Console.WriteLine("Opcion invalida");
              }
              //*************************************************
            }
            //*************************************************

            //Mostrar informacion tanto de libros como de personas
            //*************************************************
            else if (numero == 2)
            {
              //Menu de seleccion
              //***********************************************
              int contestacion3;
              Console.WriteLine("**********************************************");
              Console.Write("* ");
              Console.Write("Desea mostrar informacion de: ");
              Console.WriteLine("             *");

              Console.Write("* ");
              Console.Write("1: Libro, 2: Persona, 3: Ambos, 4: Ninguno");
              Console.WriteLine(" *");
              Console.WriteLine("**********************************************");
              //***********************************************


              //Captura el dato ingresado por el usuario
              //***********************************************
              Console.Write("Ingrese su opcion: ");
              contestacion3 = Convert.ToInt32(Console.ReadLine());
              //***********************************************


              //Si el dato ingresado es 1
              //***********************************************
              if (contestacion3 == 1)
              {
                Console.WriteLine();
                Console.WriteLine("Mostrando informacion de libros:");

                Console.WriteLine();
                biblioteca.MostrarLibros();
                Console.WriteLine();
              }
              //Si es 2
              else if (contestacion3 == 2)
              {
                Console.WriteLine();
                Console.WriteLine("Mostrando informacion de personas:");

                Console.WriteLine();
                biblioteca.MostrarPersonas();
                Console.WriteLine();
              }
              //Si es 3
              else if (contestacion3 == 3)
              {
                Console.WriteLine();
                Console.WriteLine("Libros: ");

                Console.WriteLine();
                biblioteca.MostrarLibros();
                Console.WriteLine();

                Console.WriteLine();
                Console.WriteLine("Personas: ");

                Console.WriteLine();
                biblioteca.MostrarPersonas();
                Console.WriteLine();
              }
              //Si es 4
              else if (contestacion3 == 4)
              {
                Console.WriteLine();
                Console.WriteLine("No se mostrara informacion");
              }
              else
              {
                Console.WriteLine();
                Console.WriteLine("Opcion invalida");
              }
              //***********************************************
            }
            //*************************************************


            //Agregar informacion tanto de libros como de usuarios
            else if (numero == 3)
            {
              //Menu
              //***********************************************
              int contestacion4;
              Console.WriteLine();
              Console.WriteLine("****************************************************");
              Console.Write("* ");
              Console.Write("1: Agregar libro, 2: Agregar persona, 3: Ninguno");
              Console.WriteLine(" *");
              Console.WriteLine("****************************************************");
              //************************************************


              //Captura de datos ingresados por el usuario
              //************************************************
              Console.Write("Ingrese su opcion: ");
              contestacion4 = Convert.ToInt32(Console.ReadLine());
              //************************************************


              //Si la contestacion es 1
              //************************************************
              if (contestacion4 == 1)
              {
                //Creacion de variables para crear objeto de libro
                string titulo3;
                string autor3;
                string editorial3;
                int anioPublicacion3;
                string edicion3;
                string isbn3;


                //Ingresar los datos del nuevo libro a aniadir y asignarselos a las varaibles creadas
                //**********************************************
                Console.WriteLine();
                Console.WriteLine("******************************************************************");
                Console.WriteLine("Ingrese la siguiente informacion del libro que desea aniadir:");

                Console.WriteLine();

                //Asignando el valor ingresado por el usuario a la varibale
                //Titulo del libro
                Console.Write("Titulo: ");
                titulo3 = Console.ReadLine();
                //Autor del libro
                Console.Write("Autor: ");
                autor3 = Console.ReadLine();
                //Editorial
                Console.Write("Editorial: ");
                editorial3 = Console.ReadLine();
                //Anio de publicacion
                Console.Write("Anio de publicacion: ");
                anioPublicacion3 = Convert.ToInt32(Console.ReadLine());
                //Edicion
                Console.Write("Edicion: ");
                edicion3 = Console.ReadLine();
                //ISBN
                Console.Write("ISBN: ");
                isbn3 = Console.ReadLine();
                Console.WriteLine("******************************************************************");

                //Creacion de objeto con las variables creadas y los valores ingresados
                Libro libro3 = new Libro(titulo3, autor3, editorial3, anioPublicacion3, edicion3, isbn3);

                biblioteca.AgregarLibro(libro3); //Agregando el objeto a la lista

                Console.WriteLine();
                Console.WriteLine("Libro agregado exitosamente");
                //**********************************************


                //Muestra los libros ya ingresados y el que se acaba de ingresar
                //**********************************************
                Console.WriteLine();
                Console.WriteLine("******************************************************************");
                Console.WriteLine("Libros: ");
                biblioteca.MostrarLibros();
                Console.WriteLine("******************************************************************");
                Console.WriteLine();
                //**********************************************


                //Le pregunta al usuario si desea aniadir otro libro y recoge su contestacion
                //**********************************************
                string contestacion5;
                Console.Write("Desea aniadir otro libro? y/n: ");
                contestacion5 = Console.ReadLine();
                //**********************************************

                
                //Si la contestacion es si hace todo nuevamente
                //**********************************************
                if (contestacion5 == "y")
                {
                  string titulo4;
                  string autor4;
                  string editorial4;
                  int anioPublicacion4;
                  string edicion4;
                  string isbn4;

                  Console.WriteLine();
                  Console.WriteLine("*******************************************************************");
                  Console.WriteLine("Ingrese la siguiente informacion de la persona que desea aniadir:");

                  Console.WriteLine();

                  Console.Write("Titulo: ");
                  titulo4 = Console.ReadLine();

                  Console.Write("Autor: ");
                  autor4 = Console.ReadLine();

                  Console.Write("Editorial: ");
                  editorial4 = Console.ReadLine();

                  Console.Write("Anio de publicacion: ");
                  anioPublicacion4 = Convert.ToInt32(Console.ReadLine());

                  Console.Write("Edicion: ");
                  edicion4 = Console.ReadLine();

                  Console.Write("ISBN: ");
                  isbn4 = Console.ReadLine();
                  Console.WriteLine("*******************************************************************");

                  Libro libro4 = new Libro(titulo4, autor4, editorial4, anioPublicacion4, edicion4, isbn4);
                  biblioteca.AgregarLibro(libro4);

                  Console.WriteLine("Libro agregado exitosamente");

                  Console.WriteLine();
                  Console.WriteLine("********************************************************************");
                  Console.WriteLine("Libros: ");
                  biblioteca.MostrarLibros();
                  Console.WriteLine("********************************************************************");
                  Console.WriteLine();
                }
                //**********************************************


                //Si es no, no hace nada
                else if (contestacion5 == "n")
                {
                  Console.WriteLine();
                  Console.WriteLine("No se agregara otro libro");
                }

                //Si la entrada es invalida
                else
                {
                  Console.WriteLine();
                  Console.WriteLine("Opcion invalida");
                }
              }
              //***********************************************

              //Si la opcion es 2, hace lo mismo que hace para libros pero para usuarios
              //***********************************************
              else if (contestacion4 == 2)
              {
                string nombre3;
                string apellido3;
                string direccion3;
                string email3;
                string telefono3;
                string id3;
                string tipo3;

                Console.WriteLine();
                Console.WriteLine("******************************************************************");
                Console.WriteLine("Ingrese la siguiente informacion de la persona que desea aniadir:");

                Console.WriteLine();

                Console.Write("Nombre: ");
                nombre3 = Console.ReadLine();

                Console.Write("Apellido: ");
                apellido3 = Console.ReadLine();

                Console.Write("Direccion: ");
                direccion3 = Console.ReadLine();

                Console.Write("Email: ");
                email3 = Console.ReadLine();

                Console.Write("Telefono: ");
                telefono3 = Console.ReadLine();

                Console.Write("ID: ");
                id3 = Console.ReadLine();

                Console.Write("Tipo: ");
                tipo3 = Console.ReadLine();
                Console.WriteLine("*****************************************************************");

                Usuario usuario3 = new Usuario(nombre3, apellido3, direccion3, email3, telefono3, id3, tipo3);
                biblioteca.AgregarPersona(usuario3);

                Console.WriteLine("Persona agregada exitosamente");

                Console.WriteLine();
                Console.WriteLine("******************************************************************");
                Console.WriteLine("Personas: ");
                biblioteca.MostrarPersonas();
                Console.WriteLine("******************************************************************");
                Console.WriteLine();

                string contestacion6;
                Console.Write("Desea aniadir otra persona? y/n: ");
                contestacion6 = Console.ReadLine();

                if (contestacion6 == "y")
                {
                  string nombre4;
                  string apellido4;
                  string direccion4;
                  string email4;
                  string telefono4;
                  string id4;
                  string tipo4;

                  Console.WriteLine("Ingrese la siguiente informacion de la persona que desea aniadir:");

                  Console.WriteLine();

                  Console.Write("Nombre: ");
                  nombre4 = Console.ReadLine();

                  Console.Write("Apellido: ");
                  apellido4 = Console.ReadLine();

                  Console.Write("Direccion: ");
                  direccion4 = Console.ReadLine();

                  Console.Write("Email: ");
                  email4 = Console.ReadLine();

                  Console.Write("Telefono: ");
                  telefono4 = Console.ReadLine();

                  Console.Write("ID: ");
                  id4 = Console.ReadLine();

                  Console.Write("Tipo: ");
                  tipo4 = Console.ReadLine();

                  Usuario usuario4 = new Usuario(nombre4, apellido4, direccion4, email4, telefono4, id4, tipo4);

                  biblioteca.AgregarPersona(usuario4);

                  Console.WriteLine("Persona agregada exitosamente");

                  Console.WriteLine();
                  Console.WriteLine("******************************************************************");
                  Console.WriteLine("Personas: ");
                  biblioteca.MostrarPersonas();
                  Console.WriteLine("******************************************************************");
                  Console.WriteLine();
                }

                else if (contestacion6 == "n")
                {
                  Console.WriteLine();
                  Console.WriteLine("No se agregara otra persona");
                }

                else
                {
                  Console.WriteLine();
                  Console.WriteLine("Opcion invalida");
                }
              }
              //***********************************************
            }
            //***********************************************


            //Si la opcion es 4, se inicia la eliminacion de libros e usuarios
            else if (numero == 4)
            {
              //Menu
              //*********************************************
              int contestacion7;
              Console.WriteLine();
              Console.WriteLine("******************************************************");
              Console.Write("* ");
              Console.Write("1: Eliminar libro, 2: Eliminar persona, 3: Ninguno");
              Console.WriteLine(" *");
              Console.WriteLine("******************************************************");
              Console.WriteLine();
              //*********************************************


              //Captura la opcion ingresada por el usuario
              //*********************************************
              Console.Write("Ingrese su opcion: ");
              contestacion7 = Convert.ToInt32(Console.ReadLine());
              //*********************************************


              //Si la opcion es 1
              //*********************************************
              if (contestacion7 == 1)
              {
                //Menu
                //*******************************************
                int contestacion8;
                Console.WriteLine();
                Console.WriteLine("**********************************************************************************************");
                Console.Write("* ");
                Console.Write("Desea eliminar el libro - 1: Don Quijote de la Mancha, 2: Cien Años de Soledad, 3- Ninguno");
                Console.WriteLine(" *");
                Console.WriteLine("**********************************************************************************************");
                Console.WriteLine();
                //*******************************************


                //Captura la opcion entrada por el usuario
                //*******************************************
                Console.Write("Ingrese su opcion: ");
                contestacion8 = Convert.ToInt32(Console.ReadLine());
                //*******************************************

                //Si la opcion ingresada es 1 elimina el libro 1
                //*******************************************
                if (contestacion8 == 1)
                {
                  biblioteca.EliminarLibro(libro1);
                  Console.WriteLine();
                  Console.WriteLine("Libro 1 eliminado exitosamente!");
                }
                //Si el la 2 elimina el libro 2
                else if (contestacion8 == 2)
                {
                  biblioteca.EliminarLibro(libro2);
                  Console.WriteLine();
                  Console.WriteLine("Libro 2 eliminado exitosamente!");
                }
                else if (contestacion8 == 3)
                {
                  Console.WriteLine();
                  Console.WriteLine("No se eliminara ningun libro");
                }
                else
                {
                  Console.WriteLine();
                  Console.WriteLine("Opcion invalida");
                }
              }
              //********************************************


              //Si es opcion 2 hace lo mismo que con libro pero con usuario
              //********************************************
              else if (contestacion7 == 2)
              {
                int contestacion9;
                Console.WriteLine();
                Console.WriteLine("********************************************************************");
                Console.Write("* ");
                Console.Write("Desea eliminar la persona: 1- Juan Perez, 2- María García, 3- Ninguno");
                Console.WriteLine(" *");
                Console.WriteLine("********************************************************************");
                Console.WriteLine();

                Console.Write("Ingrese su opcion: ");
                contestacion9 = Convert.ToInt32(Console.ReadLine());

                if (contestacion9 == 1)
                {
                  biblioteca.EliminarPersona(usuario1);
                  Console.WriteLine("Usuario 1 se borro exitosamente!");
                }
                else if (contestacion9 == 2)
                {
                  biblioteca.EliminarPersona(usuario2);
                  Console.WriteLine("Usuario 2 se borro exitosamente!");
                }
                else if (contestacion9 == 3)
                {
                  Console.WriteLine("No se eliminara ninguna persona");
                }
                else
                {
                  Console.WriteLine("Opcion invalida");
                }
              }
            }
            //********************************************

            else if (numero == 5)
            {
              Console.WriteLine("Gracias por usar el programa!");
              Console.WriteLine("*******************************************************************************************");
              break;
            }

            else
            {
              Console.WriteLine("Error, opcion invalida");
              Console.WriteLine("*******************************************************************************************");
            }
          }
        }
        else
        {
          Console.WriteLine("Programa no inicializado");
          Console.WriteLine("*******************************************************************************************");
        }
      }
    }
  }
}