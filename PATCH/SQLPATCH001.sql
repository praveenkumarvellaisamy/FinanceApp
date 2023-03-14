CREATE TABLE TBLUSER
(
	 FLDUSERCODE				INT				    NOT NULL  IDENTITY(1,1)
	,FLDFIRSTNAME				VARCHAR(50)				NULL
	,FLDLASTNAME				VARCHAR(50)				NULL 
	,FLDUSERNAME				VARCHAR(50)				NULL
	,FLDPASSWORD				VARBINARY(50)		NOT NULL			
	,FLDUSERTYPEID				INT						NULL
	,FLDUSERTYPE				VARCHAR(50)				NULL
	,FLDAPPLICABLECOMPANYID		INT						NULL
	,FLDAPPLICABLECOMPANY		VARCHAR(50)				NULL	
	,FLDPHONENUMBER				VARCHAR(50)				NULL
	,FLDDEFAULTCOMPANYID		INT						NULL
	,FLDAPPLICABLEAREA			VARCHAR(50)				NULL
	,FLDPROFILEPICPATH			NVARCHAR(500)			NULL
	,FLDCREATEDDATE				DATETIME			NOT NULL
	,FLDCREATEBY				INT					NOT	NULL
	,FLDMODIFIEDDATE			DATETIME			NOT NULL
	,FLDMODIFIEDBY				INT					NOT	NULL
	CONSTRAINT PK_TBLUSER PRIMARY KEY
	(
		FLDUSERCODE ASC
	)
)
GO

CREATE TABLE TBLCUSTOMER
(
	 FLDCUSTOMERID				INT				    NOT NULL  
	,FLDCUSTOMERCODE			VARCHAR(50)				NULL
	,FLDFIRSTNAME				VARCHAR(50)				NULL
	,FLDLASTNAME				VARCHAR(50)				NULL
	,FLDDATEOFBIRTH				DATETIME				NULL
	,FLDGOVTIDTYPEID			INT						NULL
	,FLDGOVTIDTYPE				VARCHAR(50)				NULL
	,FLDIDNUMBER				VARCHAR(50)				NULL
	,FLDIDATTACHMENTPATH		VARCHAR(300)			NULL
	,FLDPROFPICPATH				VARCHAR(500)			NULL
	,FLDQRCODE					NVARCHAR(500)			NULL
	,FLDPHONENUMBER				VARCHAR(50)				NULL
	,FLDAREAID					INT						NULL
	,FLDLOCATION				VARCHAR(50)				NULL
	,FLDADDRESS					VARCHAR(50)				NULL
	,FLDCREATEDDATE				DATETIME			NOT NULL
	,FLDCREATEBY				INT					NOT	NULL
	,FLDMODIFIEDDATE			DATETIME			NOT NULL
	,FLDMODIFIEDBY				INT					NOT	NULL
	CONSTRAINT PK_TBLCUSTOMER PRIMARY KEY
	(
		FLDCUSTOMERID ASC
	)
)
GO

CREATE TABLE TBLCOMPANY
(
	 FLDCOMPANYID			INT				    NOT NULL 
	,FLDCOMPANYNAME			VARCHAR(250)	    NOT NULL
	,FLDSHORTCODE			VARCHAR(20)		    NOT NULL 
	,FLDADDRESS				NVARCHAR(500)			NULL
	,FLDCITY				VARCHAR(50)				NULL
	,FLDSTATE				VARCHAR(50)				NULL
	,FLDCOUNTRY				VARCHAR(50)				NULL
	,FLDCREATEDDATE			DATETIME			NOT NULL
	,FLDCREATEBY			INT					NOT	NULL
	,FLDMODIFIEDDATE		DATETIME			NOT NULL
	,FLDMODIFIEDBY			INT					NOT	NULL
	CONSTRAINT PK_TBLCOMPANY PRIMARY KEY
	(
		FLDCOMPANYID ASC
	)
)
GO

