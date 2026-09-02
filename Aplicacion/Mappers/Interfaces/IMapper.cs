// IMapper.cs
namespace Aplicacion.Mappers.Interfaces
{
    public interface IMapper<TSource, TDestination>
    {
        
        TDestination Map(TSource source);
        TSource MapReverse(TDestination destination);
        IEnumerable<TDestination> MapCollection(IEnumerable<TSource> source)
        {
            return source?.Select(Map) ?? Enumerable.Empty<TDestination>();
        }

        IEnumerable<TSource> MapReverseCollection(IEnumerable<TDestination> destination)
        {
            return destination?.Select(MapReverse) ?? Enumerable.Empty<TSource>();
        }
    }
}