CREATE TABLE FastConsig.dbo.CTC921Detalhes (
  Id int IDENTITY,
  CTC921 int NOT NULL,
  TipoContrato varchar(4) NOT NULL,
  EventoTarifa varchar(4) NULL,
  DataTarifa date NULL,
  NUPortabilidade varchar(21) NULL,
  ISPBProponente varchar(8) NULL,
  Contrato varchar(40) NULL,
  CNPJIFOriginadoraContrato varchar(8) NULL,
  EnteConsignante varchar(2) NULL,
  TipoCliente varchar(1) NULL,
  CpfCnpjCliente varchar(14) NULL,
  NomeCliente varchar(150) NULL,
  TelefoneCliente varchar(15) NULL,
  EmailCliente varchar(150) NULL,
  CONSTRAINT PK_CTC921Detalhes_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.CTC921Detalhes
  ADD CONSTRAINT FK_CTC921Detalhes_EnteConsignante FOREIGN KEY (EnteConsignante) REFERENCES dbo.CTCEnteConsignante (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTC921Detalhes
  ADD CONSTRAINT FK_CTC921Detalhes_EventoTarifa FOREIGN KEY (EventoTarifa) REFERENCES dbo.CTCEventoTarifa (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTC921Detalhes
  ADD CONSTRAINT FK_CTC921Detalhes_TipoCliente FOREIGN KEY (TipoCliente) REFERENCES dbo.CTCTipoPessoa (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTC921Detalhes
  ADD CONSTRAINT FK_CTC921Detalhes_TipoContrato FOREIGN KEY (TipoContrato) REFERENCES dbo.CTCTipoContrato (Codigo)
GO