CREATE TABLE TBLAREA
(
	 FLDAREAID				INT				    NOT NULL 
	,FLDLINEID				INT					NOT	NULL
	,FLDAREACODE			VARCHAR(50)				NULL 
	,FLDAREANAME			VARCHAR(50)				NULL
	,FLDCREATEDDATE			DATETIME			NOT NULL
	,FLDCREATEBY			INT					NOT	NULL
	,FLDMODIFIEDDATE		DATETIME			NOT NULL
	,FLDMODIFIEDBY			INT					NOT	NULL
	CONSTRAINT PK_TBLAREA PRIMARY KEY
	(
		FLDAREAID ASC
	)
)
GO

CREATE TABLE TBLINVESTORCAPITAL
(
	 FLDINVESTORCAPITALID			INT				    NOT NULL  
	,FLDUSERCODE					INT						NULL
	,FLDAMOUND						DECIMAL(18,2)			NULL
	,FLDDATE						DATETIME				NULL
	,FLDTRANSACTIONTYPEID			INT						NULL
	,FLDTRANSACTIONTYPE				VARCHAR(1)				NULL
	,FLDCOMPANYID					INT						NULL
	,FLDCREATEDDATE					DATETIME			NOT NULL
	,FLDCREATEBY					INT					NOT	NULL
	,FLDMODIFIEDDATE				DATETIME			NOT NULL
	,FLDMODIFIEDBY					INT					NOT	NULL
	CONSTRAINT PK_TBLINVESTORCAPITAL PRIMARY KEY
	(
		FLDINVESTORCAPITALID ASC
	)
)
GO

CREATE TABLE TBLLINE
(
	 FLDLINEID				INT				    NOT NULL 
	,FLDLINECODE			NVARCHAR(25)			NULL
	,FLDLINENAME			VARCHAR(50)				NULL 
	,FLDCREATEDDATE			DATETIME			NOT NULL
	,FLDCREATEBY			INT					NOT	NULL
	,FLDMODIFIEDDATE		DATETIME			NOT NULL
	,FLDMODIFIEDBY			INT					NOT	NULL
	CONSTRAINT PK_TBLLINE PRIMARY KEY
	(
		FLDLINEID ASC
	)
)
GO

CREATE TABLE TBLLOAN
(
	 FLDLOANID						INT				    NOT NULL  
	,FLDLOANCODE					VARCHAR(50)				NULL
	,FLDCUSTOMERID					INT						NULL
	,FLDSTATUS						VARCHAR(50)				NULL
	,FLDDISBURSEMENTDATE			DATETIME				NULL
	,FLDAMOUNT						DECIMAL(18,2)			NULL
	,FLDCOMPANYID					INT						NULL
	,FLDCREATEDDATE					DATETIME			NOT NULL
	,FLDCREATEBY					INT					NOT	NULL
	,FLDMODIFIEDDATE				DATETIME			NOT NULL
	,FLDMODIFIEDBY					INT					NOT	NULL
	CONSTRAINT PK_TBLLOAN PRIMARY KEY
	(
		FLDLOANID ASC
	)
)
GO

CREATE TABLE TBLLOANTYPE
(
	 FLDLOANTYPEID					INT				    NOT NULL  
	,FLDTYPECODE					VARCHAR(50)				NULL
	,FLDLOANNAME					VARCHAR(50)				NULL
	,FLDLOANID						INT						NULL
	,FLDCREATEDDATE					DATETIME			NOT NULL
	,FLDCREATEBY					INT					NOT	NULL
	,FLDMODIFIEDDATE				DATETIME			NOT NULL
	,FLDMODIFIEDBY					INT					NOT	NULL
	CONSTRAINT PK_TBLLOANTYPE PRIMARY KEY
	(
		FLDLOANTYPEID ASC
	)
)
GO

