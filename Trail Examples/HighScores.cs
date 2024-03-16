namespace Examples.Trail_Examples
{
    public class HighScores
    {
        private static int highscore = 300;
        private static string highscorePlayer = "Denis";

        public static void CheckHighscore(int score, string playerName)
        {
            if (score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("It is now held by " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore could not be broken. It is still "
                    + highscore + " and held by " + highscorePlayer);
            }
        }
    }
}