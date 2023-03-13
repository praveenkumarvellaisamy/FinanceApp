CREATE PROCEDURE PRLINEINSERT  
(		
	 @LINECODE			NVARCHAR(25)
	,@LINENAME			VARCHAR(50)
	,@USERCODE			INT
)
AS
BEGIN
	DECLARE @LINEID INT

	SELECT @LINEID = MAX(FLDLINEID)
	FROM TBLLINE

	INSERT INTO TBLLINE
	(
		 FLDLINEID
		,FLDLINECODE
		,FLDLINENAME
		,FLDCREATEDDATE
		,FLDCREATEBY
		,FLDMODIFIEDDATE
		,FLDMODIFIEDBY
	)
	SELECT ISNULL(@LINEID,0) + 1
		,@LINECODE
		,@LINENAME
		,GETUTCDATE()
		,@USERCODE
		,GETUTCDATE()
		,@USERCODE
END