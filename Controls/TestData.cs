using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InteropControls
{
    class TestData
    {
        public string Hello { get; set; }
        public IAsyncCommand OpenDialog { get; set; }

        public TestData()
        {
            OpenDialog = new AsyncCommand(OpenDialogAsync);
        }

        private async Task OpenDialogAsync()
        {
            TestDataDialog testDataDialog = new TestDataDialog
            {
                HelloData = $"{Hello} from {nameof(TestData)}"
            };
            TestDialog testDialog = new TestDialog
            {
                DataContext = testDataDialog
            };
            await DialogHost.Show(testDialog);

            MessageBox.Show($"Lukkede dialog: {testDataDialog.HelloData}");
        }
    }
}
