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

