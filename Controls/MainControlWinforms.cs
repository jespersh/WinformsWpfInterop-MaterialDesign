using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteropControls
{
    public partial class MainControlWinforms: UserControl
    {
        private MainControl _mainControl;

        public MainControlWinforms()
        {
            InitializeComponent();

            Load += MainControlWinforms_Load;
        }

        private void MainControlWinforms_Load(object sender, EventArgs e)
        {
            TestData testData = new TestData { Hello = "World!" };
            _mainControl = new MainControl { DataContext = testData };
            elementHost1.Child = _mainControl;
        }
    }
}
