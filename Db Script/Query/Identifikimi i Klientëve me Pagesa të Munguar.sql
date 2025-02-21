use[Bibloteka2]

SELECT 
    k.Klienti_ID,
    k.Emri,
    k.Mbiemri,
    ISNULL(SUM(h.Tarifa_Denimi), 0) AS Borxhi_Per_Vonesat
FROM 
    Klientet k
LEFT JOIN 
    Pagesat p ON k.Klienti_ID = p.Klienti_ID AND p.Data_Pageses >= '2025-01-01' -- Filtron p�r pagesat nga fillimi i vitit
LEFT JOIN 
    Huazimet h ON k.Klienti_ID = h.Klienti_ID AND h.Data_Kthimit_Reale > h.Data_Kthimit -- Huazime t� vonuara
WHERE 
    p.Pagesa_ID IS NULL -- Filtron klient�t q� nuk kan� b�r� asnj� pages� k�t� vit
GROUP BY 
    k.Klienti_ID, k.Emri, k.Mbiemri
ORDER BY 
    Borxhi_Per_Vonesat DESC;
