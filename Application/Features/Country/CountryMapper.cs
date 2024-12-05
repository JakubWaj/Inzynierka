namespace Application.Features.Country;

public static class CountryMapper
{
    public static CountryDto ToDto(this Domain.Entities.Country entity)
    {
        return new CountryDto
        {
            Id = entity.Id,
            Name = entity.Name,
            Productions = entity.Productions
        };
    }
    
    public static IEnumerable<CountryDto> ToDto(this IEnumerable<Domain.Entities.Country> entities)
    {
        return entities.Select(entity => entity.ToDto());
    }
    
}