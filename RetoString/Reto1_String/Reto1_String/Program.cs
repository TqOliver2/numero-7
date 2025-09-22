using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Variables generales
        string archivoEntrada = "cuento.txt";
        string archivoSalida = "resultado.txt";
        string textoCuento = "";
        int longitudTexto, totalPalabras;

        try
        {
            //se lee el archivo base
            textoCuento = File.ReadAllText(archivoEntrada);
            longitudTexto = textoCuento.Length;
            totalPalabras = textoCuento.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries).Length;

            Console.WriteLine("Cuento Original ");
            Console.WriteLine(textoCuento);
            Console.WriteLine("=======================\n");

            using (StreamWriter salida = new StreamWriter(archivoSalida))
            {
                // metodo para leer en consola y escribir en archivo
                void Imprimir(string titulo, string resultado)
                {
                    string bloque = $"{titulo}\nResultado: {resultado}\n";
                    Console.WriteLine(bloque);
                    salida.WriteLine(bloque);
                }

                //se comienzan las pruebas de los metodos de string
                Imprimir("1. string.Concat()", string.Concat("Bitín", " Explorador"));

                string[] partes = textoCuento.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                Imprimir("2. string.Join()", string.Join(" | ", partes));

                Imprimir("3. string.Format()", string.Format("El cuento tiene {0} caracteres y {1} palabras", longitudTexto, totalPalabras));

                string heroe = "Bitín";
                string objetivo = "las ciudades luminosas";
                Imprimir("4. Interpolación", $"El protagonista es {heroe} y busca {objetivo}");

                Imprimir("5. Convert.ToString()", "La longitud del cuento es: " + longitudTexto.ToString());

                //busqueda
                Imprimir("6. IndexOf()", $"La primera posición de 'mundo' es: {textoCuento.IndexOf("mundo")}");
                Imprimir("7. LastIndexOf()", $"La última posición de 'ceros' es: {textoCuento.LastIndexOf("ceros")}");

                //validación
                Imprimir("8. Contains()", textoCuento.Contains("Nube") ? "Sí contiene la palabra 'Nube'." : "No contiene la palabra 'Nube'.");
                Imprimir("9. StartsWith()", $"¿Empieza con 'En el vasto universo'? {textoCuento.StartsWith("En el vasto universo")}");
                Imprimir("10. EndsWith()", $"¿Termina con 'ceros y unos.'? {textoCuento.EndsWith("ceros y unos.")}");

                //manipulación
                int pos = textoCuento.IndexOf("ciudades luminosas");
                if (pos >= 0)
                    Imprimir("11. Substring()", textoCuento.Substring(pos, "ciudades luminosas".Length));
                else
                    Imprimir("11. Substring()", "No se encontró 'ciudades luminosas'.");

                Imprimir("12. Remove()", textoCuento.Remove(0, 15));
                Imprimir("13. Replace()", textoCuento.Replace("Bitín", "ProgramaX"));

                int posFirewall = textoCuento.IndexOf("firewall");
                if (posFirewall != -1)
                {
                    string nuevoTexto = textoCuento.Insert(posFirewall + "firewall".Length, " (IMPORTANTE)");
                    Imprimir("14. Insert()", nuevoTexto);
                }
                else
                {
                    Imprimir("14. Insert()", "No se encontró la palabra 'firewall'.");
                }

                Imprimir("15. PadLeft()", "Bitín".PadLeft(10, '*'));
                Imprimir("16. PadRight()", "Nube".PadRight(12, '-'));

                string prueba1 = " firewall ";
                Imprimir("17. Trim()", $"'{prueba1}' → '{prueba1.Trim()}'");

                string prueba2 = " Mundo binario";
                Imprimir("18. TrimStart()", $"'{prueba2}' → '{prueba2.TrimStart()}'");

                string prueba3 = "Bitín explorador ";
                Imprimir("19. TrimEnd()", $"'{prueba3}' → '{prueba3.TrimEnd()}'");

                // Palabras separadas
                string[] todas = textoCuento.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
                int limite = Math.Min(10, todas.Length);
                string[] primeras = new string[limite];
                Array.Copy(todas, primeras, limite);
                Imprimir("20. Split()", string.Join(", ", primeras));

                //comparaciones
                Imprimir("21. Equals()", $"¿'Nube' == 'nube'? {"Nube".Equals("nube")}");
                int res = string.Compare("Bitín", "Firewall");
                Imprimir("22. Compare()", res < 0 ? "Bitín va primero." : "Firewall va primero.");
                Imprimir("23. CompareTo()", $"'Nube'.CompareTo('Cielo') = {"Nube".CompareTo("Cielo")}");

                // Validación nulos
                string vacia = "";
                string soloEspacios = "   ";
                Imprimir("24. IsNullOrEmpty()", string.IsNullOrEmpty(vacia).ToString());
                Imprimir("25. IsNullOrWhiteSpace()", string.IsNullOrWhiteSpace(soloEspacios).ToString());

                //mayúsculas - minúsculas
                Imprimir("26. ToLower()", textoCuento.ToLower());
                Imprimir("27. ToUpper()", textoCuento.ToUpper());
                Imprimir("28. ToLowerInvariant()", "NUBE".ToLowerInvariant());
                Imprimir("29. ToUpperInvariant()", "bitín".ToUpperInvariant());
            }

            Console.WriteLine("\n Se completo el proceso. Revisa el archivo resultado.txt");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No se encontró el archivo cuento.txt");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error " + e.Message);
        }
    }
}
