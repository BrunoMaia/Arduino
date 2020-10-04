using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using OpenHardwareMonitor.Hardware;

namespace Cs
{
    public partial class Form1 : Form
    {
        static string data;
        Computer c = new Computer()
        {
            GPUEnabled = true,
            CPUEnabled = true
        };

        float Temp_cpu, Temp_gpu;

        private SerialPort port = new SerialPort();

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            try
            {
                notifyIcon1.Visible = false;
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
                port.DataBits = 8;
                port.Handshake = Handshake.None;
                port.RtsEnable = true;
                string[] ports = SerialPort.GetPortNames();
                foreach (string port in ports)
                {
                    combo_portaSerial.Items.Add(port);
                }
                port.BaudRate = 9600;
                combo_intervalo.SelectedIndex = 0;
                combo_portaSerial.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Status()
        {
            foreach (var hardwadre in c.Hardware)
            {

                if (hardwadre.HardwareType == HardwareType.GpuAti)
                {
                    hardwadre.Update();
                    foreach (var sensor in hardwadre.Sensors)
                        if (sensor.SensorType == SensorType.Temperature)
                        {

                            Temp_gpu = sensor.Value.GetValueOrDefault();
                        }

                }

                if (hardwadre.HardwareType == HardwareType.CPU)
                {
                    hardwadre.Update();
                    foreach (var sensor in hardwadre.Sensors)
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            Temp_cpu = sensor.Value.GetValueOrDefault();

                        }

                }

            }
            try
            {
                port.Write("*");
                float Temp_gabinete = Convert.ToSingle(port.ReadLine())/100;
                textBox_gabinete.Text = Temp_gabinete.ToString() + " °C";
                textBox_cpu.Text = Convert.ToString(Temp_cpu) + " °C";
                textBox_gpu.Text = Convert.ToString(Math.Round(Temp_gpu, 2)) + " °C";
            }
            catch (Exception ex)
            {
                timer1.Stop();
                MessageBox.Show(ex.Message);
                toolStripStatusLabel1.Text = "Arduino's not responding...";
                port.Close();
                combo_portaSerial.Enabled = true;
                combo_intervalo.Enabled = true;
                button_ok.Text = "Conectar";
                toolStripStatusLabel1.Text = "Conecte ao Arduino!";
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (port.IsOpen)
            {
                port.Close(); 
            }  
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                try
                {
                    notifyIcon1.ShowBalloonTip(500, "Arduino", toolStripStatusLabel1.Text, ToolTipIcon.Info);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Hide();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            c.Open();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Status();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (port.IsOpen == false)
                {
                    try
                    {
                        port.PortName = combo_portaSerial.Text;
                        port.Open();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (port.IsOpen)
                    {
                        button_ok.Text = "Desconectar";
                        combo_portaSerial.Enabled = false;
                        combo_intervalo.Enabled = false;
                        timer1.Interval = Convert.ToInt32(combo_intervalo.Text);
                        timer1.Enabled = true;
                        toolStripStatusLabel1.Text = "Conectado!";
                    }
                }
                else
                {

                    try
                    {
                        port.Close();
                        combo_portaSerial.Enabled = true;
                        combo_intervalo.Enabled = true;
                        button_ok.Text = "Conectar";
                        timer1.Enabled = false;
                        toolStripStatusLabel1.Text = "Conecte ao Arduino!";
                    }
                    catch
                    {
                        return;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
