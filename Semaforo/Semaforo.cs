using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace Semaforo
{
    public partial class Semaforo : Form
    {
        int caso = 0;
        public Semaforo()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "bzvNjOlMdK9mKuTCz5It37DpFgFPTRdqqVkmM51J",
            BasePath = "https://proyectofinal-907ca-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
                pictureBox1.Image = global::Semaforo.Properties.Resources.verde;
                btnapagar.Enabled = false;
                btndetener.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Conexion no establecida");
            }
           
        }

        private void btnencender_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnencender.Enabled = false;
            btndetener.Enabled = true;
            btnapagar.Enabled = true;
            label1.Text="Iniciar el cruce";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            switch (caso)
            {
                case 0:
                    pictureBox1.Image = global::Semaforo.Properties.Resources.verde;
                    timer1.Interval = 7000;
                    peton.Image = global::Semaforo.Properties.Resources.peatonal_Rojo;
                    caso = 1;
                    Color c = new Color()
                    {
                        color = "Rojo"
                    };
                    var setter = client.Update("proyectofinal-907ca-default-rtdb/color", c);
                    break;
                case 1:
                    pictureBox1.Image = global::Semaforo.Properties.Resources.amarillo;
                    timer1.Interval = 3000;
                    caso = 2;
                    break;
                case 2:
                    pictureBox1.Image = global::Semaforo.Properties.Resources.rojo;
                    timer1.Interval = 10000;
                    peton.Image = global::Semaforo.Properties.Resources.peatonal_verde;
                    caso = 0;
                    c = new Color()
                    {
                        color = "Verde"
                    };
                    setter = client.Update("proyectofinal-907ca-default-rtdb/color", c);
                    break;

                                                        
            }
        }

        private void btndetener_Click(object sender, EventArgs e)
        {
            if (btndetener.Text == "DETENER")
            {
                timer1.Enabled = false;
                btndetener.Text = "REANUDAR";
                label1.Text = "AHORA DETENIDO";

            }
            else
                if (btndetener.Text == "DETENER")
            {
                timer1.Enabled = true;
                btndetener.Text = "DETENER";
                label1.Text = "AHORA ENCENDIDO";
            }
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btndetener.Enabled = false;
            btnapagar.Enabled = false;
            btnencender.Enabled = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::Semaforo.Properties.Resources.peatonal_Rojo;
            btnapagar.Enabled = false;
            btndetener.Enabled = false;
        }
    }
}
