CREATE TABLE FastConsig.dbo.TipoDado (
  Id int IDENTITY,
  Descricao varchar(50) NOT NULL,
  Mapper varchar(max) NOT NULL,
  CONSTRAINT PK_TipoDado_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.TipoDado ON
GO
INSERT FastConsig.dbo.TipoDado(Id, Descricao, Mapper) VALUES (1, 'bool', 'System.Boolean')
INSERT FastConsig.dbo.TipoDado(Id, Descricao, Mapper) VALUES (2, 'byte', 'System.Byte')
INSERT FastConsig.dbo.TipoDado(Id, Descricao, Mapper) VALUES (3, 'sbyte', 'System.SByte')
INSERT FastConsig.dbo.TipoDado(Id, Descricao, Mapper) VALUES (4, 'char', 'System.Char')
INSERT FastConsig.dbo.TipoDado(Id, Descricao, Mapper) VALUES (5, 'decimal', 'System.Decimal')
INSERT FastConsig.dbo.TipoDado(Id, Descricao, Mapper) VALUES (6, 'double', 'System.Double')
INSERT FastConsig.dbo.TipoDado(Id, Descricao, Mapper) VALUES (7, 'float', 'System.Single')
INSERT FastConsig.dbo.TipoDado(Id, Descricao, Mapper) VALUES (8, 'int', 'System.Int32')
INSERT FastConsig.dbo.TipoDado(Id, Descricao, Mapper) VALUES (9, 'uint', 'System.UInt32')
INSERT FastConsig.dbo.TipoDado(Id, Descricao, Mapper) VALUES (10, 'nint', 'System.IntPtr')
INSERT FastConsig.dbo.TipoDado(Id, Descricao, Mapper) VALUES (11, 'nuint', 'System.UIntPtr')
INSERT FastConsig.dbo.TipoDado(Id, Descricao, Mapper) VALUES (12, 'long', 'System.Int64')
INSERT FastConsig.dbo.TipoDado(Id, Descricao, Mapper) VALUES (13, 'ulong', 'System.UInt64')
INSERT FastConsig.dbo.TipoDado(Id, Descricao, Mapper) VALUES (14, 'shot', 'System.Int16')
INSERT FastConsig.dbo.TipoDado(Id, Descricao, Mapper) VALUES (15, 'ushot', 'System.UInt16')
INSERT FastConsig.dbo.TipoDado(Id, Descricao, Mapper) VALUES (16, 'object', 'System.Object')
INSERT FastConsig.dbo.TipoDado(Id, Descricao, Mapper) VALUES (17, 'string', 'System.String')
INSERT FastConsig.dbo.TipoDado(Id, Descricao, Mapper) VALUES (18, 'dynamic', 'System.Object')
INSERT FastConsig.dbo.TipoDado(Id, Descricao, Mapper) VALUES (19, 'DateTime?', 'System.DateTime?')
INSERT FastConsig.dbo.TipoDado(Id, Descricao, Mapper) VALUES (20, 'DateTime', 'System.DateTime')
INSERT FastConsig.dbo.TipoDado(Id, Descricao, Mapper) VALUES (21, 'long?', 'System.Int64?')
INSERT FastConsig.dbo.TipoDado(Id, Descricao, Mapper) VALUES (22, 'int?', 'System.Int32?')
INSERT FastConsig.dbo.TipoDado(Id, Descricao, Mapper) VALUES (23, 'decimal?', 'System.Decimal?')
GO
SET IDENTITY_INSERT FastConsig.dbo.TipoDado OFF
GO