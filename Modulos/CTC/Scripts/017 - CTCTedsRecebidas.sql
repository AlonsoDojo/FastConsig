CREATE TABLE FastConsig.dbo.CTCTedsRecebidas (
  Id int IDENTITY,
  Evento int NOT NULL,
  DataReferencia date NOT NULL,
  Mensagem varchar(max) NULL,
  Processado bit NULL,
  CONSTRAINT PK_CTCTedsRecebidas_Id PRIMARY KEY CLUSTERED (Id),
  CONSTRAINT KEY_CTCTedsRecebidas_Evento UNIQUE (Evento)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO