namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void Test1()
        {
            int x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            Book book1 = GetBook("Book 1");
            GetBookSetName(out book1, "New Name");

            Assert.Equal("New Name", book1.Name);

        }
        private void GetBookSetName(out Book book, String name)
        {
            book = new Book(name);
        }


        [Fact]
        public void CSharpIsPasByValue()
        {
            Book book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);

        }
        private void GetBookSetName(Book book, String name)
        {
            book = new Book(name);
        }


        [Fact]
        public void CanSetNameFromReference()
        {
            Book book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);

        }
        private void SetName(Book book, String name)
        {
            book.Name = name;
        }


        [Fact]
        public void GetBookREturnsDifferentObjects()
        { 
            Book book1 = GetBook("Book 1");
            Book book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);

        }
        [Fact]
        public void TwoVarsCanREferenceSameObject()
        {
            //arrange
            Book book1 = GetBook("Book 1");
            Book book2 = book1;


            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));


        }

            Book GetBook(string name)
            {
                return new Book(name);
            }
        }
    
}