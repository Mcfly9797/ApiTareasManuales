IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200817230129_InitialCreate')
BEGIN
    CREATE TABLE [Disenio] (
        [Id] int NOT NULL IDENTITY,
        [Nombre] nvarchar(max) NULL,
        CONSTRAINT [PK_Disenio] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200817230129_InitialCreate')
BEGIN
    CREATE TABLE [Elemento] (
        [Id] int NOT NULL IDENTITY,
        [Nombre] int NOT NULL,
        CONSTRAINT [PK_Elemento] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200817230129_InitialCreate')
BEGIN
    CREATE TABLE [Medida] (
        [Id] int NOT NULL IDENTITY,
        [Nombre] nvarchar(max) NULL,
        CONSTRAINT [PK_Medida] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200817230129_InitialCreate')
BEGIN
    CREATE TABLE [Tipo_Trabajo] (
        [Id] int NOT NULL IDENTITY,
        [Nombre] nvarchar(max) NULL,
        CONSTRAINT [PK_Tipo_Trabajo] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200817230129_InitialCreate')
BEGIN
    CREATE TABLE [Tipo_Usuario] (
        [Id] int NOT NULL IDENTITY,
        [Tipo] int NOT NULL,
        [Nombre] nvarchar(max) NULL,
        CONSTRAINT [PK_Tipo_Usuario] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200817230129_InitialCreate')
BEGIN
    CREATE TABLE [Usuario] (
        [Id] int NOT NULL IDENTITY,
        [Nombre] nvarchar(max) NULL,
        [Clave] nvarchar(max) NULL,
        [Tipo_UsuarioId] int NOT NULL,
        CONSTRAINT [PK_Usuario] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Usuario_Tipo_Usuario_Tipo_UsuarioId] FOREIGN KEY ([Tipo_UsuarioId]) REFERENCES [Tipo_Usuario] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200817230129_InitialCreate')
BEGIN
    CREATE TABLE [Tarea] (
        [Id] int NOT NULL IDENTITY,
        [NroSerie] int NOT NULL,
        [Detalle] nvarchar(max) NULL,
        [Duracion] datetime2 NOT NULL,
        [Fecha] datetime2 NOT NULL,
        [UsuarioId] int NOT NULL,
        [Tipo_TrabajoId] int NOT NULL,
        [ElementoId] int NOT NULL,
        [MedidaId] int NOT NULL,
        [DisenioId] int NOT NULL,
        CONSTRAINT [PK_Tarea] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Tarea_Disenio_DisenioId] FOREIGN KEY ([DisenioId]) REFERENCES [Disenio] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Tarea_Elemento_ElementoId] FOREIGN KEY ([ElementoId]) REFERENCES [Elemento] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Tarea_Medida_MedidaId] FOREIGN KEY ([MedidaId]) REFERENCES [Medida] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Tarea_Tipo_Trabajo_Tipo_TrabajoId] FOREIGN KEY ([Tipo_TrabajoId]) REFERENCES [Tipo_Trabajo] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Tarea_Usuario_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [Usuario] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200817230129_InitialCreate')
BEGIN
    CREATE INDEX [IX_Tarea_DisenioId] ON [Tarea] ([DisenioId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200817230129_InitialCreate')
BEGIN
    CREATE INDEX [IX_Tarea_ElementoId] ON [Tarea] ([ElementoId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200817230129_InitialCreate')
BEGIN
    CREATE INDEX [IX_Tarea_MedidaId] ON [Tarea] ([MedidaId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200817230129_InitialCreate')
BEGIN
    CREATE INDEX [IX_Tarea_Tipo_TrabajoId] ON [Tarea] ([Tipo_TrabajoId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200817230129_InitialCreate')
BEGIN
    CREATE INDEX [IX_Tarea_UsuarioId] ON [Tarea] ([UsuarioId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200817230129_InitialCreate')
BEGIN
    CREATE INDEX [IX_Usuario_Tipo_UsuarioId] ON [Usuario] ([Tipo_UsuarioId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200817230129_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200817230129_InitialCreate', N'3.1.7');
END;

GO

