CREATE TABLE [dbo].[Player]
(
	[player_id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [name] NCHAR(65) NOT NULL, 
    [email] NCHAR(80) NOT NULL
)
