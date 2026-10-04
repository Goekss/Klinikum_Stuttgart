# 🏥 Klinikum Stuttgart - Hospital Management System

<p align="center">
  <img src="https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET Framework 4.7.2" />
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/Windows%20Forms-0078D7?style=for-the-badge&logo=windows&logoColor=white" alt="Windows Forms" />
  <img src="https://img.shields.io/badge/MS%20SQL%20Server-CC292B?style=for-the-badge&logo=microsoftsqlserver&logoColor=white" alt="SQL Server" />
  <img src="https://img.shields.io/badge/License-MIT-yellow?style=for-the-badge" alt="License" />
</p>

<p align="center">
  <b>🌐 Sprachen / Diller / Languages:</b><br>
  <a href="#-deutsch">🇩🇪 Deutsch</a> &nbsp;|&nbsp;
  <a href="#-t%C3%BCrk%C3%A7e">🇹🇷 Türkçe</a> &nbsp;|&nbsp;
  <a href="#-english">🇬🇧 English</a>
</p>

---

## 🇩🇪 Deutsch

### 👋 Herzlich Willkommen!
**Klinikum Stuttgart** ist ein modernes, benutzerfreundliches Krankenhausverwaltungssystem (Desktop-Anwendung), das mit **C# Windows Forms** und **Microsoft SQL Server** entwickelt wurde.

Das Projekt entstand aus Leidenschaft für die Softwareentwicklung, um reale Krankenhausabläufe – von der Terminvergabe über die Patientenbetreuung bis hin zur Verwaltung durch das Sekretariat – einfach, intuitiv und digital zu lösen.

---

### ✨ Was bietet das System? (Hauptmodule)

#### 1. 🚪 Haupteingang (`FormEINGANG`)
Ein zentraler Willkommensbildschirm mit direkter Weiterleitung für:
* 🩺 **Patienten**
* 👨‍⚕️ **Ärzte**
* 📋 **Sekretariat & Verwaltung**

#### 2. 🩺 Patientenbereich
* **Registrierung & Login:** Schnelle Anmeldung mit Bürger-ID und Passwort.
* **Termin buchen:** Fachrichtung (Kardiologie, Chirurgie etc.) und Arzt auswählen, freie Termine prüfen und mit wenigen Klicks reservieren.
* **Beschwerden angeben:** Vorab-Notizen für den behandelnden Arzt hinterlassen.
* **Terminhistorie & Profil:** Vergangene Termine einsehen und persönliche Daten jederzeit aktualisieren.

#### 3. 👨‍⚕️ Ärztebereich
* **Sicherer Login:** Zugriff nur für registriertes medizinisches Personal.
* **Tagesübersicht:** Alle anstehenden Patiententermine und Details auf einen Blick.
* **Patientenbeschwerden:** Detaillierte Vorabinformationen der Patienten direkt einsehen.
* **Klinik-Mitteilungen:** Wichtige Bekanntmachungen des Hauses sofort lesen.
* **Profilverwaltung:** Eigene Fachrichtung und Zugangsdaten anpassen.

#### 4. 📋 Sekretariat & Klinikleitung
* **Live-Dashboard:** Aktuelle Ärzte- und Fachrichtungslisten im Überblick.
* **Terminplanung:** Neue Terminslots für Ärzte anlegen und freigeben.
* **Ärzteverwaltung (CRUD):** Neue Ärzte anlegen, Daten aktualisieren oder bei Bedarf entfernen.
* **Fachabteilungen (CRUD):** Medizinische Abteilungen flexibel erstellen und verwalten.
* **Rundschreiben:** Mitteilungen für das gesamte Klinikpersonal veröffentlichen.
* **Termin-Gesamtliste:** Komplette Übersicht aller vergebenen und offenen Termine.

---

