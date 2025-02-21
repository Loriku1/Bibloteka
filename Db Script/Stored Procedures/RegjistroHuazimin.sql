CREATE PROCEDURE RegjistroHuazimin
    @Klienti_ID INT,
    @Material_ID INT,
    @Data_Huazimit DATE,
    @Data_Kthimit DATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Kontrollo n�se klienti dhe materiali ekzistojn�
    IF NOT EXISTS (SELECT 1 FROM Klientet WHERE Klienti_ID = @Klienti_ID)
    BEGIN
        PRINT 'Error: Klienti nuk ekziston!';
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM Materialet_Bibliografike WHERE Material_ID = @Material_ID)
    BEGIN
        PRINT 'Error: Materiali nuk ekziston!';
        RETURN;
    END

    -- Kontrollo n�se materiali �sht� i disponuesh�m (ka kopje t� lira)
    DECLARE @KopjetDisponibile INT;
    SELECT @KopjetDisponibile = Kopjet_Disponibile 
    FROM Materialet_Bibliografike 
    WHERE Material_ID = @Material_ID;

    IF @KopjetDisponibile <= 0
    BEGIN
        PRINT 'Error: Nuk ka kopje t� lira t� k�tij materiali!';
        RETURN;
    END

    -- Regjistro huazimin
    INSERT INTO Huazimet (Klienti_ID, Material_ID, Data_Huazimit, Data_Kthimit, Data_Kthimit_Reale, Tarifa_Denimi)
    VALUES (@Klienti_ID, @Material_ID, @Data_Huazimit, @Data_Kthimit, NULL, 0.00);

    -- Zvog�lo numrin e kopjeve t� disponueshme
    UPDATE Materialet_Bibliografike
    SET Kopjet_Disponibile = Kopjet_Disponibile - 1
    WHERE Material_ID = @Material_ID;

    PRINT 'Huazimi u regjistrua me sukses!';
END;


SELECT * FROM Huazimet;
SELECT * FROM Materialet_Bibliografike WHERE Material_ID = 2;
