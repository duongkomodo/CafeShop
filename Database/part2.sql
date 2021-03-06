/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [id]
      ,[DateCheckIn]
      ,[DateCheckOut]
      ,[idTable]
      ,[status]
      ,[discount]
  FROM [QuanLyQuanCafe].[dbo].[Bill]
  CREATE TRIGGER AnswerTrigger ON Answer INSTEAD OF INSERT 
AS
BEGIN
	if exists(
	select *
	from inserted
	where Correct = '0'
	)
	begin
		--them di lieu tu bang inserted vao OrderIems
		insert into Answer
		select inserted.QuestionID,inserted.AnswerContent,inserted.Correct,inserted.Comment from inserted
		-- Cap nhat stock quantity cua product
		update Question 
		set  NumAnsCorrect = (NumAnsCorrect + 1)
		WHERE Question.ID = (Select inserted.ID
		FROM inserted)
		
	end
END