# 👩‍💻 Kişisel Portföy Projesi - .NET Core 8.0

Bu proje, **M&Y Yazılım Akademi** danışmanlığı ve **Murat Yücedağ** hocamızın eğitmenliğinde, .NET Core 8.0 kullanılarak geliştirilmiş bir kişisel portföy web uygulamasıdır. Amaç, yazılım geliştirici olarak eğitim, deneyim, projeler ve iletişim bilgilerimi modern bir yapıyla sergileyebilmek ve aynı zamanda içerikleri yönetebileceğim bir **Admin Paneli** oluşturmaktır.

---

## 🚀 Kullanılan Teknolojiler

- ✅ **ASP.NET Core 8.0** (MVC mimarisi)
- ✅ **Entity Framework Core** – Code First yaklaşımı ile MSSQL veritabanı bağlantısı
- ✅ **ViewComponent** – Sayfaları dinamik veriyle doldurmak için
- ✅ **PartialView** – UI'da kod tekrarını azaltmak ve bileşenleri ayırmak için
- ✅ **SweetAlert** – Form işlemleri sonrası kullanıcıya görsel geri bildirim vermek için
- ✅ **Tek katmanlı mimari** – Hızlı ve doğrudan geliştirme yaklaşımı

---

## 🧱 Proje Yapısı

Proje tek katmanlı bir yapıya sahiptir ve aşağıdaki `DbSet` tablolarıyla veritabanı ilişkileri kurulmuştur:


public DbSet<Education> Educations { get; set; }
public DbSet<Experience> Experiences { get; set; }
public DbSet<Message> Messages { get; set; }
public DbSet<Service> Services { get; set; }
public DbSet<Testimonial> Testimonials { get; set; }
public DbSet<Skill> Skills { get; set; }
public DbSet<Category> Categories { get; set; }
public DbSet<Portfolio> Portfolios { get; set; }
public DbSet<Work> Works { get; set; }
public DbSet<About> Abouts { get; set; }
public DbSet<Istatistik> Istatistiks { get; set; }
public DbSet<Contact> Contacts { get; set; }
public DbSet<SocialMedia> SocialMedias { get; set; }
public DbSet<ProjectImage> ProjectImages { get; set; }


🖥️ Uygulama Modülleri
🎨 UI Arayüzü
Kullanıcıların ziyaret ettiği ana sayfa, yetenekler, projeler, eğitimler, iletişim gibi bölümler içerir.

Sayfa düzenleri ViewComponent ve PartialView yapılarıyla bölünerek sade ve sürdürülebilir bir yapı oluşturulmuştur.

🧑🏻‍💻 Admin Panel
Admin paneli üzerinden aşağıdaki modüller yönetilebilir:

📍 Deneyimlerim

CRUD işlemleri yapılabilir.

Güncelleme formuna ID üzerinden veri otomatik çekilir.

📍 Eğitimlerim

Eğitim geçmişi yönetilebilir.

CRUD işlemleri aktif ve güncelleme özelliği mevcuttur.

📍 Projelerim / Portföy

Projeler kart yapısı ile gösterilir.

Her projeye ait görseller ve açıklamalar eklenebilir.

![Ekran görüntüsü 2025-04-30 004647](https://github.com/user-attachments/assets/d4494811-f9d2-4bc8-902d-5114731b2525)

📍 İletişim / Mesajlar

Sol kısımda iletişim bilgileri, sağ kısımda mesaj gönderme formu bulunur.

Mesaj gönderildikten sonra SweetAlert ile bilgilendirme yapılır.

![Ekran görüntüsü 2025-04-30 001240](https://github.com/user-attachments/assets/6c3f71a3-3617-4d0f-8cfe-a579f61d5cc0)

📍 Yetenekler / Skills

Teknik beceriler listelenir ve güncellenebilir.

![Ekran görüntüsü 2025-04-30 001742](https://github.com/user-attachments/assets/1e7040f3-1b0d-421d-b482-8b9a897a5c2a)


📍 Hakkımda / About

Hakkımda bilgileri düzenlenebilir.

![Ekran görüntüsü 2025-04-30 001335](https://github.com/user-attachments/assets/e6da38a9-1e6c-475c-96c1-3ea1e1ab797f)


📍 İstatistikler / Istatistiks

Sitede yer alan genel bilgiler dinamik şekilde güncellenebilir.

📍 Sosyal Medya Linkleri

LinkedIn, GitHub vb. hesaplar admin panelden girilerek ana sayfaya yansıtılır.