CREATE PROCEDURE PRUSERINSERT  
(		
	  @FIRSTNAME				VARCHAR(50)		
	 ,@LASTNAME					VARCHAR(50)		
	 ,@USERNAME					VARCHAR(50)		
	 ,@PASSWORD					NVARCHAR(50)	
	 ,@USERTYPEID				INT				
	 ,@USERTYPE					VARCHAR(50)		
	 ,@APPLICABLECOMPANYID		INT				
	 ,@APPLICABLECOMPANY		VARCHAR(50)		
	 ,@PHONENUMBER				VARCHAR(50)		
	 ,@DEFAULTCOMPANYID			INT				
	 ,@APPLICABLEAREA			VARCHAR(50)		
	 ,@PROFILEPICPATH			NVARCHAR(500)	
	 ,@USERCODE					INT
)
AS
BEGIN
	
	INSERT INTO TBLUSER
	(
		 FLDFIRSTNAME			
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
	)
	SELECT 
		 @FIRSTNAME			
		,@LASTNAME				
		,@USERNAME				
		,HASHBYTES('MD5', N''+@PASSWORD+'')
		,@USERTYPEID			
		,@USERTYPE				
		,@APPLICABLECOMPANYID	
		,@APPLICABLECOMPANY	
		,@PHONENUMBER			
		,@DEFAULTCOMPANYID		
		,@APPLICABLEAREA		
		,@PROFILEPICPATH		
		,GETUTCDATE()
		,@USERCODE
		,GETUTCDATE()
		,@USERCODE

END
GO

CREATE PROCEDURE PRUSERUPDATE
(	
	 @USERCODEID				INT
	 ,@FIRSTNAME				VARCHAR(50)		
	 ,@LASTNAME					VARCHAR(50)		
	 ,@USERNAME					VARCHAR(50)		
	 ,@PASSWORD					NVARCHAR(50)	
	 ,@USERTYPEID				INT				
	 ,@USERTYPE					VARCHAR(50)		
	 ,@APPLICABLECOMPANYID		INT				
	 ,@APPLICABLECOMPANY		VARCHAR(50)		
	 ,@PHONENUMBER				VARCHAR(50)		
	 ,@DEFAULTCOMPANYID			INT				
	 ,@APPLICABLEAREA			VARCHAR(50)		
	 ,@PROFILEPICPATH			NVARCHAR(500)	
	 ,@USERCODE					INT
)
AS
BEGIN
	UPDATE TBLUSER
	SET 
		 FLDFIRSTNAME			 = @FIRSTNAME			
		,FLDLASTNAME			 = @LASTNAME				
		,FLDUSERNAME			 = @USERNAME				
		,FLDPASSWORD			 = HASHBYTES('MD5', N''+@PASSWORD+'')
		,FLDUSERTYPEID			 = @USERTYPEID			
		,FLDUSERTYPE			 = @USERTYPE				
		,FLDAPPLICABLECOMPANYID	 = @APPLICABLECOMPANYID	
		,FLDAPPLICABLECOMPANY	 = @APPLICABLECOMPANY	
		,FLDPHONENUMBER			 = @PHONENUMBER			
		,FLDDEFAULTCOMPANYID	 = @DEFAULTCOMPANYID		
		,FLDAPPLICABLEAREA		 = @APPLICABLEAREA		
		,FLDPROFILEPICPATH		 = @PROFILEPICPATH	
		,FLDMODIFIEDDATE		 = GETUTCDATE()
		,FLDMODIFIEDBY			 = @USERCODE
	WHERE FLDUSERCODE			 = @USERCODE
END
GO

CREATE PROCEDURE PRUSERDELETE
(	
	@USERCODEID				INT	=	NULL
)
AS
BEGIN
	DELETE FROM TBLUSER
	WHERE FLDUSERCODE = @USERCODEID
END
GO

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
		--, FLDPASSWORD
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
GO

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
GO

