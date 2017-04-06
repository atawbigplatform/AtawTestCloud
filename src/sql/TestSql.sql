
/****** Object:  Table [dbo].[TestCase]    Script Date: 04/06/2017 10:32:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TestCase](
	[FID] [nvarchar](50) NOT NULL,
	[UserID] [nvarchar](50) NULL,
	[PageName] [nvarchar](50) NULL,
	[IsPass] [nvarchar](200) NULL,
	[TestTime] [nvarchar](200) NULL,
	[CREATE_ID] [nvarchar](50) NULL,
	[CREATE_TIME] [datetime] NULL,
	[UPDATE_ID] [nvarchar](50) NULL,
	[UPDATE_TIME] [datetime] NULL,
	[ISDELETE] [int] NULL,
	[FControlUnitID] [nvarchar](50) NULL,
	[TIMESSTAMP] [nvarchar](50) NULL,
	[UDDATETIME] [datetime] NULL,
	[UDINT1] [int] NULL,
	[UDVARCHAR1] [nvarchar](200) NULL,
	[UDVARCHAR2] [nvarchar](200) NULL,
	[Title] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[FID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'FID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestCase', @level2type=N'COLUMN',@level2name=N'FID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'UserID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestCase', @level2type=N'COLUMN',@level2name=N'UserID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'PageName' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestCase', @level2type=N'COLUMN',@level2name=N'PageName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'IsPass' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestCase', @level2type=N'COLUMN',@level2name=N'IsPass'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'TestTime' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestCase', @level2type=N'COLUMN',@level2name=N'TestTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestCase', @level2type=N'COLUMN',@level2name=N'CREATE_ID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestCase', @level2type=N'COLUMN',@level2name=N'CREATE_TIME'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后编辑人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestCase', @level2type=N'COLUMN',@level2name=N'UPDATE_ID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后编辑时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestCase', @level2type=N'COLUMN',@level2name=N'UPDATE_TIME'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否删除' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestCase', @level2type=N'COLUMN',@level2name=N'ISDELETE'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'组织机构' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestCase', @level2type=N'COLUMN',@level2name=N'FControlUnitID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'时间戳' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestCase', @level2type=N'COLUMN',@level2name=N'TIMESSTAMP'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备用时间字段' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestCase', @level2type=N'COLUMN',@level2name=N'UDDATETIME'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备用数值字段' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestCase', @level2type=N'COLUMN',@level2name=N'UDINT1'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备用文本字段1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestCase', @level2type=N'COLUMN',@level2name=N'UDVARCHAR1'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备用文本字段2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestCase', @level2type=N'COLUMN',@level2name=N'UDVARCHAR2'
GO




/****** Object:  Table [dbo].[TestStep]    Script Date: 04/06/2017 10:42:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TestStep](
	[FID] [nvarchar](50) NOT NULL,
	[UserID] [nvarchar](50) NULL,
	[TestCaseFID] [nvarchar](50) NULL,
	[CmdName] [nvarchar](50) NULL,
	[Line] [nvarchar](200) NULL,
	[KeyStr] [nvarchar](50) NULL,
	[IsPass] [nvarchar](50) NULL,
	[IsSend] [nvarchar](50) NULL,
	[CREATE_ID] [nvarchar](50) NULL,
	[CREATE_TIME] [datetime] NULL,
	[UPDATE_ID] [nvarchar](50) NULL,
	[UPDATE_TIME] [datetime] NULL,
	[ISDELETE] [int] NULL,
	[FControlUnitID] [nvarchar](50) NULL,
	[TIMESSTAMP] [nvarchar](50) NULL,
	[UDDATETIME] [datetime] NULL,
	[UDINT1] [int] NULL,
	[UDVARCHAR1] [nvarchar](200) NULL,
	[UDVARCHAR2] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[FID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'FID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestStep', @level2type=N'COLUMN',@level2name=N'FID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'UserID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestStep', @level2type=N'COLUMN',@level2name=N'UserID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'TestCaseFID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestStep', @level2type=N'COLUMN',@level2name=N'TestCaseFID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CmdName' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestStep', @level2type=N'COLUMN',@level2name=N'CmdName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Line' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestStep', @level2type=N'COLUMN',@level2name=N'Line'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'KeyStr' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestStep', @level2type=N'COLUMN',@level2name=N'KeyStr'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'IsPass' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestStep', @level2type=N'COLUMN',@level2name=N'IsPass'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'IsSend' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestStep', @level2type=N'COLUMN',@level2name=N'IsSend'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestStep', @level2type=N'COLUMN',@level2name=N'CREATE_ID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestStep', @level2type=N'COLUMN',@level2name=N'CREATE_TIME'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后编辑人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestStep', @level2type=N'COLUMN',@level2name=N'UPDATE_ID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后编辑时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestStep', @level2type=N'COLUMN',@level2name=N'UPDATE_TIME'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否删除' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestStep', @level2type=N'COLUMN',@level2name=N'ISDELETE'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'组织机构' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestStep', @level2type=N'COLUMN',@level2name=N'FControlUnitID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'时间戳' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestStep', @level2type=N'COLUMN',@level2name=N'TIMESSTAMP'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备用时间字段' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestStep', @level2type=N'COLUMN',@level2name=N'UDDATETIME'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备用数值字段' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestStep', @level2type=N'COLUMN',@level2name=N'UDINT1'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备用文本字段1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestStep', @level2type=N'COLUMN',@level2name=N'UDVARCHAR1'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备用文本字段2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TestStep', @level2type=N'COLUMN',@level2name=N'UDVARCHAR2'
GO





