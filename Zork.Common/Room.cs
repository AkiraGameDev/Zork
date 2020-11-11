using System;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json.Linq;
using System.Runtime.CompilerServices;

namespace Zork
{
    public class Room : INotifyPropertyChanged, IEquatable<Room>
    {

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty(Order = 1)]
        public string Name {
            get => _name;
            set {
                _name = value;
                OnPropertyChanged();
            }
        }

        [JsonProperty(Order = 2)]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "Neighbors", Order = 3)]
        public Dictionary<Directions, string> NeighborNames {
            get => _neighborNames;
            set {
                _neighborNames = value;
                OnPropertyChanged();
            }
        }

        [JsonIgnore]
        public Dictionary<Directions, Room> Neighbors {
            get => neighbors; 
            private set {
                neighbors = value;
                OnPropertyChanged();
            }
        }

        public Room() {
            Neighbors = new Dictionary<Directions, Room>();
            NeighborNames = new Dictionary<Directions, string>();
        }
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public static bool operator ==(Room lhs, Room rhs) {
            if (ReferenceEquals(lhs, rhs)) {
                return true;
            }

            if (lhs is null || rhs is null) {
                return false;
            }

            return string.Compare(lhs.Name, rhs.Name, ignoreCase: true) == 0;
        }


        public static bool operator !=(Room lhs, Room rhs) => !(lhs == rhs);

        public override bool Equals(object obj) => obj is Room room ? this == room : false;

        public bool Equals(Room other) => this == other;

        public override string ToString() => Name;

        public override int GetHashCode() => Name.GetHashCode();

        public void UpdateNeighbors(World world) => Neighbors = (from entry in NeighborNames
                                                                 let room = world.RoomsByName.GetValueOrDefault(entry.Value)
                                                                 where room != null
                                                                 select (Direction: entry.Key, Room: room))
                                                                       .ToDictionary(pair => pair.Direction, pair => pair.Room);
        private string _name;
        private Dictionary<Directions, string> _neighborNames;
        private Dictionary<Directions, Room> neighbors;
    }
}
