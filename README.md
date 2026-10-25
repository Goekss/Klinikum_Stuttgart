# 🏥 Klinikum Stuttgart – Hospital Management System

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

> **Hinweis / Not / Note:** Dies ist ein **Portfolio- und Lernprojekt** (Mock/Demo), kein produktionsreifes Medizinprodukt.
> Bu bir **portfolyo / öğrenme projesidir** (mock/demo), üretim ortamı için hazır bir tıbbi ürün değildir.
> This is a **portfolio / learning project** (mock/demo), not a production-ready medical product.

---

## 🇩🇪 Deutsch

### 👋 Herzlich Willkommen!

**Klinikum Stuttgart** ist eine Desktop-Anwendung zur Verwaltung von Krankenhausabläufen: Patientenregistrierung, Terminvergabe, Arztverwaltung, Fachabteilungen und klinikweite Mitteilungen. Die Oberfläche ist vollständig auf **Deutsch**.

Das Projekt ist als **vorzeigbares Demo-System** gedacht: Es lässt sich nach dem Klonen ohne Datenbankkonfiguration starten, enthält Beispieldaten und ist so strukturiert, dass es zu einem echten Produkt weiterentwickelt werden kann.

---

### ✨ Funktionsumfang

| Modul | Funktionen |
|---|---|
| 🚪 Haupteingang | Zentrale Startseite mit Weiterleitung zu Patient, Arzt und Sekretariat |
| 🩺 Patient | Registrierung, Login, freie Termine suchen (Fachrichtung → Arzt), Termin buchen, Beschwerden hinterlegen, Terminhistorie, Profil bearbeiten |
| 👨‍⚕️ Arzt | Login, eigene Terminliste, Patienten-Beschwerden einsehen, Klinik-Mitteilungen lesen, Profil bearbeiten |
| 📋 Sekretariat | Ärzte- und Fachrichtungslisten, Terminslots anlegen, Ärzte-CRUD, Fächer-CRUD, Mitteilungen versenden, Gesamtliste aller Termine |

> Der Arztbereich listet **alle** Termine des angemeldeten Arztes – nicht nur die des aktuellen Tages.

---

### 🧰 Tech-Stack

| Bereich | Verwendet |
|---|---|
| Sprache | C# (C# 5-kompatibel, klassisches Projektformat) |
| UI | Windows Forms (`WinExe`) |
| Zielplattform | .NET Framework **4.7.2** |
| Datenbank | Microsoft SQL Server (Express, LocalDB oder höher) |
| Datenzugriff | ADO.NET (`System.Data.SqlClient`), SQL-Skripte direkt in den Formularen |
| Externe Pakete | **keine** (nur .NET-Framework-Bordmittel, kein NuGet) |
| IDE / Build | Visual Studio 2022 (Solution Format 12.00, VS 17.7) oder MSBuild |
| Lizenz | MIT |

---

### 📦 Voraussetzungen

* Windows 10/11
* **.NET Framework 4.7.2** (Runtime ist in Windows enthalten; für den Build wird das Developer Pack bzw. Visual Studio benötigt)
* Zum **Ausführen**: keine weiteren Tools
* Zum **Selbstbauen**: Visual Studio 2022 mit Workload „.NET-Desktopentwicklung“ *oder* MSBuild
* Zum **Verbinden mit einer echten Datenbank**: SQL Server (Express genügt) + SQL Server Management Studio (SSMS)
* Zum **Demo-Modus ohne Setup**: SQL Server Express **LocalDB** oder eine laufende Express-Instanz `.\SQLEXPRESS`

---

### 🚀 Schnellstart

#### Variante A – Demo-Modus (kein Setup nötig)

```powershell
Start-Process .\Klinikum_Stuttgart\bin\Debug\Klinikum_Stuttgart.exe
```

Die Anwendung sucht beim Start automatisch nach einer lokalen SQL-Server-Instanz
(`(LocalDB)\MSSQLLocalDB`, `.\SQLEXPRESS`, `localhost`), legt bei Bedarf die Datenbank
`Klinikum_Stuttgart_Demo` an, spielt Schema und Beispieldaten ein und öffnet das Hauptfenster.
Im Fenstertitel erscheint dann **„Klinikum Stuttgart – Demo-Modus“**.
Die Login-Formulare sind mit Demo-Zugangsdaten vorbelegt – ein Klick auf „Einloggen“ genügt.

Findet die Anwendung keinen SQL Server, erscheint eine Meldung mit Einrichtungsanleitung statt eines Absturzes.

#### Variante B – Eigene Datenbank verwenden

