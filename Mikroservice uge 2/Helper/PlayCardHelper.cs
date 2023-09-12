using Mikroservice_uge_2.Model;

namespace Mikroservice_uge_2.Helper
{
    public class PlayCardHelper
    {

        public static PlayCard GetRandomCard(PlayCard[] playCards)
        {
            int random = new System.Random().Next(0, playCards.Length);
            return playCards[random];
        }

    }
}
