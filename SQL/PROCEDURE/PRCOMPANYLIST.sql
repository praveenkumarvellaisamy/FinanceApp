CREATE PROCEDURE PRCOMPANYLIST
(	
	@COMPANYID	INT	=	NULL
)
AS
BEGIN
	SELECT 
		 FLDCOMPANYID
		,FLDCOMPANYNAME
		,FLDSHORTCODE
		,FLDADDRESS
		,FLDCITY
		,FLDSTATE
		,FLDCOUNTRY
		,FLDCREATEDDATE
		,FLDCREATEBY
		,FLDMODIFIEDDATE
		,FLDMODIFIEDBY
	FROM TBLCOMPANY
	WHERE (@COMPANYID IS NULL OR FLDCOMPANYID = @COMPANYID)
END