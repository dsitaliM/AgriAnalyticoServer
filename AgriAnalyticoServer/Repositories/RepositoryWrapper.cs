using AgriAnalyticoServer.Contracts;
using AgriAnalyticoServer.Models;

namespace AgriAnalyticoServer.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly DataContext _context;
        private ICropsRepository _crop;
        private ISoilRepository _soil;
        public ISoilRepository Soil => _soil ?? (_soil = new SoilsRepository(_context));
        public ICropsRepository Crop => _crop ?? (_crop = new CropsRepository(_context));

        public RepositoryWrapper(DataContext context)
        {
            _context = context;
        }
    }
}