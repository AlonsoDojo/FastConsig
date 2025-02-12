CREATE TABLE FastConsig.dbo.UsuarioBlacklist (
  CpfCnpj bigint NOT NULL,
  CONSTRAINT PK_UsuarioBlacklist_CpfCnpj PRIMARY KEY CLUSTERED (CpfCnpj)
)
ON [PRIMARY]
GO
