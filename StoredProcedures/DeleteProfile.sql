USE [craps_game_db]
GO
/****** Object:  StoredProcedure [dbo].[DeleteProfile]    Script Date: 10/2/2018 8:20:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DeleteProfile]
@player_id int
AS
	DELETE Player
	WHERE [player_id]=@player_id