1. **Datenbank bereitstellen** – eine der beiden Möglichkeiten:
   * [`Klinikum_Stuttgart_MicrosoftSqlServer_All_DATA.bacpac`](./Klinikum_Stuttgart_MicrosoftSqlServer_All_DATA.bacpac) in SSMS über *„Data-tier Application importieren“* importieren, **oder**
   * [`Klinikum_Stuttgart_Demo.sql`](./Klinikum_Stuttgart/Database/Klinikum_Stuttgart_Demo.sql) in SSMS in einer neuen Datenbank ausführen (Schema + Beispieldaten, idempotent).
2. **Connection-String setzen** – genau **eine** Stelle, in [`App.config`](./Klinikum_Stuttgart/App.config):

   ```xml
   <connectionStrings>
     <add name="KlinikumConnectionString"
          connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=Klinikum_Stuttgart;Integrated Security=True"
          providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

   Bleibt der Wert leer, greift automatisch der Demo-Modus.
3. Anwendung starten (siehe Variante A) oder in Visual Studio mit **F5**.

> ⚠️ Der Connection-String steht **nicht mehr** im Quellcode. Die früher fest eingetragene
> Verbindung in `FormMitteilungen.cs` wurde entfernt – alle Formulare nutzen jetzt
> [`SQLverbindung.cs`](./Klinikum_Stuttgart/SQLverbindung.cs).

#### Variante C – Selbst kompilieren

```powershell
# In Visual Studio 2022: Klinikum_Stuttgart.sln öffnen und F5 drücken
# oder über MSBuild:
msbuild .\Klinikum_Stuttgart.sln /t:Build /p:Configuration=Debug
```

Ergebnis: `Klinikum_Stuttgart\bin\Debug\Klinikum_Stuttgart.exe`

> `dotnet build` funktioniert **nicht**, weil das Projekt das klassische (Nicht-SDK-)Format verwendet. Bitte MSBuild oder Visual Studio nutzen.

---

### 🔑 Demo-Zugänge

Im **Demo-Modus sind die Zugangsdaten bereits eingetragen** – einfach auf „Einloggen“ klicken.
Die Anwendung übernimmt automatisch den ersten Datensatz je Rolle, die Vorbelegung bleibt also auch nach eigenen Änderungen an den Stammdaten korrekt.

| Rolle | Bürger-ID | Passwort | Name |
|---|---|---|---|
| 👨‍⚕️ Arzt | `48160725390` | `4172` | Katrin Waldmann (Kardiologie) |
| 👨‍⚕️ Arzt | `17940263854` | `6418` | Markus Zeidler (Hals-Nasen-Ohren) |
| 👨‍⚕️ Arzt | `75832194066` | `1829` | Ulrike Sonnemann (Onkologie) |
| 📋 Sekretariat | `57301846299` | `4416` | Nadine Krämer |
| 📋 Sekretariat | `82640517399` | `2873` | Oliver Sandberg |
| 🩺 Patient | `34719285601` | `2468` | Leonie Hartmann |
| 🩺 Patient | `86204715933` | `8372` | Bernd Kuhlmann |
| 🩺 Patient | `51938472660` | `6153` | Sandra Petrov |

**Weitere Testdaten:** 12 Ärzte, 13 Fachrichtungen, 8 Patienten, 16 Termine (10 frei / 6 vergeben inkl. Beschwerden) und 5 Mitteilungen.
Beim Import der `.bacpac` gelten die Zugänge der Originaldatei; die Vorbelegung nutzt dann den ersten Datensatz der jeweiligen Tabelle.

---

### 🗄️ Datenbankschema

6 Tabellen, jeder Primärschlüssel ist ein `IDENTITY`-Feld. Es gibt **keine** Fremdschlüssel – Beziehungen werden über Textwerte hergestellt (z. B. `Tbl_Termine.TerminArzt` = „Vorname Nachname“).

| Tabelle | Spalten |
|---|---|
| `Tbl_Patient` | `Ptid` (smallint, identity), `PtName`, `PtNachname`, `PtBürgerID` (nchar(11)), `PtTelnummer`, `PtPasswort`, `PtGeschlecht` |
| `Tbl_Doktor` | `Drid` (tinyint, identity), `DrName`, `DrNachname`, `DrFachrichtung`, `DrBürgerID` (char(11)), `DrPasswort` |
| `Tbl_Sekretärin` | `Sekrid` (tinyint, identity), `SekrNameNachname`, `SekrBürgerID` (char(11)), `SekrPasswort` |
| `Tbl_Fach` | `Fachid` (tinyint, identity), `FachName` |
| `Tbl_Termine` | `Terminid` (int, identity), `TerminDatum` (Text, `TT.MM.JJJJ`), `TerminUhr` (Text, `HH:MM`), `TerminFach`, `TerminArzt`, `TerminStatus` (bit, Default `0` = frei), `Ptid`, `PatientBeschwerden` (varchar(80)) |
| `Tbl_Mitteilungen` | `MitteilungsId` (smallint, identity), `Mitteilung` (varchar(max)) |

---

### 🗂️ Projektstruktur

```text
Klinikum_Stuttgart/
├─ Klinikum_Stuttgart.sln                  Visual-Studio-Solution
├─ README.md
├─ LICENSE                                  MIT
├─ Klinikum_Stuttgart_MicrosoftSqlServer_All_DATA.bacpac   Datenbank-Export (Schema + Daten)
└─ Klinikum_Stuttgart/
   ├─ Program.cs                            Einstiegspunkt + globale Fehlerbehandlung
   ├─ SQLverbindung.cs                      zentrale Datenbankverbindung / Demo-Modus
   ├─ App.config                            Connection-String (KlinikumConnectionString)
   ├─ Database/
   │  └─ Klinikum_Stuttgart_Demo.sql        Schema + Beispieldaten (in die .exe eingebettet)
   ├─ Form*.cs / Form*.Designer.cs / *.resx 15 Formulare inkl. Layout und Bildern
   └─ Properties/                           AssemblyInfo, Ressourcen, Settings
