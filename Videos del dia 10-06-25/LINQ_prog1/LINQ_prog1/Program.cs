using System;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using LINQ_prog1;

LinqQueries queries = new LinqQueries();

void printfValues(IEnumerable<Libro> listBooks)
{
    
    Console.WriteLine("{0, -60} {1, 15} {2, 15}\n ", "Titulo", "N. Paginas", "Fecha de publicacion");
    foreach (var item in listBooks)
    {
        Console.WriteLine("{0, -60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}


Console.WriteLine("------- TODOS LOS LIBROS");
printfValues(queries.TodaLaCollection());
Console.WriteLine("\n\n\n\n\n");

Console.WriteLine("------- LIBROS PUBLICADOS DESPUES DEL 2000");
printfValues(queries.booskBeforeOf2000());
Console.WriteLine("\n\n\n\n\n");

Console.WriteLine("------- USO DE QUERY EXPRESION");
printfValues(queries.booksBeforeOf200QryExp());
Console.WriteLine("\n\n\n\n\n");
Console.WriteLine("------- LIBROS CON 250 PAGINAS Y QUE CONTENGA ACTION");
printfValues(queries.books250pagANDtileAction());
Console.WriteLine("\n\n\n\n\n");
Console.WriteLine("------- USO DE ALL");
Console.WriteLine("Todos los libros tiene status?: " + queries.UseOfOperatorALL());
Console.WriteLine("\n\n\n\n\n");

Console.WriteLine("------- USO DE ANY");
Console.WriteLine("Algun libro fue publicado en el 2005?: " + queries.UseOfOperatorANY());
Console.WriteLine("\n\n\n\n\n");


Console.WriteLine("------- USO DE CONTAINS");
printfValues(queries.booksCatPython());
Console.WriteLine("\n\n\n\n\n");

Console.WriteLine("------- USO DE ORDER BY");
printfValues(queries.booksCatJavaOrderByName());
Console.WriteLine("\n\n\n\n\n");

Console.WriteLine("------- USO DE ORDER BY DECENDING");
printfValues(queries.booksMore450PagOrderByDes());
Console.WriteLine("\n\n\n\n\n");


Console.WriteLine("------- USO DE TAKE");
printfValues(queries.threeBooksJavaOrderByDate());
Console.WriteLine("\n\n\n\n\n");

Console.WriteLine("------- USO DE SKIP");
printfValues(queries.thirdAndFourthBooksMore400pages());
Console.WriteLine("\n\n\n\n\n");

Console.WriteLine("------- USO DE SELECCION DINAMICA");
printfValues(queries.ThreeBooksInCollection());
Console.WriteLine("\n\n\n\n\n");