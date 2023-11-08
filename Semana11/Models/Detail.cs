namespace Semana11.Models
{
    public class Detail
    {
        public int DetailID { get; set; }
        public int InvoicesID { get; set; }

        public virtual Invoice Invoice { get; set; }

        public int ProductID { get; set; }

        public virtual Product Product { get; set; }

        public int Amount { get; set; }

        public float Price { get; set; }

        public float Subtotal { get; set; }
    }
}
