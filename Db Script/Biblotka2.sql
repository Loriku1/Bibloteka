use[Bibloteka2]
CREATE TABLE Materialet_Bibliografike (
    Material_ID INT PRIMARY KEY IDENTITY(1,1),
    Titulli VARCHAR(255),
    Autori VARCHAR(255),
    BashkeAutoret VARCHAR(255),
    Botuesi VARCHAR(255),
    Data_Publikimit DATE,
    ISBN VARCHAR(20),
    DOI VARCHAR(50),
    Lloji_Materialit VARCHAR(50),
    Abstrakti TEXT,
    Kopjet_Disponibile INT,
    Data_Shtuar DATE
);
CREATE TABLE Klientet (
    Klienti_ID INT PRIMARY KEY IDENTITY(1,1),
    Emri VARCHAR(255),
    Mbiemri VARCHAR(255),
    Data_Lindjes DATE,
    Email VARCHAR(255),
    Telefon VARCHAR(50),
    Adresa TEXT,
    AnetarAktiv BIT
);
CREATE TABLE Huazimet (
    Huazimi_ID INT PRIMARY KEY IDENTITY(1,1),
    Klienti_ID INT,
    Material_ID INT,
    Data_Huazimit DATE,
    Data_Kthimit DATE,
    Data_Kthimit_Reale DATE,
    Tarifa_Denimi DECIMAL(10,2),
    FOREIGN KEY (Klienti_ID) REFERENCES Klientet(Klienti_ID),
    FOREIGN KEY (Material_ID) REFERENCES Materialet_Bibliografike(Material_ID)
);

SELECT name 
FROM sys.foreign_keys 
WHERE parent_object_id = OBJECT_ID('dbo.Huazimet') 
AND referenced_object_id = OBJECT_ID('dbo.Materialet_Bibliografike');

ALTER TABLE Huazimet DROP CONSTRAINT FK__Huazimet__Materi__4AB81AF0;
ALTER TABLE Huazimet 
ADD CONSTRAINT FK_Huazimet_Material 
FOREIGN KEY (Material_ID) 
REFERENCES Materialet_Bibliografike(Material_ID) 
ON DELETE CASCADE;



CREATE TABLE Pagesat (
    Pagesa_ID INT PRIMARY KEY IDENTITY(1,1),
    Klienti_ID INT,
    Shuma DECIMAL(10,2),
    Data_Pageses DATE,
    Lloji_Pageses VARCHAR(50),
    FOREIGN KEY (Klienti_ID) REFERENCES Klientet(Klienti_ID)
);
CREATE TABLE Perdoruesit (
    Perdoruesi_ID INT PRIMARY KEY IDENTITY(1,1),
    Emri_Perdoruesit VARCHAR(50),
    Fjalekalimi VARCHAR(255),
    Roli VARCHAR(50)
);

select * from Huazimet

INSERT INTO Materialet_Bibliografike (Titulli, Autori, BashkeAutoret, Botuesi, Data_Publikimit, ISBN, DOI, Lloji_Materialit, Abstrakti, Kopjet_Disponibile, Data_Shtuar)
VALUES 
('The Great Gatsby', 'F. Scott Fitzgerald', NULL, 'Charles Scribner''s Sons', '1925-04-10', '9780743273565', '10.1007/978-3-030-22391-1', 'Libër', 'Një roman për ëndrrën amerikane gjatë epokës së Jazz-it.', 5, '2025-02-05'),
('Moby-Dick', 'Herman Melville', NULL, 'Harper & Brothers', '1851-10-18', '9781853260087', '10.1016/j.csr.2020.102131', 'Libër', 'Një roman që trajton tema të fiksimit dhe hakmarrjes.', 3, '2025-02-05'),
('The Basics of Machine Learning', 'John Smith', 'Jane Doe', 'Tech Press', '2020-05-01', '9781234567890', '10.1016/j.csr.2020.102131', 'Artikull', 'Një hyrje në parimet themelore të mësimit të makinerisë.', 10, '2025-02-05');


INSERT INTO Klientet (Emri, Mbiemri, Data_Lindjes, Email, Telefon, Adresa, AnetarAktiv)
VALUES 
('Mark', 'Smith', '1985-06-15', 'mark.smith@email.com', '1234567890', 'Rruga e Dajti, Tiranë', 1),
('Anita', 'Kola', '1990-03-22', 'anita.kola@email.com', '0987654321', 'Rruga e Elbasanit, Shkodër', 1),
('Luan', 'Hoxha', '1982-07-10', 'luan.hoxha@email.com', '1122334455', 'Rruga e Pavarësisë, Vlorë', 0);


DELETE FROM Huazimet 
WHERE Klienti_ID IN (1, 2, 3, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22,23,24);

DELETE FROM Pagesat 
WHERE Klienti_ID IN (1, 2, 3, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24);


DELETE FROM Klientet 
WHERE Klienti_ID IN (1, 2, 3, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24);


Select A

INSERT INTO Huazimet (Klienti_ID, Material_ID, Data_Huazimit, Data_Kthimit, Data_Kthimit_Reale, Tarifa_Denimi)
VALUES 
(1, 1, '2025-02-01', '2025-02-15', NULL, 0.00),
(2, 2, '2025-02-02', '2025-02-16', NULL, 0.00),
(3, 3, '2025-02-03', '2025-02-17', '2025-02-12', 1.50);


