using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;
using System.Data.SQLite;

namespace Votowf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                pictureBox1.Image = (Image)eventArgs.Frame.Clone();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Contenedor f = new Contenedor();
            f.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            partidos f = new partidos();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            try
            {
                CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo Device in CaptureDevice)
                {
                    comboBox1.Items.Add(Device.Name);
                }
                comboBox1.SelectedIndex = 0;
                FinalFrame = new VideoCaptureDevice();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No hay Camara");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (FinalFrame.IsRunning == true)
                {
                    FinalFrame.Stop();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            button1.Enabled = false;
            btnini.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnini.Enabled = false;
            textBox1.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)pictureBox1.Image);
           
                string decoded = result.ToString().Trim();
                textBox1.Text = decoded;

                
                

            }
            catch (Exception ex)
            {

            }
        }


        public void startseccion()
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            string actuser = Convert.ToString(textBox1.Text);
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\bdd\\sm.s3db; Version=3;");
            try
            {
                cnx.Open();
                SQLiteDataAdapter ad;
                DataTable dt = new DataTable();
                SQLiteCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "select numced from cedula where numced = '" + textBox1.Text + "'";
                ad = new SQLiteDataAdapter(cmd);

                DataSet ds = new DataSet();
                ad.Fill(dt);
                ds.Tables.Add(dt);
                if (dt.Rows.Count <= 0)
                {
                    oper.consultasinreaultado("insert into cedula(numced)values('" + textBox1.Text + "')");
                    partidos f = new partidos();
                    f.MdiParent = this.MdiParent;
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Esta Persona ya voto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