CREATE PROCEDURE PRCUSTOMERINSERT  
(		
	  @CUSTOMERCODE				VARCHAR(50)	
	 ,@FIRSTNAME				VARCHAR(50)	
	 ,@LASTNAME					VARCHAR(50)	
	 ,@DATEOFBIRTH				DATETIME	
	 ,@GOVTIDTYPEID				INT			
	 ,@GOVTIDTYPE				VARCHAR(50)	
	 ,@IDNUMBER					VARCHAR(50)	
	 ,@IDATTACHMENTPATH			VARCHAR(300)
	 ,@PROFPICPATH				VARCHAR(500)
	 ,@QRCODE					NVARCHAR(500)
	 ,@PHONENUMBER				VARCHAR(50)	
	 ,@AREAID					INT			
	 ,@LOCATION					VARCHAR(50)	
	 ,@ADDRESS				VARCHAR(50)	
	 ,@USERCODE					INT
)
AS
BEGIN
	
	DECLARE @CUSTOMERID INT

	SELECT @CUSTOMERID = MAX(FLDCUSTOMERID)
	FROM TBLCUSTOMER


	INSERT INTO TBLCUSTOMER
	(
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
	)
	SELECT ISNULL(@CUSTOMERID,0) + 1
		,@CUSTOMERCODE		
		,@FIRSTNAME		
		,@LASTNAME			
		,@DATEOFBIRTH		
		,@GOVTIDTYPEID		
		,@GOVTIDTYPE		
		,@IDNUMBER			
		,@IDATTACHMENTPATH	
		,@PROFPICPATH		
		,@QRCODE			
		,@PHONENUMBER		
		,@AREAID			
		,@LOCATION			
		,@ADDRESS			
		,GETUTCDATE()
		,@USERCODE
		,GETUTCDATE()
		,@USERCODE

END
GO

CREATE PROCEDURE PRCUSTOMERUPDATE
(	
	  @CUSTOMERID				INT			
	 ,@CUSTOMERCODE				VARCHAR(50)	
	 ,@FIRSTNAME				VARCHAR(50)	
	 ,@LASTNAME					VARCHAR(50)	
	 ,@DATEOFBIRTH				DATETIME	
	 ,@GOVTIDTYPEID				INT			
	 ,@GOVTIDTYPE				VARCHAR(50)	
	 ,@IDNUMBER					VARCHAR(50)	
	 ,@IDATTACHMENTPATH			VARCHAR(300)
	 ,@PROFPICPATH				VARCHAR(500)
	 ,@QRCODE					NVARCHAR(500)
	 ,@PHONENUMBER				VARCHAR(50)	
	 ,@AREAID					INT			
	 ,@LOCATION					VARCHAR(50)	
	 ,@ADDRESS				VARCHAR(50)	
	 ,@USERCODE					INT
)
AS
BEGIN
	UPDATE TBLCUSTOMER
	SET 
				
		 FLDCUSTOMERCODE		 = @CUSTOMERCODE		
		,FLDFIRSTNAME			 = @FIRSTNAME		
		,FLDLASTNAME			 = @LASTNAME			
		,FLDDATEOFBIRTH			 = @DATEOFBIRTH		
		,FLDGOVTIDTYPEID		 = @GOVTIDTYPEID		
		,FLDGOVTIDTYPE			 = @GOVTIDTYPE		
		,FLDIDNUMBER			 = @IDNUMBER			
		,FLDIDATTACHMENTPATH	 = @IDATTACHMENTPATH	
		,FLDPROFPICPATH			 = @PROFPICPATH		
		,FLDQRCODE				 = @QRCODE			
		,FLDPHONENUMBER			 = @PHONENUMBER		
		,FLDAREAID				 = @AREAID			
		,FLDLOCATION			 = @LOCATION			
		,FLDADDRESS				 = @ADDRESS			
		,FLDMODIFIEDDATE		 = GETUTCDATE()
		,FLDMODIFIEDBY			 = @USERCODE
	WHERE FLDCUSTOMERID			 = @CUSTOMERID
END
GO

