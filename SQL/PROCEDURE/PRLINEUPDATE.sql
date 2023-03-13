CREATE PROCEDURE PRLINEUPDATE
(	
	 @LINEID			INT
	,@LINECODE			NVARCHAR(25)
	,@LINENAME			VARCHAR(50)
	,@USERCODE			INT
)
AS
BEGIN
	UPDATE TBLLINE
	SET 
		 FLDLINECODE		= @LINECODE 
		,FLDLINENAME		= @LINENAME
		,FLDMODIFIEDDATE	= GETUTCDATE()
		,FLDMODIFIEDBY		= @USERCODE
	WHERE FLDLINEID			= @LINEID
END