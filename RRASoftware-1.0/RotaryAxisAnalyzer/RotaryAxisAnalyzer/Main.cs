using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

using OxyPlot.WindowsForms;


namespace RotaryAxisAnalyzer
{
    
    public partial class Main_Form : Form
    {
        private PlotControl plotControl;
        private Plot plotForm;

        Timer delayTimer;
        private PlotView plotView;

        public Main_Form()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;

            //button image insert
            plotBtn.ImageIndex = 1;
            importDataBtn.ImageIndex = 2;
            dataStorageBtn.ImageIndex = 3;
            settingsBtn.ImageIndex = 4;

            //button decorate
            plotBtn.Paint += (sender, e) => BtnDecoration.ButtonDecoration(plotBtn, e);
            importDataBtn.Paint += (sender, e) => BtnDecoration.ButtonDecoration(importDataBtn, e);
            dataStorageBtn.Paint += (sender, e) => BtnDecoration.ButtonDecoration(dataStorageBtn, e);
            settingsBtn.Paint += (sender, e) => BtnDecoration.ButtonDecoration(settingsBtn, e);


        }


        //Make multiple Panel for Plot and Datastorage to appear on Main Screen
        public void loadform(Form formToLoad)
        {
            mainPanel.Controls.Clear();

            formToLoad.TopLevel = false;
            formToLoad.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(formToLoad);

            formToLoad.Show();
        }

        private void ShowSettingsForm()
        {
            Settings ST = new Settings();
            ST.StartPosition = FormStartPosition.CenterScreen;
            ST.Show();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            ShowSettingsForm();
            createSaveFolder();

        }

        //Create Folder
        private void createSaveFolder()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string configFolderName = "RRAConfig";
            string saveDataFolderName = "SaveDataRRA";
            string saveSettingFolderName = "SaveSettingRRA";

            string configFolderPath = Path.Combine(documentsPath, configFolderName);
            string saveDataFolderPath = Path.Combine(configFolderPath, saveDataFolderName);
            string saveSettingFolderPath = Path.Combine(configFolderPath, saveSettingFolderName);

            if (!Directory.Exists(configFolderPath))
            {
                Directory.CreateDirectory(configFolderPath);
            }

            if (!Directory.Exists(saveDataFolderPath))
            {
                Directory.CreateDirectory(saveDataFolderPath);
            }

            if (!Directory.Exists(saveSettingFolderPath))
            {
                Directory.CreateDirectory(saveSettingFolderPath);
            }

        }

        //Create CSV Files [undone]



        //Date Time
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.DateLabel.Text = dateTime.ToString();
        }

        private double[][] ReadXYZDataFromCSV(string filePath)
        {
            try
            {
                List<double> xData = new List<double>();
                List<double> yData = new List<double>();
                List<double> zData = new List<double>();

                bool isFirstLine = true;

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);

                        if (isFirstLine)
                        {
                            isFirstLine = false;
                            continue;
                        }

                        string[] values = line.Split(',');
                        Console.WriteLine($"Number of values in this line: {values.Length}");
                        if (values.Length >= 3)
                        {

                            string xValueString = values[0].Trim().Replace(" ", "");
                            if (double.TryParse(values[0].Trim(), out double xValue))
                            {
                                xData.Add(xValue);
                                Console.WriteLine("xValue: " + xValue);
                            }
                            else
                            {
                                Console.WriteLine("Failed to parse xValue.");
                            }

                            if (double.TryParse(values[1].Trim(), out double yValue))
                                yData.Add(yValue);

                            if (double.TryParse(values[2].Trim(), out double zValue))
                                zData.Add(zValue);

                        }
                    }
                }

                return new double[][] { xData.ToArray(), yData.ToArray(), zData.ToArray() };

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error reading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Btn Event
        private void plotBtn_Click_1(object sender, EventArgs e)
        {
            if (plotControl == null)
            {
                mainPanel.Controls.Clear();
                plotControl = new PlotControl();
            }

            mainPanel.Controls.Clear();
            plotControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(plotControl);
        }


        private void dataStorageBtn_Click(object sender, EventArgs e)
        {
            DataStorage dataStorageForm = new DataStorage();
            loadform(dataStorageForm);
        }

        private void importDataBtn_Click(object sender, EventArgs e)
        {
            //define path to open as default
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string configFolderName = "RRAConfig";
            string saveDataFolderName = "SaveDataRRA";

            string configFolderPath = Path.Combine(documentsPath, configFolderName);
            string saveDataFolderPath = Path.Combine(configFolderPath, saveDataFolderName);

            importDataDialog.FileName = "";
            importDataDialog.Filter = "CSV Files|*.csv";
            importDataDialog.InitialDirectory = saveDataFolderPath;
            importDataDialog.ShowDialog();

            if (!string.IsNullOrEmpty(importDataDialog.FileName))
            {
                string filePath = importDataDialog.FileName;

                double[][] importedData = ReadXYZDataFromCSV(filePath);

                if (importedData != null && importedData.Length == 3)
                {
                    double[] importedXData = importedData[0];
                    double[] importedYData = importedData[1];
                    double[] importedZData = importedData[2];

                    Console.WriteLine("Data loaded successfully!");

                    Console.WriteLine("importedXData values:");
                    foreach (var value in importedXData)
                    {
                        Console.WriteLine(value);
                    }

                    Console.WriteLine("importedYData values:");
                    foreach (var value in importedYData)
                    {
                        Console.WriteLine(value);
                    }

                    Console.WriteLine("importedZData values:");
                    foreach (var value in importedZData)
                    {
                        Console.WriteLine(value);
                    }


                    //plotControl.SetData(importedXData, importedYData, importedZData);

                    if (plotControl == null)
                    {
                        plotControl = new PlotControl();
                    }

                    plotControl.Dock = DockStyle.Fill;
                    mainPanel.Controls.Add(plotControl);

                }
                else
                {
                    Console.WriteLine("Nothing Here at the first time");
                }
            }
        }


        private void settingsBtn_Click_1(object sender, EventArgs e)
        {
            Settings ST = new Settings();
            ST.StartPosition = FormStartPosition.CenterScreen;
            ST.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
