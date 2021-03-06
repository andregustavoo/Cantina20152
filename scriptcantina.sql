USE [dbcantina]
GO
/****** Object:  Table [dbo].[tbl_cliente]    Script Date: 08/03/2016 21:00:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_cliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nome_cliente] [varchar](max) NULL,
	[telefone_cliente] [varchar](20) NULL,
 CONSTRAINT [PK_tbl_cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_conta]    Script Date: 08/03/2016 21:00:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_conta](
	[id_conta] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NULL,
 CONSTRAINT [PK_tbl_conta] PRIMARY KEY CLUSTERED 
(
	[id_conta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_funcionario]    Script Date: 08/03/2016 21:00:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_funcionario](
	[id_funcionario] [int] IDENTITY(1,1) NOT NULL,
	[nome_funcionario] [varchar](max) NULL,
	[matricula_funcionario] [varchar](10) NULL,
 CONSTRAINT [PK_tbl_funcionario] PRIMARY KEY CLUSTERED 
(
	[id_funcionario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_pagamento]    Script Date: 08/03/2016 21:00:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_pagamento](
	[id_pagamento] [int] IDENTITY(1,1) NOT NULL,
	[data_pagamento] [date] NULL,
	[valor_pagamento] [money] NULL,
	[id_conta] [int] NULL,
 CONSTRAINT [PK_tbl_pagamento] PRIMARY KEY CLUSTERED 
(
	[id_pagamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_produto]    Script Date: 08/03/2016 21:00:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_produto](
	[id_produto] [int] IDENTITY(1,1) NOT NULL,
	[descricao_produto] [varchar](max) NULL,
	[preco_unitario] [money] NULL,
 CONSTRAINT [PK_tbl_produto] PRIMARY KEY CLUSTERED 
(
	[id_produto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_venda]    Script Date: 08/03/2016 21:00:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_venda](
	[id_venda] [int] IDENTITY(1,1) NOT NULL,
	[data_venda] [date] NULL,
	[id_cliente] [int] NULL,
	[id_funcionario] [int] NULL,
 CONSTRAINT [PK_tbl_venda] PRIMARY KEY CLUSTERED 
(
	[id_venda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_venda_produto]    Script Date: 08/03/2016 21:00:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_venda_produto](
	[id_venda] [int] NOT NULL,
	[id_produto] [int] NOT NULL,
	[quantidade] [float] NULL,
 CONSTRAINT [PK_tbl_venda_produto] PRIMARY KEY CLUSTERED 
(
	[id_venda] ASC,
	[id_produto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[tbl_conta]  WITH CHECK ADD  CONSTRAINT [FK_tbl_conta_tbl_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[tbl_cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[tbl_conta] CHECK CONSTRAINT [FK_tbl_conta_tbl_cliente]
GO
ALTER TABLE [dbo].[tbl_pagamento]  WITH CHECK ADD  CONSTRAINT [FK_tbl_pagamento_tbl_conta] FOREIGN KEY([id_conta])
REFERENCES [dbo].[tbl_conta] ([id_conta])
GO
ALTER TABLE [dbo].[tbl_pagamento] CHECK CONSTRAINT [FK_tbl_pagamento_tbl_conta]
GO
ALTER TABLE [dbo].[tbl_venda]  WITH CHECK ADD  CONSTRAINT [FK_tbl_venda_tbl_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[tbl_cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[tbl_venda] CHECK CONSTRAINT [FK_tbl_venda_tbl_cliente]
GO
ALTER TABLE [dbo].[tbl_venda]  WITH CHECK ADD  CONSTRAINT [FK_tbl_venda_tbl_funcionario] FOREIGN KEY([id_funcionario])
REFERENCES [dbo].[tbl_funcionario] ([id_funcionario])
GO
ALTER TABLE [dbo].[tbl_venda] CHECK CONSTRAINT [FK_tbl_venda_tbl_funcionario]
GO
ALTER TABLE [dbo].[tbl_venda_produto]  WITH CHECK ADD  CONSTRAINT [FK_tbl_venda_produto_tbl_produto] FOREIGN KEY([id_produto])
REFERENCES [dbo].[tbl_produto] ([id_produto])
GO
ALTER TABLE [dbo].[tbl_venda_produto] CHECK CONSTRAINT [FK_tbl_venda_produto_tbl_produto]
GO
ALTER TABLE [dbo].[tbl_venda_produto]  WITH CHECK ADD  CONSTRAINT [FK_tbl_venda_produto_tbl_venda] FOREIGN KEY([id_venda])
REFERENCES [dbo].[tbl_venda] ([id_venda])
GO
ALTER TABLE [dbo].[tbl_venda_produto] CHECK CONSTRAINT [FK_tbl_venda_produto_tbl_venda]
GO