```

| Formular | Modul | Aufgabe |
|---|---|---|
| `FormEINGANG` | Start | Weiterleitung zu den drei Portalen |
| `FormPatientLogin` | Patient | Anmeldung, Link zur Registrierung |
| `FormPatientRegistrierung` | Patient | Neuanlage eines Patienten |
| `FormPatientDetail` | Patient | Terminsuche/-buchung, Historie, Beschwerden |
| `FormPatientEinstellung` | Patient | Profil ändern |
| `FormDoktorLogin` | Arzt | Anmeldung |
| `FormDoktorDetail` | Arzt | Terminliste + Beschwerden des Patienten |
| `FormDoktorEinstellung` | Arzt | Menüfenster zum Profil |
| `FormDoktorBearbeitung` | Arzt | Profil (Fachrichtung, Passwort) ändern |
| `FormMitteilungen` | Arzt | Klinik-Mitteilungen anzeigen |
| `FormSekretariatLogin` | Sekretariat | Anmeldung |
| `FormSekretariatDetail` | Sekretariat | Übersicht, Terminslot anlegen, Mitteilung senden |
| `FormSekretariatDrPanel` | Sekretariat | Ärzte-CRUD |
| `FormSekretariatDrFächer` | Sekretariat | Fächer-CRUD |
| `FormSekTerList` | Sekretariat | Liste aller Termine |

---

### ⚠️ Bekannte Einschränkungen (bewusst offen)

Dieses Projekt ist ein Lern-/Demo-Stand. Für einen echten Einsatz fehlen unter anderem:

* **Passwörter im Klartext** (`PtPasswort`, `DrPasswort`, `SekrPasswort`) – kein Hashing, keine Salts
* **Zwei Abfragen mit String-Verkettung** (SQL-Injection-Risiko): `FormPatientDetail.cs` (Zimmer-/Terminabfrage) und `FormDoktorDetail.cs`
* **Keine Fremdschlüssel, Indizes oder Unique-Constraints** → keine referenzielle Integrität
* **Legacy-Datenzugriff**: `SQLverbindung.verbindung()` öffnet pro Aufruf eine neue Verbindung; einige Aufrufstellen schließen eine andere Instanz als die geöffnete (Aufräumen übernimmt der GC). Im Demo-Modus ist deshalb `Pooling=False` gesetzt.
* **Keine automatisierten Tests**, kein Logging, keine Async-Verarbeitung
* **Nur Deutsch** in der Oberfläche (keine Lokalisierung)
* Termin-Datum/-Uhrzeit als Text, Arztzuordnung über den Namen statt über IDs
* Große Bilder sind in den `.resx`-Dateien eingebettet und blähen das Repository auf

**Nächste sinnvolle Schritte:** Passwort-Hashing, restliche Abfragen parametrisieren, PK/FK + Indizes ergänzen, Repository-Schicht und Tests einführen, Internationalisierung.

---

<br>

## 🇹🇷 Türkçe

### 👋 Merhaba!

**Klinikum Stuttgart**, hastane iş akışlarını yöneten bir masaüstü uygulamasıdır: hasta kaydı, randevu verme, doktor yönetimi, branş yönetimi ve hastane duyuruları. Arayüz tamamen **Almanca**dır.

Proje bir **portfolyo / demo sistemi** olarak tasarlandı: Klonladıktan sonra veritabanı ayarı yapmadan çalışır, örnek verilerle gelir ve gerçek bir ürüne dönüştürülebilecek şekilde yapılandırılmıştır.

---

### ✨ Özellikler

| Modül | İşlevler |
|---|---|
| 🚪 Ana giriş | Hasta, doktor ve sekreterya portallarına yönlendirme |
| 🩺 Hasta | Kayıt, giriş, boş randevu arama (branş → doktor), randevu alma, şikayet yazma, randevu geçmişi, profil düzenleme |
| 👨‍⚕️ Doktor | Giriş, kendi randevu listesi, hasta şikayetlerini görüntüleme, duyuruları okuma, profil düzenleme |
| 📋 Sekreterya | Doktor ve branş listeleri, randevu slotu oluşturma, doktor CRUD, branş CRUD, duyuru gönderme, tüm randevuların listesi |

> Doktor paneli **sadece bugünün** değil, o doktorun **tüm** randevularını listeler.

---

### 🧰 Teknoloji Yığını

| Alan | Kullanılan |
|---|---|
| Dil | C# (C# 5 uyumlu, klasik proje formatı) |
| Arayüz | Windows Forms (`WinExe`) |
| Hedef platform | .NET Framework **4.7.2** |
| Veritabanı | Microsoft SQL Server (Express, LocalDB veya üstü) |
| Veri erişimi | ADO.NET (`System.Data.SqlClient`), SQL sorguları formların içinde |
| Harici paket | **yok** (sadece .NET Framework kitaplıkları, NuGet kullanılmıyor) |
| IDE / derleme | Visual Studio 2022 (Solution 12.00, VS 17.7) veya MSBuild |
| Lisans | MIT |

---

### 📦 Ön koşullar

* Windows 10/11
* **.NET Framework 4.7.2** (çalıştırmak için Windows'ta hazır gelir; derlemek için Developer Pack veya Visual Studio gerekir)
* **Çalıştırmak için** başka araç gerekmez
* **Derlemek için**: Visual Studio 2022 (".NET masaüstü geliştirme" iş yükü) *veya* MSBuild
* **Gerçek veritabanına bağlanmak için**: SQL Server (Express yeterli) + SQL Server Management Studio (SSMS)
* **Kurulumsuz demo modu için**: SQL Server Express **LocalDB** ya da çalışan bir `.\SQLEXPRESS` örneği

---

### 🚀 Hızlı Başlangıç

#### Seçenek A – Demo modu (kurulum gerekmez)

```powershell
Start-Process .\Klinikum_Stuttgart\bin\Debug\Klinikum_Stuttgart.exe
```

Uygulama açılışta yerel bir SQL Server örneği arar (`(LocalDB)\MSSQLLocalDB`, `.\SQLEXPRESS`, `localhost`),
gerekirse `Klinikum_Stuttgart_Demo` veritabanını oluşturur, şemayı ve örnek verileri yükler ve ana pencereyi açar.
Pencere başlığında **„Klinikum Stuttgart – Demo-Modus“** yazar.
Giriş formları demo hesaplarıyla önceden doldurulur – „Einloggen“ düğmesine basmak yeterlidir.

SQL Server bulunamazsa çökme yerine, kurulum adımlarını anlatan bir mesaj gösterilir.

#### Seçenek B – Kendi veritabanını kullanma

1. **Veritabanını hazırlayın** – iki yoldan biri:
   * [`Klinikum_Stuttgart_MicrosoftSqlServer_All_DATA.bacpac`](./Klinikum_Stuttgart_MicrosoftSqlServer_All_DATA.bacpac) dosyasını SSMS'te *"Data-tier Application Import"* ile içe aktarın, **veya**
   * [`Klinikum_Stuttgart_Demo.sql`](./Klinikum_Stuttgart/Database/Klinikum_Stuttgart_Demo.sql) script'ini SSMS'te yeni bir veritabanında çalıştırın (şema + örnek veriler, idempotent).
2. **Connection string'i ayarlayın** – tek bir yerde, [`App.config`](./Klinikum_Stuttgart/App.config):

   ```xml
   <connectionStrings>
     <add name="KlinikumConnectionString"
          connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=Klinikum_Stuttgart;Integrated Security=True"
          providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

   Boş bırakılırsa otomatik demo modu kullanılır.
