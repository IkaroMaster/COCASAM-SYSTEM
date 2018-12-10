
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

--CREATE PROCEDURE [dbo].[Sp_Guardar_ProductorXLugar]
--	@IdProductor nvarchar(5),
--	@IdLugar int
--AS
--	BEGIN
--		SET NOCOUNT OFF
--		INSERT INTO ProductorXLugar
--		VALUES(@IdProductor,@IdLugar)
--	END
--GO

----execute Sp_Guardar_ProductorXLugar 'CC000', 1

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


--CREATE PROCEDURE [dbo].[Sp_Eliminar_LugarXProductor]
--	@IdProductor nvarchar(5)
--AS
--	BEGIN
--		SET NOCOUNT OFF
--		DELETE 
--		FROM ProductorXLugar
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


--CREATE PROCEDURE [dbo].[Sp_Actualizar_Usuario]
--	@IdUsuario int,
--	@Usuario varchar(20),
--	@Contrasena varchar(500),
--	@Estado bit,
--	@Administrador bit
--AS
--	BEGIN
--		SET NOCOUNT OFF
--		UPDATE Usuario
--		SET Usuario = @Usuario, 
--			Contrasena = @Contrasena,  
--			Estado = @Estado,
--			Administrador = @Administrador
--		WHERE IdUsuario = @IdUsuario
--	END
--GO

--CREATE PROCEDURE [dbo].[Sp_Mostrar_LugarXProductor]
--	@IdProductor nvarchar(5)
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT p.IdLugar, l.Lugar
--		FROM ProductorXLugar p inner join Lugar l
--		on p.IdLugar = l.IdLugar
--		WHERE IdProductor = @IdProductor
--	END
--GO

----execute Sp_Mostrar_LugarXProductor 'CC007'



--------------------------------------------PROCEDIMIENTOS ALMACENADOS LUGAR -----------------------------
--CREATE PROCEDURE [dbo].[Sp_Guardar_Lugar]
--	@Lugar varchar(100)
--AS
--	BEGIN
--		SET NOCOUNT OFF
--		INSERT INTO Lugar
--		VALUES(@Lugar)
--	END
--GO

--alter table Lugar alter column Lugar varchar(100)

--CREATE PROCEDURE [dbo].[Sp_Mostrar_Todo_Lugar]
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT *
--		FROM Lugar
--	END
--GO

--CREATE PROCEDURE [dbo].[Sp_Eliminar_Lugar]
--	@IdLugar int
--AS
--	BEGIN
--		SET NOCOUNT OFF
--		DELETE 
--		FROM Lugar
--		WHERE IdLugar = @IdLugar
--	END
--GO

--CREATE PROCEDURE [dbo].[Sp_Mostrar_Un_Lugar]
--	@IdLugar int
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT *
--		FROM Lugar
--		WHERE IdLugar = @IdLugar
--	END
--GO

--CREATE PROCEDURE [dbo].[Sp_Actualizar_Lugar]
--	@IdLugar int,
--	@Lugar varchar(15)
--AS
--	BEGIN
--		SET NOCOUNT OFF
--		UPDATE Lugar
--		SET Lugar = @Lugar
--		WHERE IdLugar = @IdLugar
--	END
--GO

--------------------------------------------PROCEDIMIENTOS ALMACENADOS NOTA PESO -----------------------------

--CREATE PROCEDURE [dbo].[Sp_Mostrar_TipoCafe]
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT *
--		FROM TipoCafe
--	END
--GO


--CREATE PROCEDURE [dbo].[Sp_Mostrar_Productor_Combobox]
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT IdProductor, CONCAT(Nombre, ' ', Apellido) AS NombreCompleto
--		FROM Productor
--	END
--GO
--execute Sp_Mostrar_Productor_Combobox


--CREATE PROCEDURE [dbo].[Sp_Guardar_NotaPeso]
--	@IdNotaPeso int,
--	@IdProductor nvarchar(5),
--	@IdTipoCafe int,
--	@IdLugar int,
--	@IdUsuario int,
--	@Fecha date,
--	@PesoBruto float,
--	@Tara decimal(10,2),
--	@Descuento decimal(10,2),
--	@Humedad float,
--	@Observaciones nvarchar(100),
--	@PrecioUnitario decimal(10,2),
--	@Anulada bit
--AS
--	BEGIN
--	  SET NOCOUNT OFF
--		INSERT INTO NotaPeso
--		VALUES(@IdNotaPeso ,@IdProductor ,@IdTipoCafe ,@IdLugar ,@IdUsuario ,@Fecha ,@PesoBruto,@Tara,@Descuento ,@Humedad ,@Observaciones ,@PrecioUnitario ,@Anulada)
--	END

--GO


--CREATE PROCEDURE [dbo].[Sp_Guardar_DetalleNotaPeso]
--	@IdNotaPeso int,
--	@Peso decimal(10,2),
--	@Saco int
--AS
--	BEGIN
--		SET NOCOUNT OFF
--		INSERT INTO DetalleNotaPeso(IdNotaPeso,Peso,Saco)
--		VALUES(@IdNotaPeso,@Peso,@Saco)
--	END
--GO

