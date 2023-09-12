using Mikroservice_uge_2.Model;
using Newtonsoft.Json;

namespace Mikroservice_uge_2.Stores
{
    public class PlayCardStore : IPlayCardStore
    {
        PlayCard[]? deck = new PlayCard[52];


        public PlayCardStore()
        {

            //Read JSON file into string
            string json = File.ReadAllText("Stores/deck_of_cards.json");
            //Deserialize JSON string into object
            deck = JsonConvert.DeserializeObject<PlayCard[]>(json);
        }

        public PlayCard[] GetAll()
        {
            return deck;
        }
    }
}
