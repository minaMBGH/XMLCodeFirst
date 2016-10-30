using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace JASON_HTML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Urun> urunlerListesi = new List<Urun>();
        private void btnVeriGoster_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Urunler.xml");
            var urunElements = doc.GetElementsByTagName("Urun");
            
            foreach (XmlElement siaradakiNod in urunElements)
            {
                var siradakiElementOzellikleri = "";
                //var test = siaradakiNod.Attributes["Id"].Value;

                Urun yeniUrun = new Urun();
                yeniUrun.Id = Convert.ToInt32(siaradakiNod.Attributes["Id"].Value);
                yeniUrun.Ad = siaradakiNod.Attributes["Ad"].Value;
                yeniUrun.Fiyat =string.IsNullOrEmpty(siaradakiNod.Attributes["Fiyat"].Value)?0m : Convert.ToDecimal(siaradakiNod.Attributes["Fiyat"].Value);
                yeniUrun.KategoriAdi = siaradakiNod.Attributes["KategoriAdi"].Value;

                urunlerListesi.Add(yeniUrun);


                //foreach (XmlAttribute siradakiAttr in siaradakiNod.Attributes)
                //{
                    
                    
                //    siradakiElementOzellikleri += siradakiAttr.Value + " ";
                //}
                //lstUrunler.Items.Add(siradakiElementOzellikleri);

            }

            lstUrunler.DataSource = (from u in urunlerListesi
                                     select new
                                     {
                                         id = u.Id,
                                         AdFiyatKategoriAdi = u.Ad + " " + u.Fiyat + " " + u.KategoriAdi
                                     }).ToList();

            lstUrunler.DisplayMember = "AdFiyatKategoriAdi";
        
            lstUrunler.ValueMember = "id";

            
        }

        private void btnVeriaktar_Click(object sender, EventArgs e)
        {

            UrunlerDBEntities ent = new UrunlerDBEntities();
            ent.Urunler.AddRange(urunlerListesi);
            MessageBox.Show(ent.SaveChanges() > 0 ? " Aktarıldı!!!!!" : "Sorun var");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Urun
    {

        public int Id { get; set; }
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public string KategoriAdi { get; set; }


    }


    public class UrunlerDBEntities : DbContext
    {
        //Tabloları DbSet<ClassAdi> isimleri ile oluştururuz.
        //Bu sınıfın constructor'ı içerisinde database ayarlamaları yapabiliyoruz (connectionstring gibi).
        public DbSet<Urun> Urunler { get; set; } //conteximiz içerisindeki veriler. 


        public UrunlerDBEntities()
        {
            Database.Connection.ConnectionString = "Server=BASB02;Database=UrunlerDBEntities;User id=sa;Password=1234";

            //Veritabanına bağlanmak için gerekli olan connectionString'i burada ayarlayabiliriz. 
            //Database.Connection.ConnectionString = "Server=.;Database=EticaretEntities;User id=sa;Password=Password1";
            //Veritabanı oluşturma stratejilerini burada yazabiliriz. 
            Database.SetInitializer<UrunlerDBEntities>(new CreateDatabaseIfNotExists<UrunlerDBEntities>()); //Eğer veritabanı yoksa bir tane üret. 
            Database.SetInitializer<UrunlerDBEntities>(new DropCreateDatabaseIfModelChanges<UrunlerDBEntities>()); //Modelde bir değişiklik olduysa eğer veritabanını drop et ve yeniden oluştur. 
        }

    }


}