3. Uygulamayı başlatın (Seçenek A) veya Visual Studio'da **F5**.

> ⚠️ Connection string artık **kodun içinde değil**. Daha önce `FormMitteilungen.cs` içine sabitlenen
> bağlantı kaldırıldı; tüm formlar [`SQLverbindung.cs`](./Klinikum_Stuttgart/SQLverbindung.cs) üzerinden bağlanır.

#### Seçenek C – Kendiniz derleyin

```powershell
# Visual Studio 2022: Klinikum_Stuttgart.sln dosyasını açın ve F5
# veya MSBuild ile:
msbuild .\Klinikum_Stuttgart.sln /t:Build /p:Configuration=Debug
```

Çıktı: `Klinikum_Stuttgart\bin\Debug\Klinikum_Stuttgart.exe`

> Proje klasik (SDK olmayan) formatta olduğu için `dotnet build` **çalışmaz**. MSBuild veya Visual Studio kullanın.

---

### 🔑 Demo hesapları

**Demo modunda alanlar önceden doldurulur** – tek yapılacak „Einloggen“ düğmesine basmak.
Uygulama her rol için ilk kaydı otomatik getirir; kendi eklediğiniz kayıtlardan sonra da doğru çalışır.

| Rol | Bürger-ID | Şifre | Ad |
|---|---|---|---|
| 👨‍⚕️ Doktor | `48160725390` | `4172` | Katrin Waldmann (Kardiyoloji) |
| 👨‍⚕️ Doktor | `17940263854` | `6418` | Markus Zeidler (KBB) |
| 👨‍⚕️ Doktor | `75832194066` | `1829` | Ulrike Sonnemann (Onkoloji) |
| 📋 Sekreterya | `57301846299` | `4416` | Nadine Krämer |
| 📋 Sekreterya | `82640517399` | `2873` | Oliver Sandberg |
| 🩺 Hasta | `34719285601` | `2468` | Leonie Hartmann |
| 🩺 Hasta | `86204715933` | `8372` | Bernd Kuhlmann |
| 🩺 Hasta | `51938472660` | `6153` | Sandra Petrov |

