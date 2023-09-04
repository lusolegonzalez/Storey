using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Storey;
class Program
{
    static void Main(string[] args)
    {
        var categorias = new List<Categoria>();

        var itemsA = new Dictionary<string, int>
                {
                    { "Lámpara Led de 5w", 5 },
                    { "Lámpara Led de 10w", 10 },
                    { "Lámpara Led de 40w", 40 },
                    { "Lámpara Led de 100w", 100 },
                    { "Lámpara Led de 200w", 200 }
                };

        var categoriaA = new Categoria
        {
            Tipo = CategoriaTipo.Iluminacion,
            Items = itemsA
        };

        categorias.Add(categoriaA);

        var itemsB = new Dictionary<string, int>
                {
                    { "Heladera", 1000 },
                    { "Freezer", 1500 }
                };

        var categoriaB = new Categoria
        {
            Tipo = CategoriaTipo.Refrigeracion,
            Items = itemsB
        };

        categorias.Add(categoriaB);
        Console.WriteLine();

        String sPrettyStr;
        var item = JsonConvert.SerializeObject(categorias);
        sPrettyStr = JValue.Parse(item).ToString(Newtonsoft.Json.Formatting.Indented);
        Console.WriteLine(sPrettyStr);

    }
}