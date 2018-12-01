USE [Employee]
GO

/****** Object:  StoredProcedure [dbo].[usp_Employee_Select]    Script Date: 12/1/2018 1:17:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE usp_Employee_Select
(
	@EmployeeID int
)

AS 

SET NOCOUNT ON

SELECT	EmployeeID,
		LastName,
		FirstName,
		Gender,
		MiddleName,
		HiredDate
FROM	Employee
WHERE	EmployeeID	= @EmployeeID
GO

USE [Employee]
GO

/****** Object:  StoredProcedure [dbo].[usp_Employee_SelectList]    Script Date: 12/1/2018 1:22:00 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_Employee_SelectList

AS 

SET NOCOUNT ON

SELECT	EmployeeID,
		FirstName,
		LastName,
		MiddleName,
		Gender,
		HiredDate
FROM	Employee
GO

/****** Object:  StoredProcedure [dbo].[usp_Employee_Insert]    Script Date: 12/1/2018 1:23:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE usp_Employee_Insert
(
	@LastName		varchar(50),
	@FirstName		varchar(50),
	@Gender			char(1) = NULL,
	@MiddleName		varchar(50) = NULL,
	@HiredDate		date
)

AS 

SET NOCOUNT OFF

INSERT INTO Employee
(
	LastName,
	FirstName,
	Gender,
	MiddleName,
	HiredDate
)

VALUES
(
	@LastName,
	@FirstName,
	@Gender,
	@MiddleName,
	@HiredDate
)
GO

/****** Object:  StoredProcedure [dbo].[usp_Employee_Update]    Script Date: 12/1/2018 1:24:21 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE usp_Employee_Update
(
	@EmployeeID int,
	@LastName		varchar(50),
	@FirstName		varchar(50),
	@Gender			char(1) = NULL,
	@MiddleName		varchar(50) = NULL,
	@HiredDate		date
)

AS 

SET NOCOUNT OFF

UPDATE	Employee
SET		LastName	=	@LastName,
		FirstName	=	@FirstName,
		Gender		=	@Gender,
		MiddleName	=	@MiddleName,
		HiredDate	=	@HiredDate
WHERE	EmployeeID	=	@EmployeeID
GO


/****** Object:  StoredProcedure [dbo].[usp_Employee_Delete]    Script Date: 12/1/2018 1:25:12 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE usp_Employee_Delete
(
	@EmployeeID int
)

AS 

SET NOCOUNT OFF

DELETE FROM Employee
WHERE EmployeeID	=	@EmployeeID
GO

/****** Object:  StoredProcedure [dbo].[grantUser]    Script Date: 12/1/2018 1:25:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE grantUser
AS
	DECLARE curProcedure CURSOR FOR SELECT
		name
	FROM sysobjects
	WHERE type = 'P'
	ORDER BY name

	OPEN curProcedure
	DECLARE @procedurename VARCHAR(100)
	DECLARE @printline NVARCHAR(200)

	FETCH NEXT FROM curProcedure INTO @procedurename
	WHILE @@fetch_status = 0
	BEGIN
	SET @printline = 'GRANT EXEC ON ' + @procedurename + ' to EmployeeUser'
	EXEC SP_EXECUTESQL @printline
	PRINT @printline
	FETCH NEXT FROM curProcedure INTO @procedurename
	END

	CLOSE curProcedure
	DEALLOCATE curProcedure
GO