### 🗄️ Datenbank & Einrichtung
Das Projekt nutzt **Microsoft SQL Server (ADO.NET)** für eine sichere und strukturierte Datenspeicherung.
* Die vorbereitete Datenbankdatei [`Klinikum_Stuttgart_MicrosoftSqlServer_All_DATA.bacpac`](./Klinikum_Stuttgart_MicrosoftSqlServer_All_DATA.bacpac) liegt direkt im Projektordner.
* In SSMS einfach über **"Import Data-tier Application"** importieren.
* Den eigenen Connection-String in [`SQLverbindung.cs`](./Klinikum_Stuttgart/SQLverbindung.cs) eintragen – fertig!

---

### 🚀 Schnellanleitung zum Starten
```powershell
# Direkt die fertige Anwendung starten:
Start-Process .\Klinikum_Stuttgart\bin\Debug\Klinikum_Stuttgart.exe
```

---

<br>

## 🇹🇷 Türkçe

### 👋 Merhaba ve Hoş Geldiniz!
**Klinikum Stuttgart**, sağlık kuruluşlarının günlük operasyonlarını kolaylaştırmak ve uçtan uca dijitalleştirmek için **C# Windows Forms** ve **Microsoft SQL Server** kullanılarak geliştirilmiş samimi ve kapsamlı bir hastane otomasyon sistemidir.

Yazılım geliştirme sürecinde pratik yapmak, gerçek dünya senaryolarını (hasta-doktor-sekreterya etkileşimleri) modellemek ve temiz bir masaüstü deneyimi sunmak amacıyla özenle hazırlandı.

---

### ✨ Neler Yapabilirsiniz? (Modüller)

#### 1. 🚪 Ana Giriş Kapısı (`FormEINGANG`)
Kullanıcıyı karşılayan ve tek tıkla doğru panele yönlendiren giriş ekranı:
* 🩺 **Hasta Girişi**
* 👨‍⚕️ **Doktor Girişi**
* 📋 **Sekreterya Girişi**

#### 2. 🩺 Hasta Modülü
* **Kolay Kayıt ve Giriş:** Kimlik numarası (BürgerID) ve şifre ile sisteme anında dahil olma.
* **Akıllı Randevu Alma:** Poliklinik (branş) ve hekim seçimi yaparak boş randevu saatlerini listeleme.
* **Şikayetini Paylaş:** Muayene öncesinde doktora iletilmek üzere şikayet metni ekleme.
* **Geçmişim & Profil:** Eski randevuları takip etme ve iletişim/şifre bilgilerini güncelleme.

#### 3. 👨‍⚕️ Doktor Masası
* **Kişiselleştirilmiş Panel:** Giriş yapan hekime özel randevu listesi.
* **Hasta Şikayetlerini İnceleme:** Randevuya tıklayarak hastanın belirttiği şikayeti anında görme.
* **Duyuru Takibi:** Hastane yönetiminin yayınladığı güncel anons ve duyuruları okuma.
* **Profil Düzenleme:** Branş ve erişim bilgilerini güncelleme.

#### 4. 📋 Sekreterya & Yönetim Merkezi
* **Merkezi İzleme:** Tüm aktif branşları ve görevli doktorları tek ekranda görme.
* **Randevu Oluşturma:** Tarih ve saat belirleyerek hekimlere yeni randevu slotları açma.
* **Doktor Yönetimi (CRUD):** Doktor ekleme, güncelleme ve silme işlemleri.
* **Branş Yönetimi (CRUD):** Yeni poliklinik/servis tanımlama ve düzenleme.
* **Genel Duyuru Sistemi:** Tüm hastane personeline anında bilgilendirme mesajı gönderme.
* **Toplu Randevu Listesi:** Sistemdeki tüm randevuları filtreleme ve inceleme.

---

