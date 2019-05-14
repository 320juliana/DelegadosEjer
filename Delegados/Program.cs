using System;
using System.Linq;
using System.Collections.Generic;

namespace Delegados
{
    class Program
    {
        
        //ejercicios
        static void Main(string[] args)
        {
            //obtener todos los proyectos cuya relacion sea >6 y <a12 

            //Proyecto pro = new Proyecto();
            //Console.WriteLine("***************Primer ejercicio***************");
            //pro.AddProyect2();
            //var proyectolis = pro.proyectosList;
            //var guardar = proyectolis.Where(x => x.Codigo > 6 && x.Codigo < 12).ToList();
            //pro.MostrarLista(guardar);
            //Console.ReadLine();

           //obtener todos los proyectos que empiencen por b



            //Proyecto pro = new Proyecto();
            //Console.WriteLine("***************Segundo ejercicio***************");
            //pro.AddProyect2();
            //var proyectolis = pro.proyectosList;
            //var Search = from p in proyectolis
            //             where (p.Nombre.StartsWith("B"))
            //             select p;
            //pro.MostrarLista(Search.ToList());
            //Console.ReadLine();

            //obtener todos los proyectos cuyo codigo sea muLTIPLO DE 7

            //Proyecto pro = new Proyecto();
            //Console.WriteLine("***************Tercer ejercicio***************");
            //pro.AddProyect2();
            //var proyectolis = pro.proyectosList;
            //var Multi = proyectolis.Where(x => x.Codigo % 7 ==0).ToList();
            //pro.MostrarLista(Multi);
            //Console.ReadLine();

             //agrupar los proyectos que tengan una duracion superior a 6 y menor a 10

            //Proyecto pro = new Proyecto();
            //Console.WriteLine("***************Primer ejercicio***************");
            //pro.AddProyect2();
            //var proyectolis = pro.proyectosList;
            //var Superior = proyectolis.GroupBy(x =>
            //{
            //    if (x.Duracion<=6)
            //    {
            //        return "Duracion inferior a 6";

            //    }
            //    else if (x.Duracion >= 7 && x.Duracion < 11)
            //    {
            //        return "Duracion entre 7 y 10";

            //    }
            //    else
            //    {
            //        return "Salio";

            //    }


            //});

            //foreach (var Proyectosbase in Superior)
            //{

            //    Console.WriteLine("Grupo de proyectos"+Proyectosbase.Key +"  Hay  "+ Proyectosbase.Count());
            //    foreach (var item in Proyectosbase)
            //    {

            //        Console.WriteLine($"Nombre del proyecto:{item.Nombre} ");
            //        Console.WriteLine($"Codigo:{item.Codigo} ");
            //        Console.WriteLine($"Codigo:{item.Duracion} ");
            //    }

            //}

            //Console.ReadLine();


             //obtener el promedio de la duracion de todos los proyectos



            //Proyecto pro = new Proyecto();
            //Console.WriteLine("***************Quinto ejercicio***************");
            //pro.AddProyect2();
            //var proyectolis = pro.proyectosList;
            //var Promedio = proyectolis.Average(x => x.Codigo);
            //Console.WriteLine($"Su promedio es: {Promedio}");
            //Console.ReadLine();



            //obtener el nimbre del proyecto con mas duracion


            //Proyecto pro = new Proyecto();
            //Console.WriteLine("***************Sexto ejercicio***************");
            //pro.AddProyect2();
            //var proyectolis = pro.proyectosList;

            //var dato = proyectolis.Max(y => y.Duracion);
            //var mayor = proyectolis.Where(x => x.Duracion==dato).Select(x => x.Nombre).FirstOrDefault();

            //Console.WriteLine($"el nombre del proyecto con maxima duracion es :  {mayor}");
            //Console.ReadLine();



            //seleccionar el nombre y el area el proyecto con duracion mayor a 6 (firtsorDefault)



            //Proyecto pro = new Proyecto();
            //Console.WriteLine("***************Septimo ejercicio***************");
            //pro.AddProyect2();
            //var proyectolis = pro.proyectosList;
            //var NombreArea = proyectolis.Where(x => x.Duracion > 6).Select(x =>
            //   new Proyecto()
            //   {
            //       Nombre = x.Nombre,
            //       Area = x.Area

            //   }

            //).ToList();
            //pro.MostrarLista(NombreArea);

            //Console.ReadLine();

        //verificar si hay un proyecto
            //Proyecto pro = new Proyecto();
            //Console.WriteLine("***************Primer ejercicio***************");
            //pro.AddProyect2();
            //var proyectolis = pro.proyectosList;
            //var guardar = proyectolis.Any(x => x.Duracion > 24);
            //Console.WriteLine($"{guardar}");
            //Console.ReadLine();


          //sumar las duraciones de los proyectos cuyo codigo sea superior a 20
            //Proyecto pro = new Proyecto();
            //Console.WriteLine("***************Primer ejercicio***************");
            //pro.AddProyect2();
            //var proyectolis = pro.proyectosList;
            //var sum = proyectolis.Where(x => x.Codigo > 20).Sum(x => x.Duracion);
            //Console.WriteLine($"{sum}");
            //Console.ReadLine();

          

            



        }


    }
}
