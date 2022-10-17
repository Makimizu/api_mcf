using api_mcf.Entities;
using api_mcf.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace api_mcf.Controllers
{
    public class BPKBController : Controller
    {
        private readonly BPKBRepository bpkbRepo;

        public BPKBController(BPKBRepository _bpkbRepo)
        {
            this.bpkbRepo = _bpkbRepo;
        }

        [Route("api/bpkb/getbycode")]
        [HttpPost]
        public ActionResult<List<TrBpkb>> GetList(string agreementNumber)
        {
            var result = bpkbRepo.GetListById(agreementNumber);
            return Ok(result);
        }

        [Route("api/bpkb/getall")]
        [HttpGet]
        public ActionResult<List<TrBpkb>> GetList()
        {
            var result = bpkbRepo.GetList();
            return Ok(result);
        }

        [Route("api/bpkb/create")]
        [HttpPost]
        public ActionResult<List<TrBpkb>> Create(TrBpkb view)
        {
            bpkbRepo.Create(view);
            return Ok();
        }

        [Route("api/bpkb/update")]
        [HttpPost]
        public ActionResult<List<TrBpkb>> Update(TrBpkb view)
        {
            bpkbRepo.Update(view);
            return Ok();
        }

        [Route("api/bpkb/delete")]
        [HttpPost]
        public ActionResult<List<TrBpkb>> Delete(string agreementNumber)
        {
            bpkbRepo.Delete(agreementNumber);
            return Ok();
        }
    }
}
