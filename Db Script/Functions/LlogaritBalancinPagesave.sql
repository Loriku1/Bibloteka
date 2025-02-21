CREATE FUNCTION LlogaritBalancinPagesave
(
    @Klienti_ID INT -- ID e klientit për të marrë balancin e pagesave
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @Balanci DECIMAL(10,2);
    
    -- Llogarit balancin e pagesave për klientin
    SELECT @Balanci = SUM(CASE 
                            WHEN p.Lloji_Pageses = 'Dënim për vonesë' THEN p.Shuma -- Dënimet e vonesës janë detyrim
                            WHEN p.Lloji_Pageses = 'Pagesë mujore' THEN p.Shuma -- Pagesat mujore janë pozitive
                            ELSE 0 -- Për lloje të tjera pagesash, nuk bëhet llogaritje
                        END)
    FROM Pagesat p
    WHERE p.Klienti_ID = @Klienti_ID;
    
    -- Kthe balancin
    RETURN ISNULL(@Balanci, 0.00); -- Nëse klienti nuk ka pagesa, kthe 0
END


SELECT dbo.LlogaritBalancinPagesave(1) AS Balanci;
