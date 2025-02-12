CREATE TABLE FastConsig.dbo.ComunicadosConfirmacaoLeitura (
  Id int IDENTITY,
  Comunicado int NOT NULL,
  Usuario varchar(50) NOT NULL,
  DataLeitura datetime NOT NULL,
  CONSTRAINT PK_ConfirmacaoLeitura PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.ComunicadosConfirmacaoLeitura
  ADD CONSTRAINT FK_ComunicadoConfirmacaoLeitura_Comunicado FOREIGN KEY (Comunicado) REFERENCES dbo.Comunicados (Id)
GO

ALTER TABLE FastConsig.dbo.ComunicadosConfirmacaoLeitura
  ADD CONSTRAINT FK_ComunicadosConfirmacaoLeitura_Usuario FOREIGN KEY (Usuario) REFERENCES dbo.Usuario (Id)
GO