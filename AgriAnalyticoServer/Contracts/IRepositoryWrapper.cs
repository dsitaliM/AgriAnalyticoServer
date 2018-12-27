namespace AgriAnalyticoServer.Contracts
{
    public interface IRepositoryWrapper
    {
        ISoilRepository Soil { get; }
        ICropsRepository Crop { get; }
    }
}