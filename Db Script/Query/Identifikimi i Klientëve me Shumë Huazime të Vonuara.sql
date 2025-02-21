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
    Pagesat p ON k.Klienti_ID = p.Klienti_ID AND p.Data_Pageses >= '2025-01-01' -- Filtron p�r pagesat nga fillimi i vitit
WHERE 
    p.Pagesa_ID IS NULL -- Sigurohet q� klienti nuk ka b�r� pagesa
GROUP BY 
    k.Klienti_ID, k.Emri, k.Mbiemri
HAVING 
    ISNULL(SUM(h.Tarifa_Denimi), 0) > 0 -- Filtron klient�t q� kan� borxhe t� pa paguara
ORDER BY 
    Shuma_Totale_Tarifash_Vonese DESC;
