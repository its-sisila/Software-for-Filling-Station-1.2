CREATE TABLE [dbo].[Sales] (
    [date]        NVARCHAR (50) NOT NULL,
    [shift]       NVARCHAR (50) NOT NULL,
    [meterStart]  NVARCHAR (50) NOT NULL,
    [meterEnd]    NVARCHAR (50) NOT NULL,
    [salesLiters] NVARCHAR (50) NOT NULL,
    [salesLKR]    NVARCHAR (50) NOT NULL,
    [nozzel] NVARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([date])
);

