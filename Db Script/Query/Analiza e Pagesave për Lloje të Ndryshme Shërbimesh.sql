use[Bibloteka2]
SELECT 
    p.Lloji_Pageses,
    SUM(p.Shuma) AS Shuma_Totale_Pagesash,
    COUNT(DISTINCT p.Klienti_ID) AS Numri_Klient�ve
FROM 
    Pagesat p
WHERE 
    YEAR(p.Data_Pageses) = YEAR(DATEADD(YEAR, -1, GETDATE())) -- Filtron p�r vitin e kaluar
GROUP BY 
    p.Lloji_Pageses
ORDER BY 
    Shuma_Totale_Pagesash DESC;
