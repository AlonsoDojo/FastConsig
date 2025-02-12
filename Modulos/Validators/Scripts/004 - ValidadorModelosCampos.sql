CREATE TABLE FastConsig.dbo.ValidadorModelosCampos (
  Id int IDENTITY,
  Modelo int NOT NULL,
  NomePropriedade varchar(500) NOT NULL,
  Descricao varchar(max) NULL,
  TipoDado int NOT NULL,
  IsList bit NULL,
  CONSTRAINT PK_ValidadorModelosCampos_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.ValidadorModelosCampos
  ADD CONSTRAINT FK_ValidadorModelosCampos_Modelo FOREIGN KEY (Modelo) REFERENCES dbo.ValidadorModelos (Id)
GO

ALTER TABLE FastConsig.dbo.ValidadorModelosCampos
  ADD CONSTRAINT FK_ValidadorModelosCampos_TipoDado FOREIGN KEY (TipoDado) REFERENCES dbo.TipoDado (Id)
GO