CREATE TABLE FastConsig.dbo.ValidadorCampos (
  Id int IDENTITY,
  Validador int NOT NULL,
  Modelo int NOT NULL,
  CampoModelo int NOT NULL,
  [Rule] int NOT NULL,
  Parametro1 varchar(max) NULL,
  Parametro2 varchar(max) NULL,
  Parametro3 varchar(max) NULL,
  CONSTRAINT PK_ValidadorCampos_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.ValidadorCampos
  ADD CONSTRAINT FK_ValidadorCampos_CampoModelo FOREIGN KEY (CampoModelo) REFERENCES dbo.ValidadorModelosCampos (Id)
GO

ALTER TABLE FastConsig.dbo.ValidadorCampos
  ADD CONSTRAINT FK_ValidadorCampos_Modelo FOREIGN KEY (Modelo) REFERENCES dbo.ValidadorModelos (Id)
GO

ALTER TABLE FastConsig.dbo.ValidadorCampos
  ADD CONSTRAINT FK_ValidadorCampos_Rule FOREIGN KEY ([Rule]) REFERENCES dbo.ValidadorRules (Id)
GO

ALTER TABLE FastConsig.dbo.ValidadorCampos
  ADD CONSTRAINT FK_ValidadorCampos_Validador FOREIGN KEY (Validador) REFERENCES dbo.Validador (Id)
GO