using ExcelDataReader;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public partial class Form1 : Form
    {
        private const int COLLUMN_KEYS = 0;
        private const int COLLUMN_VALUES = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_read_excel_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_file_path.Text)) 
            {
                MessageBox.Show("Missing file path");
                return;
            }

            listbox_results.Items.Clear();
            
            var excelMap = new Dictionary<string, double>();

            var readTask = new Task(() =>
            {
                // need to add this to allow for Encoding.CodePages (it won't work without it)
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                using var stream = File.Open(txt_file_path.Text, FileMode.Open, FileAccess.Read);
                using var reader = ExcelReaderFactory.CreateReader(stream);
                
                do
                {
                    while (reader.Read())
                    {
                        var key = reader.GetString(COLLUMN_KEYS);
                        var value = reader.GetDouble(COLLUMN_VALUES);

                        excelMap.Add(key, value);
                    }
                } while (reader.NextResult());
            });
            readTask.Start();

            // wait for task execution to finish
            await readTask;

            // print results in listbox
            foreach (var (key, value) in excelMap) {
                listbox_results.Items.Add($"{key}: {value}");
            }
        }
    }
}