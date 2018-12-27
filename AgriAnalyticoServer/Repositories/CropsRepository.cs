using System;
using System.Collections.Generic;
using System.Linq;
using AgriAnalyticoServer.Contracts;
using AgriAnalyticoServer.Models;

namespace AgriAnalyticoServer.Repositories
{
    public class CropsRepository : RepositoryBase<Crop>, ICropsRepository
    {
        public CropsRepository(DataContext context)
            : base(context) { }

        public IEnumerable<Crop> GetCrops()
        {
            return base.GetAll().OrderBy(crop => crop.Name);
        }

        public void AddNewCrop(Crop crop)
        {
            crop.CropId = Guid.NewGuid();
            base.Add(crop);
            base.Save();
        }

        public Crop GetCropById(Guid cropId)
        {
            return base.GetByCondition(crop => crop.CropId.Equals(cropId))
                .FirstOrDefault();
        }

        public Crop GetCropByName(string name)
        {
            return base.GetByCondition(crop => crop.Name.Equals(name))
                .FirstOrDefault();
        }
    }
}