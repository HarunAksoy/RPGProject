namespace Shakes_and_Fidget
{
    public class Level
    {
        private static int level = 1;

        public static int Level1
        {
            get => level;
            set => level = value;
        }

        public static void FirstLevel()
        {
            Quest.FirstQuest();
        }

        public static void SecondLevel()
        {
            Quest.SecondQuest();
        }

        public static void ThirdLevel()
        {
            Quest.ThirdQuest();
        }

        public static void FourthLevel()
        {
            Quest.FourthQuest();
        }

        //Unlocking the levels
        public static void CheckLevel()
        {
            if (level == 1)
            {
                FirstLevel();
            }

            if (level == 2)
            {
                SecondLevel();
            }

            if (level == 3)
            {
                ThirdLevel();
            }

            if (level == 4)
            {
                FourthLevel();
            }
        }
    }
}