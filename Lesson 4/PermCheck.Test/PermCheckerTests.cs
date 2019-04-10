using System;
using Xunit;
using PermCheck;

namespace PermCheck.Test
{
    public class PermCheckerTests
    {
        private readonly PermCheck.PermChecker _sut;

        public PermCheckerTests()
        {
            _sut = new PermChecker();
        }

        [Fact]
        public void Should_return_0_if_array_is_empty()
        {
            //act
            var result = _sut.Solution(new int[] { });
            //assert
            Assert.Equal(0, result);
        }


        [Fact]
        public void Should_return_0_if_arrays_single_element_is_0()
        {
            //act
            var result = _sut.Solution(new int[] { 0 });
            //assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Should_return_1_if_array_is_perm_a_permutation_with_1_element_and_element_greather_than_0()
        {
            //act
            var result = _sut.Solution(new int[] { 1 });
            //assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Should_return_1_if_array_is_permutation_with_2_elements_and_is_permutation()
        {
            //act
            var result = _sut.Solution(new int[] { 1, 2 });
            //assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Should_return_0_if_array_is_not_permutation_with_2_elements()
        {
            //act
            var result = _sut.Solution(new int[] { 1, 3 });
            //assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Should_return_0_if_array_is_not_permutation_with_3_elements_but_2_of_then_is_the_same()
        {
            //act
            var result = _sut.Solution(new int[] { 1, 2, 2 });
            //assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Should_return_1_if_array_is_permutation_with_3_elements_unordered()
        {
            //act
            var result = _sut.Solution(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            //assert
            Assert.Equal(1, result);
        }
    }
}
