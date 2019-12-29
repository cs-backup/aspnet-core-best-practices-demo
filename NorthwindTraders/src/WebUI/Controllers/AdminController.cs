using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Northwind.Application.Customers.Queries.GetCustomersList;
using Northwind.WebUI.Controllers;

public class AdminController : BaseController
{
    [HttpGet]
    [Authorize(Policy = "ApiKeyPolicy")]
    public async Task<ActionResult<CustomersListVm>> GetCustomers()
    {
        var vm = await Mediator.Send(new GetCustomersListQuery());

        return Ok(vm);
    }
}