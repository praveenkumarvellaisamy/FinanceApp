CREATE PROCEDURE PRLOANDELETE
(	
	 @LOANID			INT	
	,@USERCODE			INT	=	NULL
)
AS
BEGIN
	DELETE FROM TBLLOAN
	WHERE FLDLOANID = @LOANID
END