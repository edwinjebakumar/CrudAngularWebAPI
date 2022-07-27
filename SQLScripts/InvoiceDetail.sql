USE [InvoiceDB]
GO

/****** Object:  Table [dbo].[InvoiceDetail]    Script Date: 7/27/2022 2:24:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[InvoiceDetail](
	[Id] [int] NOT NULL,
	[Item] [nvarchar](50) NULL,
	[Quantity] [int] NULL,
	[Amount] [money] NULL,
	[Tax] [money] NULL
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[InvoiceDetail]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceDetail_INVOICEHEADER] FOREIGN KEY([Id])
REFERENCES [dbo].[INVOICEHEADER] ([ID])
GO

ALTER TABLE [dbo].[InvoiceDetail] CHECK CONSTRAINT [FK_InvoiceDetail_INVOICEHEADER]
GO


