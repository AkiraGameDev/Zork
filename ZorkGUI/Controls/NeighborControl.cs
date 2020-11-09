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
using ZorkGUI.ViewModels;

namespace ZorkGUI.Controls
{
    public partial class NeighborControl : UserControl
    {

        public static readonly Room NoNeighbor = new Room { Name = "<None>" };

        public GameViewModel ViewModel {
            get => _viewModel; 
            set {
                _viewModel = value;
                if (_viewModel != null)
                {
                        neighborComboBox.DataSource = _viewModel.Rooms;
                }
                
            }
        }

        public Room Room { get; set; }

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
        private GameViewModel _viewModel;
        public static readonly Room noRoom = new Room() { Name = "None" };

        public NeighborControl() {
            InitializeComponent();

            Direction = _direction;
            neighborComboBox.DataSource = Array.Empty<Room>();
        }
    }
}
