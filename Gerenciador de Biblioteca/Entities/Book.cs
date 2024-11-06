namespace Gerenciador_de_Biblioteca.Entities
{
    public class Book : BaseEntity
    {
        public Book(string title, string description, string author, DateTime yearPublication, decimal totalCost)
            :base()
        {
            Title = title;
            Description = description;
            Author = author;
            YearPublication = yearPublication;
            TotalCost = totalCost;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Author { get; private set; }
        public DateTime YearPublication { get; private set; }
        public decimal TotalCost { get; private set; }


    }
}
