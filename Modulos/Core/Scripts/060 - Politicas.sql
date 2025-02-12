CREATE TABLE FastConsig.dbo.Politicas (
  Id int IDENTITY,
  Descricao varchar(255) NOT NULL,
  Metodo varchar(max) NOT NULL,
  TipoPolitica int NULL,
  Simulacao bit NULL,
  ParametrosDefault varchar(max) NULL,
  CONSTRAINT PK_Politicas_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.Politicas
  ADD CONSTRAINT FK_Politicas_TipoPolitica FOREIGN KEY (TipoPolitica) REFERENCES dbo.TipoPolitica (Id)
GO