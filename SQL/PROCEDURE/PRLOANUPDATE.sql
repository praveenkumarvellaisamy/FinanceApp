CREATE PROCEDURE PRLOANUPDATE
(	
	 @LOANID			INT
	,@LOANCODE			VARCHAR(50)		
	,@CUSTOMERID		INT				
	,@STATUS			VARCHAR(50)		
	,@DISBURSEMENTDATE	DATETIME		
	,@AMOUNT			DECIMAL(18,2)	
	,@COMPANYID			INT				
	,@USERCODE			INT
)
AS
BEGIN
	UPDATE TBLLOAN
	SET 
		
		 FLDLOANCODE		 = @LOANCODE
		,FLDCUSTOMERID		 = @CUSTOMERID
		,FLDSTATUS			 = @STATUS
		,FLDDISBURSEMENTDATE = @DISBURSEMENTDATE
		,FLDAMOUNT			 = @AMOUNT
		,FLDCOMPANYID		 = @COMPANYID
		,FLDMODIFIEDDATE	 = GETUTCDATE()
		,FLDMODIFIEDBY		 = @USERCODE
	WHERE FLDLOANID			 = @LOANID
END