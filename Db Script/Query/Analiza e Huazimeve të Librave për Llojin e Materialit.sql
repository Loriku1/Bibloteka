use[Bibloteka2]
SELECT 
    m.Titulli, 
    m.Lloji_Materialit, 
    COUNT(h.Huazimi_ID) AS Numri_Huazimeve
FROM 
    Materialet_Bibliografike m
INNER JOIN 
    Huazimet h ON m.Material_ID = h.Material_ID
GROUP BY 
    m.Titulli, 
    m.Lloji_Materialit
ORDER BY 
    Numri_Huazimeve DESC;
