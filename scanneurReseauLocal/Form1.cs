using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;


namespace scanneurReseauLocal
{
    public partial class scanneurReseauLocal : Form
    {
        public scanneurReseauLocal()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void scanneurReseauLocal_Load(object sender, EventArgs e)
        {
            txbIp.Enabled = false;
            txbNomMachine.Enabled = false;
            txbPasserelle.Enabled = false;

            System.Net.IPHostEntry localIP = System.Net.Dns.Resolve(System.Net.Dns.GetHostName());
            txbIp.Text = localIP.AddressList.GetValue(1).ToString();

            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            txbNomMachine.Text = computerProperties.HostName;

            lblAdresseTestee.Visible = false;
            lblAvancement.Visible = false;

        }

        private void btnLancerLeScan_Click(object sender, EventArgs e)
        {
            lancerScan();
        }
        public void lancerScan()
        {
            lblAdresseTestee.Visible = true;
            lblAvancement.Visible = true;

            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();
            options.DontFragment = true;

            String data = new String('a', 32);
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 10;

            for (int i = 0; i <= 255; ++i)
            {
                //MessageBox.Show("Boucle occurence " + i);

                //MessageBox.Show("Occurence " + i);
                String adresse = "192.168.1." + i;
                lblAdresseTestee.Text = "Adresse testée : " + adresse;
                int avancementInt = i + 1;
                lblAvancement.Text = "Avancement " + avancementInt + " / 256";
                Form.ActiveForm.Refresh();
                try
                {

                    IPHostEntry entry = Dns.GetHostEntry(adresse);
                    PingReply reply = pingSender.Send(entry.AddressList[0], timeout, buffer, options);

                    if (reply.Status == IPStatus.Success)
                    {
                        dgvInfosMachines.Rows.Add(adresse, "Nom de machine inconnu");
                    }
                }
                catch (Exception exc)
                {
                    //MessageBox.Show(exc.ToString());
                    //return;
                }
            }
        }
    }
}
