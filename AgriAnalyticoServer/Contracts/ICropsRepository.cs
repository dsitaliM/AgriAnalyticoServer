using System;
using System.Collections.Generic;
using AgriAnalyticoServer.Models;
using AgriAnalyticoServer.Repositories;

namespace AgriAnalyticoServer.Contracts
{
    public interface ICropsRepository : IDataRepository<Crop>
    {
        IEnumerable<Crop> GetCrops();
        void AddNewCrop(Crop crop);
        Crop GetCropById(Guid cropId);
        Crop GetCropByName(string name);
    }
}