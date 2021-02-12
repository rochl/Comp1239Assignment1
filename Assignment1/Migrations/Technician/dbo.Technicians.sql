CREATE TABLE [dbo].[Technicians] (
    [techName]  NVARCHAR (450) NOT NULL,
    [techEmail] NVARCHAR (MAX) NOT NULL,
    [techPhone] NVARCHAR (MAX) NOT NULL,
    [techId] INT NOT NULL, 
    CONSTRAINT [PK_Technicians] PRIMARY KEY CLUSTERED ([techId])
);

