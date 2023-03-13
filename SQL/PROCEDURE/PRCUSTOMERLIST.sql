CREATE PROCEDURE PRCUSTOMERLIST
(	
	@CUSTOMERID	INT	=	NULL
)
AS
BEGIN
	SELECT 
	    FLDCUSTOMERID
		,FLDCUSTOMERCODE
		,FLDFIRSTNAME
		,FLDLASTNAME
		,FLDDATEOFBIRTH
		,FLDGOVTIDTYPEID
		,FLDGOVTIDTYPE
		,FLDIDNUMBER
		,FLDIDATTACHMENTPATH
		,FLDPROFPICPATH
		,FLDQRCODE
		,FLDPHONENUMBER
		,FLDAREAID
		,FLDLOCATION
		,FLDADDRESS
		,FLDCREATEDDATE
		,FLDCREATEBY
		,FLDMODIFIEDDATE
		,FLDMODIFIEDBY
	FROM TBLCUSTOMER
	WHERE (@CUSTOMERID IS NULL OR FLDCUSTOMERID = @CUSTOMERID)
END