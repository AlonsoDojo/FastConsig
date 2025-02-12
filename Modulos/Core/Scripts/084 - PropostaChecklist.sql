CREATE TABLE FastConsig.dbo.PropostaChecklist (
  Id int IDENTITY,
  Proposta int NOT NULL,
  Checklist int NOT NULL,
  Item int NOT NULL,
  Obrigatorio bit NULL,
  TipoDocumento int NULL,
  Pessoa int NULL,
  CONSTRAINT PK_PropostaChecklist_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.PropostaChecklist
  ADD CONSTRAINT FK_PropostaChecklist_Checklist FOREIGN KEY (Checklist) REFERENCES dbo.CheckList (Id)
GO

ALTER TABLE FastConsig.dbo.PropostaChecklist
  ADD CONSTRAINT FK_PropostaChecklist_Pessoa FOREIGN KEY (Pessoa) REFERENCES dbo.Pessoas (Id)
GO

ALTER TABLE FastConsig.dbo.PropostaChecklist
  ADD CONSTRAINT FK_PropostaChecklist_Proposta FOREIGN KEY (Proposta) REFERENCES dbo.Propostas (Id)
GO

ALTER TABLE FastConsig.dbo.PropostaChecklist
  ADD CONSTRAINT FK_PropostaChecklist_TipoDocumento FOREIGN KEY (TipoDocumento) REFERENCES dbo.TipoDocumento (Id)
GO