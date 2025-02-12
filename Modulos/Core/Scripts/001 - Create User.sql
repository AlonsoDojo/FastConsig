USE master
GO

IF DB_NAME() <> N'master' SET NOEXEC ON
GO


--
-- Set transaction isolation level
--
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

--
-- Start Transaction
--
BEGIN TRANSACTION
GO

--
-- Create login [FastConsig]
--
CREATE LOGIN FastConsig
WITH 
PASSWORD = 'FastConsig'
,DEFAULT_DATABASE = FastConsig
,CHECK_POLICY = OFF
GO
IF @@ERROR<>0 OR @@TRANCOUNT=0 BEGIN
 IF @@TRANCOUNT>0 ROLLBACK
SET NOEXEC ON
 END
GO

--
-- Commit Transaction
--
IF @@TRANCOUNT>0 COMMIT TRANSACTION
GO

--
-- Set NOEXEC to off
--
SET NOEXEC OFF
GO

USE FastConsig
GO

IF DB_NAME() <> N'FastConsig' SET NOEXEC ON
GO


--
-- Set transaction isolation level
--
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

--
-- Start Transaction
--
BEGIN TRANSACTION
GO

--
-- Create user [FastConsig]
--
CREATE USER FastConsig
  FOR LOGIN FastConsig
GO
IF @@ERROR<>0 OR @@TRANCOUNT=0 BEGIN
 IF @@TRANCOUNT>0 ROLLBACK
SET NOEXEC ON
 END
GO

--
-- Add members to the role [db_owner]
--
EXEC sp_addrolemember N'db_owner'
                     ,N'FastConsig'
GO
IF @@ERROR<>0 OR @@TRANCOUNT=0 BEGIN
 IF @@TRANCOUNT>0 ROLLBACK
SET NOEXEC ON
 END
GO

--
-- Commit Transaction
--
IF @@TRANCOUNT>0 COMMIT TRANSACTION
GO

--
-- Set NOEXEC to off
--
SET NOEXEC OFF
GO



USE master
GO

IF DB_NAME() <> N'master' SET NOEXEC ON
GO


--
-- Set transaction isolation level
--
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

--
-- Start Transaction
--
BEGIN TRANSACTION
GO

--
-- Alter login [FastConsig]
--
ALTER LOGIN FastConsig
WITH
DEFAULT_LANGUAGE = Brazilian
GO
IF @@ERROR<>0 OR @@TRANCOUNT=0 BEGIN
 IF @@TRANCOUNT>0 ROLLBACK
SET NOEXEC ON
 END
GO

--
-- Commit Transaction
--
IF @@TRANCOUNT>0 COMMIT TRANSACTION
GO

--
-- Set NOEXEC to off
--
SET NOEXEC OFF
GO