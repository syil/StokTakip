SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Expenses'
GO
CREATE TABLE [Expenses] (
	[Id] int IDENTITY (1,1) NOT NULL
, [Description] nvarchar(1000) NOT NULL
, [Category] nvarchar(100) NOT NULL
, [Amount] money NOT NULL
, [ExpenseDate] datetime NOT NULL
, [CreateDate] datetime NOT NULL
, [Status] int NOT NULL
);
GO
ALTER TABLE [Expenses] ADD CONSTRAINT [PK_Expenses] PRIMARY KEY ([Id]);