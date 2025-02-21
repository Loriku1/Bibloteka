CREATE TRIGGER trg_AktivizoKlientin
ON Pagesat
AFTER INSERT
AS
BEGIN
    -- P�r t� shmangur probleme n� rast t� futjes s� shum� rreshtave
    SET NOCOUNT ON;

    -- P�rdit�so statusin e an�tar�sis� n�se klienti ishte joaktiv
    UPDATE Klientet
    SET AnetarAktiv = 1
    FROM Klientet
    INNER JOIN inserted i ON Klientet.Klienti_ID = i.Klienti_ID
    WHERE Klientet.AnetarAktiv = 0; -- Vet�m p�r klient�t joaktiv�
END;
