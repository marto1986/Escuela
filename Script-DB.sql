USE [Test]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 5/8/2020 12:06:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno](
	[AlumnoId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[ApPaterno] [varchar](50) NULL,
	[ApMaterno] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_Alumno] PRIMARY KEY CLUSTERED 
(
	[AlumnoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SPAalumnos]    Script Date: 5/8/2020 12:06:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,Martin Matias>
-- Create date: <Create 04/08/2020>
-- Description:	<Actualiza los datos de un alumno>
-- =============================================
CREATE PROCEDURE [dbo].[SPAalumnos] 
	@AlumnoId INT,
	@Nombre VARCHAR(50),
	@ApPaterno VARCHAR(50),
	@ApMaterno VARCHAR(50),
	@Email VARCHAR(50)
AS
BEGIN
	UPDATE Alumno
	SET Nombre = @Nombre,
		ApPaterno = @ApPaterno,
		ApMaterno = @ApMaterno,
		Email = @Email
	WHERE AlumnoId = @AlumnoId
END
GO
/****** Object:  StoredProcedure [dbo].[SPEalumnos]    Script Date: 5/8/2020 12:06:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,Martin Matias>
-- Create date: <Create 04/08/2020>
-- Description:	<Elimina un alumno>
-- =============================================
CREATE PROCEDURE [dbo].[SPEalumnos]
	@AlumnoId INT
AS
BEGIN
	DELETE FROM Alumno WHERE AlumnoId = @AlumnoId
END
GO
/****** Object:  StoredProcedure [dbo].[SPIalumnos]    Script Date: 5/8/2020 12:06:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,Martin Matias>
-- Create date: <Create 04/08/2020>
-- Description:	<Inserta un nuevo alumno>
-- =============================================
CREATE PROCEDURE [dbo].[SPIalumnos] 
	@Nombre VARCHAR(50),
	@ApPaterno VARCHAR(50),
	@ApMaterno VARCHAR(50),
	@Email VARCHAR(50)
AS
BEGIN
	INSERT INTO Alumno (Nombre, ApPaterno, ApMaterno, Email)
		   VALUES (@Nombre, @ApPaterno, @ApMaterno, @Email)
END
GO
/****** Object:  StoredProcedure [dbo].[SPSalumnos]    Script Date: 5/8/2020 12:06:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,Martin Matias>
-- Create date: <Create 04/08/2020>
-- Description:	<Selecciona todos los alumnos>
-- =============================================
CREATE PROCEDURE [dbo].[SPSalumnos] 
AS
BEGIN
	SELECT AlumnoId 'ClaveAlumno'
		  , Nombre 'Nombre'
		  , ApPaterno 'ApellidoPaterno'
		  , ApMaterno 'ApellidoMaterno'
		  , Email 'CorreoElectronico'
	FROM Alumno
END
GO
