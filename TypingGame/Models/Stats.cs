namespace TypingGame.Models
{
    public class Stats
    {
        public int Correct;
        public int Missed;
        public int Total;
        public int Accuracy;

        public void total() {
            Total = Correct + Missed;
        }

        public void CountAccuracy()
        {
            Accuracy = Correct * 100 / (Correct + Missed);
        }
    }
}
