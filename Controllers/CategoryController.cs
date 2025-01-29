using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationTest.Model;
using System.Collections.Generic;

namespace WebApplicationTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        List<Category> listofCategories = new List<Category>
        {
            new Category{Id=1 ,Title="Samsung",DisplayOrder=1 },
            new Category{Id=2 ,Title="Xiomi", DisplayOrder=2},
            new Category{Id=3 ,Title="Nokia", DisplayOrder=3},
            new Category{Id=4 ,Title="Apple", DisplayOrder=4},
            new Category{Id=5,Title="Vivo", DisplayOrder=5},




        };
        [HttpGet]
        public IEnumerable<Category>Get()
            { return listofCategories; }
    }
}
