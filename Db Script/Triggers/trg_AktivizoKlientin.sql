CREATE TRIGGER trg_AktivizoKlientin
ON Pagesat
AFTER INSERT
AS
BEGIN
    -- Për të shmangur probleme në rast të futjes së shumë rreshtave
    SET NOCOUNT ON;

    -- Përditëso statusin e anëtarësisë nëse klienti ishte joaktiv
    UPDATE Klientet
    SET AnetarAktiv = 1
    FROM Klientet
    INNER JOIN inserted i ON Klientet.Klienti_ID = i.Klienti_ID
    WHERE Klientet.AnetarAktiv = 0; -- Vetëm për klientët joaktivë
END;