CREATE PROCEDURE PRCUSTOMERDELETE
(	
	@CUSTOMERID				INT	=	NULL
)
AS
BEGIN
	DELETE FROM TBLCUSTOMER
	WHERE FLDCUSTOMERID = @CUSTOMERID
END
GO

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
GO

CREATE PROCEDURE PRCOMPANYINSERT  
(		
	 @COMPANYNAME	VARCHAR(250)
	,@SHORTCODE		VARCHAR(20)
	,@ADDRESS		NVARCHAR(500)
	,@CITY			VARCHAR(50)
	,@STATE			VARCHAR(50)
	,@COUNTRY		VARCHAR(50)
	,@USERCODE		INT
)
AS
BEGIN
	DECLARE @COMPANYID INT

	SELECT @COMPANYID = MAX(FLDCOMPANYID)
	FROM TBLCOMPANY

	INSERT INTO TBLCOMPANY
	(
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
	)
	SELECT ISNULL(@COMPANYID,0) + 1
		,@COMPANYNAME
		,@SHORTCODE
		,@ADDRESS
		,@CITY
		,@STATE
		,@COUNTRY
		,GETUTCDATE()
		,@USERCODE
		,GETUTCDATE()
		,@USERCODE
END
GO

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
GO

CREATE PROCEDURE PRCOMPANYDELETE
(	
	 @COMPANYID				INT	
	,@USERCODE				INT	=	NULL
)
AS
BEGIN
	DELETE FROM TBLCOMPANY
	WHERE FLDCOMPANYID = @COMPANYID
END
GO

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
GO

CREATE PROCEDURE PRAREAINSERT  
(		
	 @LINEID			INT
	,@AREACODE			VARCHAR(50)
	,@AREANAME			VARCHAR(50)
	,@USERCODE			INT
)
AS
BEGIN
	DECLARE @AREAID INT

	SELECT @AREAID = MAX(FLDAREAID)
	FROM TBLAREA

	INSERT INTO TBLAREA
	(
		 FLDAREAID
		,FLDLINEID
		,FLDAREACODE
		,FLDAREANAME
		,FLDCREATEDDATE
		,FLDCREATEBY
		,FLDMODIFIEDDATE
		,FLDMODIFIEDBY
	)
	SELECT ISNULL(@AREAID,0) + 1
		,@LINEID
		,@AREACODE
		,@AREANAME
		,GETUTCDATE()
		,@USERCODE
		,GETUTCDATE()
		,@USERCODE
END
GO

CREATE PROCEDURE PRAREAUPDATE
(	
	 @AREAID			INT
	,@LINEID			INT
	,@AREACODE			VARCHAR(50)
	,@AREANAME			VARCHAR(50)
	,@USERCODE			INT
)
AS
BEGIN
	UPDATE TBLAREA
	SET 
		 FLDLINEID			= @LINEID
		,FLDAREACODE		= @AREACODE
		,FLDAREANAME		= @AREANAME
		,FLDMODIFIEDDATE	= GETUTCDATE()
		,FLDMODIFIEDBY		= @USERCODE
	WHERE FLDAREAID			= @AREAID
END
GO

CREATE PROCEDURE PRAREADELETE
(	
	 @AREAID			INT	
	,@USERCODE			INT	=	NULL
)
AS
BEGIN
	DELETE FROM TBLAREA
	WHERE FLDAREAID = @AREAID
END
GO

CREATE PROCEDURE PRAREALIST
(	
	@AREAID	INT	=	NULL
)
AS
BEGIN
	SELECT 
		 FLDAREAID
		,FLDLINEID
		,FLDAREACODE
		,FLDAREANAME
		,FLDCREATEDDATE
		,FLDCREATEBY
		,FLDMODIFIEDDATE
		,FLDMODIFIEDBY
	FROM TBLAREA
	WHERE (@AREAID IS NULL OR FLDAREAID = @AREAID)
END
GO

