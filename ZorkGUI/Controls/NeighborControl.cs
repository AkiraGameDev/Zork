using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zork;

namespace ZorkGUI.Controls
{
    public partial class NeighborControl : UserControl
    {
        public Room room {
            get => _room;
            set {
                if(_room != value) {
                    _room = value;

                    if(_room != null) {
                        List<Room> rooms = new List<Room>();
                    } else {
                        
                    }
                }

                neighborTextBox.Text = _direction.ToString();
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

        private Directions _direction;
        private Room _room;

        public static readonly Room noRoom = new Room() { Name = "None" };

        public NeighborControl() {
            InitializeComponent();
        }
    }
}
