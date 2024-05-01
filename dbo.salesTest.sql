CREATE TABLE [dbo].[salesTest] (
    [date]        DATETIME      NOT NULL,
    [shift]       TIME (7)      NOT NULL,
    [startMeter]  NVARCHAR (50) NOT NULL,
    [endMeter]    NVARCHAR (50) NOT NULL,
    [salesLiters] NVARCHAR (50) NOT NULL,
    [salesLKR]    NVARCHAR (50) NOT NULL,
    [nozzel]      NVARCHAR (50) NOT NULL,
    [shiftDrop]   NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([date] ASC)
);