**Ek test verisi:** 12 doktor, 13 branş, 8 hasta, 16 randevu (10 boş / 6 dolu + şikayetler) ve 5 duyuru.
`.bacpac` içe aktarıldığında orijinal dosyadaki hesaplar geçerlidir; ön doldurma her tablonun ilk kaydını kullanır.

---

### 🗄️ Veritabanı şeması

6 tablo; tüm birincil anahtarlar `IDENTITY`. **Yabancı anahtar yoktur** – ilişkiler metin değerlerle kurulur (örn. `Tbl_Termine.TerminArzt` = „Ad Soyad“).

| Tablo | Kolonlar |
|---|---|
| `Tbl_Patient` | `Ptid` (smallint, identity), `PtName`, `PtNachname`, `PtBürgerID` (nchar(11)), `PtTelnummer`, `PtPasswort`, `PtGeschlecht` |
| `Tbl_Doktor` | `Drid` (tinyint, identity), `DrName`, `DrNachname`, `DrFachrichtung`, `DrBürgerID` (char(11)), `DrPasswort` |
| `Tbl_Sekretärin` | `Sekrid` (tinyint, identity), `SekrNameNachname`, `SekrBürgerID` (char(11)), `SekrPasswort` |
| `Tbl_Fach` | `Fachid` (tinyint, identity), `FachName` |
| `Tbl_Termine` | `Terminid` (int, identity), `TerminDatum` (metin, `GG.AA.YYYY`), `TerminUhr` (metin, `SS:DD`), `TerminFach`, `TerminArzt`, `TerminStatus` (bit, varsayılan `0` = boş), `Ptid`, `PatientBeschwerden` (varchar(80)) |
| `Tbl_Mitteilungen` | `MitteilungsId` (smallint, identity), `Mitteilung` (varchar(max)) |

---

### 🗂️ Proje yapısı

```text
Klinikum_Stuttgart/
├─ Klinikum_Stuttgart.sln                  Visual Studio çözümü
├─ README.md
├─ LICENSE                                  MIT
├─ Klinikum_Stuttgart_MicrosoftSqlServer_All_DATA.bacpac   Veritabanı yedeği (şema + veri)
└─ Klinikum_Stuttgart/
   ├─ Program.cs                            Giriş noktası + global hata yönetimi
   ├─ SQLverbindung.cs                      merkezî bağlantı yönetimi / demo modu
   ├─ App.config                            Connection string (KlinikumConnectionString)
   ├─ Database/
   │  └─ Klinikum_Stuttgart_Demo.sql        Şema + örnek veriler (exe içine gömülü)
   ├─ Form*.cs / Form*.Designer.cs / *.resx 15 form (tasarım ve görseller dahil)
   └─ Properties/                           AssemblyInfo, kaynaklar, ayarlar
```

