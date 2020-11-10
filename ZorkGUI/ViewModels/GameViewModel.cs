using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Zork;

namespace ZorkGUI.ViewModels
{
    public class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string FileName {
            get => _fileName;
            set {
                if (_fileName != value) {
                    _fileName = value;
                    OnPropertyChanged();
                }
            }
        }

        public BindingList<Room> Rooms {
            get => _rooms; 
            set {
                if(_rooms != value) {
                    _rooms = value;
                    OnPropertyChanged();
                }
            }
        }


        public Game Game {
            get => mGame;
            set {
                if (mGame != value) {
                    mGame = value;
                    if (mGame != null) {
                        Rooms = new BindingList<Room>(mGame.World.Rooms.ToList());
                        OnPropertyChanged();
                    }
                }
            }
        }



        public GameViewModel(Game game = null) {
            Game = game;
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void SaveWorld() {
            if (string.IsNullOrEmpty(FileName)) {
                throw new InvalidProgramException("Filename expected.");
            }

            JsonSerializer serializer = new JsonSerializer {
                Formatting = Formatting.Indented
            };
            using (StreamWriter streamWriter = new StreamWriter(FileName))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter)) {
                serializer.Serialize(jsonWriter, mGame);
            }
        }

        public void RemoveRoom(Room roomToRemove) {
            Rooms.Remove(roomToRemove);
        }

        private Game mGame;
        private string _fileName;
        private BindingList<Room> _rooms;
    }
}
