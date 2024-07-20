# Kalori Takip Programı

Bu proje, kullanıcıların günlük kalori, protein, karbonhidrat ve yağ alımlarını takip etmelerini sağlayan bir Windows Forms uygulamasıdır. Proje, katmanlı mimari ve modern yazılım desenleri kullanılarak geliştirilmiştir.

## Özellikler 🌟

- **Günlük Kalori Takibi**: Kullanıcıların günlük kalori, protein, karbonhidrat ve yağ alımlarını hesaplar.
- **Admin Kullanıcı Paneli**: Adminler yemek ekleyebilir, silebilir ve kullanıcı istatistiklerini görüntüleyebilir.
- **Kullanıcı Paneli**: Kullanıcılar kendilerine özel yemekler ekleyebilir ve besin değerlerini tarih aralıklarına göre görebilir.
- **Yapay Zeka Entegrasyonu**: Günlük besin öğeleri yapay zekaya yorumlatılır (Gemini API).
- **Grafik Görselleştirme**: Besin değerlerini grafikler üzerinden görüntüleme.

## Kullanılan Teknolojiler 🛠️

- **Windows Forms**: Uygulamanın kullanıcı arayüzü için kullanıldı.
- **Katmanlı Mimari**: Projede katmanlı mimari kullanıldı.
- **Repository Pattern**: Veri erişimi ve iş mantığını ayrıştırmak için Repository Pattern uygulandı.
- **AutoMapper**: Nesneler arasındaki veri dönüşümleri için kullanıldı.
- **Entity Framework Core**: ORM yapısı olarak kullanıldı.
- **Unit of Work**: İş birliği ve veri bütünlüğü sağlamak için Unit of Work tasarım deseni kullanıldı.
- **Yapay Zeka (Gemini API)**: Günlük besin öğeleri yapay zekaya yorumlatıldı.

## Kullanılan Paketler 📦

- `AutoMapper` (13.0.1)
- `Magick.NET.Core` (13.6.0)
- `Microsoft.EntityFrameworkCore.SqlServer` (8.0.3)
- `Microsoft.EntityFrameworkCore.Tools` (8.0.3)
- `Microsoft.EntityFrameworkCore.Design` (8.0.4)
- `Newtonsoft.Json` (13.0.3)
- `RestSharp` (110.2.0)
