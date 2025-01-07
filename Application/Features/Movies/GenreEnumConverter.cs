using System.Text.Json;
using Domain.Common.Enums;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Application.Features.Movies;

public class GenreEnumConverter : JsonConverter<Genre>
{
    public override void WriteJson(JsonWriter writer, Genre value, JsonSerializer serializer)
    {
        writer.WriteValue(value.ToString());
    }

    public override Genre ReadJson(JsonReader reader, Type objectType, Genre existingValue, bool hasExistingValue,
        JsonSerializer serializer)
    {
        var genreString = reader.Value.ToString();

        // Try to map string to enum
        if (Enum.TryParse<Genre>(genreString, true, out var result))
        {
            return result; // If successfully parsed, return the enum value
        }

        // If parsing fails, you can throw an exception or return a default value
        return Genre.Inny; // Default fallback genre
    }
}