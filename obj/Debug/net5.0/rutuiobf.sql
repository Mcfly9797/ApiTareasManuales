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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201130233616_CreateDatabase')
BEGIN
    CREATE TABLE [Disenio] (
        [IdDisenio] int NOT NULL IDENTITY,
        [NombreDisenio] nvarchar(20) NOT NULL,
        CONSTRAINT [PK_Disenio] PRIMARY KEY ([IdDisenio])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201130233616_CreateDatabase')
BEGIN
    CREATE TABLE [Elemento] (
        [IdElemento] int NOT NULL IDENTITY,
        [NombreElemento] nvarchar(20) NOT NULL,
        CONSTRAINT [PK_Elemento] PRIMARY KEY ([IdElemento])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201130233616_CreateDatabase')
BEGIN
    CREATE TABLE [Medida] (
        [IdMedida] int NOT NULL IDENTITY,
        [NombreMedida] nvarchar(20) NOT NULL,
        CONSTRAINT [PK_Medida] PRIMARY KEY ([IdMedida])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201130233616_CreateDatabase')
BEGIN
    CREATE TABLE [Tipo_Trabajo] (
        [IdTipoTrabajo] int NOT NULL IDENTITY,
        [NombreTipoTrabajo] nvarchar(20) NOT NULL,
        CONSTRAINT [PK_Tipo_Trabajo] PRIMARY KEY ([IdTipoTrabajo])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201130233616_CreateDatabase')
BEGIN
    CREATE TABLE [Tipo_User] (
        [IdTipoUser] int NOT NULL IDENTITY,
        [TipoUser] int NOT NULL,
        [NombreTipoUser] nvarchar(20) NOT NULL,
        CONSTRAINT [PK_Tipo_User] PRIMARY KEY ([IdTipoUser])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201130233616_CreateDatabase')
BEGIN
    CREATE TABLE [User] (
        [IdUser] int NOT NULL IDENTITY,
        [NombreUser] nvarchar(30) NOT NULL,
        [Clave] nvarchar(30) NOT NULL,
        [Tipo_UserId] int NOT NULL,
        CONSTRAINT [PK_User] PRIMARY KEY ([IdUser]),
        CONSTRAINT [FK_User_Tipo_User_Tipo_UserId] FOREIGN KEY ([Tipo_UserId]) REFERENCES [Tipo_User] ([IdTipoUser]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201130233616_CreateDatabase')
BEGIN
    CREATE TABLE [Tarea] (
        [IdTarea] int NOT NULL IDENTITY,
        [NroSerie] int NOT NULL,
        [Detalle] nvarchar(max) NULL,
        [Duracion] datetime2 NOT NULL,
        [Fecha] datetime2 NOT NULL,
        [UserId] int NOT NULL,
        [Tipo_TrabajoId] int NOT NULL,
        [ElementoId] int NOT NULL,
        [MedidaId] int NOT NULL,
        [DisenioId] int NOT NULL,
        CONSTRAINT [PK_Tarea] PRIMARY KEY ([IdTarea]),
        CONSTRAINT [FK_Tarea_Disenio_DisenioId] FOREIGN KEY ([DisenioId]) REFERENCES [Disenio] ([IdDisenio]) ON DELETE CASCADE,
        CONSTRAINT [FK_Tarea_Elemento_ElementoId] FOREIGN KEY ([ElementoId]) REFERENCES [Elemento] ([IdElemento]) ON DELETE CASCADE,
        CONSTRAINT [FK_Tarea_Medida_MedidaId] FOREIGN KEY ([MedidaId]) REFERENCES [Medida] ([IdMedida]) ON DELETE CASCADE,
        CONSTRAINT [FK_Tarea_Tipo_Trabajo_Tipo_TrabajoId] FOREIGN KEY ([Tipo_TrabajoId]) REFERENCES [Tipo_Trabajo] ([IdTipoTrabajo]) ON DELETE CASCADE,
        CONSTRAINT [FK_Tarea_User_UserId] FOREIGN KEY ([UserId]) REFERENCES [User] ([IdUser]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201130233616_CreateDatabase')
BEGIN
    CREATE INDEX [IX_Tarea_DisenioId] ON [Tarea] ([DisenioId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201130233616_CreateDatabase')
BEGIN
    CREATE INDEX [IX_Tarea_ElementoId] ON [Tarea] ([ElementoId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201130233616_CreateDatabase')
BEGIN
    CREATE INDEX [IX_Tarea_MedidaId] ON [Tarea] ([MedidaId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201130233616_CreateDatabase')
BEGIN
    CREATE INDEX [IX_Tarea_Tipo_TrabajoId] ON [Tarea] ([Tipo_TrabajoId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201130233616_CreateDatabase')
BEGIN
    CREATE INDEX [IX_Tarea_UserId] ON [Tarea] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201130233616_CreateDatabase')
BEGIN
    CREATE INDEX [IX_User_Tipo_UserId] ON [User] ([Tipo_UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201130233616_CreateDatabase')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20201130233616_CreateDatabase', N'5.0.0');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201130233655_InitialMigration')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20201130233655_InitialMigration', N'5.0.0');
END;
GO

COMMIT;
GO

