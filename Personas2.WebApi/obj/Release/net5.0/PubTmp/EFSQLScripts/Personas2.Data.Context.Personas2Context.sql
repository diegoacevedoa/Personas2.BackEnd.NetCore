IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014162052_InitialCreate')
BEGIN
    CREATE TABLE [Persona2] (
        [Id] int NOT NULL IDENTITY,
        [Nombres] varchar(200) NOT NULL,
        [Apellidos] varchar(200) NOT NULL,
        [TipoDocumento] int NOT NULL,
        [NoDocumento] varchar(max) NOT NULL,
        [FechaNacimiento] datetime2 NOT NULL,
        [NoContacto] varchar(50) NOT NULL,
        [Email] varchar(200) NOT NULL,
        [Direccion] varchar(200) NOT NULL,
        [Activo] bit NOT NULL,
        [Eliminado] bit NOT NULL,
        [UsuarioRegistro] int NOT NULL,
        [UsuarioModifica] int NOT NULL,
        [UsuarioElimina] int NOT NULL,
        [FechaRegistro] datetime2 NOT NULL,
        [FechaModificado] datetime2 NOT NULL,
        [FechaEliminado] datetime2 NOT NULL,
        CONSTRAINT [PK_Persona2] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014162052_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211014162052_InitialCreate', N'5.0.11');
END;
GO

COMMIT;
GO

