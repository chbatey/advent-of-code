using System;
using Xunit;
using AdventOfCode;

namespace AdventOfCodeTest
{
    public class BathroomCodeTest
    {
        private BathroomCode underTest;

        public BathroomCodeTest()
        {
            underTest = new BathroomCode();
        }

        [Fact]
        public void AtStart()
        {
            Assert.Equal("", underTest.Code());
        }

        [Fact]
        public void UpAtStart()
        {
            underTest.AddCode("U");
            Assert.Equal("5", underTest.Code());
        }

        [Fact]
        public void DownAtStart()
        {
            underTest.AddCode("D");
            Assert.Equal("5", underTest.Code());
        }

        [Fact]
        public void LeftAtStart()
        {
            underTest.AddCode("L");
            Assert.Equal("5", underTest.Code());
        }

        [Fact]
        public void RightAtStart()
        {
            underTest.AddCode("R");
            Assert.Equal("6", underTest.Code());
        }

        [Fact]
        public void Down()
        {
            underTest.AddCode("RD");
            Assert.Equal("A", underTest.Code());
        }

        [Fact]
        public void Up()
        {
            underTest.AddCode("RU");
            Assert.Equal("2", underTest.Code());
        }

        [Fact]
        public void Left()
        {
            underTest.AddCode("RL");
            Assert.Equal("5", underTest.Code());
        }

        [Fact]
        public void LeftIntoEmpty()
        {
            underTest.AddCode("RDL");
            Assert.Equal("A", underTest.Code());
        }

        [Fact]
        public void RightIntoEmpty()
        {
            underTest.AddCode("RURRR");
            Assert.Equal("4", underTest.Code());
        }

        [Fact]
        public void RightOffEdge()
        {
            underTest.AddCode("RRRRR");
            Assert.Equal("9", underTest.Code());
        }

        [Fact]
        public void DownOffEdge()
        {
            underTest.AddCode("RRDDD");
            Assert.Equal("D", underTest.Code());
        }

        [Fact]
        public void UpOffEdge()
        {
            underTest.AddCode("RRUUU");
            Assert.Equal("1", underTest.Code());
        }

        [Fact]
        public void ProvidedExample()
        {
            underTest.AddCode("ULL");
            underTest.AddCode("RRDDD");
            underTest.AddCode("LURDL");
            underTest.AddCode("UUUUD");
            Assert.Equal("5DB3", underTest.Code());
        }
    }
}