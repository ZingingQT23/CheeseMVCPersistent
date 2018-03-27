namespace CheeseMVC.Models
{
    public class CheeseMenu
    {
        public Menu Menu { get; set; }
        public int MenuID { get; set; }

        public Cheese Cheese { get; set; }
        public int CheeseID { get; set; }
    }
}
