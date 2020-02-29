USE [master]
GO
/****** Object:  Database [db]    Script Date: 29/02/2020 12:45:44 a. m. ******/
CREATE DATABASE [db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [db] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db] SET ARITHABORT OFF 
GO
ALTER DATABASE [db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db] SET RECOVERY FULL 
GO
ALTER DATABASE [db] SET  MULTI_USER 
GO
ALTER DATABASE [db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'db', N'ON'
GO
ALTER DATABASE [db] SET QUERY_STORE = OFF
GO
USE [db]
GO
/****** Object:  Table [dbo].[Tareas]    Script Date: 29/02/2020 12:45:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tareas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](255) NOT NULL,
	[Fecha] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 29/02/2020 12:45:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](255) NOT NULL,
	[Apellido] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RelacionTareaEmpleado]    Script Date: 29/02/2020 12:45:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RelacionTareaEmpleado](
	[FK_Tarea] [int] NOT NULL,
	[FK_Empleado] [int] NOT NULL,
	[ID_EntityFrameWork] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_EntityFrameWork] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VistaTareaEmpleado]    Script Date: 29/02/2020 12:45:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VistaTareaEmpleado]
AS
SELECT        dbo.Tareas.Descripcion, dbo.Empleados.Nombre
FROM            dbo.RelacionTareaEmpleado INNER JOIN
                         dbo.Tareas ON dbo.Tareas.ID = dbo.RelacionTareaEmpleado.FK_Tarea INNER JOIN
                         dbo.Empleados ON dbo.Empleados.ID = dbo.RelacionTareaEmpleado.FK_Empleado
GO
ALTER TABLE [dbo].[RelacionTareaEmpleado]  WITH CHECK ADD FOREIGN KEY([FK_Empleado])
REFERENCES [dbo].[Empleados] ([ID])
GO
ALTER TABLE [dbo].[RelacionTareaEmpleado]  WITH CHECK ADD FOREIGN KEY([FK_Tarea])
REFERENCES [dbo].[Tareas] ([ID])
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "RelacionTareaEmpleado"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 234
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Tareas"
            Begin Extent = 
               Top = 6
               Left = 272
               Bottom = 119
               Right = 442
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Empleados"
            Begin Extent = 
               Top = 6
               Left = 480
               Bottom = 119
               Right = 650
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaTareaEmpleado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaTareaEmpleado'
GO
USE [master]
GO
ALTER DATABASE [db] SET  READ_WRITE 
GO
