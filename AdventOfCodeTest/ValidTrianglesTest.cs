using Xunit;
using AdventOfCode;

namespace AdventOfCodeTest
{
    public class ValidTrianglesTest
    {
        [Fact]
        public void ShortestSideFirst()
        {
            Assert.True(ValidTriangles.Valid(4, 5, 6));
            Assert.False(ValidTriangles.Valid(8, 2, 5));
            Assert.False(ValidTriangles.Valid(5, 10, 25));
        }
    }
}