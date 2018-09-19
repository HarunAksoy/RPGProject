using System;

namespace Shakes_and_Fidget
{
    public class CharacterMethods : ICharacterMethods
    {
        public void ContinueCharacter()
        {
            Console.Clear();
            Character.printMenuRace();
            Character.startRace();
        }

        public void continueHome()
        {
            Console.Clear();
            Home.printMenuHome();
            Home.startHome();
        }
    }
}