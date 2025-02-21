CREATE TRIGGER trg_PerditsimiTarifave
ON Huazimet
AFTER UPDATE
AS
BEGIN
    -- P�r t� shmangur probleme n� rast t� p�rdit�simeve t� shum�fishta
    SET NOCOUNT ON;

    -- P�rdit�so tarif�n e vones�s vet�m p�r huazimet ku Data_Kthimit_Reale �sht� pas Data_Kthimit
    UPDATE h
    SET Tarifa_Denimi = DATEDIFF(DAY, h.Data_Kthimit, i.Data_Kthimit_Reale) * 0.50
    FROM Huazimet h
    INNER JOIN inserted i ON h.Huazimi_ID = i.Huazimi_ID
    WHERE i.Data_Kthimit_Reale > h.Data_Kthimit;
END;
