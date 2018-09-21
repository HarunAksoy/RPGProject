using System;

namespace Shakes_and_Fidget
{
    public class CharacterMethods : ICharacterMethods
    {
        public void ContinueCharacter()
        {
            Console.Clear();
            Character.PrintMenuRace();
            Character.StartRace();
        }

        public void ContinueHome()
        {
            Console.Clear();
            Home.PrintMenuHome();
            Home.StartHome();
        }
    }
}