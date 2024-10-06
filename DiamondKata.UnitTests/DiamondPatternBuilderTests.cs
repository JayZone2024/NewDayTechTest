using FluentAssertions;

namespace DiamondKata.UnitTests
{
    public class DiamondPatternBuilderTests
    {
        [Theory]
        [InlineData('A', "A\r\n")]
        [InlineData('B', " A \r\nB B\r\n A \r\n")]
        [InlineData('C', "  A  \r\n B B \r\nC   C\r\n B B \r\n  A  \r\n")]
        public void When_Char_Value_Is_Provided_Then_Result_Should_Match_Expected_Value_With_Empty_Space_Character(char charValue, string expectedValue)
        {
            // Arrange
            IPatternBuilder builder = new DiamondPatternBuilder();

            // Act
            var result = builder.Build(charValue);

            // Assert
            result.Should().Be(expectedValue);
        }

        [Theory]
        [InlineData('A', "A\r\n")]
        [InlineData('B', "_A_\r\nB_B\r\n_A_\r\n")]
        [InlineData('C', "__A__\r\n_B_B_\r\nC___C\r\n_B_B_\r\n__A__\r\n")]
        public void When_Char_Value_Is_Provided_Then_Result_Should_Match_Expected_Value_With_Underscore_Space_Character(char charValue, string expectedValue)
        {
            // Arrange
            IPatternBuilder builder = new DiamondPatternBuilder();

            // Act
            var result = builder.Build(charValue, "_");

            // Assert
            result.Should().Be(expectedValue);
        }
    }
}
