CREATE TABLE TBLAUDITCOMPANY
(
	 FLDAUDITTYPE				INT						NOT NULL
	,FLDAUDITUSERCODE			INT						NOT NULL
	,FLDAUDITDATETIME			DATETIME				NOT NULL
	,FLDAUDITPROCEDURE			VARCHAR(128)			NOT NULL
	,FLDCOMPANYID				INT						NOT NULL
	,FLDCOMPANYNAME				VARCHAR(250)			NOT NULL
	,FLDSHORTCODE				VARCHAR(20)				NOT NULL
	,FLDADDRESS					NVARCHAR(500)				NULL
	,FLDCITY					VARCHAR(50)					NULL
	,FLDSTATE					VARCHAR(50)					NULL
	,FLDCOUNTRY					VARCHAR(50)					NULL
	,FLDCREATEDDATE				DATETIME				NOT NULL
	,FLDCREATEBY				INT						NOT	NULL
	,FLDMODIFIEDDATE			DATETIME				NOT NULL
	,FLDMODIFIEDBY				INT						NOT	NULL


)


