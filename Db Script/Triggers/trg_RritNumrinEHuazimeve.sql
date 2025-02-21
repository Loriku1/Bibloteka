CREATE TRIGGER trg_RritNumrinEHuazimeve
ON Huazimet
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- P�rdit�so numrin e huazimeve p�r klient�t q� kan� b�r� nj� huazim t� ri
    UPDATE Klientet
    SET Numri_Huazimeve = Numri_Huazimeve + 1
    FROM Klientet
    INNER JOIN inserted i ON Klientet.Klienti_ID = i.Klienti_ID;
END;
