USE [craps_game_db]
GO
/****** Object:  StoredProcedure [dbo].[GetGame]    Script Date: 10/2/2018 8:21:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[GetGame]
	@player_id int
AS

	BEGIN
	SELECT *
	FROM Game
	WHERE player_id=@player_id;
	END