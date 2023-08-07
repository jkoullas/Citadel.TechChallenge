namespace Citadel.API.Mappers
{
    public interface IMapper<From, To>
    {
        To Map(From data);
    }
}
