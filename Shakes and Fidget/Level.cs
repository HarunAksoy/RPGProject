using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Shakes_and_Fidget
{
    public class Level
    {
        public static int level = 1;

        public static void firstLevel()
        {
            Quest.firstQuest();
        }

        public static void secondLevel()
        {
            Quest.secondQuest();
        }

        public static void thirdLevel()
        {
            Quest.thirdQuest();
        }

        public static void fourthLevel()
        {
            Quest.fourthQuest();
        }


        public static void checkLevel()
        {
            if (level == 1)
            {
                firstLevel();
            }

            if (level == 2)
            {
                secondLevel();
            }

            if (level == 3)
            {
                thirdLevel();
            }

            if (level == 4)
            {
                fourthLevel();
            }
        }
    }
}