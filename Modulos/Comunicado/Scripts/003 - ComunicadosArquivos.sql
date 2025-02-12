CREATE TABLE FastConsig.dbo.ComunicadosArquivos (
  Id int IDENTITY,
  Comunicado int NOT NULL,
  NomeArquivo varchar(255) NOT NULL,
  Conteudo varbinary(max) NULL,
  CONSTRAINT PK_ComunicadoArquivo_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.ComunicadosArquivos
  ADD CONSTRAINT FK_ComunicadosArquivos_Comunicado FOREIGN KEY (Comunicado) REFERENCES dbo.Comunicados (Id)
GO