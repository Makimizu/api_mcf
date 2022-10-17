using api_mcf.Entities;
using Microsoft.Extensions.Hosting;

namespace api_mcf.Repository
{
    public class LocationRepository : IBaseRepository<MsStorageLocation>
    {
        private readonly dbMCFContext db;  

        public LocationRepository(dbMCFContext _db)
        {
            this.db = _db;
        }

        public void Create(MsStorageLocation entity)
        {
            db.MsStorageLocations.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var location = db.MsStorageLocations.Find(id);
            if (location != null)
                db.MsStorageLocations.Remove(location);
            db.SaveChanges();
        }

        public MsStorageLocation Get(int id)
        {
            MsStorageLocation location = new MsStorageLocation();
            var data = db.MsStorageLocations.Find(id);
            if (data != null)
                location = data;

            return location;
        }
        
        public MsStorageLocation Get(string code)
        {
            MsStorageLocation location = new MsStorageLocation();
            var data = db.MsStorageLocations.Find(code);
            if (data != null)
                location = data;

            return location;
        }

        public List<MsStorageLocation> GetList()
        {
            return db.MsStorageLocations.ToList();
        }

        public List<MsStorageLocation> GetListById(string code)
        {
            return db.MsStorageLocations.Where(a => a.LocationId == code).ToList();
        }

        public void Read(MsStorageLocation entity)
        {
            throw new NotImplementedException();
        }

        public void Update(string code)
        {
            var data = db.MsStorageLocations.Find(code);
            if (data != null)
                db.MsStorageLocations.Update(data);
            db.SaveChanges();
        }

        public void Update(MsStorageLocation entity)
        {
            var data = db.MsStorageLocations.Find(entity.LocationId);
            if (data != null)
                db.MsStorageLocations.Update(entity);
            db.SaveChanges();
        }
    }
}
