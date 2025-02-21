use[Bibloteka2]
CREATE TRIGGER trg_UlKopjetDisponibile
ON Huazimet
AFTER INSERT
AS
BEGIN
    -- P�r t� shmangur probleme n� rast t� futjes s� shum� rreshtave
    SET NOCOUNT ON;

    -- P�rdit�son numrin e kopjeve t� disponueshme duke e ulur me 1
    UPDATE Materialet_Bibliografike
    SET Kopjet_Disponibile = Kopjet_Disponibile - 1
    FROM Materialet_Bibliografike
    INNER JOIN inserted i ON Materialet_Bibliografike.Material_ID = i.Material_ID
    WHERE Kopjet_Disponibile > 0; -- Siguron q� nuk zbret n�n 0
END;
