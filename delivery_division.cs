using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using LibraryManagementSystem;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace UTS_Kelompok9
{

    public partial class delivery_division : UserControl
    {
        //dari sini tambahan
        /*lokasi db = new MYDB();

        public Boolean add
        string lokasi = .Text;
        string tanggal = .Text;

        DataTable table = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command = new MySqlCommand(
            "SELECT * FROM users WHERE username= @usn AND password= @pass", db.getConnection());
        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value=password;    

            adapter.SelectCommand = command;
            adapter.Fill(table);
            //sampai sini tambahan*/

        public delivery_division()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            

            if (textBox1.Text == "Tulis nama kecamatan, kota, provinsi")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            

            if (textBox1.Text == "Mancasan Indah 3")
            {
                textBox1.Text = "pilih lokasi";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
            //combolokasi.Size = new Size(216, 26);


           // ComboBox mybox = new ComboBox();
            combolokasi.Location = new Point(41, 56);
            combolokasi.Size = new Size(558, 28);
            combolokasi.Name = "My_Cobo_Box";
            

            this.Controls.Add(combolokasi);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        MYDB db = new MYDB();
        private void delivery_division_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.GenreList();
            textBox1.Hide();
        }

        string lokasi ;
        DateTime lok = DateTime.Now;
        string tanggal = Convert.ToString( DateTime.Now);

        internal static DateTime GetCurrentDate()
        {
            return DateTime.Now.Date;
        }
        GENRE genre = new GENRE();
        private void button1_Click(object sender, EventArgs e)
        {
            lokasi = combolokasi.Text;
            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=login");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO history_lokasi (nama_lokasi,tanggal) values (@nama_lokasi,@tanggal)", con);
            cmd.Parameters.AddWithValue("@nama_lokasi", lokasi);
            cmd.Parameters.AddWithValue("@tanggal", tanggal);
            //cmd.Parameters.AddWithValue("@t", 1);
            cmd.ExecuteNonQuery();
            con.Close();


            string nama_lokasi = combolokasi.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(
                "SELECT * FROM history_lokasi WHERE nama_lokasi= @nama_lokasi", db.getConnection());

            command.Parameters.Add("@nama_lokasi", MySqlDbType.VarChar).Value = nama_lokasi;
            if(genre.addlokasi(nama_lokasi, tanggal)){
                dataGridView1.DataSource = db.GenreList();

                MessageBox.Show("Lokasi berhasil disimpan!",
                    "Lokasi baru",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                combolokasi.DataSource = genre.lokasiList();
            }
            
            //command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = tanggal;
            /*DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(
                "SELECT * FROM users WHERE username= @usn AND password= @pass", db.getConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
           textBox1.Show();
        }
    }
}


