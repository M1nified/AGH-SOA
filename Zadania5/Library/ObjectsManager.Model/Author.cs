namespace ObjectsManager.Model
{
    public class Author
    {
        private int id;
        private string authorName;
        private string authorSurname;

        public string AuthorSurname { get => authorSurname; set => authorSurname = value; }
        public int Id { get => id; set => id = value; }
        public string AuthorName { get => authorName; set => authorName = value; }
    }
}
