# 📦 Kapsamlı Stok, Müşteri ve Sipariş Yönetim Sistemi (C# Windows Forms)

## 🌟 Projeye Genel Bakış

Bu proje, C# Windows Forms kullanılarak geliştirilmiş, küçük ve orta ölçekli işletmelerin (KOBİ) günlük operasyonlarını kolaylaştırmak ve otomatikleştirmek için tasarlanmış bir masaüstü uygulamasıdır. 🏪 Stok envanterini, müşteri ilişkilerini (CRM) ve sipariş süreçlerini verimli bir şekilde yönetir. Kullanıcı dostu arayüzü ile bu uygulama, envanter takibini, müşteri veritabanı yönetimini ve hızlı sipariş oluşturmayı tek bir platformda birleştirerek iş akışlarını önemli ölçüde hızlandırır ve hataları azaltır. 🚀📊

## ✨ Temel Özellikler ve Modüller

Uygulama temel olarak aşağıdaki ana modüllerden oluşur:

### 1. 🏠 Ana Menü

*   Uygulamanın merkezi gezinme noktasıdır. Tüm ana yönetim modüllerine hızlı ve kolay erişim sağlar.
*   **Modüller:** "Ürün Ekle" ➕, "Ürün Düzenle/Ara" ✏️🔍, "Müşteri Ekle" 🧑‍🤝‍➕, "Müşteri Düzenle/Ara" 🧑‍🤝‍✏️🔍, "Sipariş Oluştur" 🛒✍️.

### 2. ➕ Ürün Ekleme Modülü

*   Sisteme yeni ürünlerin kaydedilmesi için kullanılır.
*   **Giriş Alanları:** Ürün ID 🆔, Ürün Adı 🏷️, Ürün Markası 🏭, Ürün Fiyatı 💰 (NumericUpDown), Ürün Miktarı 🔢 (NumericUpDown), Ürün Kategorisi 🗂️ (Açılır Liste - örn. Eğlence, Teknoloji, Kırtasiye), Ürün Açıklaması 📝.
*   **Kullanıcı Geri Bildirimi:**
    *   Başarılı kayıt sonrası "Ürün ekleme işlemi başarılı!" onayı. ✅
    *   Eksik alan bırakılırsa "Eksik ürün kaydı." uyarısı. ⚠️

### 3. ✏️🔍 Ürün Yönetimi (Düzenle/Ara) Modülü

*   Mevcut ürünleri görüntülemek, güncellemek, aramak veya silmek için kullanılır.
*   **Arama Fonksiyonu:** "ID'ye göre Ara" çubuğu ile hızlı arama. 🔎
*   **Veri Listeleme:** Tüm ürünler DataGridView (tablo) formatında listelenir.
*   **Kolay Düzenleme:** Tablodan seçilen ürünün bilgileri yandaki alanlara otomatik olarak yüklenir.
*   **Veri Yönetim Butonları:**
    *   **"Güncelle":** Değişiklikleri kaydeder. ✅
    *   **"Sil":** Seçili ürünü sistemden kaldırır. 🗑️
    *   **"Temizle":** Tüm giriş alanlarını temizler. 🧹

### 4. 🧑‍🤝‍➕ Müşteri Ekleme Modülü

*   Yeni müşteri profilleri oluşturmak için kullanılır.
*   **Giriş Alanları:** Müşteri ID 🆔, Müşteri Adı 👤, Telefon Numarası 📞, Adres 📍, ve E-posta 📧.

### 5. 🧑‍🤝‍✏️🔍 Müşteri Yönetimi (Düzenle/Ara) Modülü

*   Kayıtlı müşteri bilgilerini yönetmek, güncellemek, aramak ve silmek için kullanılır.
*   **Arama Fonksiyonu:** "ID'ye göre Ara" ile anında müşteri arama. 🔎
*   **Kapsamlı Listeleme:** Tüm müşteri kayıtları DataGridView'de listelenir.
*   **Veri Yönetim Butonları:** "Güncelle", "Sil", "Temizle".

### 6. 🛒✍️ Sipariş Oluşturma Modülü

*   Seçili müşteriler için mevcut ürünlerden yeni siparişler oluşturma sürecini yönetir.
*   **İki Aşamalı Seçim:** Müşteri ve ürün seçimi için ayrı DataGridView'ler.
*   **Dinamik Toplam Hesaplama:** Siparişin toplam tutarı anlık olarak hesaplanır ve görüntülenir. 💲
*   **"Sipariş Ver":** Siparişi onaylar ve kaydeder. 🎉
*   **Fatura Oluşturma ve Yazdırma (PDF):** Sipariş sonrası fatura PDF olarak kaydedilebilir veya doğrudan yazdırılabilir. 📄🖨️

## 💻 Teknolojiler

*   **Programlama Dili:** C#
*   **Arayüz (GUI):** Windows Forms (WinForms)
*   **Veritabanı:** Microsoft SQL Server (MSSQL) 💾
*   **Veritabanı Bağlantısı:** ADO.NET (`Connection.cs` üzerinden düzenlenebilir) 🔗

## 🚀 Kurulum ve Çalıştırma

Projeyi sisteminizde çalıştırmak için aşağıdaki adımları izleyin:

1.  **MSSQL Veritabanı Kurulumu:**
    *   Proje dizinindeki "Veritabani" klasörüne gidin. 📁
    *   İçindeki `.sql` betiğini Microsoft SQL Server'da çalıştırarak gerekli veritabanı ve tabloları oluşturun. 🛠️

2.  **Bağlantı Dizesini (Connection String) Güncelleme:**
    *   `UrunSatis` klasöründeki `Connection.cs` dosyasını açın. 📝
    *   İçindeki veritabanı bağlantı dizesini kendi MSSQL sunucu bilgilerinize göre güncelleyin.
        ```csharp
        // Örnek:
        "Data Source=SUNUCU_ADINIZ;Initial Catalog=VERITABANI_ADINIZ;Integrated Security=True;"
        ```
    *   Değişiklikleri kaydedin. 💾

3.  **Projeyi Çalıştırma:**
    *   Visual Studio ile `.sln` uzantılı proje dosyasını açın. 📂
    *   Projeyi derleyin (Build). 🏗️
    *   Uygulamayı çalıştırın (Start veya Ctrl+F5). ▶️

## 🎯 Kullanım Alanları

Bu uygulama; ürünlerini ve müşterilerini sistematik olarak kaydetmek, mevcut envanteri takip etmek ve hızlıca sipariş oluşturmak isteyen küçük işletmeler, butikler ve e-ticaret girişimcileri için ideal bir çözümdür. 📈✨
