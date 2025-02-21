use[Bibloteka2]
CREATE TRIGGER trg_UlKopjetDisponibile
ON Huazimet
AFTER INSERT
AS
BEGIN
    -- Për të shmangur probleme në rast të futjes së shumë rreshtave
    SET NOCOUNT ON;

    -- Përditëson numrin e kopjeve të disponueshme duke e ulur me 1
    UPDATE Materialet_Bibliografike
    SET Kopjet_Disponibile = Kopjet_Disponibile - 1
    FROM Materialet_Bibliografike
    INNER JOIN inserted i ON Materialet_Bibliografike.Material_ID = i.Material_ID
    WHERE Kopjet_Disponibile > 0; -- Siguron që nuk zbret nën 0
END;
