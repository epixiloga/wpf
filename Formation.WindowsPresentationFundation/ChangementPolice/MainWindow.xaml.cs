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

namespace ChangementPolice
{
	/// <summary>
	/// Logique d'interaction pour MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			this.UpdateSizeOfTextBox();

		}

		private void TB_Size_KeyUp(object sender, KeyEventArgs e)
		{
			this.UpdateSizeOfTextBox();
		}

		private void UpdateSizeOfTextBox()
		{
			int size = 0;
			int.TryParse(this.TB_Size.Text, out size);
			//this.TB_Text.FontSize = int.Parse(this.TB_Size.Text);
			this.TB_Text.FontSize = size == 0 ? 8 : size;
		}
	}
}
