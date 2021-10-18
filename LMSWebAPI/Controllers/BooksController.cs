using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMSWebAPI.Models;
using LMSWebAPI.DataAccess;

namespace LMSWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        [Route("BOOK")]
        public List<BOOK> LoadBooks()
        {
            List<BOOK> books = BooksManage.GetAllBooks();
            return books;
        }
    }
}
