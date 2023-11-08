namespace Semana11.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public int CustomerID { get; set; }

        public virtual Customer Customer { get; set; }

        public DateTime Date { get; set; }

        public string InvoiceNumber { get; set; }

        public float Total { get; set; }

    }
}
