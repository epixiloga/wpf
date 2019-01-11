using DecouvertesDataContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DecouvertesDataContext
{
	/// <summary>
	/// Logique d'interaction pour MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			this.Initialize();
		}

		private void Initialize()
		{
			List<Girafe> theGirafes = new List<Girafe>()
			{
				new Girafe(){Id=1,Nom="gir1"},
				new Girafe(){Id=2,Nom="gir2"},
				new Girafe(){Id=3,Nom="gir3"},
			};
			this.DataContext = new Models.Zoo()
			{
				Ouistiti = new Ouistiti() { Id = 1, Nom = "Ouit1", Taille = 50 },
				Elephant = new Elephant() { Id = 1, Nom = "Eleph1", Taille = 60 },
				Girafes = theGirafes
			};
		}
	}
}
