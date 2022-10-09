using AMS.Profile;
using AMS.Profile._2;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DemoApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			config = new Ini(Application.StartupPath + "\\config.ini");

			Dictionary<string, Dictionary<string, string>> configInfo = IniReader.ReadConfig(config.Name);
			MessageBox.Show(string.Join(", ", configInfo["Example-Settings-2"].Values.ToArray()));
		}

		private Ini config = null;
	}
}
