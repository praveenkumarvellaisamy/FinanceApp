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

