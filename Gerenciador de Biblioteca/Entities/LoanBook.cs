namespace Gerenciador_de_Biblioteca.Entities
{
    public class LoanBook : BaseEntity
    {
        public LoanBook(int userId, int bookId, DateTime? loanStart, DateTime? loanDevolution)
            :base()
        {
            UserId = userId;
            BookId = bookId;
            LoanStart = loanStart;
            LoanDevolution = loanDevolution;
        }

        public Book Title { get; private set; }
        public User Name { get; private set; }
        public int UserId { get; private set; }
        public int BookId { get; private set; }
        public DateTime? LoanStart { get; private set; }
        public DateTime? LoanDevolution { get; private set; }
    }
}