### 🗄️ Veritabanı Kurulumu
* Proje kök dizinindeki [`Klinikum_Stuttgart_MicrosoftSqlServer_All_DATA.bacpac`](./Klinikum_Stuttgart_MicrosoftSqlServer_All_DATA.bacpac) yedeğini SQL Server Management Studio (SSMS) üzerinden *Import Data-tier Application* ile içeri aktarabilirsiniz.
* [`SQLverbindung.cs`](./Klinikum_Stuttgart/SQLverbindung.cs) içindeki bağlantı cümlesini kendi yerel SQL Server adresinizle eşleştirmeniz yeterlidir.

---

### 🚀 Terminalden Tek Tıkla Çalıştırma
```powershell
# Derlenmiş uygulamayı bağımsız pencerede başlatır:
Start-Process .\Klinikum_Stuttgart\bin\Debug\Klinikum_Stuttgart.exe
```

---

<br>

## 🇬🇧 English

### 👋 Welcome!
**Klinikum Stuttgart** is a complete, user-friendly Hospital Information & Management desktop system crafted with **C# Windows Forms** and **Microsoft SQL Server**.

Designed with care and passion for building practical, real-world software, it digitizes core healthcare workflows including patient appointments, doctor schedules, department management, and hospital announcements.

---

### ✨ Key Modules & Capabilities

#### 1. 🚪 Gateway Portal (`FormEINGANG`)
A welcoming hub providing instant navigation to three dedicated areas:
* 🩺 **Patient Portal**
* 👨‍⚕️ **Doctor Portal**
* 📋 **Secretariat / Administration Portal**

#### 2. 🩺 Patient Experience
* **Sign Up & Authentication:** Quick registration with Citizen ID and password.
* **Easy Appointment Booking:** Filter by specialty, choose a doctor, browse open slots, and confirm appointments.
* **Symptom / Complaint Notes:** Patients can explain their health complaints ahead of time.
* **History & Profile Management:** Track past visits and update profile or contact details anytime.

#### 3. 👨‍⚕️ Doctor Workspace
* **Personalized Schedule:** Automatic listing of all assigned patient appointments.
* **Patient Complaints at a Glance:** Click on any appointment to review patient symptoms instantly.
* **Internal Announcements:** Stay informed with clinic-wide notices from management.
* **Profile Settings:** Update specialty and security credentials easily.

#### 4. 📋 Secretariat & Hospital Operations
* **Live Overview:** Real-time visibility into active clinics and medical personnel.
* **Slot Generation:** Schedule new date/time appointment slots for doctors.
* **Doctor Administration (CRUD):** Add, update, or remove doctor profiles.
* **Department Administration (CRUD):** Manage medical units and departments seamlessly.
* **Hospital Broadcasting:** Dispatch announcements to all medical staff in one click.
* **Master Appointment List:** Comprehensive log of all booked and vacant appointments.

---

### 🗄️ Database Setup
* A pre-built database archive [`Klinikum_Stuttgart_MicrosoftSqlServer_All_DATA.bacpac`](./Klinikum_Stuttgart_MicrosoftSqlServer_All_DATA.bacpac) is included in the root directory.
* Import it into SQL Server via SSMS (*Import Data-tier Application*).
* Update your connection string in [`SQLverbindung.cs`](./Klinikum_Stuttgart/SQLverbindung.cs) and you're good to go!

---

### 🚀 Quick Run from Terminal
```powershell
# Launch the pre-compiled application:
Start-Process .\Klinikum_Stuttgart\bin\Debug\Klinikum_Stuttgart.exe
```

---

## 🤝 İletişim & Katkı / Kontakt / Contact
Sorularınız, geri bildirimleriniz veya katkılarınız için her zaman bir **Issue** veya **Pull Request** açabilirsiniz. ⭐ Beğendiyseniz projeye yıldız vermeyi unutmayın!

---

## 📄 Lizenz / Lisans / License
Dieses Projekt steht unter der [MIT License](LICENSE). / Bu proje MIT Lisansı ile korunmaktadır. / Distributed under the MIT License.
