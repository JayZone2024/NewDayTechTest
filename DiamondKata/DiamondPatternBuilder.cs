using System.Text;

namespace DiamondKata
{
    public class DiamondPatternBuilder : IPatternBuilder
    {
        private const char AlphaCharacter = 'A';

        public string Build(char charValue, string spaceCharacter = " ")
        {
            var sb = new StringBuilder();

            int totalNumberOfChars = charValue - AlphaCharacter + 1;

            BuildTopTier(totalNumberOfChars, spaceCharacter, sb);
            BuildBottomTier(totalNumberOfChars, spaceCharacter, sb);

            return sb.ToString();
        }


        private static void BuildTopTier(int totalNumberOfChars, string spaceCharacter, StringBuilder sb)
        {
            for (int currentCharIndex = 0; currentCharIndex < totalNumberOfChars; currentCharIndex++)
            {
                AddEmptySpaces(totalNumberOfChars, currentCharIndex, spaceCharacter, sb);
                AddCurrentCharacter(currentCharIndex, sb);

                if (currentCharIndex > 0)
                {
                    AddEmptySpaces(currentCharIndex, spaceCharacter, sb);
                    AddCurrentCharacter(currentCharIndex, sb);
                }

                AddEmptySpaces(totalNumberOfChars, currentCharIndex, spaceCharacter, sb);

                sb.AppendLine();
            }
        }

        private static void BuildBottomTier(int totalNumberOfChars, string spaceCharacter, StringBuilder sb)
        {
            for (int currentCharIndex = totalNumberOfChars - 2; currentCharIndex >= 0; currentCharIndex--)
            {
                AddEmptySpaces(totalNumberOfChars, currentCharIndex, spaceCharacter, sb);
                AddCurrentCharacter(currentCharIndex, sb);

                if (currentCharIndex > 0)
                {
                    AddEmptySpaces(currentCharIndex, spaceCharacter, sb);
                    AddCurrentCharacter(currentCharIndex, sb);
                }

                AddEmptySpaces(totalNumberOfChars, currentCharIndex, spaceCharacter, sb);

                sb.AppendLine();
            }
        }

        private static void AddEmptySpaces(
            int numberOfChars, 
            int currentCharIndex, 
            string spaceCharacter, 
            StringBuilder sb)
        {
            int totalNumberOfSpaceCharsToBuild = numberOfChars - currentCharIndex - 1;

            for (int spaceIndex = 0; spaceIndex < totalNumberOfSpaceCharsToBuild; spaceIndex++)
            {
                sb.Append(spaceCharacter);
            }
        }

        private static void AddEmptySpaces(int currentCharIndex, string spaceCharacter, StringBuilder sb)
        {
            int totalNumberOfSpaceCharsToBuild = 2 * currentCharIndex - 1;

            for (int spaceIndex = 0; spaceIndex < totalNumberOfSpaceCharsToBuild; spaceIndex++)
            {
                sb.Append(spaceCharacter);
            }
        }

        private static void AddCurrentCharacter(int currentCharIndex, StringBuilder sb)
        {
            var currentChar = (char) (AlphaCharacter + currentCharIndex);

            sb.Append(currentChar);
        }

    }
}