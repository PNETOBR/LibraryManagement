namespace Gerenciador_de_Biblioteca.Entities
{
    public class BaseEntity
    {
        protected BaseEntity()
        {
            CreatedAt = DateTime.Now;
            IsDeleted = false;
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; private set; }
        public bool IsDeleted { get; private set; }


        public void SetAsDeleted() // SetAsDeleted é um metodo utilizado para marcar a entidade como deletada, mas sem realmente remover do banco
        {
            IsDeleted = true;
        }

    }
}
