# 🗳️ Veri Tabanlı Parti Seçim Analizi 📊

Bu proje, SQL tabanlı bir veritabanı ile çalışarak seçim sonuçlarını yönetmenize olanak tanıyan bir masaüstü uygulamasıdır. Kullanıcılar ilçe bazında parti oylarını girebilir, toplam oyları grafiklerle inceleyebilir ve ilçe bazında detaylı oy oranlarını görebilir.

## Özellikler 🚀

- İlçe bazında oy girişi yapılabilir.
- Partilere ait toplam oylar grafiksel olarak gösterilir.
- İlçe seçimine göre partilerin oy oranları görselleştirilebilir.
- Grafikler ve ilerleme çubukları (progress bar) ile kolay analiz.

---

## Veritabanı Tablosu 🗄️

Proje, oy bilgilerini saklamak için kullanılan bir sql veritabanına sahiptir. Aşağıda sql tablo yapısı açıklanmıştır:

### Tablo: `Tbl_District`

| Sütun Adı    | Veri Tipi   | Açıklama                                                |
|--------------|-------------|--------------------------------------------------------|
| `DistrictID` | `TINYINT`   | Otomatik artan birincil anahtar. İlçe sayısı az olduğu için `TINYINT` seçilmiştir. |
| `DistrictName` | `VARCHAR(20)` | İlçe adını saklar.                                     |
| `Party_A`    | `SMALLINT`  | A Partisi'ne ait oy sayısı.                             |
| `Party_B`    | `SMALLINT`  | B Partisi'ne ait oy sayısı.                             |
| `Party_C`    | `SMALLINT`  | C Partisi'ne ait oy sayısı.                             |
| `Party_D`    | `SMALLINT`  | D Partisi'ne ait oy sayısı.                             |
| `Party_E`    | `SMALLINT`  | E Partisi'ne ait oy sayısı.    

## 🖥️ Uygulama Ekranları

### 1️⃣ Giriş Ekranı
Giriş ekranı, kullanıcıların seçim verilerini girebileceği ana ekranı temsil eder. Bu ekranda, ilçelerin adı ve her bir parti için toplam oy sayıları girilebilir. Kullanıcı, ilçenin adını yazarak her bir parti için oy sayısını girdikten sonra "Oy Girişi Yap" butonuna tıklayarak verileri veritabanına kaydedebilir.

<p align="center">
  <img src="https://github.com/EdaYaren/Csharp_DataBasedPartyElectionAnalysis/blob/main/Vote%20Entry.png" alt="Giriş Ekranı" width="500">
</p>
---

### 2️⃣ Grafik Ekranı
Grafik ekranı, seçim sonuçlarının görsel olarak sunulduğu alandır. Bu ekranda, kullanıcılar ilçeyi seçerek, ilgili ilçenin parti bazında oy oranlarını grafiksel olarak görebilir. Ayrıca, genel seçim sonuçları da burada bar grafiği şeklinde gösterilir. İlçe seçildikçe, her bir partinin oy oranları, grafiklerdeki barlarla birlikte ilerler. Ayrıca, her bir partinin oy sayıları, progress barlar üzerinde ve metin olarak gösterilir. 

<p align="center">
  <img src="https://github.com/EdaYaren/Csharp_DataBasedPartyElectionAnalysis/blob/main/Graphics%20Screen.png" alt="Giriş Ekranı" width="800">
</p>

---

## Kullanılan Teknolojiler 💻

- **C#**: Uygulamanın geliştirilmesi için kullanılan ana programlama dili.
- **Windows Forms**: Grafik kullanıcı arayüzü (GUI) geliştirmek için kullanılmıştır.
- **SQL Server**: Veritabanı yönetimi için kullanılmıştır.
- **Chart Control**: Partilerin toplam oy oranlarını görselleştirmek için grafik çiziminde kullanılmıştır.

## 🚀 Çalıştırma Talimatları

1. **Proje Dosyasını İndir:**  
   - Proje klasörünü indirin veya klonlayın.

2. **Uygulamayı Çalıştır:**  
   - Aşağıdaki dizinde bulunan **DatabaseElectionProject.exe** dosyasını çalıştırın:  
     ```
     Data Based Party Election Analysis\DatabaseElectionProject\DatabaseElectionProject\bin\Debug\
     ```

 **Not:**  
   - Veritabanı bağlantısı için **SQL Server**'ınızın çalıştığından emin olun.

