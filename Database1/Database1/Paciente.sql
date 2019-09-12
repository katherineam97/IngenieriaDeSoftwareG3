CREATE TABLE [dbo].[Paciente]
(
	[Id] INT IDENTITY (1, 1) NOT NULL,
 [Nombre] VARCHAR(50) NOT NULL,
 [Apellidos] VARCHAR(50) NULL,
 [FechaNacimiento] DATETIME NOT NULL,
 [Residencia] VARCHAR(MAX) NULL,
 [Peso] DECIMAL(5, 2) NULL,
 [Altura] DECIMAL (3, 2) NULL,
 [PresionArterial] INT NULL,
 PRIMARY KEY CLUSTERED ([Id] ASC)
)
