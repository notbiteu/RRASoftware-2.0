using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotaryAxisAnalyzer
{
    public partial class DataStorage : Form
    {
        public DataStorage()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            //button image insert
            importDBbtn.ImageIndex = 1;
            deleteBtn.ImageIndex = 2;
            refreshBtn.ImageIndex = 3;
            exportBtn.ImageIndex = 0;
        }

        private void deleteBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataStorage_Load(object sender, EventArgs e)
        {
            var client = new MongoClient(Globals.connectionString);
            var database = client.GetDatabase(Globals.databaseName);
            var measurecoll = database.GetCollection<BsonDocument>("measurementDetails");

            var filter = new BsonDocument();
            var doc = measurecoll.Find(filter).ToList();

            dataStorageTable.DataSource = DtGridView(doc);
        }

        private DataTable DtGridView(List<BsonDocument> doc)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("Test title");
            dataTable.Columns.Add("Machine Name");
            dataTable.Columns.Add("Machine Serial Number");
            dataTable.Columns.Add("Axis");
            dataTable.Columns.Add("Operator Name");

            foreach (var document in doc)
            {
                var row = dataTable.NewRow();
                row["Test title"] = document.GetValue("testTitle").AsString;
                row["Operator Name"] = document.GetValue("operatorName").AsString;
                row["Machine Name"] = document.GetValue("machineName").AsString;
                row["Axis"] = document.GetValue("Axis").AsString;
                row["Machine Serial Number"] = document.GetValue("serialNumberMachine").AsString;
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
    }
}
