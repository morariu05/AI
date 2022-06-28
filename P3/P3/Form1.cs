using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace P3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            GraficEroare_label.Visible = false;
            panel1.Visible = false;

            SetariAntrenare_label.Visible = false;
            panel2.Visible = false;

            panel3.Visible = false;
            dataGridView2.Visible = false;

            this.panel.Controls.Find("lineUp", true).FirstOrDefault().Visible = false;
            this.panel.Controls.Find("btn_test", true).FirstOrDefault().Visible = false;
            this.panel.Controls.Find("lineDown", true).FirstOrDefault().Visible = false;
        }

        #region Excel
        public DataTable ReadExcel(string fileName, string fileExt)
        {
            string conn = string.Empty;
            DataTable dtexcel = new DataTable();
            fileName = @"C:\Users\Ela\Desktop\diabetes.xlsx";

            conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=NO';" ; //for above excel 2007  
            
            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [diabetes$]", con); //here we read data from sheet1  
                    oleAdpt.Fill(dtexcel); //fill excel data into dataTable  
                }
                catch { }
            }

            #region ColumnName
            DataRow row = dtexcel.Rows[1];
            dtexcel.Rows.Remove(row);

            dtexcel.Columns[0].ColumnName = "Age";
            dtexcel.Columns[1].ColumnName = "Gender";
            dtexcel.Columns[2].ColumnName = "Polyuria";
            dtexcel.Columns[3].ColumnName = "Polydipsia";
            dtexcel.Columns[4].ColumnName = "Sudden weight loss";
            dtexcel.Columns[5].ColumnName = "Weakness";
            dtexcel.Columns[6].ColumnName = "Polyphagia";
            dtexcel.Columns[7].ColumnName = "Genital thrush";
            dtexcel.Columns[8].ColumnName = "Visual blurring";
            dtexcel.Columns[9].ColumnName = "Itching";
            dtexcel.Columns[10].ColumnName = "Irritability";
            dtexcel.Columns[11].ColumnName = "Delayed healing";
            dtexcel.Columns[12].ColumnName = "Partial paresis";
            dtexcel.Columns[13].ColumnName = "Muscle stiffness";
            dtexcel.Columns[14].ColumnName = "Alopecia";
            dtexcel.Columns[15].ColumnName = "Obesity";
            dtexcel.Columns[16].ColumnName = "class";
            #endregion

            return dtexcel;
        }

        public DataTable ReadExcel2(string fileName, string fileExt)
        {
            string conn = string.Empty;
            DataTable dtexcel = new DataTable();
            fileName = @"C:\Users\Ela\Desktop\Book1.xlsx";

            conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=NO';"; //for above excel 2007  

            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [Sheet1$]", con); //here we read data from sheet1  
                    oleAdpt.Fill(dtexcel); //fill excel data into dataTable  
                }
                catch { }
            }

            #region ColumnName
            DataRow row = dtexcel.Rows[1];
            dtexcel.Rows.Remove(row);

            dtexcel.Columns[0].ColumnName = "Age";
            dtexcel.Columns[1].ColumnName = "Gender";
            dtexcel.Columns[2].ColumnName = "Polyuria";
            dtexcel.Columns[3].ColumnName = "Polydipsia";
            dtexcel.Columns[4].ColumnName = "Sudden weight loss";
            dtexcel.Columns[5].ColumnName = "Weakness";
            dtexcel.Columns[6].ColumnName = "Polyphagia";
            dtexcel.Columns[7].ColumnName = "Genital thrush";
            dtexcel.Columns[8].ColumnName = "Visual blurring";
            dtexcel.Columns[9].ColumnName = "Itching";
            dtexcel.Columns[10].ColumnName = "Irritability";
            dtexcel.Columns[11].ColumnName = "Delayed healing";
            dtexcel.Columns[12].ColumnName = "Partial paresis";
            dtexcel.Columns[13].ColumnName = "Muscle stiffness";
            dtexcel.Columns[14].ColumnName = "Alopecia";
            dtexcel.Columns[15].ColumnName = "Obesity";
            dtexcel.Columns[16].ColumnName = "class";
            #endregion

            return dtexcel;
        }

        #endregion

        #region Date de intrare

        private void btnDateIntrare_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            string fileExt = string.Empty;
            //OpenFileDialog file = new OpenFileDialog(); //open dialog to choose file  
            //if (file.ShowDialog() == DialogResult.OK) //if there is a file choosen by the user  
            //{
            //    filePath = file.FileName; //get the path of the file  
            //    fileExt = Path.GetExtension(filePath); //get the file extension  
            //    if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
            //    {
                    try
                    {
                        DataTable dtExcel = new DataTable();
                        dtExcel = ReadExcel(filePath, fileExt); //read excel file  
                        dataGridView1.Visible = true;
                        dataGridView1.DataSource = dtExcel;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                //}
                //else
                //{
                //    MessageBox.Show("Please choose .csv file only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
           // }

            GraficEroare_label.Visible = false;
            panel1.Visible = false;

            SetariAntrenare_label.Visible = false;
            panel2.Visible = false;

            panel3.Visible = false;
            dataGridView2.Visible = false;

            this.panel.Controls.Find("lineUp", true).FirstOrDefault().Visible = false;
            this.panel.Controls.Find("btn_test", true).FirstOrDefault().Visible = false;
            this.panel.Controls.Find("lineDown", true).FirstOrDefault().Visible = false;
        }
        #endregion

        #region Date de intrare normalizate

        private void btnDateIntrareNormalizate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value is double)
                    {
                        double age = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                        age = (age - 20) / (70 - 20);
                        dataGridView1.Rows[i].Cells[j].Value = Math.Round(age, 3);
                    }

                    if (dataGridView1.Rows[i].Cells[j].Value is string)
                    {
                        string x = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        if (x == "Male" || x == "Yes" || x == "Positive")
                        {
                            x = "1";
                        }
                        if (x == "Female" || x == "No" || x == "Negative")
                        {
                            x = "0";
                        }
                        dataGridView1.Rows[i].Cells[j].Value = x;
                    }
                }
            }

           
            //background color rows 20%

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    if (dataGridView1.Rows[j].Cells[i].Value is double)
                    {
                        //ExcepApp.Cells[row, col].Font.Color = Excel.XlRgbColor.rgbMidnightBlue
                        //double age = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                        //age = (age - 20) / (65 - 20);
                        //dataGridView1.Rows[i].Cells[j].Value = Math.Round(age, 3);
                    }
                }
            }

            GraficEroare_label.Visible = false;
            panel1.Visible = false;

            SetariAntrenare_label.Visible = false;
            panel2.Visible = false;

            panel3.Visible = false;
            dataGridView2.Visible = false;

            this.panel.Controls.Find("lineUp", true).FirstOrDefault().Visible = false;
            this.panel.Controls.Find("btn_test", true).FirstOrDefault().Visible = false;
            this.panel.Controls.Find("lineDown", true).FirstOrDefault().Visible = false;
        }
        #endregion

        #region Antrenare

        int contor = 1;
        int marginTop = 45;

        private void btnAntrenare_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;

            GraficEroare_label.Visible = true;
            panel1.Visible = true;

            SetariAntrenare_label.Visible = true;
            panel2.Visible = true;

            panel3.Visible = false;
            dataGridView2.Visible = false;

            this.panel.Controls.Find("lineUp", true).FirstOrDefault().Visible = false;
            this.panel.Controls.Find("btn_test", true).FirstOrDefault().Visible = false;
            this.panel.Controls.Find("lineDown", true).FirstOrDefault().Visible = false;
        }

        private void numeric_Hidden_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown hL = (NumericUpDown)this.panel2.Controls.Find("numeric_Hidden", true).FirstOrDefault();
            int nrHiddenL = (int)hL.Value;
            if (contor < nrHiddenL)
            {
                contor++;
                Label nrHiddenLayer = new Label();
                nrHiddenLayer.Name = "nrHiddenLayer" + contor.ToString();
                nrHiddenLayer.Text = "Nr neuroni pe stratul ascuns " + contor.ToString();
                nrHiddenLayer.Size = new Size(227, 20);
                nrHiddenLayer.Location = new Point(13, marginTop);
                this.panel_Hidden.Controls.Add(nrHiddenLayer);

                NumericUpDown nrNeuronsInHiddenLayer = new NumericUpDown();
                nrNeuronsInHiddenLayer.Name = "nrNeuronsInHiddenLayer" + contor.ToString();
                nrNeuronsInHiddenLayer.Size = new Size(82, 27);
                nrNeuronsInHiddenLayer.Location = new Point(282, (marginTop - 2));
                nrNeuronsInHiddenLayer.Value = 1;
                nrNeuronsInHiddenLayer.Minimum = 1;
                nrNeuronsInHiddenLayer.TextAlign = HorizontalAlignment.Center;
                this.panel_Hidden.Controls.Add(nrNeuronsInHiddenLayer);

                marginTop += 35;
            }
            else
            {
                this.panel_Hidden.Controls.Remove(this.panel_Hidden.Controls.Find("nrHiddenLayer" + contor, true).FirstOrDefault());
                this.panel_Hidden.Controls.Remove(this.panel_Hidden.Controls.Find("nrNeuronsInHiddenLayer" + contor, true).FirstOrDefault());

                contor--;
                marginTop -= 35;
            }
        }


        #endregion

        #region Testare

        private void btnTestare_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            string fileExt = string.Empty;
            try
            {
                DataTable dtExcel = new DataTable();
                dtExcel = ReadExcel2(filePath, fileExt); //read excel file
                dataGridView2.Visible = true;
                dataGridView2.DataSource = dtExcel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            this.panel.Controls.Find("lineUp", true).FirstOrDefault().Visible = true;
            this.panel.Controls.Find("btn_test", true).FirstOrDefault().Visible = true;
            this.panel.Controls.Find("lineDown", true).FirstOrDefault().Visible = true;

            dataGridView2.Visible = true;
            panel3.Visible = true;

            GraficEroare_label.Visible = false;
            panel1.Visible = false;

            SetariAntrenare_label.Visible = false;
            panel2.Visible = false;

            dataGridView1.Visible = false;
        }

        #endregion

    }
}

