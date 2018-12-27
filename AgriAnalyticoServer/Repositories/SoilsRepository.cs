using AgriAnalyticoServer.Contracts;
using AgriAnalyticoServer.Models;

namespace AgriAnalyticoServer.Repositories
{
    public class SoilsRepository : RepositoryBase<Soil>, ISoilRepository
    {
        public SoilsRepository(DataContext context)
            : base(context) { }
    }
}