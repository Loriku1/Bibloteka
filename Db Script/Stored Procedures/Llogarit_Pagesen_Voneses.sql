CREATE PROCEDURE Llogarit_Pagesen_Voneses
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @TarifaPerDite DECIMAL(10,2) = 0.50; -- Example: 0.50€ per day of delay

    -- Update the late fee for all overdue loans
    UPDATE Huazimet
    SET Tarifa_Denimi = DATEDIFF(DAY, Data_Kthimit, Data_Kthimit_Reale) * @TarifaPerDite
    WHERE Data_Kthimit_Reale IS NOT NULL 
    AND Data_Kthimit_Reale > Data_Kthimit;

    -- Insert the penalty into the Pagesat table for clients who returned late
    INSERT INTO Pagesat (Klienti_ID, Shuma, Data_Pageses, Lloji_Pageses)
    SELECT h.Klienti_ID, h.Tarifa_Denimi, GETDATE(), 'Dënim për vonesë'
    FROM Huazimet h
    WHERE h.Data_Kthimit_Reale IS NOT NULL 
    AND h.Data_Kthimit_Reale > h.Data_Kthimit;
END;
