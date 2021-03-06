USE [craps_game_db]
GO
/****** Object:  StoredProcedure [dbo].[AddGame]    Script Date: 10/2/2018 8:19:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[AddGame]
	@mode nvarchar(10),
	@win int,
	@lose int,
	@roll_result int,
	@round int,
	@player_id int,
	@point_set int
AS
	If @mode='Win'

	BEGIN
	INSERT INTO Game
	([win], [lose], [roll_result], [point_set], [round], [player_id]
	) VALUES (
	@win, @lose, @roll_result, @point_set, @round, @player_id)
	END

	ELSE IF @mode='Lose'

	BEGIN
	INSERT INTO Game
	([win], [lose], [roll_result], [point_set], [round], [player_id]
	) VALUES (
	@win, @lose, @roll_result, @point_set, @round, @player_id)
	END

	ELSE IF @mode='Neither'

	BEGIN
	INSERT INTO Game
	([win], [lose], [roll_result], [point_set], [round], [player_id]
	) VALUES (
	@win, @lose, @roll_result, @point_set, @round, @player_id)
	END