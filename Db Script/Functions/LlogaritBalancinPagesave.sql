CREATE FUNCTION LlogaritBalancinPagesave
(
    @Klienti_ID INT -- ID e klientit p�r t� marr� balancin e pagesave
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @Balanci DECIMAL(10,2);
    
    -- Llogarit balancin e pagesave p�r klientin
    SELECT @Balanci = SUM(CASE 
                            WHEN p.Lloji_Pageses = 'D�nim p�r vones�' THEN p.Shuma -- D�nimet e vones�s jan� detyrim
                            WHEN p.Lloji_Pageses = 'Pages� mujore' THEN p.Shuma -- Pagesat mujore jan� pozitive
                            ELSE 0 -- P�r lloje t� tjera pagesash, nuk b�het llogaritje
                        END)
    FROM Pagesat p
    WHERE p.Klienti_ID = @Klienti_ID;
    
    -- Kthe balancin
    RETURN ISNULL(@Balanci, 0.00); -- N�se klienti nuk ka pagesa, kthe 0
END


SELECT dbo.LlogaritBalancinPagesave(1) AS Balanci;
