﻿CREATE TABLE [dbo].[Rent](
	[ID] [int] NOT NULL,
	[Rate] [money] NULL,
	[Meters] [money] NULL,
	[Public utilities] [money] NULL,
 CONSTRAINT [PK_Rent] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Rent]  WITH CHECK ADD  CONSTRAINT [FK_Rent_Transaction] FOREIGN KEY([ID])
REFERENCES [dbo].[Transaction] ([ID])
GO

ALTER TABLE [dbo].[Rent] CHECK CONSTRAINT [FK_Rent_Transaction]