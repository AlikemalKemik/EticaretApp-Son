using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EticaretApp.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {

            var kategoriler = new List<Category>
            {
                new Category(){Name="Kamera", Description="Kamera " },
                new Category(){Name="Bilgisayar", Description="Bilgisayar " },
                new Category(){Name="Elektronik", Description="Elektronik " },
                new Category(){Name="Telefon", Description="Telefon " },
                new Category(){Name="Beyaz Eşya", Description="Beyaz Eşya " },


            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();


            var urunler = new List<Product>()
            {
                new Product() {Name="Canon Eos 1200D 18-55mm DC Profesyonel Dijital Fotoğraf Makinesi" ,Description="Her biri kendi kalitesine ve karakterine sahip fotoğraflar ve videolar çekin. EOS 1200D'nun 18 megapiksellik görüntüleri ayrıntılı bir şekilde kaydedilir ve A2+ boyutlarına kadar baskı için yeterli büyüklüktedir. Videolar profesyonel görünümlüdür ve evinizdeki HDTV'de oynatıldığında harika görünür.",Price=2000 , Stock=100, IsApproved=true, CategoryId=1 , IsHome=true, Image="1.jpg"},
                new Product() {Name="Canon Eos 100D 18-55mm DC Profesyonel Fotoğraf Makinesi" ,Description="EOS 100D, her yere götürebileceğiniz kadar küçük ve hafif olan tam özellikli, hassas bir DSLR'dir. Hayatınızı ölümsüzleştirmek için ideal fotoğraf makinesi. Gittiğiniz her yerde 18 megapiksel fotoğraflar ve Full HD videolar çekin; düşük ışıkta bile harika performansın tadını çıkarın: Maksimum ISO 12800 hassasiyeti (ISO 25600'e genişletilebilir) sayesinde sahnenin ruhunu yakalayan, düşük parazitli görüntüler çekebilirsiniz",Price=2500 , Stock=100, IsApproved=true, CategoryId=1, Image="2.jpg" },
                new Product() {Name="Canon Eos 700D 18-55 DC DSLR Fotoğraf Makinesi" ,Description="18 megapiksel Hibrid CMOS AF sensörle her ayrıntıyı yakalayın. EOS 700D, büyük boyutlarda yazdırabileceğiniz ya da alternatif kompozisyonlar için kırpabileceğiniz düşük parazitli görüntüler üretir.",Price=2000 , Stock=100, IsApproved=false, CategoryId=1 , Image="3.jpg" },
                new Product() {Name="Canon Eos 100D 18-55mm IS STM Kit DSLR Fotoğraf Makinesi" ,Description="Parlak, hassas optik vizörü kullanarak fotoğraf çekin ya da 1.040.000 nokta 7,7 cm (3,0 inç) 3:2 Clear View II TFT Dokunmatik ekranı kullanarak fotoğraf makinesini kontrol edin. Dokunma, kaydırma ve kıstırma hareketleriyle menülerde dolaşın, fotoğraflara bakın ve hatta odaklama ve çekim yapın.",Price=2700 , Stock=100, IsApproved=true, CategoryId=1 , IsHome=true , Image="4.jpg"},
                new Product() {Name="Canon Eos 700D + 18-55 Is Stm + Çanta + 16GB Hafıza Kartı" ,Description="Size uygun otomatik veya manuel kontrol seviyesinin keyfini çıkararak 1080p çözünürlükte video çekin. Hibrid AF teknolojisi video çekerken sürekli odaklama sağlar ve EOS 700D, uyumlu STM lenslerle sessize yakın Movie Servo AF'yi destekler. Yerleşik veya harici mikrofonla stereo ses kaydedin.",Price=3000 , Stock=100, IsApproved=true, CategoryId=1 , IsHome=true, Image="5.jpg"},

                new Product() {Name="Dell Inspiron 5567 Intel Core i5 7200U 8GB 1TB R7 M445 Windows 10" ,Description="Hareket halinde eğlence deneyimi için şık ve mobil bir dizüstü bilgisayar isteyen üniversite öğrencileri ve genç uzmanlar.",Price=3500 , Stock=200, IsApproved=true, CategoryId=2 , Image="1.jpg"},
                new Product() {Name="Lenovo Ideapad 310 Intel Core i7 7500U 12GB 1TB GT920M Windows 10" ,Description="İstediğiniz zaman ev-eğlence merkezi, gerek duyduğunuzda güçlü bir iş istasyonu. Lenovo Ideapad 510 (15”) dizüstü bilgisayar, gelecek nesil işlemcilerden gücünü alır ve etkileyici ses kalitesi ve çarpıcı yüksek tanımlı görüntü sunar. Bu aygıt, çalışma ve eğlenme için mükemmel taşınabilirliği ile sizi asla yarı yolda bırakmaz.",Price=5000 , Stock=100, IsApproved=true, CategoryId=2 , IsHome=true ,Image="2.jpg" },
                new Product() {Name="Asus UX310UQ-FB418T Intel Core i7 7500U 8GB 512GB SSD GT940MX Windows 10" ,Description="Tamamen yeni ZenBook UX310, zarafeti, inceliği ve üstün performansı muazzam ince ve hafif bir tasarımla sunuyor. Yekpare alüminyumdan yapılan ve Zen'den ilham alan metal kaplamadan oluşan ZenBook UX310 sadece 18.35mm kalınlığında.",Price=3800 , Stock=100, IsApproved=false, CategoryId=2 , Image="3.jpg"},
                new Product() {Name="Asus UX310UQ-FB418T Intel Core i7 7500U 16GB 512GB SSD GT940MX Windows 10" ,Description="1.4kg'lik seyahat dostu ağırlığı, onu yanınızda taşımanın asla külfet olmayacağı anlamına geliyor. 13.3 inçlik geniş inceleme açısına sahip olan ve net görüntü sunan ekranı size her zaman büyük keyif verecek. Üstelik 6. Nesil Intel® Core™ işlemcilerine, güçlü grafik kartına ve süper hızlı belleğe sahip olan ZenBook UX310 iş yükünüze doğru bir çözüm olmak için gereken yüksek performansa sahip.",Price=2600 , Stock=50, IsApproved=true, CategoryId=2 , IsHome=true, Image="4.jpg"},
                new Product() {Name="Asus N580VD-DM160T Intel Core i7 7700HQ 16GB 1TB + 128GB SSD GT940M Windows 10" ,Description="ASUS VivoBook Pro 15, 7. Nesil Intel® Core ™ işlemci ile desteklenen ince ve hafif, yüksek performanslı bir dizüstü bilgisayardır.",Price=2800 , Stock=150, IsApproved=true, CategoryId=2 , Image="3.jpg" },

                new Product() {Name="LG 49UH610V 49 124 Ekran 4K Uydu Alıcılı Smart Led TV" ,Description="LG’nin ultra hd yüksek çözünürlüklü 4K TV modelleriyle sadece TV izlemekle kalmayacak, her anın tanığı olacaksınız. ultra HD TV’lerden dört kat daha yoğun piksel sayısıyla her zamankinden daha canlı, keskin ve zengin!LG ultra hd ile yüksek çözünürlüğün keyifini keşfedin",Price=3500 , Stock=500, IsApproved=true, CategoryId=3 , IsHome=true , Image="1.jpg"},
                new Product() {Name="Vestel 49UB8300 49 124 Ekran 4K Smart Led TV" ,Description="Standart bir televizyon ötesinde, birbirinden farklı içerik alternatifleri sunan Vestel Smart TV evde geçirdiğiniz zamanı daha eğlenceli hale getirir.",Price=4000 , Stock=500, IsApproved=true, CategoryId=3 , Image="2.jpg"},
                new Product() {Name="Samsung 55KU7500 55 140 Ekran 4K Uydu Alıcılı Smart" ,Description="HDR Premium ile HDR içeriği izlerken TV ekranınızın en parlak kısımlarında gizlenmiş, daha önce görülmeyen detayların tadını çıkarabilirsiniz. Tiyatro gibi, gerçek HDR deneyimi artık oturma odanızda.",Price=5000 , Stock=100, IsApproved=true, CategoryId=3 , IsHome=true , Image="3.jpg" },
                new Product() {Name="LG 55UH615V 55 140 Ekran 4k Uydu Alıcılı Smart Wi-Fi" ,Description="HDR Pro özelliği ekranın parlaklığını ayarlayarak görüntüleri gerçeğe yakın bir kalitede seyretmenizi sağlar. HDR Po ile LG UHD TV’de canlı ve keskin görüntülerin tadını çıkarabilirsiniz.",Price=2780 , Stock=100, IsApproved=true, CategoryId=3 , IsHome=true, Image="4.jpg"},
                new Product() {Name="Sony Kd-55xd7005B 55 140 Ekran 4K Uydu Alıcılı Smart Led TV" ,Description="4K X-Realisty PRO Görüntü İşlemcisi *Marshmallow 6.0 *Digital Sound Enhancement Engine *Triluminos Ekran",Price=3500 , Stock=500, IsApproved=true, CategoryId=3 , Image="5.jpg" },

                new Product() {Name="Apple Iphone 6 32GB Apple Türkiye Garantili" ,Description="Dokunmatik ekranlı akıllı cep telefonları, hemen herkesin cebinde yer almaya devam edip sektöre yön veren markaların ortaya koyduğu ürünler farklı kullanım alanlarının oluşmasına da zemin hazırlıyor",Price=2999 , Stock=1000, IsApproved=true, CategoryId=4 , IsHome=true , Image="1.jpg"},
                new Product() {Name="Apple Iphone 7 32GB Apple Türkiye Garantili" ,Description="iPhone 7,iPhone deneyiminizi daha iyi bir hale getriyor.En önemli özellikler önemli ölçüde gelişiyor, değişiyor. Gelişmiş yepyeni kamera sistemleri, bir iPhone'da şimdiye kadar sunulan en iyi performans ve pil ömrü, etkileyici stereo hoparlörler, bugüne kadarki en canlı ve en renkli ekran, suya ve sıçramalara dayanıklı tasarım.Kısacası, her milimetresiyle çok güçlü bir telefon.",Price=3500 , Stock=400, IsApproved=true, CategoryId=4 , IsHome=true , Image="2.jpg"},
                new Product() {Name="Apple Iphone 6S 32GB Apple Türkiye Garantili" ,Description="iPhone 6S, iPhone 6 ile aynı tasarıma sahiptir, ancak materyal anlamında güçlendirilmiş 7000 serisi alüminyum kullanılmıştır.[3] Arkasında, iPhone yazısının altında yer alan ibaresi, dış görünümde yer alan tek belirgin farklılıktır. iPhone 6S, selefi iPhone 6'dan 0.2 mm daha kalın ve %10 oranında daha ağırdır.",Price=2800 , Stock=100, IsApproved=true, CategoryId=4 , IsHome=true , Image="3.jpg"},
                new Product() {Name="Case 4U Manyetik Mıknatıslı Araç içi Telefon Tutucu" ,Description="Araç için mıktanıslı tutucu.",Price=10 , Stock=5000, IsApproved=true, CategoryId=4 , Image="4.jpg" },
                new Product() {Name="Xiaomi Mi 5S 64GB Ithalatçı Garantili" ,Description="Kullanıcıların yenilikleri kolayca farkedebileceği androidin yeni yıldızı bu sefer yeni bir modelle karşınızda.",Price=3000 , Stock=1000, IsApproved=true, CategoryId=4, Image="5.jpg" },

            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            base.Seed(context);
        }

    }
}