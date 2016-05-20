IF OBJECT_ID('tblPaper') IS NOT NULL DROP TABLE tblPaper 
IF OBJECT_ID('tblAssignment') IS NOT NULL DROP TABLE tblAssignment 
IF OBJECT_ID('tblLecturer') IS NOT NULL DROP TABLE tblLecturer
CREATE TABLE tblLecturer
(
lecturerID   int     IDENTITY,
firstName    varchar(20) NOT NULL,
lastName     varchar(20) NOT NULL,
email        varchar(64) NOT NULL,
CONSTRAINT PK_tblLecturer PRIMARY KEY(lecturerID)
)
CREATE TABLE tblPaper
(
paperID				int			IDENTITY,
lecturerID			int			NOT NULL,
paperCode			varchar(20)	NOT NULL,
CONSTRAINT PK_paperID PRIMARY KEY(paperID),
CONSTRAINT FP_paper_lecturer FOREIGN KEY(lecturerID) REFERENCES tblLecturer(lecturerID)
)
CREATE TABLE tblAssignment
(
assignmentID		int			IDENTITY,
paperID				int			NOT NULL,
assignmentname		varchar(20) NOT NULL,
assignDescription	varchar(20) NOT NULL,
mark			    int			 NULL,
dueDate				date	NOT NULL,
CONSTRAINT PK_assignmentID PRIMARY KEY(assignmentID),
CONSTRAINT FK_assignmentPaper FOREIGN KEY(paperID) REFERENCES tblPaper(paperID)
)