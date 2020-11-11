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
                if (_rooms != value) {
                    _rooms = value;
                    OnPropertyChanged();
                }
            }
        }


        public Game Game {
            get => _Game;
            set {
                if (_Game != value) {
                    if (_Game != null) {
                        _Game.PropertyChanged -= Game_PropertyChanged;
                        _Game.World.PropertyChanged -= Game_PropertyChanged;
                        foreach (Room room in _Game.World.Rooms) {
                            room.PropertyChanged -= Game_PropertyChanged;
                        }
                    }

                    _Game = value;

                    if (_Game != null) {
                        Rooms = new BindingList<Room>(_Game.World.Rooms.ToList());
                        OnPropertyChanged();
                        _Game.PropertyChanged += Game_PropertyChanged;
                        _Game.World.PropertyChanged += Game_PropertyChanged;
                        foreach (Room room in _Game.World.Rooms) {
                            room.PropertyChanged += Game_PropertyChanged;
                        }
                    } else {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        public bool IsModified { get => mIsModified; set => mIsModified = value; }
        private void Game_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            IsModified = true;
            PropertyChanged?.Invoke(this, e);
        }

        public GameViewModel(Game game = null) {
            Game = game;
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void RefreshModify() {
            mIsModified = false;
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
                serializer.Serialize(jsonWriter, _Game);
            }
        }

        public void RemoveRoom(Room roomToRemove) {
            Rooms.Remove(roomToRemove);
        }

        private Game _Game;
        private string _fileName;
        private BindingList<Room> _rooms;
        private bool mIsModified = false;
    }
}
