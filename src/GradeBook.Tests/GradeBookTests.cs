namespace GradeBook.Tests
{
    public class GradeBookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);



            //act
            var result = book.GetStatistic();
            //assert
            Assert.Equal(85.6, result.Average,1);
            Assert.Equal(90.5, result.High,1);
            Assert.Equal(77.3, result.Low,1);
        }
    }
}