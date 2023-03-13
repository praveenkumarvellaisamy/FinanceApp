CREATE PROCEDURE PRCOMPANYUPDATE
(	
	 @COMPANYID		INT
	,@COMPANYNAME	VARCHAR(250)
	,@SHORTCODE		VARCHAR(20)
	,@ADDRESS		NVARCHAR(500)
	,@CITY			VARCHAR(50)
	,@STATE			VARCHAR(50)
	,@COUNTRY		VARCHAR(50)
	,@USERCODE		INT
)
AS
BEGIN
	UPDATE TBLCOMPANY
	SET 
		 FLDCOMPANYNAME		=	@COMPANYNAME
		,FLDSHORTCODE		=	@SHORTCODE
		,FLDADDRESS			=	@ADDRESS
		,FLDCITY			=	@CITY
		,FLDSTATE			=	@STATE
		,FLDCOUNTRY			=	@COUNTRY
		,FLDMODIFIEDDATE	=	GETUTCDATE()
		,FLDMODIFIEDBY		=	@USERCODE
	WHERE FLDCOMPANYID		=	@COMPANYID
END