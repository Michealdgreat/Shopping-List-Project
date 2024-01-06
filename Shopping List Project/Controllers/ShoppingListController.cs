using Microsoft.AspNetCore.Mvc;
using ShoppingLibrary.ShoppingListModel;

namespace Shopping_List_Project.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ShoppingListController : ControllerBase
{
    // GET: api/<ShoppingListController>
    [HttpGet]
    public ActionResult<IEnumerable<ListModel>> Get() //with ActionResult or IActionResult we can return multiple status code depending on what happen in this method
    {
        throw new NotImplementedException();
    }

    // POST api/CategoryName
    [HttpPost ("CategoryName")]
    public ActionResult<ListModel> CategoryName([FromBody] string value)
    {
        throw new NotImplementedException();
    }

    // POST api/Date
    [HttpPost ("Date")]
    public ActionResult<ListModel> Date([FromBody] string value)
    {
        throw new NotImplementedException();
    }

    // POST api/Budget
    [HttpPost ("Budget")]
    public ActionResult<ListModel> Budget([FromBody] string value)
    {
        throw new NotImplementedException();

    }

    // POST api/StoreName
    [HttpPost("StoreName")]
    public ActionResult<ListModel> StroreName([FromBody] string value)
    {
        throw new NotImplementedException();

    }

    // POST api/ProductName
    [HttpPost ("ProductName")]
    public ActionResult<ListModel> ProductName([FromBody] string value)
    {
        throw new NotImplementedException();

    }

    // POST api/Price
    [HttpPost ("Price")]
    public ActionResult<ListModel> Price([FromBody] string value)
    {
        throw new NotImplementedException();

    }

    // POST api/TotalSpent
    [HttpPost ("TotalSpent")]
    public ActionResult<ListModel> TotalSpent([FromBody] string value)
    {
        throw new NotImplementedException();

    }

    // POST api/ExcessMoney
    [HttpPost ("ExcessMoney")]
    public ActionResult<ListModel> ExcessMoney([FromBody] string value)
    {
        throw new NotImplementedException();

    }

    // POST api/SavedMoney
    [HttpPost("SavedMoney")]
    public ActionResult<ListModel> SavedMoney([FromBody] string value)
    {
        throw new NotImplementedException();

    }

    // POST api/AddNote
    [HttpPost ("AddNote")]
    public ActionResult<ListModel> AddNote([FromBody] string value)
    {
        throw new NotImplementedException();

    }

    // PUT api/SaveList
    [HttpPut("SaveList")]
    public IActionResult SaveList(int id, [FromBody] string value)
    {
        throw new NotImplementedException();

    }

    // GET api/GetAllList
    [HttpGet("GetAllList")]
    public void GetAllList(int id)
    {
        throw new NotImplementedException();

    }

    // GET api/GetOneList
    [HttpGet("GetOneList")]
    public void GetOneList(int id)
    {
        throw new NotImplementedException();

    }

    // PUT api/<ShoppingListController>/5
    [HttpPut("{id}")]
    public IActionResult UpdateList(int id, [FromBody] string value)
    {
        throw new NotImplementedException();
    }

    // DELETE api/<ShoppingListController>/5
    [HttpDelete("{id}")]
    public IActionResult DeleteList(int id)
    {
        throw new NotImplementedException();
    }
}