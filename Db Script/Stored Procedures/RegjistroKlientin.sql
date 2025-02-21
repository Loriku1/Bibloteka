CREATE PROCEDURE RegjistroKlientin
    @Emri VARCHAR(255),
    @Mbiemri VARCHAR(255),
    @Data_Lindjes DATE,
    @Email VARCHAR(255),
    @Telefon VARCHAR(50),
    @Adresa TEXT,
    @AnetarAktiv BIT
AS
BEGIN
    -- Fut klientin në tabelën Klientet
    INSERT INTO Klientet (Emri, Mbiemri, Data_Lindjes, Email, Telefon, Adresa, AnetarAktiv)
    VALUES (@Emri, @Mbiemri, @Data_Lindjes, @Email, @Telefon, @Adresa, @AnetarAktiv);
    
    -- Kthen një mesazh konfirmimi
    SELECT 'Klienti i ri është regjistruar me sukses!' AS Mesazh;
END;
