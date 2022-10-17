using api_mcf.Entities;

namespace api_mcf.Repository
{
    public class BPKBRepository : IBaseRepository<TrBpkb>
    {
        private readonly dbMCFContext db;

        public BPKBRepository(dbMCFContext _db)
        {
            this.db = _db;
        }

        public void Create(TrBpkb entity)
        {
            db.TrBpkbs.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var bpkb = db.TrBpkbs.Find(id);
            if (bpkb != null)
                db.TrBpkbs.Remove(bpkb);
            db.SaveChanges();
        }
        
        public void Delete(string code)
        {
            var bpkb = db.TrBpkbs.Find(code);
            if (bpkb != null)
                db.TrBpkbs.Remove(bpkb);
            db.SaveChanges();
        }

        public TrBpkb Get(int id)
        {
            TrBpkb bpkb = new TrBpkb();
            var data = db.TrBpkbs.Find(id);
            if (data != null)
                bpkb = data;

            return bpkb;
        }

        public TrBpkb Get(string agreementNumber)
        {
            TrBpkb bpkb = new TrBpkb();
            var data = db.TrBpkbs.Find(agreementNumber);
            if (data != null)
                bpkb = data;

            return bpkb;
        }

        public List<TrBpkb> GetList()
        {
            return db.TrBpkbs.ToList();
        }

        public List<TrBpkb> GetListById(string agreementNumber)
        {
            return db.TrBpkbs.Where(a => a.AgreementNumber == agreementNumber).ToList();
        }

        public void Read(TrBpkb entity)
        {
            throw new NotImplementedException();
        }

        public void Update(string code)
        {
            var data = db.TrBpkbs.Find(code);
            if (data != null)
                db.TrBpkbs.Update(data);
            db.SaveChanges();
        }

        public void Update(TrBpkb entity)
        {
            var data = db.TrBpkbs.Find(entity.AgreementNumber);
            if (data != null)
                db.TrBpkbs.Update(entity);
            db.SaveChanges();
        }
    }
}
