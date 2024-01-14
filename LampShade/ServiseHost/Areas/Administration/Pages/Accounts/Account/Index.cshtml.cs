using AccountManagement.Application.Contracts.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ServiseHost.Areas.Administration.Pages.Accounts.Account
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public AccountSearchModel SearchModel;
        public List<AccountViewModel> Accounts;
        public SelectList Roles;

        private readonly IAccountApplication _accountAppilcation;
        

        public IndexModel(IAccountApplication accountAppilcation)
        {
            _accountAppilcation = accountAppilcation;
            
        }

        public void OnGet(AccountSearchModel searchModel)
        {
            Accounts = _accountAppilcation.Search(searchModel);
        }
        public IActionResult OnGetCreate()
        {
            var command = new CreateAccount
            {
                
            };
            return Partial("./Create", command);
        }
        public JsonResult OnPostCreate(CreateAccount command)
        {
            var result = _accountAppilcation.Create(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetEdit(long id)
        {
            var account = _accountAppilcation.GetDetails(id);
            return Partial("Edit", account);
        }
        public JsonResult OnPostEdit(EditAccount command)
        {
            var result = _accountAppilcation.Edit(command);
            return new JsonResult(result);
        }

    }
}
