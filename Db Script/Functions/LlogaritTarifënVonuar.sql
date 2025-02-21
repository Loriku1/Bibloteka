CREATE FUNCTION LlogaritTarif�nVonuar
(
    @Tarifa_Ditore DECIMAL(10,2) -- Tarif� p�r �do dit� vonese
)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        h.Huazimi_ID,
        h.Klienti_ID,
        k.Emri + ' ' + k.Mbiemri AS Klienti,
        h.Material_ID,
        m.Titulli AS Materiali,
        h.Data_Huazimit,
        h.Data_Kthimit,
        ISNULL(h.Data_Kthimit_Reale, GETDATE()) AS Data_Kthimit_Reale,
        DATEDIFF(DAY, h.Data_Kthimit, ISNULL(h.Data_Kthimit_Reale, GETDATE())) AS DiteVonesa,
        DATEDIFF(DAY, h.Data_Kthimit, ISNULL(h.Data_Kthimit_Reale, GETDATE())) * @Tarifa_Ditore AS Denimi
    FROM Huazimet h
    INNER JOIN Klientet k ON h.Klienti_ID = k.Klienti_ID
    INNER JOIN Materialet_Bibliografike m ON h.Material_ID = m.Material_ID
    WHERE h.Data_Kthimit < GETDATE() -- Vet�m huazimet q� kan� kaluar dat�n e kthimit
      AND (h.Data_Kthimit_Reale IS NULL OR h.Data_Kthimit_Reale > h.Data_Kthimit) -- Vet�m huazimet q� jan� vonuar
)

SELECT * FROM dbo.LlogaritTarif�nVonuar(2.00);