| Form | Modül | Görev |
|---|---|---|
| `FormEINGANG` | Başlangıç | Üç portala yönlendirme |
| `FormPatientLogin` | Hasta | Giriş, kayıt bağlantısı |
| `FormPatientRegistrierung` | Hasta | Yeni hasta kaydı |
| `FormPatientDetail` | Hasta | Randevu arama/ alma, geçmiş, şikayet |
| `FormPatientEinstellung` | Hasta | Profil güncelleme |
| `FormDoktorLogin` | Doktor | Giriş |
| `FormDoktorDetail` | Doktor | Randevu listesi + hasta şikayeti |
| `FormDoktorEinstellung` | Doktor | Profile giden menü penceresi |
| `FormDoktorBearbeitung` | Doktor | Profil (branş, şifre) güncelleme |
| `FormMitteilungen` | Doktor | Hastane duyurularını görüntüleme |
| `FormSekretariatLogin` | Sekreterya | Giriş |
| `FormSekretariatDetail` | Sekreterya | Genel bakış, randevu slotu oluşturma, duyuru gönderme |
| `FormSekretariatDrPanel` | Sekreterya | Doktor CRUD |
| `FormSekretariatDrFächer` | Sekreterya | Branş CRUD |
| `FormSekTerList` | Sekreterya | Tüm randevuların listesi |

---

### ⚠️ Bilinen sınırlamalar (bilerek açık bırakıldı)

Bu proje bir öğrenme/demo sürümüdür. Gerçek kullanım için eksikler:

* **Şifreler düz metin** (`PtPasswort`, `DrPasswort`, `SekrPasswort`) – hash/salt yok
* **İki sorguda string birleştirme** (SQL injection riski): `FormPatientDetail.cs` ve `FormDoktorDetail.cs`
* **Yabancı anahtar, index ve unique kısıt yok** → referans bütünlüğü yok
* **Eski veri erişim deseni**: `SQLverbindung.verbindung()` her çağrıda yeni bağlantı açar; bazı yerlerde açılan bağlantı yerine başka bir örnek kapatılır (temizliği GC yapar). Bu nedenle demo modunda `Pooling=False` kullanılır.
* **Otomatik test yok**, loglama yok, async işlem yok
* Arayüz **sadece Almanca** (yerelleştirme yok)
* Randevu tarihi/saati metin olarak tutulur, doktor eşleşmesi isim üzerinden yapılır
* Görseller `.resx` dosyalarına gömülü olduğu için depo boyutu büyük

**Sonraki mantıklı adımlar:** şifre hash'leme, kalan sorguları parametreleştirme, PK/FK + index ekleme, repository katmanı ve testler, çoklu dil desteği.

---

<br>

## 🇬🇧 English

### 👋 Welcome!

**Klinikum Stuttgart** is a desktop application for hospital administration: patient registration, appointment booking, doctor management, departments and hospital-wide announcements. The user interface is entirely in **German**.

The project is meant as a **presentable demo system**: it runs right after cloning without any database configuration, ships with sample data, and is structured so it can be developed into a real product.

---

### ✨ Features

| Module | Capabilities |
|---|---|
| 🚪 Gateway | Central start screen routing to patient, doctor and secretariat areas |
| 🩺 Patient | Registration, login, search free slots (specialty → doctor), book an appointment, submit complaints, appointment history, profile editing |
| 👨‍⚕️ Doctor | Login, personal appointment list, review patient complaints, read announcements, edit profile |
| 📋 Secretariat | Doctor and department lists, create appointment slots, doctor CRUD, department CRUD, send announcements, master appointment list |

> The doctor workspace lists **all** appointments of the signed-in doctor, not just today's.

---

### 🧰 Tech Stack

| Area | Used |
|---|---|
| Language | C# (C# 5 compatible, classic project format) |
| UI | Windows Forms (`WinExe`) |
| Target | .NET Framework **4.7.2** |
| Database | Microsoft SQL Server (Express, LocalDB or higher) |
| Data access | ADO.NET (`System.Data.SqlClient`), SQL embedded in the forms |
| External packages | **none** (framework libraries only, no NuGet) |
| IDE / build | Visual Studio 2022 (solution format 12.00, VS 17.7) or MSBuild |
| License | MIT |

