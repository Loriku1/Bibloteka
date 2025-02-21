CREATE FUNCTION LlogaritDenimin
(
    @Huazimi_ID INT,
    @Tarifa_Ditore DECIMAL(10,2) -- Tarifa për çdo ditë vonese
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @Data_Kthimit DATE, @Data_Kthimit_Reale DATE, @DiteVonesa INT, @Denimi DECIMAL(10,2);

    -- Merr datën e kthimit dhe datën reale të kthimit për huazimin e dhënë
    SELECT @Data_Kthimit = Data_Kthimit, 
           @Data_Kthimit_Reale = Data_Kthimit_Reale
    FROM Huazimet 
    WHERE Huazimi_ID = @Huazimi_ID;

    -- Nëse libri ende nuk është kthyer, vendos si datë kthimi reale sot
    IF @Data_Kthimit_Reale IS NULL
        SET @Data_Kthimit_Reale = GETDATE();

    -- Llogarit sa ditë ka vonesë (nëse ka vonesë)
    SET @DiteVonesa = DATEDIFF(DAY, @Data_Kthimit, @Data_Kthimit_Reale);

    -- Nëse nuk ka vonesë, dënimi është 0
    IF @DiteVonesa <= 0
        SET @Denimi = 0;
    ELSE
        SET @Denimi = @DiteVonesa * @Tarifa_Ditore; -- Shuma e dënimit sipas tarifës ditore

    RETURN @Denimi;
END;

SELECT Huazimi_ID, Data_Kthimit, Data_Kthimit_Reale, dbo.LlogaritDenimin(Huazimi_ID, 1.00) AS Denimi
FROM Huazimet;

ALTER FUNCTION LlogaritDenimin
(
    @Huazimi_ID INT,
    @Tarifa_Ditore DECIMAL(10,2) -- Tarifa për çdo ditë vonese
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @Data_Kthimit DATE, 
            @Data_Kthimit_Reale DATE, 
            @DiteVonesa INT, 
            @Denimi DECIMAL(10,2);

    -- Merr datën e kthimit dhe datën reale të kthimit për huazimin e dhënë
    SELECT @Data_Kthimit = Data_Kthimit, 
           @Data_Kthimit_Reale = Data_Kthimit_Reale
    FROM Huazimet 
    WHERE Huazimi_ID = @Huazimi_ID;

    -- Nëse Data_Kthimit_Reale është NULL, vendos si vlerë datën aktuale (supozojmë se libri nuk është kthyer)
    IF @Data_Kthimit_Reale IS NULL
        SET @Data_Kthimit_Reale = GETDATE();

    -- Llogarit ditët e vonesës
    SET @DiteVonesa = DATEDIFF(DAY, @Data_Kthimit, @Data_Kthimit_Reale);

    -- Nëse vonesa është negative ose zero, dënimi është 0
    IF @DiteVonesa <= 0
        SET @Denimi = 0;
    ELSE
        SET @Denimi = @DiteVonesa * @Tarifa_Ditore; -- Llogarit dënimin sipas tarifës ditore

    RETURN @Denimi;
END;

SELECT Huazimi_ID, Data_Huazimit, Data_Kthimit, Data_Kthimit_Reale, 
       dbo.LlogaritDenimin(Huazimi_ID, 1.00) AS Denimi
FROM Huazimet;
