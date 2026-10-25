/* =========================================================================
   Klinikum Stuttgart - Demo-Datenbank (Schema + Beispieldaten)
   -------------------------------------------------------------------------
   Dieses Skript ist idempotent: Es kann beliebig oft ausgefuehrt werden.
   Es wird von der Anwendung automatisch im Demo-Modus verwendet
   (siehe SQLverbindung.cs) und kann alternativ manuell in SSMS ausgefuehrt
   werden, wenn keine .bacpac importiert werden soll.

   Schema-Quelle: Klinikum_Stuttgart_MicrosoftSqlServer_All_DATA.bacpac
   ========================================================================= */

IF OBJECT_ID(N'dbo.Tbl_Fach', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Tbl_Fach
    (
        Fachid   tinyint     IDENTITY(1,1) NOT NULL,
        FachName varchar(30) NULL
    );
END
GO

IF OBJECT_ID(N'dbo.Tbl_Doktor', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Tbl_Doktor
    (
        Drid           tinyint     IDENTITY(1,1) NOT NULL,
        DrName         varchar(20) NULL,
        DrNachname     varchar(50) NULL,
        DrFachrichtung varchar(30) NULL,
        DrBürgerID     char(11)    NULL,
        DrPasswort     varchar(10) NULL
    );
END
GO

IF OBJECT_ID(N'dbo.Tbl_Mitteilungen', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Tbl_Mitteilungen
    (
        MitteilungsId smallint     IDENTITY(1,1) NOT NULL,
        Mitteilung    varchar(max) NULL
    );
END
GO

IF OBJECT_ID(N'dbo.Tbl_Patient', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Tbl_Patient
    (
        Ptid         smallint    IDENTITY(1,1) NOT NULL,
        PtName       varchar(20) NULL,
        PtNachname   varchar(20) NULL,
        PtBürgerID   nchar(11)   NULL,
        PtTelnummer  varchar(20) NULL,
        PtPasswort   varchar(10) NULL,
        PtGeschlecht varchar(50) NULL
    );
END
GO

IF OBJECT_ID(N'dbo.Tbl_Sekretärin', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Tbl_Sekretärin
    (
        Sekrid           tinyint     IDENTITY(1,1) NOT NULL,
        SekrNameNachname varchar(40) NULL,
        SekrBürgerID     char(11)    NULL,
        SekrPasswort     varchar(10) NULL
    );
END
GO

IF OBJECT_ID(N'dbo.Tbl_Termine', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Tbl_Termine
    (
        Terminid           int         IDENTITY(1,1) NOT NULL,
        TerminDatum        varchar(10) NULL,
        TerminUhr          varchar(5)  NULL,
        TerminFach         varchar(30) NULL,
        TerminArzt         varchar(50) NULL,
        TerminStatus       bit         NULL CONSTRAINT DF_Tbl_Termine_TerminStatus DEFAULT ((0)),
        Ptid               char(11)    NULL,
        PatientBeschwerden varchar(80) NULL
    );
END
GO

/* ------------------------------ Beispieldaten --------------------------- */

IF NOT EXISTS (SELECT 1 FROM dbo.Tbl_Fach)
BEGIN
    INSERT INTO dbo.Tbl_Fach (FachName) VALUES
        ('Kardiologie'),
        ('Dermatologie'),
        ('Innere Medizin'),
        ('Pädiatrie'),
        ('Neurologie'),
        ('Pathologie'),
        ('Physiologie'),
        ('Radiologie'),
        ('Urologie'),
        ('Hals-Nasen-Ohren'),
        ('Allgemeinmedizin'),
        ('Anästhesiologie'),
        ('Onkologie');
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Tbl_Doktor)
BEGIN
    INSERT INTO dbo.Tbl_Doktor (DrName, DrNachname, DrFachrichtung, DrBürgerID, DrPasswort) VALUES
        ('Stefanie', 'Schneiders', 'Gynäkologie',      '10000000000', '1111'),
        ('Erica',    'Müller',     'Gynäkologie',      '20000000000', '2222'),
        ('Gizem',    'Bicer Konuk','Physiologie',      '90909090909', '9090'),
        ('Gerhart',  'Blumberg',   'Urologie',         '99887766554', '1234'),
        ('Anil',     'Seker',      'Neurologie',       '13131313131', '1234'),
        ('Richard',  'Heldel',     'Onkologie',        '30000000000', '3333'),
        ('Jane',     'Mortsensen', 'Dermatologie',     '40000000000', '4444'),
        ('Johann',   'German',     'Hals-Nasen-Ohren', '60000000000', '6666'),
        ('Christina','Böhm',       'Allgemeinmedizin', '80000000000', '8888'),
        ('Maria',    'Mayer',      'Urologie',         '50000000000', '5555'),
        ('Michael',  'Hofflinger', 'Pathologie',       '70000000000', '7777'),
        ('Adam',     'Dogualp',    'Neurologie',       '90000000000', '9999');
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Tbl_Sekretärin)
BEGIN
    INSERT INTO dbo.Tbl_Sekretärin (SekrNameNachname, SekrBürgerID, SekrPasswort) VALUES
        ('Lina Finn',  '11223344556', '1234'),
        ('Felix Emma', '11111111111', '1234');
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Tbl_Patient)
BEGIN
    INSERT INTO dbo.Tbl_Patient (PtName, PtNachname, PtBürgerID, PtTelnummer, PtPasswort, PtGeschlecht) VALUES
        ('Hans',  'Franker', '12121212121', '(152)00000000', '1212', 'Männlich'),
        ('Aysel', 'Konuk',   '12345678910', '(123)45678912', '1010', 'Weiblich'),
        ('Recai', 'Büberci', '91919191919', '(134)53547123', '5555', 'Männlich'),
        ('Emrah', 'Özdven',  '55551111222', '(151)22233445', '1234', 'Männlich');
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Tbl_Termine)
BEGIN
    INSERT INTO dbo.Tbl_Termine (TerminDatum, TerminUhr, TerminFach, TerminArzt, TerminStatus, Ptid, PatientBeschwerden) VALUES
        ('15.11.2026', '09:00', 'Pathologie',  'Michael Hofflinger',  0, NULL,          NULL),
        ('15.11.2026', '16:00', 'Pathologie',  'Michael Hofflinger',  0, NULL,          NULL),
        ('18.11.2026', '12:00', 'Gynäkologie', 'Erica Müller',        0, NULL,          NULL),
        ('18.11.2026', '08:30', 'Urologie',    'Gerhart Blumberg',    0, NULL,          NULL),
        ('19.11.2026', '11:15', 'Neurologie',  'Anil Seker',          0, NULL,          NULL),
        ('20.10.2026', '09:45', 'Onkologie',   'Richard Heldel',      1, '12121212121', 'Rückenschmerzen seit zwei Wochen'),
        ('20.10.2026', '14:00', 'Onkologie',   'Richard Heldel',      1, '12345678910', 'Kontrolle der Blutwerte'),
        ('21.10.2026', '10:00', 'Gynäkologie', 'Stefanie Schneiders', 1, '91919191919', 'Vorsorgeuntersuchung'),
        ('22.10.2026', '15:30', 'Urologie',    'Maria Mayer',         1, '55551111222', 'Unregelmäßige Perioden');
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Tbl_Mitteilungen)
BEGIN
    INSERT INTO dbo.Tbl_Mitteilungen (Mitteilung) VALUES
        ('Alle Krankenschwestern & Krankenpfleger/innen und Ärzte & Ärztinnen können ab morgen an dem Schalter vorbeikommen, um ihre Krankenhaus-Arbeitszeitfassungskarte abzuholen.'),
        ('Versammlung am Freitag um 13:00 Uhr im Notfallzimmer: geehrte Dr. Christina Böhm.'),
        ('Die neue Dienstplanung für Dezember ist ab sofort im Sekretariat einsehbar.');
END
GO
