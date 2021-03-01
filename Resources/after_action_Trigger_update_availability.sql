CREATE TRIGGER dbo.updateCourseAvailability
	ON [dbo].[Course]
	AFTER DELETE, INSERT, UPDATE
	AS BEGIN
		UPDATE dbo.course set dbo.course.isAvailable = 0
		FROM Course
		WHERE dbo.course.seats = dbo.course.maxSeats
		SET NOCOUNT ON
	END