---

### 📦 Prerequisites

* Windows 10/11
* **.NET Framework 4.7.2** (runtime ships with Windows; building requires the developer pack or Visual Studio)
* To **run**: nothing else
* To **build**: Visual Studio 2022 with the “.NET desktop development” workload *or* MSBuild
* To **use a real database**: SQL Server (Express is enough) + SQL Server Management Studio (SSMS)
* For the **zero-config demo mode**: SQL Server Express **LocalDB** or a running `.\SQLEXPRESS` instance

---

### 🚀 Quick Start

#### Option A – Demo mode (no setup)

```powershell
Start-Process .\Klinikum_Stuttgart\bin\Debug\Klinikum_Stuttgart.exe
```

On startup the application looks for a local SQL Server instance
(`(LocalDB)\MSSQLLocalDB`, `.\SQLEXPRESS`, `localhost`), creates the database
`Klinikum_Stuttgart_Demo` if needed, applies schema and sample data, and opens the main window.
The window title then shows **“Klinikum Stuttgart – Demo-Modus”**.
The login forms come prefilled with demo credentials – one click on “Einloggen” is all it takes.

If no SQL Server can be found, a dialog with setup instructions appears instead of a crash.

#### Option B – Use your own database

1. **Provide the database** – either:
   * import [`Klinikum_Stuttgart_MicrosoftSqlServer_All_DATA.bacpac`](./Klinikum_Stuttgart_MicrosoftSqlServer_All_DATA.bacpac) via SSMS *“Import Data-tier Application”*, **or**
   * run [`Klinikum_Stuttgart_Demo.sql`](./Klinikum_Stuttgart/Database/Klinikum_Stuttgart_Demo.sql) in SSMS against a new database (schema + sample data, idempotent).
2. **Set the connection string** – in exactly one place, [`App.config`](./Klinikum_Stuttgart/App.config):

   ```xml
   <connectionStrings>
     <add name="KlinikumConnectionString"
          connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=Klinikum_Stuttgart;Integrated Security=True"
          providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

   Leave it empty to use the automatic demo mode.
3. Start the application (Option A) or press **F5** in Visual Studio.

> ⚠️ The connection string is **no longer hard-coded**. The machine-specific string that used to live in
> `FormMitteilungen.cs` was removed – every form now goes through
> [`SQLverbindung.cs`](./Klinikum_Stuttgart/SQLverbindung.cs).

#### Option C – Build from source

```powershell
# Visual Studio 2022: open Klinikum_Stuttgart.sln and press F5
# or with MSBuild:
msbuild .\Klinikum_Stuttgart.sln /t:Build /p:Configuration=Debug
```

Output: `Klinikum_Stuttgart\bin\Debug\Klinikum_Stuttgart.exe`

> `dotnet build` does **not** work because the project uses the classic (non-SDK) format. Use MSBuild or Visual Studio.

---

### 🔑 Demo Accounts

In **demo mode the credentials are already filled in** – just click “Einloggen”.
The application picks the first record per role automatically, so the prefill stays correct even after you edit the master data.

| Role | Citizen ID | Password | Name |
|---|---|---|---|
| 👨‍⚕️ Doctor | `48160725390` | `4172` | Katrin Waldmann (Cardiology) |
| 👨‍⚕️ Doctor | `17940263854` | `6418` | Markus Zeidler (ENT) |
| 👨‍⚕️ Doctor | `75832194066` | `1829` | Ulrike Sonnemann (Oncology) |
| 📋 Secretariat | `57301846299` | `4416` | Nadine Krämer |
| 📋 Secretariat | `82640517399` | `2873` | Oliver Sandberg |
| 🩺 Patient | `34719285601` | `2468` | Leonie Hartmann |
| 🩺 Patient | `86204715933` | `8372` | Bernd Kuhlmann |
| 🩺 Patient | `51938472660` | `6153` | Sandra Petrov |

**More test data:** 12 doctors, 13 specialties, 8 patients, 16 appointments (10 free / 6 booked incl. complaints) and 5 announcements.
When importing the `.bacpac`, the credentials of the original file apply; the prefill simply uses the first record of each table.

---

### 🗄️ Database Schema

Six tables; every primary key is an `IDENTITY` column. There are **no foreign keys** – relations are expressed through text values (e.g. `Tbl_Termine.TerminArzt` = “First Last”).

| Table | Columns |
|---|---|
| `Tbl_Patient` | `Ptid` (smallint, identity), `PtName`, `PtNachname`, `PtBürgerID` (nchar(11)), `PtTelnummer`, `PtPasswort`, `PtGeschlecht` |
| `Tbl_Doktor` | `Drid` (tinyint, identity), `DrName`, `DrNachname`, `DrFachrichtung`, `DrBürgerID` (char(11)), `DrPasswort` |
| `Tbl_Sekretärin` | `Sekrid` (tinyint, identity), `SekrNameNachname`, `SekrBürgerID` (char(11)), `SekrPasswort` |
| `Tbl_Fach` | `Fachid` (tinyint, identity), `FachName` |
| `Tbl_Termine` | `Terminid` (int, identity), `TerminDatum` (text, `DD.MM.YYYY`), `TerminUhr` (text, `HH:MM`), `TerminFach`, `TerminArzt`, `TerminStatus` (bit, default `0` = free), `Ptid`, `PatientBeschwerden` (varchar(80)) |
| `Tbl_Mitteilungen` | `MitteilungsId` (smallint, identity), `Mitteilung` (varchar(max)) |

---

### 🗂️ Project Structure

```text
Klinikum_Stuttgart/
├─ Klinikum_Stuttgart.sln                  Visual Studio solution
├─ README.md
├─ LICENSE                                  MIT
├─ Klinikum_Stuttgart_MicrosoftSqlServer_All_DATA.bacpac   database export (schema + data)
└─ Klinikum_Stuttgart/
   ├─ Program.cs                            entry point + global error handling
   ├─ SQLverbindung.cs                      central connection handling / demo mode
   ├─ App.config                            connection string (KlinikumConnectionString)
   ├─ Database/
   │  └─ Klinikum_Stuttgart_Demo.sql        schema + sample data (embedded into the exe)
   ├─ Form*.cs / Form*.Designer.cs / *.resx 15 forms incl. layout and images
   └─ Properties/                           AssemblyInfo, resources, settings
