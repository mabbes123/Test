/****** Object:  Table [dbo].[Operator]    Script Date: 07/09/2022 10:31:01 ******/
CREATE TABLE [dbo].[Operator](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[First_Name] [varchar](50) NULL,
	[Last_Name] [varchar](50) NULL,
	[Login] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Type] [varchar](5) NOT NULL,
	[Creation_Date] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Operator] ADD  CONSTRAINT [DF_Operator_Creation_Date]  DEFAULT (getdate()) FOR [Creation_Date]
GO

/****** Object:  Table [dbo].[Part]    Script Date: 07/09/2022 10:31:45 ******/
CREATE TABLE [dbo].[Part](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Partnumber] [varchar](50) NOT NULL,
	[DelayInFrigot] [float] NOT NULL,
	[DelayOutFrigot] [float] NOT NULL,
	[DelayStabilisation] [float] NOT NULL,
	[DelayAfterOppening] [float] NOT NULL,
	[Creation_Date] [datetime] NOT NULL,
	[Comment] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Partnumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Part] ADD  DEFAULT ((0)) FOR [DelayInFrigot]
GO

ALTER TABLE [dbo].[Part] ADD  DEFAULT ((0)) FOR [DelayOutFrigot]
GO

ALTER TABLE [dbo].[Part] ADD  DEFAULT ((0)) FOR [DelayStabilisation]
GO

ALTER TABLE [dbo].[Part] ADD  DEFAULT ((0)) FOR [DelayAfterOppening]
GO

ALTER TABLE [dbo].[Part] ADD  DEFAULT (getdate()) FOR [Creation_Date]
GO

/****** Object:  Table [dbo].[Creme]    Script Date: 07/09/2022 10:32:12 ******/
CREATE TABLE [dbo].[Creme](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UID] [varchar](50) NOT NULL,
	[Id_Part] [int] NOT NULL,
	[Expiration_Date] [datetime] NOT NULL,
	[In_Frigo_Date] [datetime] NULL,
	[Out_Frigo_Date] [datetime] NULL,
	[Oppening_Date] [datetime] NULL,
	[Creation_Date] [datetime] NOT NULL,
	[Comment] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Creme] ADD  DEFAULT (getdate()) FOR [Creation_Date]
GO

ALTER TABLE [dbo].[Creme]  WITH CHECK ADD FOREIGN KEY([Id_Part])
REFERENCES [dbo].[Part] ([ID])
GO

INSERT INTO Operator ( First_Name, Last_Name, Login, Password, Type) VALUES 
('Top', 'Admin', 'topadmin', 'topadmin', 'ad')