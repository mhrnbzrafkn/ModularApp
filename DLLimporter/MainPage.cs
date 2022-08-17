using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace DLLimporter
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SelectButton_Click(object sender, System.EventArgs e)
        {
            string path = Path.GetDirectoryName(
                Assembly.GetExecutingAssembly().Location) +"\\Plugins";
            var dll = Directory.GetFiles(path, "*.dll").First();

            var assembly = Assembly.LoadFrom(dll);

            var type = assembly.GetType("Calculator.Calculate");

            var obj = Activator.CreateInstance(type);

            var method = type.GetMethod("Add");

            var result = method.Invoke(
                obj,
                new object[]
                {
                    4, 4
                });

            SelectsTextBox.Text += result;
        }
    }
}
