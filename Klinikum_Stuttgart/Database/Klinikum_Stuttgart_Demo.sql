/* =========================================================================
   Klinikum Stuttgart - Demo-Datenbank (Schema + Beispieldaten)
   -------------------------------------------------------------------------
   Dieses Skript ist idempotent: Es kann beliebig oft ausgefuehrt werden.
   Es wird von der Anwendung automatisch im Demo-Modus verwendet
   (siehe SQLverbindung.cs) und kann alternativ manuell in SSMS ausgefuehrt
   werden, wenn keine .bacpac importiert werden soll.

   Die Demo-Zugaenge (erste Zeile je Tabelle) werden im Demo-Modus
   automatisch in die Login-Formulare eingetragen.

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
        ('Katrin',   'Waldmann',    'Kardiologie',      '48160725390', '4172'),
        ('Tobias',   'Rehberg',     'Innere Medizin',   '72615384902', '8306'),
        ('Miriam',   'Albrecht',    'Dermatologie',     '30591827465', '5921'),
        ('Jonas',    'Kirchhoff',   'Neurologie',       '91734602815', '2648'),
        ('Sabine',   'Vogtländer',  'Pädiatrie',        '26840917355', '7139'),
        ('Daniel',   'Strohmeier',  'Radiologie',       '59302746188', '3854'),
        ('Anneke',   'Brüggemann',  'Urologie',         '84172639507', '9273'),
        ('Markus',   'Zeidler',     'Hals-Nasen-Ohren', '17940263854', '6418'),
        ('Franziska','Böhmert',     'Allgemeinmedizin', '63581920477', '5092'),
        ('Hendrik',  'Ohlsen',      'Anästhesiologie',  '40295817366', '7361'),
        ('Ulrike',   'Sonnemann',   'Onkologie',        '75832194066', '1829'),
        ('Patrick',  'Amrhein',     'Pathologie',       '29047361855', '6745');
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Tbl_Sekretärin)
BEGIN
    INSERT INTO dbo.Tbl_Sekretärin (SekrNameNachname, SekrBürgerID, SekrPasswort) VALUES
        ('Nadine Krämer',  '57301846299', '4416'),
        ('Oliver Sandberg', '82640517399', '2873');
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Tbl_Patient)
BEGIN
    INSERT INTO dbo.Tbl_Patient (PtName, PtNachname, PtBürgerID, PtTelnummer, PtPasswort, PtGeschlecht) VALUES
        ('Leonie', 'Hartmann',  '34719285601', '(170)4829315', '2468', 'Weiblich'),
        ('Bernd',  'Kuhlmann',  '86204715933', '(151)7264913', '8372', 'Männlich'),
        ('Sandra', 'Petrov',    '51938472660', '(160)3948271', '6153', 'Weiblich'),
        ('Fabian', 'Ostermann', '27486093155', '(176)9283746', '4091', 'Männlich'),
        ('Nadine', 'Wehrle',    '93051827466', '(172)5639201', '7584', 'Weiblich'),
        ('Ilker',  'Yildirim',  '64820973155', '(155)8374920', '3296', 'Männlich'),
        ('Kerstin','Albers',    '18374659200', '(168)4291753', '9037', 'Weiblich'),
        ('Tomasz', 'Nowak',     '79512038466', '(174)6182934', '5172', 'Männlich');
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Tbl_Termine)
BEGIN
    INSERT INTO dbo.Tbl_Termine (TerminDatum, TerminUhr, TerminFach, TerminArzt, TerminStatus, Ptid, PatientBeschwerden) VALUES
        -- freie Termine (TerminStatus = 0), buchbar im Patientenportal
        ('12.11.2026', '08:30', 'Kardiologie',     'Katrin Waldmann',    0, NULL,          NULL),
        ('12.11.2026', '10:15', 'Kardiologie',     'Katrin Waldmann',    0, NULL,          NULL),
        ('13.11.2026', '09:00', 'Dermatologie',    'Miriam Albrecht',    0, NULL,          NULL),
        ('16.11.2026', '14:45', 'Neurologie',      'Jonas Kirchhoff',    0, NULL,          NULL),
        ('17.11.2026', '11:30', 'Pädiatrie',       'Sabine Vogtländer',  0, NULL,          NULL),
        ('18.11.2026', '08:00', 'Urologie',        'Anneke Brüggemann',  0, NULL,          NULL),
        ('19.11.2026', '16:00', 'Onkologie',       'Ulrike Sonnemann',   0, NULL,          NULL),
        ('20.11.2026', '09:45', 'Pathologie',      'Patrick Amrhein',    0, NULL,          NULL),
        ('23.11.2026', '13:15', 'Radiologie',      'Daniel Strohmeier',  0, NULL,          NULL),
        ('24.11.2026', '10:30', 'Allgemeinmedizin','Franziska Böhmert',  0, NULL,          NULL),
        -- vergebene Termine (TerminStatus = 1) inkl. Beschwerden
        ('14.10.2026', '09:15', 'Kardiologie',     'Katrin Waldmann',    1, '34719285601', 'Herzstolpern seit zwei Wochen'),
        ('15.10.2026', '11:00', 'Innere Medizin',  'Tobias Rehberg',     1, '86204715933', 'Anhaltende Magenschmerzen'),
        ('16.10.2026', '15:30', 'Dermatologie',    'Miriam Albrecht',    1, '51938472660', 'Ausschlag am Unterarm'),
        ('19.10.2026', '08:45', 'Neurologie',      'Jonas Kirchhoff',    1, '27486093155', 'Regelmäßige Kopfschmerzen'),
        ('21.10.2026', '13:00', 'Pädiatrie',       'Sabine Vogtländer',  1, '93051827466', 'Kontrolluntersuchung'),
        ('22.10.2026', '16:15', 'Onkologie',       'Ulrike Sonnemann',   1, '64820973155', 'Nachsorge nach Therapie');
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Tbl_Mitteilungen)
BEGIN
    INSERT INTO dbo.Tbl_Mitteilungen (Mitteilung) VALUES
        ('Alle Mitarbeitenden können ihre neue Arbeitszeitkarte ab Montag im Sekretariat abholen.'),
        ('Teambesprechung am Freitag um 13:00 Uhr im Notfallzimmer - Teilnahme für alle Ärztinnen und Ärzte verpflichtend.'),
        ('Die Dienstplanung für Dezember ist ab sofort im Sekretariat einsehbar.'),
        ('Neue Hygiene-Schulung: Die Unterlagen liegen im Intranet bereit.'),
        ('Wartungsarbeiten am Kliniksystem am Samstag zwischen 22:00 und 02:00 Uhr.');
END
GO
