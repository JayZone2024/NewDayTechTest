namespace DiamondKata;

public interface IPatternBuilder
{
    string Build(char charValue, string spaceCharacter = " ");
}