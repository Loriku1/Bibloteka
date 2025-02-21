CREATE FUNCTION LlogaritDenimin
(
    @Huazimi_ID INT,
    @Tarifa_Ditore DECIMAL(10,2) -- Tarifa p�r �do dit� vonese
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @Data_Kthimit DATE, @Data_Kthimit_Reale DATE, @DiteVonesa INT, @Denimi DECIMAL(10,2);

    -- Merr dat�n e kthimit dhe dat�n reale t� kthimit p�r huazimin e dh�n�
    SELECT @Data_Kthimit = Data_Kthimit, 
           @Data_Kthimit_Reale = Data_Kthimit_Reale
    FROM Huazimet 
    WHERE Huazimi_ID = @Huazimi_ID;

    -- N�se libri ende nuk �sht� kthyer, vendos si dat� kthimi reale sot
    IF @Data_Kthimit_Reale IS NULL
        SET @Data_Kthimit_Reale = GETDATE();

    -- Llogarit sa dit� ka vones� (n�se ka vones�)
    SET @DiteVonesa = DATEDIFF(DAY, @Data_Kthimit, @Data_Kthimit_Reale);

    -- N�se nuk ka vones�, d�nimi �sht� 0
    IF @DiteVonesa <= 0
        SET @Denimi = 0;
    ELSE
        SET @Denimi = @DiteVonesa * @Tarifa_Ditore; -- Shuma e d�nimit sipas tarif�s ditore

    RETURN @Denimi;
END;

SELECT Huazimi_ID, Data_Kthimit, Data_Kthimit_Reale, dbo.LlogaritDenimin(Huazimi_ID, 1.00) AS Denimi
FROM Huazimet;

ALTER FUNCTION LlogaritDenimin
(
    @Huazimi_ID INT,
    @Tarifa_Ditore DECIMAL(10,2) -- Tarifa p�r �do dit� vonese
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @Data_Kthimit DATE, 
            @Data_Kthimit_Reale DATE, 
            @DiteVonesa INT, 
            @Denimi DECIMAL(10,2);

    -- Merr dat�n e kthimit dhe dat�n reale t� kthimit p�r huazimin e dh�n�
    SELECT @Data_Kthimit = Data_Kthimit, 
           @Data_Kthimit_Reale = Data_Kthimit_Reale
    FROM Huazimet 
    WHERE Huazimi_ID = @Huazimi_ID;

    -- N�se Data_Kthimit_Reale �sht� NULL, vendos si vler� dat�n aktuale (supozojm� se libri nuk �sht� kthyer)
    IF @Data_Kthimit_Reale IS NULL
        SET @Data_Kthimit_Reale = GETDATE();

    -- Llogarit dit�t e vones�s
    SET @DiteVonesa = DATEDIFF(DAY, @Data_Kthimit, @Data_Kthimit_Reale);

    -- N�se vonesa �sht� negative ose zero, d�nimi �sht� 0
    IF @DiteVonesa <= 0
        SET @Denimi = 0;
    ELSE
        SET @Denimi = @DiteVonesa * @Tarifa_Ditore; -- Llogarit d�nimin sipas tarif�s ditore

    RETURN @Denimi;
END;

SELECT Huazimi_ID, Data_Huazimit, Data_Kthimit, Data_Kthimit_Reale, 
       dbo.LlogaritDenimin(Huazimi_ID, 1.00) AS Denimi
FROM Huazimet;
