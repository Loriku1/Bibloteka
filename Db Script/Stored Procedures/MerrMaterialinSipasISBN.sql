CREATE PROCEDURE MerrMaterialinSipasISBN
    @ISBN VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Material_ID, Titulli, Autori, BashkeAutoret, Botuesi, Data_Publikimit, 
           ISBN, DOI, Lloji_Materialit, Abstrakti, Kopjet_Disponibile, Data_Shtuar
    FROM Materialet_Bibliografike
    WHERE ISBN = @ISBN;
END;

EXEC MerrMaterialinSipasISBN @ISBN = '9780743273565';



