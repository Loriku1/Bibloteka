CREATE TRIGGER trg_PerditsimiTarifave
ON Huazimet
AFTER UPDATE
AS
BEGIN
    -- Për të shmangur probleme në rast të përditësimeve të shumëfishta
    SET NOCOUNT ON;

    -- Përditëso tarifën e vonesës vetëm për huazimet ku Data_Kthimit_Reale është pas Data_Kthimit
    UPDATE h
    SET Tarifa_Denimi = DATEDIFF(DAY, h.Data_Kthimit, i.Data_Kthimit_Reale) * 0.50
    FROM Huazimet h
    INNER JOIN inserted i ON h.Huazimi_ID = i.Huazimi_ID
    WHERE i.Data_Kthimit_Reale > h.Data_Kthimit;
END;
