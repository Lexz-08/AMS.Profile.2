using AMS.Profile;
using System.Windows.Forms;

namespace DemoApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			config = new Ini(Application.StartupPath + "\\config.ini");

			config.AddSection("Example-Settings-3");
		}

		private Ini config = null;
	}
}
