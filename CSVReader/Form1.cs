using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CSVReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            
        }

        private void dataGridViev_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button_read_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = LoadCsv(textBox1.Text);










            //var lines = File.ReadAllLines("cars.csv");
            //var list = new List<Elements>();
            //foreach (var line in lines)
            //{
            //    var values = line.Split(',');
            //    if(values.Length == 2)
            //    {
            //        var elements  = new Elements() { mpg = values[1]};
            //    }
            //}







            //    using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            //    {
            //        if (ofd.ShowDialog() == DialogResult.OK)
            //        {
            //            var sraka = new StreamReader(new FileStream(ofd.FileName, FileMode.Open));
            //            var csv = new CsvReader(sraka);
            //            elementsBindingSource.DataSource = csv.GetRecord<Elements>().ToString;


            //        }
            //    }






            //    var filename = @"e:\projects\c#\linqtech\cars.csv";
            //    var configuration = new csvconfiguration(cultureinfo.invariantculture)
            //    {
            //        encoding = encoding.utf8, // our file uses utf-8 encoding.
            //        delimiter = "," // the delimiter is a comma.
            //    };

            //    using (var fs = file.open(filename, filemode.open, fileaccess.read, fileshare.read))
            //    {
            //        using (var textreader = new streamreader(fs, encoding.utf8))
            //        using (var csv = new csvreader(textreader, configuration))
            //        {
            //            var data = csv.getrecords<elements>();
            //            datagridviev.datasource = data;
            //        }
            //    }
        }

        public List<Elements> LoadCsv (string csvFile)
        {
            var query = from l in File.ReadAllLines(csvFile)
                        let data = l.Split(',')
                        select new Elements
                        {
                            mark = data[0],
                            mpg = data[1],
                            cyl = data[2],
                            disp = data[3],
                            hp = data[4],
                            drat = data[5],
                            wt = data[6],
                            qsec    = data[7],
                            vs = data[8],   
                            am = data[9],
                            gear = data[10],
                            carb = data[11],
                        };
            return query.ToList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //elementsBindingSource.DataSource = new List<Elements>();
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            textBox1.Text = dlg.FileName;
        }
    }
}
