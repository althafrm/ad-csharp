CREATE TABLE [dbo].[Events] (
    [Id]       UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [Name]     NVARCHAR (255)   NOT NULL,
    [DateTime] DATETIME         NOT NULL,
    [Venue]         NVARCHAR (255)   NOT NULL,
    [Type]     NVARCHAR (50)    NOT NULL,
    [Capacity]      INT              NOT NULL,
    [TicketPrice]   DECIMAL (10, 2)  NOT NULL,
    [CreatedAt]     DATETIME         DEFAULT (getdate()) NULL,
    [UpdatedAt]     DATETIME         DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CHECK ([Capacity]>=(0)),
    CHECK ([TicketPrice]>=(0)),
    CONSTRAINT [CHK_Type] CHECK ([Type]='Other' OR [Type]='Wedding' OR [Type]='Concert' OR [Type]='Conference')
);

CREATE TABLE [dbo].[Attendees] (
    [Id]  UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [EventId]     UNIQUEIDENTIFIER NOT NULL,
    [Name]        NVARCHAR (255)   NOT NULL,
    [Email]       NVARCHAR (255)   NOT NULL,
    [PhoneNumber] NVARCHAR (20)    NOT NULL,
    [CreatedAt]   DATETIME         DEFAULT (getdate()) NULL,
    [UpdatedAt]   DATETIME         DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Attendees_Events] FOREIGN KEY ([EventId]) REFERENCES [dbo].[Events] ([Id])
);
