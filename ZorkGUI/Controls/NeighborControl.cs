using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Zork;

namespace ZorkGUI.Controls
{
    public partial class NeighborControl : UserControl
    {
        public static readonly Room NoNeighbor = new Room { Name = "<None>" };

        public void RefreshNeighbors(IEnumerable<Room> rooms) {
            List<Room> neighbors = rooms != null ? new List<Room>(rooms) : new List<Room>();
            neighbors.Insert(0, NoNeighbor);
            neighborComboBox.DataSource = neighbors;
        }

        public Room Room {
            get => _room;
            set {
                _room = value;
                if (_room != null) {
                    if (_room.Neighbors.TryGetValue(Direction, out Room neighbor)) {
                        neighborComboBox.SelectedItem = neighbor;
                    } else {
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
            //change current room's neighbor to selected new neighbor. if none set to null
        }

        private Directions _direction;
        private Room _room;
    }
}