INSERT INTO Pagesat (Klienti_ID, Shuma, Data_Pageses, Lloji_Pageses)
VALUES 
(1, 20.00, '2025-02-05', 'Pagesë mujore'),
(2, 15.00, '2025-02-05', 'Dënim për vonesë'),
(3, 10.00, '2025-02-05', 'Pagesë mujore');


INSERT INTO Perdoruesit (Emri_Perdoruesit, Fjalekalimi, Roli)
VALUES 
('admin', 'admin123', 'Administrator'),
('bibliotekar', 'libri456', 'Bibliotekar'),
('perdorues', 'perdorues789', 'Përdorues');


DELETE FROM Klientet WHERE Klienti_ID > 3;

Select * from Materialet_Bibliografike
Select * from Klientet

DELETE FROM Materialet_Bibliografike
WHERE Material_ID NOT IN (10, 11, 12);



ALTER TABLE Klientet
ADD Numri_Huazimeve INT DEFAULT 0;

-- Huazimet e vonuara--
INSERT INTO Huazimet (Klienti_ID, Material_ID, Data_Huazimit, Data_Kthimit, Data_Kthimit_Reale, Tarifa_Denimi)
VALUES 
(1, 1, '2025-01-01', '2025-02-01', NULL, 5.00),-- Dënim për vonesë
(2, 2, '2025-01-05', '2025-02-10', NULL, 3.00), -- Dënim për vonesë
(3, 3, '2025-01-10', '2025-02-12', NULL, 4.50); -- Dënim për vonesë


-- Shto huazime të vonuara për klientin me Klienti_ID = 1 (Mark Smith)
INSERT INTO Huazimet (Klienti_ID, Material_ID, Data_Huazimit, Data_Kthimit, Data_Kthimit_Reale, Tarifa_Denimi)
VALUES 
(1, 1, '2025-01-01', '2025-02-01', NULL, 5.00), -- Huazim i vonuar
(1, 2, '2025-01-05', '2025-02-10', NULL, 3.00), -- Huazim i vonuar
(1, 3, '2025-01-10', '2025-02-12', NULL, 4.50), -- Huazim i vonuar
(1, 1, '2025-01-15', '2025-02-15', NULL, 2.50), -- Huazim i vonuar
(1, 2, '2025-01-20', '2025-02-20', NULL, 3.50), -- Huazim i vonuar
(1, 3, '2025-01-25', '2025-02-25', NULL, 4.00); -- Huazim i vonuar


select*from Perdoruesit



DELETE FROM Huazimet WHERE Huazimi_ID > 3;

-- Kjo mund të jetë për klientin me Klienti_ID = 1 (Mark Smith)
INSERT INTO Huazimet (Klienti_ID, Material_ID, Data_Huazimit, Data_Kthimit, Data_Kthimit_Reale, Tarifa_Denimi)
VALUES
(1, 1, '2025-01-01', '2025-01-15', '2025-01-20', 5.00),  -- Dënim për vonesë
(1, 2, '2025-01-02', '2025-01-16', '2025-01-22', 3.50),  -- Dënim për vonesë
(1, 3, '2025-01-03', '2025-01-17', '2025-01-25', 4.00),  -- Dënim për vonesë
(1, 8, '2025-01-04', '2025-01-18', '2025-01-26', 2.50);  -- Dënim për vonesë



-- Shto disa pagesa për vitin 2024
INSERT INTO Pagesat (Klienti_ID, Shuma, Data_Pageses, Lloji_Pageses)
VALUES 
(1, 20.00, '2024-02-05', 'Pagesë mujore'),
(2, 15.00, '2024-05-10', 'Dënim për vonesë'),
(1, 10.00, '2024-06-15', 'Pagesë mujore'),
(3, 30.00, '2024-11-20', 'Pagesë mujore'),
(2, 5.00, '2024-12-05', 'Dënim për vonesë'),
(3, 25.00, '2024-07-25', 'Dënim për vonesë');



select * from Klientet

DELETE FROM Perdoruesit 
WHERE Perdoruesi_ID IN (7, 8, 9, 10, 11);


-- Creating an index on Klienti_ID in the Huazimet table for faster lookups
CREATE INDEX idx_Klienti_ID ON Huazimet (Klienti_ID);

-- Creating an index on Material_ID in the Huazimet table
CREATE INDEX idx_Material_ID ON Huazimet (Material_ID);

-- Index for ISBN in Materialet_Bibliografike
CREATE INDEX idx_ISBN ON Materialet_Bibliografike (ISBN);

-- Index for Email in Klientet (if querying frequently by email)
CREATE INDEX idx_Email ON Klientet (Email);

-- Index for Data_Lindjes in Klientet (if querying frequently by birth date)
CREATE INDEX idx_Data_Lindjes ON Klientet (Data_Lindjes);


-- Composite index example: for queries involving both Klienti_ID and Material_ID
CREATE INDEX idx_Klienti_Material ON Huazimet (Klienti_ID, Material_ID);



