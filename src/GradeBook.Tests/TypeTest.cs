namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void Test2()
        {
            InMemoryBook book = new InMemoryBook("book");
            book.AddGrade(99);

            Assert.Equal(99, book.grades[0]);
        }

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
            InMemoryBook book1 = GetBook("Book 1");
            GetBookSetName(out book1, "New Name");

            Assert.Equal("New Name", book1.Name);

        }
        private void GetBookSetName(out InMemoryBook book, String name)
        {
            book = new InMemoryBook(name);
        }


        [Fact]
        public void CSharpIsPasByValue()
        {
            InMemoryBook book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);

        }
        private void GetBookSetName(InMemoryBook book, String name)
        {
            book = new InMemoryBook(name);
        }


        [Fact]
        public void CanSetNameFromReference()
        {
            InMemoryBook book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);

        }
        private void SetName(InMemoryBook book, String name)
        {
            book.Name = name;
        }
        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Scott";
            string upper = MakeUpperCase(name);

            Assert.Equal("Scott", name);
            Assert.Equal("SCOTT", upper);
        }

        private string MakeUpperCase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void GetBookREturnsDifferentObjects()
        { 
            InMemoryBook book1 = GetBook("Book 1");
            InMemoryBook book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);

        }
        [Fact]
        public void TwoVarsCanREferenceSameObject()
        {
            //arrange
            InMemoryBook book1 = GetBook("Book 1");
            InMemoryBook book2 = book1;


            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));


        }

            InMemoryBook GetBook(string name)
            {
                return new InMemoryBook(name);
            }
        }
    
}