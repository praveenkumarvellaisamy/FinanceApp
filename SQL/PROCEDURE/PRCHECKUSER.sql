CREATE PROCEDURE PRCHECKUSER 
(
	@USERNAME  VARCHAR(100)  
	,@PASSWORD NVARCHAR(200) 
)
AS 
BEGIN 
	SELECT FLDUSERCODE
		,FLDFIRSTNAME
		,FLDLASTNAME
		,FLDUSERNAME
		,FLDPASSWORD
		,FLDUSERTYPEID
		,FLDUSERTYPE
		,FLDAPPLICABLECOMPANYID
		,FLDAPPLICABLECOMPANY
		,FLDPHONENUMBER
		,FLDDEFAULTCOMPANYID
		,FLDAPPLICABLEAREA
		,FLDPROFILEPICPATH
		,FLDCREATEDDATE
		,FLDCREATEBY
		,FLDMODIFIEDDATE
		,FLDMODIFIEDBY
	FROM TBLUSER(NOLOCK)
	WHERE FLDUSERNAME = @USERNAME 
			AND FLDPASSWORD = HASHBYTES('MD5',@PASSWORD) 
END