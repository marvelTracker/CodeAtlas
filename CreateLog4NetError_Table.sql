﻿SET ANSI_NULLS ON
GO
 
SET QUOTED_IDENTIFIER ON
GO
 
SET ANSI_PADDING ON
GO
 
CREATE TABLE [dbo].[Log4Net_Error](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Date] [datetime] NOT NULL,
    [Thread] [varchar](255) NOT NULL,
    [Level] [varchar](50) NOT NULL,
    [Logger] [varchar](255) NOT NULL,
    [Message] [varchar](4000) NOT NULL,
    [Exception] [varchar](2000) NULL
) ON [PRIMARY]
 
GO
 
SET ANSI_PADDING OFF
GO