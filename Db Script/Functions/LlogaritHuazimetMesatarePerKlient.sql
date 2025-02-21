CREATE FUNCTION LlogaritHuazimetMesatarePerKlient
(
    @Klienti_ID INT -- ID e klientit për të marrë huazimet mesatare
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @Mesatare DECIMAL(10,2);
    
    -- Llogarit huazimet mesatare për klientin
    SELECT @Mesatare = AVG(CASE 
                            WHEN h.Klienti_ID = @Klienti_ID THEN 1
                            ELSE NULL
                        END)
    FROM Huazimet h
    WHERE h.Klienti_ID = @Klienti_ID;
    
    -- Kthe mesataren
    RETURN ISNULL(@Mesatare, 0.00); -- Nëse nuk ka huazime, kthe 0
END


SELECT dbo.LlogaritHuazimetMesatarePerKlient(1) AS HuazimetMesatare;