```

| Form | Module | Purpose |
|---|---|---|
| `FormEINGANG` | Gateway | Navigation to the three portals |
| `FormPatientLogin` | Patient | Login, link to registration |
| `FormPatientRegistrierung` | Patient | Create a patient |
| `FormPatientDetail` | Patient | Slot search/booking, history, complaints |
| `FormPatientEinstellung` | Patient | Edit profile |
| `FormDoktorLogin` | Doctor | Login |
| `FormDoktorDetail` | Doctor | Appointment list + patient complaints |
| `FormDoktorEinstellung` | Doctor | Menu window leading to the profile |
| `FormDoktorBearbeitung` | Doctor | Edit profile (specialty, password) |
| `FormMitteilungen` | Doctor | Read hospital announcements |
| `FormSekretariatLogin` | Secretariat | Login |
| `FormSekretariatDetail` | Secretariat | Overview, create slots, send announcements |
| `FormSekretariatDrPanel` | Secretariat | Doctor CRUD |
| `FormSekretariatDrFächer` | Secretariat | Department CRUD |
| `FormSekTerList` | Secretariat | Master appointment list |

---

### ⚠️ Known Limitations (intentional)

This is a learning/demo stage. For real-world use, the following are missing:

* **Plain-text passwords** (`PtPasswort`, `DrPasswort`, `SekrPasswort`) – no hashing, no salts
* **Two queries built with string concatenation** (SQL injection risk): `FormPatientDetail.cs` and `FormDoktorDetail.cs`
* **No foreign keys, indexes or unique constraints** → no referential integrity
* **Legacy data access**: `SQLverbindung.verbindung()` opens a new connection per call, while some call sites close a different instance than the one they opened (cleanup relies on the GC). Demo mode therefore uses `Pooling=False`.
* **No automated tests**, no logging, no async processing
* **German UI only** (no localization)
* Appointment date/time stored as text, doctor matching by name instead of IDs
* Large images are embedded in `.resx` files and bloat the repository

**Reasonable next steps:** password hashing, parameterize the remaining queries, add PK/FK + indexes, introduce a repository layer and tests, add localization.

---

## 🤝 İletişim & Katkı / Kontakt / Contact

Sorularınız, geri bildirimleriniz veya katkılarınız için bir **Issue** veya **Pull Request** açabilirsiniz.
Für Fragen, Feedback oder Beiträge gerne ein **Issue** oder einen **Pull Request** öffnen.
Feel free to open an **issue** or a **pull request** for questions, feedback or contributions. ⭐

---

## 📄 Lizenz / Lisans / License

Dieses Projekt steht unter der [MIT License](./LICENSE). / Bu proje MIT Lisansı ile korunmaktadır. / Distributed under the MIT License.
