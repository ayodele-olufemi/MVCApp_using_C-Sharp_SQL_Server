USE [Employee]
GO

CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[Gender] [char](1) NULL,
	[MiddleName] [varchar](50) NULL,
	[HiredDate] [date] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([EmployeeID], [LastName], [FirstName], [Gender], [MiddleName], [HiredDate]) VALUES (1, N'Doe', N'John', N'M', N'D', CAST(N'2015-01-01' AS Date))
INSERT [dbo].[Employee] ([EmployeeID], [LastName], [FirstName], [Gender], [MiddleName], [HiredDate]) VALUES (3, N'Doe', N'Jannet', N'F', N'J', CAST(N'2015-01-01' AS Date))
SET IDENTITY_INSERT [dbo].[Employee] OFF

GO