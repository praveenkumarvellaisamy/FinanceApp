CREATE PROCEDURE PRINVESTORCAPITALUPDATE
(	
	 @INVESTORCAPITALID		 INT
	,@INVESUSERCODE			 INT
	,@AMOUND				 DECIMAL(18,2)		
	,@DATE					 DATETIME
	,@TRANSACTIONTYPEID		 INT
	,@TRANSACTIONTYPE		 VARCHAR(1)
	,@COMPANYID				 INT
	,@USERCODE				 INT
)
AS
BEGIN
	UPDATE TBLINVESTORCAPITAL
	SET 
		 FLDUSERCODE			= @INVESUSERCODE			
		,FLDAMOUND				= @AMOUND				
		,FLDDATE				= @DATE				
		,FLDTRANSACTIONTYPEID	= @TRANSACTIONTYPEID	
		,FLDTRANSACTIONTYPE		= @TRANSACTIONTYPE		
		,FLDCOMPANYID			= @COMPANYID			
		,FLDMODIFIEDDATE		= GETUTCDATE()
		,FLDMODIFIEDBY			= @USERCODE
	WHERE FLDINVESTORCAPITALID	 = @INVESTORCAPITALID
END