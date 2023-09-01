using GTR_WebApiTask.DB;
using GTR_WebApiTask.Model;
using GTR_WebApiTask.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GTR_WebApiTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        taskContext db;
        ProductRepo ProRepo;
        CategoryRepo CateRepo;

        public OwnerController()
        {
            ProRepo = new ProductRepo(db);
            CateRepo = new CategoryRepo(db);

        }

        

        //
        [Route("api/product/All")]
        [HttpGet]
        public List<Product> GetAll()
        {
            return ProRepo.Get();
        }


        [Route("api/product/Create")]
        [HttpGet]
        public List<Category> GetCat()
        {
            return CateRepo.Get();
        }

        
        [Route("api/product/Create")]
        [HttpPost]
        [Authorize]
        public void Add(Product model)
        {
            ProRepo.Add(model);

        }

        [Authorize]
        [Route("api/product/delete/{id}")]
        [HttpPost]
        public void Delete(int id)
        {
            ProRepo.Delete(id);
        }

        [Authorize]
        [Route("api/product/update/{id}")]
        [HttpPost]
        public void Edit(Product model)
        {
            ProRepo.Edit(model);
        }
        //



    }
}
