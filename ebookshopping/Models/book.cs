using System.ComponentModel;

namespace ebookshopping.Models
{
    public class book
    {
        public int Id { get; set; }
        [DisplayName("Title")]
        public string title { get; set; }
        [DisplayName("Info")]
        public string info { get; set; }
        [DisplayName("Quantity")]
        public int bookquantity { get; set; }
        [DisplayName("Price")]
        public int price { get; set; }
        [DisplayName("Catid")]
        public int cataid { get; set; }
        [DisplayName("Author")]
        public string author { get; set; }
        [DisplayName("Imgfile")]
        public string imgfile { get; set; }


    }
}