CREATE PROCEDURE PRINVESTORCAPITALINSERT  
(		
	 @INVESUSERCODE			 INT
	,@AMOUND				 DECIMAL(18,2)		
	,@DATE					 DATETIME
	,@TRANSACTIONTYPEID		 INT
	,@TRANSACTIONTYPE		 VARCHAR(5)
	,@COMPANYID				 INT
	,@USERCODE				 INT
)
AS
BEGIN
	DECLARE @INVESTORCAPITALID INT

	SELECT @INVESTORCAPITALID = MAX(FLDINVESTORCAPITALID)
	FROM TBLINVESTORCAPITAL

	INSERT INTO TBLINVESTORCAPITAL
	(
		 FLDINVESTORCAPITALID
		,FLDUSERCODE
		,FLDAMOUND
		,FLDDATE
		,FLDTRANSACTIONTYPEID
		,FLDTRANSACTIONTYPE
		,FLDCOMPANYID
		,FLDCREATEDDATE
		,FLDCREATEBY
		,FLDMODIFIEDDATE
		,FLDMODIFIEDBY
	)
	SELECT ISNULL(@INVESTORCAPITALID,0) + 1
		,@INVESUSERCODE		
		,@AMOUND			
		,@DATE				
		,@TRANSACTIONTYPEID	
		,@TRANSACTIONTYPE	
		,@COMPANYID			
		,GETUTCDATE()
		,@USERCODE
		,GETUTCDATE()
		,@USERCODE
END
GO

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
GO

CREATE PROCEDURE PRINVESTORCAPITALDELETE
(	
	 @INVESTORCAPITALID			INT	
	,@USERCODE					INT	=	NULL
)
AS
BEGIN
	DELETE FROM TBLINVESTORCAPITAL
	WHERE FLDINVESTORCAPITALID = @INVESTORCAPITALID
END
GO

CREATE PROCEDURE PRINVESTORCAPITALLIST
(	
	@INVESTORCAPITALID	INT	=	NULL
)
AS
BEGIN
	SELECT 
		 FLDINVESTORCAPITALID
		,FLDUSERCODE
		,FLDAMOUND
		,FLDDATE
		,FLDTRANSACTIONTYPEID
		,FLDTRANSACTIONTYPE
		,FLDCOMPANYID
		,FLDCREATEDDATE
		,FLDCREATEBY
		,FLDMODIFIEDDATE
		,FLDMODIFIEDBY
	FROM TBLINVESTORCAPITAL
	WHERE (@INVESTORCAPITALID IS NULL OR FLDINVESTORCAPITALID = @INVESTORCAPITALID)
END
GO

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
GO

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
GO

CREATE PROCEDURE PRLINEDELETE
(	
	 @LINEID			INT	
	,@USERCODE			INT	=	NULL
)
AS
BEGIN
	DELETE FROM TBLLINE
	WHERE FLDLINEID = @LINEID
END
GO

CREATE PROCEDURE PRLINELIST
(	
	@LINEID	INT	=	NULL
)
AS
BEGIN
	SELECT 
		 
		 FLDLINECODE
		,FLDLINENAME
		,FLDCREATEDDATE
		,FLDCREATEBY
		,FLDMODIFIEDDATE
		,FLDMODIFIEDBY
	FROM TBLLINE
	WHERE (@LINEID IS NULL OR FLDLINEID =@LINEID)
END
GO

CREATE PROCEDURE PRLOANINSERT  

