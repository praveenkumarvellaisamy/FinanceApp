CREATE PROCEDURE PRUSERLIST
(	
	@USERCODEID	INT	=	NULL
)
AS
BEGIN
	SELECT 
	      FLDUSERCODE
		, FLDFIRSTNAME
		, FLDLASTNAME
		, FLDUSERNAME
		, FLDPASSWORD
		, FLDUSERTYPEID
		, FLDUSERTYPE
		, FLDAPPLICABLECOMPANYID
		, FLDAPPLICABLECOMPANY
		, FLDPHONENUMBER
		, FLDDEFAULTCOMPANYID
		, FLDAPPLICABLEAREA
		, FLDPROFILEPICPATH
		, FLDCREATEDDATE
		, FLDCREATEBY
		, FLDMODIFIEDDATE
		, FLDMODIFIEDBY
	FROM TBLUSER
	WHERE (@USERCODEID IS NULL OR FLDUSERCODE = @USERCODEID)
END