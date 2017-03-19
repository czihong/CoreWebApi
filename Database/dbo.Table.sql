USE [VideoStore];

ALTER DATABASE [VideoStore] COLLATE Chinese_PRC_CI_AS;
--ALTER DATABASE [VideoStore] COLLATE SQL_Latin1_General_CP1_CI_AS;

/*
	WebUser
*/
IF OBJECT_ID('[dbo].[WebUser]') IS NOT NULL DROP TABLE [dbo].[WebUser];

CREATE TABLE [dbo].[WebUser]
(
	[WebUserId] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY, 
    [Phone] NVARCHAR(256) NOT NULL, 
    [Mail] NVARCHAR(256) NULL, 
    [Password] NVARCHAR(256) NULL, 
    [WeChatId] NVARCHAR(256) NULL,
    [MicrosoftId] NVARCHAR(256) NULL, 
    [OrgId] NVARCHAR(256) NULL, 
    [SinaWeiboId] NVARCHAR(256) NULL, 
    [QqId] NVARCHAR(256) NULL, 
    [PictureUrl] NVARCHAR(MAX) NULL, 
    [UserName] NVARCHAR(256) NOT NULL, 
    [UserType] INT NOT NULL , 
    [CreateTime] DATETIME NOT NULL DEFAULT GETDATE(), 
    [UpdateTime] DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE NONCLUSTERED INDEX [IDX_Phone] ON [dbo].[WebUser]([Phone] ASC);
CREATE NONCLUSTERED INDEX [IDX_Mail] ON [dbo].[WebUser]([Mail] ASC);

INSERT INTO [dbo].[WebUser] VALUES ('12345678901','webapi@test','123456',1,'','','','','','webapi',1,'','');
INSERT INTO [dbo].[WebUser] VALUES ('12345678902','hello@word','123456',1,'','','','','','hello',2,'','');

SELECT * FROM dbo.WebUser;

/*
	WeChatUser
*/
IF OBJECT_ID('[dbo].[WeChatUser]') IS NOT NULL DROP TABLE [dbo].[WeChatUser];

CREATE TABLE [dbo].[WeChatUser]
(
	[Id] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY, 
    [UnionId] NVARCHAR(256) NOT NULL,
    [OpenId] NVARCHAR(256) NOT NULL, 
    [NickName] NVARCHAR(256) NOT NULL, 
    [Sex] NVARCHAR(256) NULL, 
    [Province] NVARCHAR(256) NULL, 
    [City] NVARCHAR(256) NULL, 
    [Country] NVARCHAR(256) NULL, 
    [PictureUrl] NVARCHAR(MAX) NULL, 
    [Privilege] NVARCHAR(256) NULL, 
    [CreateTime] DATETIME NOT NULL DEFAULT GETDATE(), 
    [UpdateTime] DATETIME NOT NULL DEFAULT GETDATE()
)

CREATE NONCLUSTERED INDEX [IDX_UnionId] ON [dbo].[WeChatUser]([UnionId] ASC);
CREATE NONCLUSTERED INDEX [IDX_OpenId] ON [dbo].[WeChatUser]([OpenId] ASC);

INSERT INTO [dbo].[WeChatUser] VALUES ('adfa1341dfcddfa','retyutyfgjhb5542fd','NickName','Male','Province','City','China','','','','');

SELECT * FROM [dbo].[WeChatUser];

/*
	MicrosoftUser
*/
IF OBJECT_ID('[dbo].[MicrosoftUser]') IS NOT NULL DROP TABLE [dbo].[MicrosoftUser];

CREATE TABLE [dbo].[MicrosoftUser]
(
	[Id] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY, 
    [MicrosoftName] NVARCHAR(256) NOT NULL, 
    [CreateTime] DATETIME NOT NULL DEFAULT GETDATE(), 
    [UpdateTime] DATETIME NOT NULL DEFAULT GETDATE()
)

CREATE NONCLUSTERED INDEX [IDX_MicrosoftName] ON [dbo].[MicrosoftUser]([MicrosoftName] ASC);

INSERT INTO [dbo].[MicrosoftUser] VALUES ('helloworld@test.com','','');

SELECT * FROM [dbo].[MicrosoftUser];