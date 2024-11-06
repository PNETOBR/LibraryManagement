namespace Gerenciador_de_Biblioteca.Models
{
    public class CreateBookInputModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public  DateTime YearPublication { get; set; }
    }
}
