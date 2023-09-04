using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Storey
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CategoriaTipo
    {
        Refrigeracion,
        Iluminacion
    }
}
