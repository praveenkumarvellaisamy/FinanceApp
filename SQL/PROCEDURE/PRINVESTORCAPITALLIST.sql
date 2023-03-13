CREATE PROCEDURE PRINVESTORCAPITALLIST
(	
	@INVESTORCAPITALID	INT	=	NULL
)
AS
BEGIN
	SELECT 
		 FLDINVESTORCAPITALID
		,FLDUSERCODE
		,FLDAMOUND
		,FLDDATE
		,FLDTRANSACTIONTYPEID
		,FLDTRANSACTIONTYPE
		,FLDCOMPANYID
		,FLDCREATEDDATE
		,FLDCREATEBY
		,FLDMODIFIEDDATE
		,FLDMODIFIEDBY
	FROM TBLINVESTORCAPITAL
	WHERE (@INVESTORCAPITALID IS NULL OR FLDINVESTORCAPITALID = @INVESTORCAPITALID)
END