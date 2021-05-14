using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoWF1
{
    public partial class Form1 : Form
    {
        private ToolStripMenuItem velocidadeSelecionada;
        private ToolStripMenuItem portaSelecionada;
        private SerialPort conectorSerial;
        private bool quebraLinha;
        private bool scrollAutomatico;


        public Form1()
        {
            InitializeComponent();

            HabilitarControles(false);

            quebraLinha = false;
            scrollAutomatico = false;

            List<int> baudRates = new List<int>();

            baudRates.Add(4800);
            baudRates.Add(9600);
            baudRates.Add(19200);
            baudRates.Add(38400);
            baudRates.Add(57600);
            baudRates.Add(115200);
            baudRates.Add(230400);

            foreach (int value in baudRates)
            {
                ToolStripMenuItem velocidade = new ToolStripMenuItem(value.ToString(), null, OnClickVelocidade, value.ToString());
                itemVelocidade.DropDownItems.Add(velocidade);

                if (value == 9600)
                {
                    velocidadeSelecionada = velocidade;
                    velocidade.Checked = true;
                }
            }

            conectorSerial = new SerialPort();
            conectorSerial.DataReceived += OnDadoRecebido;

            string[] portas = SerialPort.GetPortNames();

            foreach (string value in portas)
            {
                ToolStripMenuItem porta = new ToolStripMenuItem(value, null, OnClickPorta, value);
                itemAbrirPorta.DropDownItems.Add(porta);
            }
        }

        public delegate void SerialDelegate(string valor);

        private void OnDadoRecebido(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string dadoRecebido = conectorSerial.ReadLine();

                object[] parametros = new object[1];
                parametros[0] = dadoRecebido;

                SerialDelegate delegar = new SerialDelegate(MostrarDados);
                BeginInvoke(delegar, parametros);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro");
            }
        }

        private void MostrarDados(string valor)
        {
            txtLog.AppendText(valor);

            if (quebraLinha)
            {
                txtLog.AppendText("\n");
            }

            if (scrollAutomatico)
            {
                txtLog.SelectionStart = txtLog.Text.Length;
                txtLog.ScrollToCaret();
            }
        }

        private void OnClickPorta(object sender, EventArgs e)
        {
            if (portaSelecionada != null)
            {
                portaSelecionada.Checked = false;
            }
            portaSelecionada = (ToolStripMenuItem)sender;
            portaSelecionada.Checked = true;

            if (conectorSerial.IsOpen == false)
            {
                conectorSerial.PortName = portaSelecionada.Name;
                conectorSerial.BaudRate = int.Parse(velocidadeSelecionada.Name);

                conectorSerial.Open();

                HabilitarControles(true);
            }
        }

        private void OnClickVelocidade(object sender, EventArgs e)
        {
            velocidadeSelecionada.Checked = false;
            velocidadeSelecionada = (ToolStripMenuItem)sender;
            velocidadeSelecionada.Checked = true;
        }

        private void itemFecharPorta_Click(object sender, EventArgs e)
        {
            if (conectorSerial.IsOpen)
            {
                conectorSerial.Close();
                HabilitarControles(false);
            }
        }

        private void HabilitarControles(bool ativo)
        {
            txtEnviar.Enabled = ativo;
            btnEnviar.Enabled = ativo;
            txtLog.Enabled = ativo;
            itemFecharPorta.Enabled = ativo;
            itemLimparLog.Enabled = ativo;

            itemAbrirPorta.Enabled = !ativo;
            itemVelocidade.Enabled = !ativo;

            if (portaSelecionada != null)
            {
                portaSelecionada.Checked = false;
            }

            if (conectorSerial != null)
            {
                Text = "Monitor Serial - Porta: " + conectorSerial.PortName + " | Baud: " + conectorSerial.BaudRate.ToString();
            }
            else
            {
                Text = "Monitor Serial";
            }
        }

        private void itemLimparLog_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
        }

        private void itemQuebraLinha_Click(object sender, EventArgs e)
        {
            quebraLinha = !quebraLinha;

            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            item.Checked = quebraLinha;
        }

        private void itemAutoScroll_Click(object sender, EventArgs e)
        {
            scrollAutomatico = !scrollAutomatico;

            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            item.Checked = scrollAutomatico;
        }

        private void itemSalvarLog_Click(object sender, EventArgs e)
        {
            SaveFileDialog caixaSalvar = new SaveFileDialog();

            DialogResult resultado = caixaSalvar.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                File.WriteAllText(caixaSalvar.FileName, txtLog.Text);
            }
        }

        private void itemSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Monitor Serial\n\n" +
                "Desenvonvido por:\n" +
                "Vitor Gonçalves \t\t10848\n" +
                "João Pinto \t\t14827\n" +
                "João Fernandes \t\t16978\n" +
                "Rui Silva \t\t\t7816\n" +
                "Pedro Pereira \t\t17002\n" +
                "Mário Viana \t\t13728\n\n" +
                "Trabalho Prático de SETR\n" +
                "Versão: v1.0", "Sobre");
        }

        private void itemSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (conectorSerial.IsOpen)
            {
                conectorSerial.WriteLine(txtEnviar.Text);
                txtEnviar.Clear();
            }
        }
    }
}