--ALTER PROCEDURE [dbo].[Sp_Mostrar_Todo_NotaPeso]
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT  np.IdNotaPeso,CONCAT(p.Nombre, ' ', p.Apellido) AS NombreCompleto,l.Lugar,tc.TipoCafe,u.Usuario AS PesadoPor,
--				np.Fecha,SUM(dnp.Peso) AS TotalPeso,SUM(dnp.Saco) AS TotalSaco,np.PesoBruto,np.Tara,np.Descuento,
--				(np.PesoBruto - np.Tara - Descuento) AS PesoNeto,((np.PesoBruto - np.Tara - Descuento)/ 1.25) AS QuintalOro,
--				np.Observaciones,np.PrecioUnitario,((np.PesoBruto - np.Tara - Descuento)* np.PrecioUnitario) AS Total 
--		FROM NotaPeso np inner join DetalleNotaPeso dnp
--							on np.IdNotaPeso = dnp.IdNotaPeso
--							inner join Productor p
--							on np.IdProductor = p.IdProductor
--							inner join TipoCafe tc
--							on np.IdTipoCafe = tc.IdTipoCafe
--							inner join Lugar l
--							on np.IdLugar = l.IdLugar
--							inner join Usuario u
--							on np.IdUsuario = u.IdUsuario
--		WHERE np.Anulada = 0
--		GROUP BY np.IdNotaPeso,p.Nombre,p.Apellido,l.Lugar,tc.TipoCafe,u.Usuario,np.Fecha,np.PesoBruto,np.Tara,np.Descuento,
--				np.Observaciones,np.PrecioUnitario
							
--	END

----------------- PROCEDIMIENTOS ALMACENADOS REPORTES --------------------------------------------

--ALTER PROCEDURE [dbo].[Sp_Mostrar_Rpt_NotaPeso]
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT  np.IdNotaPeso,CONCAT(p.Nombre, ' ', p.Apellido) AS NombreCompleto,l.Lugar,tc.TipoCafe,u.Usuario AS PesadoPor,
--				np.Fecha,dnp.Peso,dnp.Saco,np.PesoBruto,np.Tara,np.Descuento,
--				(np.PesoBruto - np.Tara - Descuento) AS PesoNeto,((np.PesoBruto - np.Tara - Descuento)/ 1.25) AS QuintalOro,
--				np.Observaciones,np.PrecioUnitario,((np.PesoBruto - np.Tara - Descuento)* np.PrecioUnitario) AS Total 
--		FROM NotaPeso np inner join DetalleNotaPeso dnp
--							on np.IdNotaPeso = dnp.IdNotaPeso
--							inner join Productor p
--							on np.IdProductor = p.IdProductor
--							inner join TipoCafe tc
--							on np.IdTipoCafe = tc.IdTipoCafe
--							inner join Lugar l
--							on np.IdLugar = l.IdLugar
--							inner join Usuario u
--							on np.IdUsuario = u.IdUsuario
--		WHERE np.Anulada = 0
--		GROUP BY np.IdNotaPeso,p.Nombre,p.Apellido,l.Lugar,tc.TipoCafe,u.Usuario,np.Fecha,np.PesoBruto,np.Tara,np.Descuento,
--				np.Observaciones,np.PrecioUnitario, dnp.Peso, dnp.Saco
							
--	END


--CREATE PROCEDURE [dbo].[Sp_Mostrar_NotaPeso]
--	@IdNota int
--AS
--	BEGIN
--		SET NOCOUNT ON
--		SELECT  np.IdNotaPeso,CONCAT(p.Nombre, ' ', p.Apellido) AS NombreCompleto,l.Lugar,tc.TipoCafe,u.Usuario AS PesadoPor,
--				np.Fecha,dnp.Peso,dnp.Saco,np.PesoBruto,np.Tara,np.Descuento,
--				(np.PesoBruto - np.Tara - Descuento) AS PesoNeto,((np.PesoBruto - np.Tara - Descuento)/ 1.25) AS QuintalOro,
--				np.Observaciones,np.PrecioUnitario,((np.PesoBruto - np.Tara - Descuento)* np.PrecioUnitario) AS Total 
--		FROM NotaPeso np inner join DetalleNotaPeso dnp
--							on np.IdNotaPeso = dnp.IdNotaPeso
--							inner join Productor p
--							on np.IdProductor = p.IdProductor
--							inner join TipoCafe tc
--							on np.IdTipoCafe = tc.IdTipoCafe
--							inner join Lugar l
--							on np.IdLugar = l.IdLugar
--							inner join Usuario u
--							on np.IdUsuario = u.IdUsuario
--		WHERE np.Anulada = 0 and np.IdNotaPeso = @IdNota
--		GROUP BY np.IdNotaPeso,p.Nombre,p.Apellido,l.Lugar,tc.TipoCafe,u.Usuario,np.Fecha,np.PesoBruto,np.Tara,np.Descuento,
--				np.Observaciones,np.PrecioUnitario, dnp.Peso, dnp.Saco
							
--	END

CREATE PROCEDURE [dbo].[Sp_Mostrar_RptLugarXProductor]
AS
	BEGIN
		SET NOCOUNT ON
		SELECT p.IdLugar, l.Lugar, CONCAT(pr.Nombre, ' ', pr.Apellido) AS NombreCompleto
		FROM ProductorXLugar p inner join Lugar l
		on p.IdLugar = l.IdLugar inner join Productor pr
		on pr.IdProductor = p.IdProductor
		GROUP BY p.IdProductor, p.IdLugar, l.Lugar, pr.Nombre, pr.Apellido
	END