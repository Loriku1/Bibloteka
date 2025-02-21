use [Bibloteka2]

SELECT 
    k.Klienti_ID,
    k.Emri,
    k.Mbiemri,
    ISNULL(SUM(h.Tarifa_Denimi), 0) AS Shuma_Totale_Tarifash_Vonese
FROM 
    Klientet k
LEFT JOIN 
    Huazimet h ON k.Klienti_ID = h.Klienti_ID
LEFT JOIN 
    Pagesat p ON k.Klienti_ID = p.Klienti_ID AND p.Data_Pageses >= '2025-01-01' -- Filtron për pagesat nga fillimi i vitit
WHERE 
    p.Pagesa_ID IS NULL -- Sigurohet që klienti nuk ka bërë pagesa
GROUP BY 
    k.Klienti_ID, k.Emri, k.Mbiemri
HAVING 
    ISNULL(SUM(h.Tarifa_Denimi), 0) > 0 -- Filtron klientët që kanë borxhe të pa paguara
ORDER BY 
    Shuma_Totale_Tarifash_Vonese DESC;
