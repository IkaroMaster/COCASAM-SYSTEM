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