(		
	 @LOANCODE			VARCHAR(50)		
	,@CUSTOMERID		INT				
	,@STATUS			VARCHAR(50)		
	,@DISBURSEMENTDATE	DATETIME		
	,@AMOUNT			DECIMAL(18,2)	
	,@COMPANYID			INT				
	,@USERCODE			INT
)
AS
BEGIN
	DECLARE @LOANID INT

	SELECT @LOANID = MAX(FLDLOANID)
	FROM TBLLOAN

	INSERT INTO TBLLOAN
	(
		FLDLOANID
		,FLDLOANCODE
		,FLDCUSTOMERID
		,FLDSTATUS
		,FLDDISBURSEMENTDATE
		,FLDAMOUNT
		,FLDCOMPANYID
		,FLDCREATEDDATE
		,FLDCREATEBY
		,FLDMODIFIEDDATE
		,FLDMODIFIEDBY
	)
	SELECT ISNULL(@LOANID,0) + 1
		,@LOANCODE			
		,@CUSTOMERID		
		,@STATUS			
		,@DISBURSEMENTDATE	
		,@AMOUNT			
		,@COMPANYID			
		,GETUTCDATE()
		,@USERCODE
		,GETUTCDATE()
		,@USERCODE
END
GO

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
GO

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
GO

CREATE PROCEDURE PRLOANLIST
(	
	@LOANID	INT	=	NULL
)
AS
BEGIN
	SELECT 
		FLDLOANID
		,FLDLOANCODE
		,FLDCUSTOMERID
		,FLDSTATUS
		,FLDDISBURSEMENTDATE
		,FLDAMOUNT
		,FLDCOMPANYID
		,FLDCREATEDDATE
		,FLDCREATEBY
		,FLDMODIFIEDDATE
		,FLDMODIFIEDBY
	FROM TBLLOAN
	WHERE (@LOANID IS NULL OR FLDLOANID = @LOANID)
END
GO

CREATE PROCEDURE PRLOANTYPEINSERT  

(		
	 @TYPECODE		VARCHAR(50)
	,@LOANNAME		VARCHAR(50)
	,@LOANID		INT
	,@USERCODE		INT
)
AS
BEGIN
	DECLARE @LOANTYPEID INT

	SELECT @LOANTYPEID = MAX(FLDLOANTYPEID)
	FROM TBLLOANTYPE

	INSERT INTO TBLLOANTYPE
	(
		 FLDLOANTYPEID
		,FLDTYPECODE
		,FLDLOANNAME
		,FLDLOANID
		,FLDCREATEDDATE
		,FLDCREATEBY
		,FLDMODIFIEDDATE
		,FLDMODIFIEDBY
	)
	SELECT ISNULL(@LOANTYPEID,0) + 1
		,@TYPECODE
		,@LOANNAME
		,@LOANID
		,GETUTCDATE()
		,@USERCODE
		,GETUTCDATE()
		,@USERCODE
END
GO

CREATE PROCEDURE PRLOANTYPEUPDATE
(	
	@LOANTYPEID		INT
	,@TYPECODE		VARCHAR(50)
	,@LOANNAME		VARCHAR(50)
	,@LOANID		INT
	,@USERCODE		INT
)
AS
BEGIN
	UPDATE TBLLOANTYPE
	SET 
		 FLDTYPECODE		 = @TYPECODE
		,FLDLOANNAME		 = @LOANNAME
		,FLDLOANID			 = @LOANID
		,FLDMODIFIEDDATE	 = GETUTCDATE()
		,FLDMODIFIEDBY		 = @USERCODE
	WHERE FLDLOANTYPEID		 = @LOANTYPEID
END
GO

CREATE PROCEDURE PRLOANTYPEDELETE
(	
	 @LOANTYPEID			INT	
	,@USERCODE			INT	=	NULL
)
AS
BEGIN
	DELETE FROM TBLLOANTYPE
	WHERE FLDLOANTYPEID = @LOANTYPEID
END
GO

CREATE PROCEDURE PRLOANTYPELIST
(	
	@LOANTYPEID	INT	=	NULL
)
AS
BEGIN
	SELECT 
		FLDLOANTYPEID
		,FLDTYPECODE
		,FLDLOANNAME
		,FLDLOANID
		,FLDCREATEDDATE
		,FLDCREATEBY
		,FLDMODIFIEDDATE
		,FLDMODIFIEDBY
	FROM TBLLOANTYPE
	WHERE (@LOANTYPEID IS NULL OR FLDLOANTYPEID = @LOANTYPEID)
END
GO