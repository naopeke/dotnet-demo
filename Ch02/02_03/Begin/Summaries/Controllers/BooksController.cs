namespace Summaries.Controllers {
    public class BooksController:Controllers{

        [Route("api/[controller]")]

        public class BooksController:Controller {
            private IBookService _service;

            // public ClassName(Paramaters)
            public BooksController(IBookService service){
                _service = service;
            }

            // create/add a new book
            [HttpPost("AddBook")]
            public IActionResult AddBook([FromBody]Book book){
                _service.AddBook(book);
                return Ok("Added");
            }
        }
    }
}