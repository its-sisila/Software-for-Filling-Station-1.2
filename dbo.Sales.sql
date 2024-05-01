CREATE TABLE [dbo].[Sales] (
    [date]        DATETIME NOT NULL,
    [shift]       NVARCHAR (50) NOT NULL,
    [meterStart]  NVARCHAR (50) NOT NULL,
    [meterEnd]    NVARCHAR (50) NOT NULL,
    [salesLiters] NVARCHAR (50) NOT NULL,
    [salesLKR]    NVARCHAR (50) NOT NULL,
    [nozzel]      NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([date] ASC)
);

