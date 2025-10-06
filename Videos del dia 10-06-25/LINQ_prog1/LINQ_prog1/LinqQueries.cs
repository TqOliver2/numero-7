using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace LINQ_prog1
{
    internal class LinqQueries
    {
        private List<Libro> librosCollection = new List<Libro>();
        public LinqQueries()
        {
            using (StreamReader reader = new StreamReader("books.json"))
            {
                string json = reader.ReadToEnd();
                this.librosCollection = System.Text.Json.JsonSerializer.Deserialize<List<Libro>>(json, new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }
        }

        public IEnumerable<Libro> TodaLaCollection()
        {
            return librosCollection;
        }


        public IEnumerable<Libro> booskBeforeOf2000()
        {
            return librosCollection.Where(p => p.PublishedDate.Year > 2000);
        }


        public IEnumerable<Libro> booksBeforeOf200QryExp()
        {
            return from l in librosCollection where l.PublishedDate.Year > 2000 select l;
        }

        public IEnumerable<Libro> books250pagANDtileAction()
        {
            return from l in librosCollection where l.PageCount > 250 && l.Title.Contains("in Action") select l;
        }

        public bool UseOfOperatorALL()
        {
            return librosCollection.All(p => p.Status != string.Empty);
        }

        public bool UseOfOperatorANY()
        {
            return librosCollection.Any(p => p.PublishedDate.Year == 2005);
        }

        public IEnumerable<Libro> booksCatPython()
        {
            return librosCollection.Where(p => p.Categories.Contains("Python"));
        }

        public IEnumerable<Libro> booksCatJavaOrderByName()
        {
            return librosCollection.Where(p => p.Categories.Contains("Java")).OrderBy(p => p.Title);
        }

        public IEnumerable<Libro> booksMore450PagOrderByDes()
        {
            return librosCollection.Where(p => p.PageCount > 450).OrderByDescending(p => p.PageCount);
        }

        public IEnumerable<Libro> threeBooksJavaOrderByDate()
        {
            return librosCollection
                .Where(p => p.Categories.Contains("Java"))
                .OrderBy(p => p.PublishedDate)
                .TakeLast(3);
        }


        public IEnumerable<Libro> thirdAndFourthBooksMore400pages()
        {
            return librosCollection
                .Where(p => p.PageCount > 400)
                .Take(4)
                .Skip(2);
        }


        public IEnumerable<Libro> ThreeBooksInCollection()
        {
            return librosCollection
                .Take(3)
                .Select(p => new Libro() { Title = p.Title, PageCount = p.PageCount });//Se crea una nueva coleccion solo con dos datos
        }
    }
}
