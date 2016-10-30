using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JASON_HTML1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // JSON da Entity farameWork gibi References-> Sağ tiklayıp -> Nuget ten indirmemiz gerekir
        ////http://www.newtonsoft.com/
        private void btnVeriCek_Click(object sender, EventArgs e)
        {
            var okunan=File.ReadAllText("Kisiler.json");
            List<Kisi> kisiListesi = JsonConvert.DeserializeObject<List<Kisi>>(okunan);
            lstKisiler.DataSource = kisiListesi.Select(k => new { 
                AdSoyadYas= k.Ad+  " "+ k.Soyad+ " " + k.Yas,           
                Id=k.Id
            
            }).ToList();
            lstKisiler.DisplayMember = "AdSoyadYas";
            lstKisiler.ValueMember = "Id";
        }
    }

    public class Kisi
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }


    }
}
