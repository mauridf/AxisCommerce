using System.Text.Json;
using System.Text.Json.Serialization;

namespace AxisCommerce.API.Atributes;

public class DateOnlyJsonConverter : JsonConverter<DateOnly?>
{
    private const string Format = "yyyy-MM-dd";

    public override DateOnly? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var dateString = reader.GetString();

        if (string.IsNullOrWhiteSpace(dateString))
        {
            return null; // Retorna nulo para strings vazias
        }

        return DateOnly.ParseExact(dateString, Format);
    }

    public override void Write(Utf8JsonWriter writer, DateOnly? value, JsonSerializerOptions options)
    {
        if (value.HasValue)
        {
            writer.WriteStringValue(value.Value.ToString(Format));
        }
        else
        {
            writer.WriteNullValue();
        }
    }
}

