using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Zork;

namespace ZorkGUI.ViewModels
{
    public class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string FileName { get; set; }

        public BindingList<Room> Rooms { get; set; }


        public Game Game
        {
            set
            {
                if(mGame != value)
                {
                    mGame = value;
                    if(mGame!= null)
                    {
                        Rooms = new BindingList<Room>(mGame.World.Rooms.ToList());
                    }
                }
            }

            get
            {
                return mGame;
            }
        }
        private Game mGame;

        public GameViewModel(Game game = null) => Game = null;

        public void SaveWorld()
        {
            if (string.IsNullOrEmpty(FileName))
            {
                throw new InvalidProgramException("Filename expected.");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };
            using (StreamWriter streamWriter = new StreamWriter(FileName))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, mGame);
            }
        }

        public void RemoveRoom(Room roomToRemove)
        {
            Rooms.Remove(roomToRemove);
        }
    }
}
