using Engine.Controllers.Session;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UI
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly Session _session;

		public MainWindow()
		{
			InitializeComponent();

			_session = new();
			DataContext = _session;
		}

		// Movement controls
		private void OnClick_MoveNorth(object sender, RoutedEventArgs e) { _session.MoveNorth(); }
		private void OnClick_MoveEast(object sender, RoutedEventArgs e) { _session.MoveEast(); }
		private void OnClick_MoveSouth(object sender, RoutedEventArgs e) { _session.MoveSouth(); }
		private void OnClick_MoveWest(object sender, RoutedEventArgs e) { _session.MoveWest(); }
	}
}