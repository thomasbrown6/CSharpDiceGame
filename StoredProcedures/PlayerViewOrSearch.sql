USE [craps_game_db]
GO
/****** Object:  StoredProcedure [dbo].[PlayerViewOrSearch]    Script Date: 10/2/2018 8:23:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[PlayerViewOrSearch]
	@name nvarchar(50)
AS
	SELECT *
	FROM Player
	WHERE name LIKE @name+'%'