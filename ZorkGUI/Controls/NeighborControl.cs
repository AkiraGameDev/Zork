using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Zork;
using ZorkGUI.ViewModels;
using System.Runtime.CompilerServices;

namespace ZorkGUI.Controls
{
    public partial class NeighborControl : UserControl
    {

        public static readonly Room NoNeighbor = new Room { Name = "<None>" };

        public void RefreshNeighbors(IEnumerable<Room> rooms) {
            List<Room> neighbors = rooms != null ? new List<Room>(rooms) : new List<Room>();
            neighbors.Insert(0, NoNeighbor);

            if (Room != null)
            {
                foreach (Room room in neighbors)
                {
                    if (Room.Name == room.Name)
                    {
                        neighbors.Remove(room);
                        break;
                    }
                } 
            }

            neighborComboBox.DataSource = neighbors;

            if (_room != null)
            {
                if (_room.Neighbors.TryGetValue(Direction, out Room neighbor))
                {
                    neighborComboBox.SelectedItem = neighbor;
                }
                else
                {
                    neighborComboBox.SelectedItem = NoNeighbor;
                }
            }
        }

        //currently selected room in listBox
        public Room Room {
            get => _room;
            set {
                _room = value;
                if (_room != null) {
                    if (_room.Neighbors.TryGetValue(Direction, out Room neighbor)) 
                    {
                        neighborComboBox.SelectedItem = neighbor;
                    } 
                    else 
                    {
                        neighborComboBox.SelectedItem = NoNeighbor;
                    }
                }
            }
        }

        public Directions Direction {
            get => _direction;
            set {
                _direction = value;
                neighborTextBox.Text = _direction.ToString();
            }
        }

        //the neighbor we want for the corresponding neighbor control's direction
        public Room Neighbor {
            get => (Room)neighborComboBox.SelectedItem;
            set => neighborComboBox.SelectedItem = value;
        }


        public NeighborControl() {
            InitializeComponent();

            Direction = _direction;
            neighborComboBox.DataSource = Array.Empty<Room>();
        }

        private void neighborComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if(_room != null)
            {
                Room neighbor = Neighbor;
                if(neighbor == NoNeighbor)
                {
                    _room.NeighborNames.Remove(Direction);
                }
                else
                {
                    _room.NeighborNames[Direction] = neighbor.Name;
                }
            }
        }

        private Directions _direction;
        private Room _room;
    }
}
