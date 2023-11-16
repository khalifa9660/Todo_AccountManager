using Microsoft.AspNetCore.Mvc;


namespace Todo_AccountManager.Models
{
    public class todoModels
    {
      public int Id { get; set; }
      public List<Item> TodoList { get; set; }
        public string Label { get; set; }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public int Todo { get; set; }
        public string Statut { get; set; }
    }
}
