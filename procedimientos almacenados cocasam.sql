
-----------------------	PROCEDIMIENTOS ALMACENADOS PRODUCTOR --------------------------

--CREATE PROCEDURE Sp_Guardar_Productor
--	@IdProductor nvarchar(5),
--	@Nombre varchar(20),
--	@Apellido varchar(20),
--	@IdSexo int,
--	@Socio bit
--AS
--	BEGIN
--	  SET NOCOUNT OFF
--		INSERT INTO Productor
--		VALUES(@IdProductor, @Nombre, @Apellido,@IdSexo, @Socio)
--	END

--GO


--CREATE PROCEDURE [dbo].[Sp_Mostrar_Sexo]
--AS
--	BEGIN
--	  SET NOCOUNT ON
--		SELECT * 
--		FROM Sexo
--	END
--GO


--CREATE PROCEDURE [dbo].[Sp_Mostrar_Todo_Productor]
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT *
--		FROM Productor
--	END
--GO

--CREATE PROCEDURE [dbo].[Sp_Eliminar_Productor]
--	@IdProductor nvarchar(5)
--AS
--	BEGIN
--		SET NOCOUNT OFF
--		DELETE
--		FROM Productor
--		WHERE IdProductor = @IdProductor
--	END

--GO

--CREATE PROCEDURE [dbo].[Sp_Actualizar_Productor]
--	@IdProductor nvarchar(5),
--	@Nombre varchar(20),
--	@Apellido varchar(20),
--	@IdSexo int,
--	@Socio bit
--AS
--	BEGIN
--		SET NOCOUNT OFF
--		UPDATE Productor 
--		SET IdProductor = @IdProductor, 
--			Nombre = @Nombre, 
--			Apellido = @Apellido,  
--			IdSexo = @IdSexo, 
--			Socio = @Socio
--		WHERE IdProductor = @IdProductor
--	END

--GO

--CREATE PROCEDURE [dbo].[Sp_Mostrar_Un_Productor]
--	@IdProductor nvarchar(5)
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT *
--		FROM Productor
--		WHERE IdProductor = @IdProductor
--	END
--GO


-----------------------	PROCEDIMIENTOS ALMACENADOS USUARIO --------------------------

--CREATE PROCEDURE [dbo].[Sp_Guardar_Usuario]
--	@Usuario varchar(20),
--	@Contrasena varchar(500),
--	@Estado bit,
--	@Administrador bit
--AS
--	BEGIN
--	  SET NOCOUNT OFF
--		INSERT INTO Usuario(Usuario, Contrasena, Estado ,Administrador)
--		VALUES(@Usuario, @Contrasena, @Estado,@Administrador)
--	END
--GO

--alter table Usuario alter column Contrasena varchar(500)


--CREATE PROCEDURE [dbo].[Sp_Mostrar_Todo_Usuario]
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT *
--		FROM Usuario 
--	END
--GO

--CREATE PROCEDURE [dbo].[Sp_Mostrar_UnUsuario]
--	@IdUsuario int
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT  *
--		FROM Usuario
--		WHERE IdUsuario = @IdUsuario
--	END
--GO


CREATE PROCEDURE [dbo].[Sp_Actualizar_Usuario]
	@IdUsuario int,
	@Usuario varchar(20),
	@Contrasena varchar(500),
	@Estado bit,
	@Administrador bit
AS
	BEGIN
		SET NOCOUNT OFF
		UPDATE Usuario
		SET Usuario = @Usuario, 
			Contrasena = @Contrasena,  
			Estado = @Estado,
			Administrador = @Administrador
		WHERE IdUsuario = @IdUsuario
	END
GO