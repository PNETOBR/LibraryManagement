namespace Gerenciador_de_Biblioteca.Models
{
    public class CreateLoanInputModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime DateLoan { get; set; }
    }
}
