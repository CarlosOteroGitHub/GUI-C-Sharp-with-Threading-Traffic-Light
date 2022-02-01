using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ProyectoGUI {

    public partial class Form1 : Form {

        private static TextBox textBox1;
        private static Label label1, label2, label3, label4, label5, label6, label7, label8, label9;
        private MainMenu mainMenu1;
        private MenuItem menuItem, menuItem1, menuItem2;
        private static PictureBox pictureBox1;
        private Button button1, button2, button3, button4, button5, button6;

        public Form1() {
            InitializeComponent();
            //Caracteristicas de la Ventana.
            this.Text = "Semaforo";
            this.Size = new Size(700, 570);
            this.StartPosition = FormStartPosition.CenterScreen;
            CheckForIllegalCrossThreadCalls = false;

            //Caracteristicas del Menu.
            mainMenu1 = new MainMenu();

            menuItem = new MenuItem();
            menuItem.Text = "Archivo";

            menuItem1 = new MenuItem();
            menuItem1.Text = "Seguir Funcionamiento";

            menuItem2 = new MenuItem();
            menuItem2.Text = "Sal�r";

            menuItem.MenuItems.Add(menuItem1);
            menuItem.MenuItems.Add(menuItem2);

            mainMenu1.MenuItems.Add(menuItem);
            this.Menu = mainMenu1;

            //Caracteristicas del PictureBox.
            this.Controls.Add(pictureBox1 = new PictureBox());
            pictureBox1.Size = new Size(193, 505);
            pictureBox1.Location = new Point(5, 20);
            pictureBox1.Image = Image.FromFile("F:\\xampp\\other\\Programming\\2. Desarrollo de Aplicaciones de Escritorio\\3. C# (Visual Studio)\\4. Programaci�n Concurrente\\2. Programaci�n Visual\\Semaforo\\off.png");

            //Caracteristicas de los Labels.
            this.Controls.Add(label1 = new Label());
            label1.Text = "Semaforo";
            label1.Size = new Size(310, 35);
            label1.Location = new Point(360, 50);
            label1.Font = new Font("Arial", 24, FontStyle.Bold);

            this.Controls.Add(label2 = new Label());
            label2.Size = new Size(460, 1);
            label2.Location = new Point(210, 100);
            label2.AutoSize = false;
            label2.BorderStyle = BorderStyle.Fixed3D;

            this.Controls.Add(label3 = new Label());
            label3.Text = "Funcionamiento";
            label3.Size = new Size(160, 35);
            label3.Location = new Point(240, 150);
            label3.Font = new Font("Arial", 14, FontStyle.Bold);

            this.Controls.Add(label4 = new Label());
            label4.Text = "Controles de Prueba";
            label4.Size = new Size(250, 35);
            label4.Location = new Point(450, 150);
            label4.Font = new Font("Arial", 14, FontStyle.Bold);

            this.Controls.Add(label5 = new Label());
            label5.Text = "Tiempo:";
            label5.Size = new Size(160, 35);
            label5.Location = new Point(270, 275);
            label5.Font = new Font("Arial", 14, FontStyle.Bold);

            this.Controls.Add(label6 = new Label());
            label6.Size = new Size(80, 35);
            label6.Location = new Point(305, 310);
            label6.Font = new Font("Arial", 14, FontStyle.Bold);

            this.Controls.Add(label7 = new Label());
            label7.Text = "Se�alizaci�n";
            label7.Size = new Size(160, 35);
            label7.Location = new Point(250, 410);
            label7.Font = new Font("Arial", 14, FontStyle.Bold);

            this.Controls.Add(label8 = new Label());
            label8.Text = "Estado";
            label8.Size = new Size(160, 35);
            label8.Location = new Point(510, 410);
            label8.Font = new Font("Arial", 14, FontStyle.Bold);

            this.Controls.Add(label9 = new Label());
            label9.Size = new Size(160, 40);
            label9.Location = new Point(250, 440);
            label9.Font = new Font("Arial", 13, FontStyle.Bold);

            //Caracteristicas de los Botones.
            this.Controls.Add(button1 = new Button());
            button1.Text = "Iniciar";
            button1.Size = new Size(150, 27);
            button1.Location = new Point(240, 190);

            this.Controls.Add(button2 = new Button());
            button2.Text = "Detener";
            button2.Size = new Size(150, 27);
            button2.Location = new Point(240, 230);
            button2.Enabled = false;

            this.Controls.Add(button3 = new Button());
            button3.Text = "Verde";
            button3.Size = new Size(150, 27);
            button3.Location = new Point(475, 190);

            this.Controls.Add(button4 = new Button());
            button4.Text = "Amarillo";
            button4.Size = new Size(150, 27);
            button4.Location = new Point(475, 230);

            this.Controls.Add(button5 = new Button());
            button5.Text = "Rojo";
            button5.Size = new Size(150, 27);
            button5.Location = new Point(475, 270);

            this.Controls.Add(button6 = new Button());
            button6.Text = "Apagado";
            button6.Size = new Size(150, 27);
            button6.Location = new Point(475, 310);

            //Caracteristicas de los TextBox.
            this.Controls.Add(textBox1 = new TextBox());
            textBox1.Text = "Apagado";
            textBox1.AutoSize = false;
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(160, 25);
            textBox1.Location = new Point(470, 450);
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Font = new Font("Arial", 14, FontStyle.Bold);
        }

        Thread hilo = new Thread(run);
        static void run(){
            int seg = 0;
            while (true){
                if (seg == 9){
                    seg = 0;
                }
                seg++;
                switch (seg){
                    case 1:
                        textBox1.Text = "Encendido";
                        label9.Text = "Siga Adelante";
                        label9.ForeColor = Color.Green;
                        pictureBox1.Image = Image.FromFile("F:\\xampp\\other\\Programming\\2. Desarrollo de Aplicaciones de Escritorio\\3. C# (Visual Studio)\\4. Programaci�n Concurrente\\2. Programaci�n Visual\\Semaforo\\green.png");
                        break;
                    case 2:
                        textBox1.Text = "";
                        break;
                    case 3:
                        textBox1.Text = "Encendido";
                        break;
                    case 4:
                        textBox1.Text = "";
                        label9.Text = "Precauci�n";
                        label9.ForeColor = Color.Yellow;
                        pictureBox1.Image = Image.FromFile("F:\\xampp\\other\\Programming\\2. Desarrollo de Aplicaciones de Escritorio\\3. C# (Visual Studio)\\4. Programaci�n Concurrente\\2. Programaci�n Visual\\Semaforo\\yellow.png");
                        break;
                    case 5:
                        textBox1.Text = "Encendido";
                        break;
                    case 6:
                        textBox1.Text = "";
                        break;
                    case 7:
                        textBox1.Text = "Encendido";
                        label9.Text = "Alto";
                        label9.ForeColor = Color.Red;
                        pictureBox1.Image = Image.FromFile("F:\\xampp\\other\\Programming\\2. Desarrollo de Aplicaciones de Escritorio\\3. C# (Visual Studio)\\4. Programaci�n Concurrente\\2. Programaci�n Visual\\Semaforo\\red.png");
                        break;
                    case 8:
                        textBox1.Text = "";
                        break;
                    case 9:
                        textBox1.Text = "Encendido";
                        break;
                }
                label6.Text = "" + seg;
                Thread.Sleep(1000);
            }
        }

        private void Form1_Load(object sender, EventArgs e){
            menuItem1.Click += new EventHandler(menuItem1_Click);
            menuItem2.Click += new EventHandler(menuItem2_Click);
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
            button3.Click += new EventHandler(button3_Click);
            button4.Click += new EventHandler(button4_Click);
            button5.Click += new EventHandler(button5_Click);
            button6.Click += new EventHandler(button6_Click);
        }

        private void menuItem1_Click(object sender, EventArgs e){
            if(hilo.IsAlive == false){
                this.Visible = false;
                MessageBox.Show("No ha Iniciado el Semaforo", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Visible = true;
            } else {
                hilo.Resume();
                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }

        private void menuItem2_Click(object sender, EventArgs e){
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e) {
            hilo.Start();
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e) {
            hilo.Suspend();
            label9.Text = "";
            textBox1.Text = "Apagado";
            pictureBox1.Image = Image.FromFile("F:\\xampp\\other\\Programming\\2. Desarrollo de Aplicaciones de Escritorio\\3. C# (Visual Studio)\\4. Programaci�n Concurrente\\2. Programaci�n Visual\\Semaforo\\off.png");
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e){
            pictureBox1.Image = Image.FromFile("F:\\xampp\\other\\Programming\\2. Desarrollo de Aplicaciones de Escritorio\\3. C# (Visual Studio)\\4. Programaci�n Concurrente\\2. Programaci�n Visual\\Semaforo\\green.png");
        }

        private void button4_Click(object sender, EventArgs e){
            pictureBox1.Image = Image.FromFile("F:\\xampp\\other\\Programming\\2. Desarrollo de Aplicaciones de Escritorio\\3. C# (Visual Studio)\\4. Programaci�n Concurrente\\2. Programaci�n Visual\\Semaforo\\yellow.png");
        }

        private void button5_Click(object sender, EventArgs e){
            pictureBox1.Image = Image.FromFile("F:\\xampp\\other\\Programming\\2. Desarrollo de Aplicaciones de Escritorio\\3. C# (Visual Studio)\\4. Programaci�n Concurrente\\2. Programaci�n Visual\\Semaforo\\red.png");
        }

        private void button6_Click(object sender, EventArgs e){
            pictureBox1.Image = Image.FromFile("F:\\xampp\\other\\Programming\\2. Desarrollo de Aplicaciones de Escritorio\\3. C# (Visual Studio)\\4. Programaci�n Concurrente\\2. Programaci�n Visual\\Semaforo\\off.png");
        }
    }
}