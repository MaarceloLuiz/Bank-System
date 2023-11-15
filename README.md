# Bank-System

## Database Table

CREATE TABLE [dbo].[NewAccount] (

    [AccNum]    INT            IDENTITY (100000, 1) NOT NULL,
    [FirstName] NVARCHAR (50)  NOT NULL,
    [Surname]   NVARCHAR (50)  NOT NULL,
    [DOB]       NVARCHAR (150) NOT NULL,
    [County]    NVARCHAR (50)  NOT NULL,
    [Gender]    NVARCHAR (50)  NOT NULL,
    [Balance]   MONEY          NOT NULL,
    [AccType]   NVARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([AccNum] ASC)
    
);

--------------------------------------------------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[Transactions] (

    [TransactionsID] INT            IDENTITY (1, 1) NOT NULL,
    [Firstname]      NVARCHAR (50)  NULL,
    [Surname]        NVARCHAR (50)  NULL,
    [DOB]            NVARCHAR (150) NULL,
    [County]         NVARCHAR (50)  NULL,
    [Gender]         NVARCHAR (50)  NULL,
    [Balance]        MONEY          NULL,
    [AccType]        NVARCHAR (50)  NULL,
    [Amount]         MONEY          NULL,
    PRIMARY KEY CLUSTERED ([TransactionsID] ASC)
    
);

## Triggers

CREATE TRIGGER [Trig]
	ON [dbo].[NewAccount]
	FOR DELETE, INSERT, UPDATE
	AS
	BEGIN
 
		DECLARE @fn nvarchar(50)
		SELECT @fn = Firstname From inserted
		DECLARE @sn nvarchar(50)
		SELECT @sn = Surname From inserted
		DECLARE @dob nvarchar(150)
		SELECT @dob = DOB From inserted
		DECLARE @cy nvarchar(50)
		SELECT @cy = County FROM inserted
		DECLARE @ge nvarchar(50)
		SELECT @ge = Gender FROM inserted
		DECLARE @bal money
		SELECT @bal = Balance From inserted
		DECLARE @act nvarchar(50)
		SELECT @act = AccType From inserted

		INSERT INTO Transactions(Firstname, Surname, DOB, County, Gender, Balance, AccType) VALUES(@fn, @sn, @dob, @cy, @ge, @bal, @act)

	END

## Stored Procedures

CREATE PROCEDURE [dbo].[uspAddAcc]

	@fn nvarchar(50),
	@sn nvarchar(50),
	@dob nvarchar(150),
	@cy nvarchar(50),
	@ge nvarchar(50),
	@bal money,
	@acty nvarchar(50)
 
AS

	INSERT INTO NewAccount(FirstName, Surname, DOB, County, Gender, Balance, AccType) VALUES(@fn, @sn, @dob, @cy, @ge, @bal, @acty)
 
RETURN 0

--------------------------------------------------------------------------------------------------------------------------------------------


CREATE PROCEDURE [dbo].[uspAllAbove]

	@amt decimal
 
AS

	SELECT * FROM NewAccount WHERE Balance > @amt
 
RETURN 0

--------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[uspGen]

	@gen nvarchar(50)
 
AS

	SELECT * FROM NewAccount WHERE Gender = @gen
 
RETURN 0

--------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[uspGetAll]

AS

	SELECT * FROM NewAccount
 
RETURN 0

--------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[uspGetBalance]

	@acNo int
 
AS

	SELECT * FROM NewAccount WHERE AccNum = @acNo
 
RETURN 0

--------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[uspPopCombo]
	
AS

	SELECT * FROM NewAccount
 
RETURN 0

--------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[uspTransfer]

	@acNoFrom int,
	@nbFrom decimal,
	@acNoTo int,
	@nbTo decimal
 
AS

	UPDATE NewAccount SET Balance = @nbFrom WHERE AccNum = @acNoFrom
	UPDATE NewAccount SET Balance = @nbTo WHERE AccNum = @acNoTo
 
RETURN 0

--------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[uspUpdateBalance]

	@acNo int,
	@nb decimal
 
AS

	UPDATE NewAccount SET Balance = @nb WHERE AccNum = @acNo
 
RETURN 0

--------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[uspAllTransactions]
	
AS

	SELECT * from Transactions
 
RETURN 0
