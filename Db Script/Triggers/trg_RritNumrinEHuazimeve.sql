CREATE TRIGGER trg_RritNumrinEHuazimeve
ON Huazimet
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Përditëso numrin e huazimeve për klientët që kanë bërë një huazim të ri
    UPDATE Klientet
    SET Numri_Huazimeve = Numri_Huazimeve + 1
    FROM Klientet
    INNER JOIN inserted i ON Klientet.Klienti_ID = i.Klienti_ID;
END;
