using institucion.DataAcces;
using institucion.Misc;
using institucion.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;





namespace institucion
{   


    class Program
    {



        static void Main(string[] args)
        {

            Persona[] Lista = new Persona[2];
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo("CMD.EXE", "C:\\WINDOWS\\system32\\cmd.exe");
            Console.WriteLine("prueba");
            Console.WriteLine("cd ..");
            Console.WriteLine(Persona.Contador);
            Console.ReadLine();

            var alumno = new Alumno() { Apellido = "grajales", Edad = 23, Email = "alex-12-04@hotmail.com", Id = 1, Nombre = "Alex", Telefono = "3216299038" , estado = EstadosAlumno.Matriculado};
            //var persona = new Persona() { Apellido = "grajales", Edad = 23, Id = 1, Nombre = "Alex", Telefono = "3216299038" };
            var profesor = new Profesor() { Apellido = "grajales", Edad = 23, Id = 1, Nombre = "Alex", Telefono = "3216299038", Catedra = "Redes" };

            Lista[0] = alumno;
            Lista[1] = profesor;

            foreach (Persona p in Lista)
            {
                Console.WriteLine(p.ConstruirResumen());
            }

            Persona a = profesor;
            Persona b = alumno;

            //Console.WriteLine(profesor.ConstruirResumen());
            //Console.WriteLine(alumno.ConstruirResumen());

            Console.WriteLine(Persona.Contador);
            Curso c = new Curso();
            c.NombreCurso = "C#";
            c.max_capacidad = 2;

           
            short s = 32000;
            int i = 33000;
            Console.WriteLine(s);
            s = (short)i;
            //Console.WriteLine(s);


            Persona[] arregloPersonas = new Persona[5];
            arregloPersonas[0] = new Alumno() { Apellido = "grajales", Edad = 23, Email = "alex-12-04@hotmail.com", Id = 1, Nombre = "Alex", Telefono = "3216299038", estado = EstadosAlumno.Matriculado };
            arregloPersonas[1] = new Profesor() { Apellido = "grajales", Edad = 23, Id = 1, Nombre = "jose", Telefono = "3216299038"};
            arregloPersonas[2] = new Alumno() { Apellido = "grajales", Edad = 23, Email = "alex-12-04@hotmail.com", Id = 1, Nombre = "pedro", Telefono = "3216299038", estado = EstadosAlumno.Matriculado };
            arregloPersonas[3] = new Alumno() { Apellido = "grajales", Edad = 23, Email = "alex-12-04@hotmail.com", Id = 1, Nombre = "juan", Telefono = "3216299038", estado = EstadosAlumno.Matriculado };
            arregloPersonas[4] = new Profesor() { Apellido = "grajales", Edad = 23, Id = 1, Nombre = "francisco", Telefono = "3216299038" };
            for (int j = 0; j < arregloPersonas.Length; j++)
            {
                if (arregloPersonas[j] is Alumno)
                {
                    var alu = (Alumno)arregloPersonas[j];
                    Console.WriteLine(alu.estado);
                }
                else
                {
                    Console.WriteLine(arregloPersonas[j].NombreCompleto);
                }
                
            }

            ArrayList ListaPersonasLista = new ArrayList();
            ListaPersonasLista.Add(arregloPersonas[0]);
            ListaPersonasLista.Add(arregloPersonas[1]);
            ListaPersonasLista.Add(arregloPersonas[2]);
            ListaPersonasLista.Add(arregloPersonas[3]);
            ListaPersonasLista.Add(arregloPersonas[4]);
            Console.ReadLine();

            foreach (var list in ListaPersonasLista)
            {
                if (list is Alumno)
                {
                    var alu = (Alumno)list;
                    Console.WriteLine(alu.estado);
                }
                else
                {
                    Console.WriteLine(list);
                }
                
            }
            Console.ReadLine();
            List<Persona> ListaPersonasLista2 = new List<Persona>();
            ListaPersonasLista.Add(arregloPersonas[0]);
            ListaPersonasLista.Add(arregloPersonas[1]);
            ListaPersonasLista.Add(arregloPersonas[2]);
            ListaPersonasLista.Add(arregloPersonas[3]);
            ListaPersonasLista.Add(arregloPersonas[4]);
            Console.ReadLine();

            Console.ReadLine();
            List<Profesor> ListaProfesor = new List<Profesor>();
            ListaProfesor.Add(new Profesor() { Apellido = "grajales", Edad = 23, Id = 1, Nombre = "jose", Telefono = "3216299038" });
            ListaProfesor.Add(new Profesor() { Apellido = "grajales", Edad = 23, Id = 1, Nombre = "jose", Telefono = "3216299038" });
            ListaProfesor.Add(new Profesor() { Apellido = "grajales", Edad = 23, Id = 1, Nombre = "jose", Telefono = "3216299038" });
            ListaProfesor.Add(new Profesor() { Apellido = "grajales", Edad = 23, Id = 1, Nombre = "jose", Telefono = "3216299038" });
            ListaProfesor.Add(new Profesor() { Apellido = "grajales", Edad = 23, Id = 1, Nombre = "jose", Telefono = "3216299038" });
            Console.ReadLine();

            Console.ReadLine();
            List<Alumno> ListaAlumno = new List<Alumno>();
            ListaAlumno.Add(new Alumno() { Apellido = "grajales", Edad = 23, Email = "alex-12-04@hotmail.com", Id = 1, Nombre = "Alex", Telefono = "3216299038", estado = EstadosAlumno.Matriculado });
            ListaAlumno.Add(new Alumno() { Apellido = "grajales", Edad = 23, Email = "alex-12-04@hotmail.com", Id = 1, Nombre = "Alex", Telefono = "3216299038", estado = EstadosAlumno.Matriculado });
            ListaAlumno.Add(new Alumno() { Apellido = "grajales", Edad = 23, Email = "alex-12-04@hotmail.com", Id = 1, Nombre = "Alex", Telefono = "3216299038", estado = EstadosAlumno.Matriculado });
            ListaAlumno.Add(new Alumno() { Apellido = "grajales", Edad = 23, Email = "alex-12-04@hotmail.com", Id = 1, Nombre = "Alex", Telefono = "3216299038", estado = EstadosAlumno.Matriculado });
            ListaAlumno.Add(new Alumno() { Apellido = "grajales", Edad = 23, Email = "alex-12-04@hotmail.com", Id = 1, Nombre = "Alex", Telefono = "3216299038", estado = EstadosAlumno.Matriculado });
            Console.ReadLine();

            foreach (var list in ListaPersonasLista2)
            {
                if (list is Alumno)
                {
                    var alu = (Alumno)list;
                    Console.WriteLine(alu.estado);
                }
                else
                {
                    Console.WriteLine(list);
                }

            }
            

            var profesor2 = new Profesor() { Apellido = "grajales", Edad = 23, Id = 1, Nombre = "Alex", Telefono = "3216299038", Catedra = "Redes" };

            var transmitter = new TrasmisionDeDatos();

            transmitter.InformacionEnviada += Transmitter_InformacionEnviada;
            transmitter.InformacionEnviada += (obj, evtarg) => { Console.WriteLine("Existoso"); };
            transmitter.FormatearYEnviar(profesor, formatter, "Alex");
            transmitter.FormatearYEnviar(profesor, ReverseFormatter, "Alex");
            Console.ReadLine();

            int localId = 0;

            var listasProfes = new List<Profesor>();
            string[] lineas = File.ReadAllLines("C:/Users/agrajales/Documents/Visual Studio 2015/Projects/CursoPlatzi/institucion/institucion/File/texto.txt");
            foreach (var linea in lineas)
            {
                listasProfes.Add(new Profesor() { Nombre = linea, Id = localId++ });
            }

            foreach (var profe in listasProfes)
            {
                Console.WriteLine(profe.Nombre);
            }

            var archivo = File.Open("profes binarios.bin", FileMode.OpenOrCreate);
            var binFile = new BinaryWriter(archivo);
            foreach (var profe in listasProfes)
            {
                var bytesNombre = Encoding.UTF8.GetBytes(profe.Nombre);
                archivo.Write(bytesNombre, 0, bytesNombre.Length);

            }
            binFile.Close();
            archivo.Close();
            var archivoNuevo = File.OpenText("profes binarios.bin");
            string line;
            Console.WriteLine("Se escribe el texto de el archivo binario");
            while ((line = archivoNuevo.ReadLine()) != null)
            {
                Console.WriteLine(line);  
            }
            archivoNuevo.Close();

            var archivoNuevoUno = File.OpenText("New Model.bpm");    
            Console.WriteLine("Se escribe el texto de el archivo bpm");
            while ((line = archivoNuevoUno.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }         
            archivoNuevo.Close();

            Console.ReadLine();
            var db = new IntitucionBD();         
            db.Profesores.AddRange(ListaProfesor);
            db.Alumnos.AddRange(ListaAlumno);
            db.SaveChanges();
        }

        private static void Transmitter_InformacionEnviada(object sender, EventArgs e)
        {
            Console.WriteLine("Transmisiòn informaciòn");
        }

        private static string ReverseFormatter(string input)
        {
            return new string(input.Reverse().ToArray<char>());
        }

        private static string formatter(string input)
        {
            byte[] stringBytes = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(stringBytes);   
        }



        


}
}
