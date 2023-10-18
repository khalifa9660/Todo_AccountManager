using Microsoft.AspNetCore.Mvc;

namespace Todo_AccountManager.Models
{
    public class todoModels : Controller
    {
      public int Id { get; set; }
      public string todoList { get; set; }
    }
}
