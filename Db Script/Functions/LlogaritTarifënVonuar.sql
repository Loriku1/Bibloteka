CREATE FUNCTION LlogaritTarifënVonuar
(
    @Tarifa_Ditore DECIMAL(10,2) -- Tarifë për çdo ditë vonese
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
    WHERE h.Data_Kthimit < GETDATE() -- Vetëm huazimet që kanë kaluar datën e kthimit
      AND (h.Data_Kthimit_Reale IS NULL OR h.Data_Kthimit_Reale > h.Data_Kthimit) -- Vetëm huazimet që janë vonuar
)

SELECT * FROM dbo.LlogaritTarifënVonuar(2.00);
