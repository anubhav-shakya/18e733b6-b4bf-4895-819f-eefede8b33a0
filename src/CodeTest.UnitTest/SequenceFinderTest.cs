namespace CodeTest.UnitTest
{
    public class SequenceFinderTest
    {
        [Fact]
        public void FindSequence_Case1()
        {
            //Act
            var res = SequenceFinder.FindSequence(AssertionConstant.Case11Input); 

            //Assert
            Assert.Equal(AssertionConstant.Case11Output, res);
        }

        [Fact]
        public void FindSequence_Case2()
        {
            //Act
            var res = SequenceFinder.FindSequence(AssertionConstant.Case2Input);

            //Assert
            Assert.Equal(AssertionConstant.Case2Output, res);
        }

        [Fact]
        public void FindSequence_Case3()
        {
            //Act
            var res = SequenceFinder.FindSequence(AssertionConstant.Case3Input);

            //Assert
            Assert.Equal(AssertionConstant.Case3Output, res);
        }

        [Fact]
        public void FindSequence_Case4()
        {
            //Act
            var res = SequenceFinder.FindSequence(AssertionConstant.Case4Input);

            //Assert
            Assert.Equal(AssertionConstant.Case4Output, res);
        }

        [Fact]
        public void FindSequence_Case5()
        {
            //Act
            var res = SequenceFinder.FindSequence(AssertionConstant.Case5Input);

            //Assert
            Assert.Equal(AssertionConstant.Case5Output, res);
        }

        [Fact]
        public void FindSequence_Case6()
        {
            //Act
            var res = SequenceFinder.FindSequence(AssertionConstant.Case6Input);

            //Assert
            Assert.Equal(AssertionConstant.Case6Output, res);
        }

        [Fact]
        public void FindSequence_Case7()
        {
            //Act
            var res = SequenceFinder.FindSequence(AssertionConstant.Case7Input);

            //Assert
            Assert.Equal(AssertionConstant.Case7Output, res);
        }

        [Fact]
        public void FindSequence_Case8()
        {
            //Act
            var res = SequenceFinder.FindSequence(AssertionConstant.Case8Input);

            //Assert
            Assert.Equal(AssertionConstant.Case8Output, res);
        }

        [Fact]
        public void FindSequence_Case9()
        {
            //Act
            var res = SequenceFinder.FindSequence(AssertionConstant.Case9Input);

            //Assert
            Assert.Equal(AssertionConstant.Case9Output, res);
        }

        [Fact]
        public void FindSequence_Case10()
        {
            //Act
            var res = SequenceFinder.FindSequence(AssertionConstant.Case10Input);

            //Assert
            Assert.Equal(AssertionConstant.Case10Output, res);
        }

        [Fact]
        public void FindSequence_Case11()
        {
            //Act
            var res = SequenceFinder.FindSequence(AssertionConstant.Case11Input);

            //Assert
            Assert.Equal(AssertionConstant.Case11Output, res);
        }
    }
}