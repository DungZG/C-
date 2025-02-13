USE [qldt]
GO
/****** Object:  Table [dbo].[chi_tiet_hoa_don]    Script Date: 6/1/2024 5:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chi_tiet_hoa_don](
	[mahd] [varchar](50) NOT NULL,
	[masp] [varchar](50) NOT NULL,
	[tensp] [varchar](50) NULL,
	[ghichu] [varchar](255) NULL,
	[soluong] [int] NULL,
	[dongia] [int] NULL,
	[thanhtien] [float] NULL,
 CONSTRAINT [PK_chi_tiet_hoa_don] PRIMARY KEY CLUSTERED 
(
	[mahd] ASC,
	[masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chi_tiet_phieu_nhap]    Script Date: 6/1/2024 5:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chi_tiet_phieu_nhap](
	[mapn] [varchar](50) NOT NULL,
	[masp] [varchar](50) NOT NULL,
	[gianhap] [int] NULL,
	[soluong] [int] NULL,
	[ghichu] [varchar](50) NULL,
 CONSTRAINT [PK_chi_tiet_phieu_nhap] PRIMARY KEY CLUSTERED 
(
	[mapn] ASC,
	[masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[don_vi]    Script Date: 6/1/2024 5:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[don_vi](
	[dv] [varchar](5) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hoa_Don]    Script Date: 6/1/2024 5:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoa_Don](
	[mahd] [varchar](50) NOT NULL,
	[makh] [varchar](50) NULL,
	[NgayLap] [date] NULL,
	[trangthai] [varchar](255) NULL,
	[tongtien] [float] NULL,
 CONSTRAINT [PK_Hoa_Don_1] PRIMARY KEY CLUSTERED 
(
	[mahd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khach_Hang]    Script Date: 6/1/2024 5:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khach_Hang](
	[makh] [varchar](50) NOT NULL,
	[tenkh] [varchar](50) NOT NULL,
	[GioiTinh] [varchar](3) NULL,
	[DiaChi] [varchar](255) NULL,
	[NamSinh] [date] NULL,
	[sdt] [varchar](10) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_Khach_Hang_1] PRIMARY KEY CLUSTERED 
(
	[makh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phieu_nhap]    Script Date: 6/1/2024 5:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieu_nhap](
	[mapn] [varchar](50) NOT NULL,
	[ngaynhap] [date] NULL,
	[tongtien] [int] NOT NULL,
 CONSTRAINT [PK_phieu_nhap] PRIMARY KEY CLUSTERED 
(
	[mapn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[san_pham]    Script Date: 6/1/2024 5:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[san_pham](
	[masp] [varchar](50) NOT NULL,
	[tensp] [varchar](50) NULL,
	[nhasx] [varchar](50) NULL,
	[soluong] [int] NULL,
	[giaban] [float] NULL,
	[mota] [varchar](50) NULL,
 CONSTRAINT [PK_san_pham] PRIMARY KEY CLUSTERED 
(
	[masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tai_Khoan]    Script Date: 6/1/2024 5:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tai_Khoan](
	[ID] [varchar](20) NOT NULL,
	[TenNguoiDung] [varchar](255) NULL,
	[TaiKhoan] [varchar](255) NULL,
	[MatKhau] [varchar](255) NULL,
	[VaiTro] [varchar](255) NULL,
 CONSTRAINT [PK_Tai_Khoan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[chi_tiet_hoa_don] ([mahd], [masp], [tensp], [ghichu], [soluong], [dongia], [thanhtien]) VALUES (N'01', N'dt1', N'Iphone12promax', N'moi', 1, 10000000, 10000000)
INSERT [dbo].[chi_tiet_hoa_don] ([mahd], [masp], [tensp], [ghichu], [soluong], [dongia], [thanhtien]) VALUES (N'02', N'dt2', N'SamSung S22 Ultra', N'moi', 2, 12000000, 24000000)
INSERT [dbo].[chi_tiet_hoa_don] ([mahd], [masp], [tensp], [ghichu], [soluong], [dongia], [thanhtien]) VALUES (N'03', N'dt1', N'Iphone12promax', N'moi', 1, 10000000, 10000000)
INSERT [dbo].[chi_tiet_hoa_don] ([mahd], [masp], [tensp], [ghichu], [soluong], [dongia], [thanhtien]) VALUES (N'04', N'dt1', N'Iphone12promax', NULL, 3, 10000000, 30000000)
GO
INSERT [dbo].[chi_tiet_phieu_nhap] ([mapn], [masp], [gianhap], [soluong], [ghichu]) VALUES (N'pn1', N'dt1', 10000000, 1, N'New')
INSERT [dbo].[chi_tiet_phieu_nhap] ([mapn], [masp], [gianhap], [soluong], [ghichu]) VALUES (N'pn2', N'dt2', 12000000, 1, N'New')
GO
INSERT [dbo].[Hoa_Don] ([mahd], [makh], [NgayLap], [trangthai], [tongtien]) VALUES (N'01', N'01', CAST(N'2023-04-20' AS Date), N'Ðã Thanh Toán', 74000000)
INSERT [dbo].[Hoa_Don] ([mahd], [makh], [NgayLap], [trangthai], [tongtien]) VALUES (N'02', N'02', CAST(N'2023-04-22' AS Date), N'Ðã Thanh Toán', 74000000)
INSERT [dbo].[Hoa_Don] ([mahd], [makh], [NgayLap], [trangthai], [tongtien]) VALUES (N'03', N'03', CAST(N'2024-06-05' AS Date), N'Ðã Thanh Toán', 74000000)
INSERT [dbo].[Hoa_Don] ([mahd], [makh], [NgayLap], [trangthai], [tongtien]) VALUES (N'04', N'04', CAST(N'2024-05-06' AS Date), N'Ðã Thanh Toán', 74000000)
GO
INSERT [dbo].[Khach_Hang] ([makh], [tenkh], [GioiTinh], [DiaChi], [NamSinh], [sdt], [Email]) VALUES (N'01', N'Nguyen Tri Dung', N'Nam', N'Ha Noi', CAST(N'2003-01-12' AS Date), N'0395185726', N'tridung4323@gmail.com')
INSERT [dbo].[Khach_Hang] ([makh], [tenkh], [GioiTinh], [DiaChi], [NamSinh], [sdt], [Email]) VALUES (N'02', N'Pham Huu Dat', N'Nam', N'Ha Noi', CAST(N'2003-10-30' AS Date), N'0395185726', N'huudat@gmail.com')
INSERT [dbo].[Khach_Hang] ([makh], [tenkh], [GioiTinh], [DiaChi], [NamSinh], [sdt], [Email]) VALUES (N'03', N'Doan Thi Hong', N'Nam', N'Ninh Binh', CAST(N'2003-02-02' AS Date), N'0395185726', N'hong@gmail.com')
INSERT [dbo].[Khach_Hang] ([makh], [tenkh], [GioiTinh], [DiaChi], [NamSinh], [sdt], [Email]) VALUES (N'04', N'Nguyen The Duong', N'Nam', N'Hai Duong', CAST(N'2003-01-12' AS Date), N'0395185726', N'theduong@gmail.com')
INSERT [dbo].[Khach_Hang] ([makh], [tenkh], [GioiTinh], [DiaChi], [NamSinh], [sdt], [Email]) VALUES (N'05', N'Dao Duc Huy', N'Nam', N'Hai Duong', CAST(N'2003-09-09' AS Date), N'0395185726', N'duchuy@gmail.com')
INSERT [dbo].[Khach_Hang] ([makh], [tenkh], [GioiTinh], [DiaChi], [NamSinh], [sdt], [Email]) VALUES (N'06', N'Le Tien Dat', N'Nam', N'Ha Noi', CAST(N'2003-09-01' AS Date), N'0395185726', N'dat@gmail.com')
INSERT [dbo].[Khach_Hang] ([makh], [tenkh], [GioiTinh], [DiaChi], [NamSinh], [sdt], [Email]) VALUES (N'07', N'Le Tien Dat', N'N?', N'Ha Noi', CAST(N'2003-01-09' AS Date), N'0395185726', N'dat@gmail.com')
GO
INSERT [dbo].[phieu_nhap] ([mapn], [ngaynhap], [tongtien]) VALUES (N'02', CAST(N'2023-12-06' AS Date), 24000000)
INSERT [dbo].[phieu_nhap] ([mapn], [ngaynhap], [tongtien]) VALUES (N'pn1', CAST(N'2024-06-05' AS Date), 10000000)
INSERT [dbo].[phieu_nhap] ([mapn], [ngaynhap], [tongtien]) VALUES (N'pn2', CAST(N'2024-05-06' AS Date), 12000000)
GO
INSERT [dbo].[san_pham] ([masp], [tensp], [nhasx], [soluong], [giaban], [mota]) VALUES (N'dt1', N'Iphone12promax', N'Apple', 10, 10000000, N'New')
INSERT [dbo].[san_pham] ([masp], [tensp], [nhasx], [soluong], [giaban], [mota]) VALUES (N'dt2', N'SamSung S22 Ultra', N'SamSung', 10, 12000000, N'New')
INSERT [dbo].[san_pham] ([masp], [tensp], [nhasx], [soluong], [giaban], [mota]) VALUES (N'dt3', N'XiaoMi 13 Pro', N'XiaoMi', 10, 5000000, N'New')
INSERT [dbo].[san_pham] ([masp], [tensp], [nhasx], [soluong], [giaban], [mota]) VALUES (N'dt4', N'Iphone13 ProMax', N'Apple', 10, 20000000, N'New')
INSERT [dbo].[san_pham] ([masp], [tensp], [nhasx], [soluong], [giaban], [mota]) VALUES (N'dt5', N'Iphone14 ProMax', N'Apple', 10, 23000000, N'New')
GO
INSERT [dbo].[Tai_Khoan] ([ID], [TenNguoiDung], [TaiKhoan], [MatKhau], [VaiTro]) VALUES (N'01', N'Admin', N'admin', N'admin', N'Admin')
GO
ALTER TABLE [dbo].[chi_tiet_hoa_don]  WITH CHECK ADD  CONSTRAINT [FK_chi_tiet_hoa_don_Hoa_Don1] FOREIGN KEY([mahd])
REFERENCES [dbo].[Hoa_Don] ([mahd])
GO
ALTER TABLE [dbo].[chi_tiet_hoa_don] CHECK CONSTRAINT [FK_chi_tiet_hoa_don_Hoa_Don1]
GO
ALTER TABLE [dbo].[chi_tiet_hoa_don]  WITH CHECK ADD  CONSTRAINT [FK_chi_tiet_hoa_don_san_pham] FOREIGN KEY([masp])
REFERENCES [dbo].[san_pham] ([masp])
GO
ALTER TABLE [dbo].[chi_tiet_hoa_don] CHECK CONSTRAINT [FK_chi_tiet_hoa_don_san_pham]
GO
ALTER TABLE [dbo].[chi_tiet_phieu_nhap]  WITH CHECK ADD  CONSTRAINT [FK_chi_tiet_phieu_nhap_phieu_nhap] FOREIGN KEY([mapn])
REFERENCES [dbo].[phieu_nhap] ([mapn])
GO
ALTER TABLE [dbo].[chi_tiet_phieu_nhap] CHECK CONSTRAINT [FK_chi_tiet_phieu_nhap_phieu_nhap]
GO
ALTER TABLE [dbo].[chi_tiet_phieu_nhap]  WITH CHECK ADD  CONSTRAINT [FK_chi_tiet_phieu_nhap_san_pham] FOREIGN KEY([masp])
REFERENCES [dbo].[san_pham] ([masp])
GO
ALTER TABLE [dbo].[chi_tiet_phieu_nhap] CHECK CONSTRAINT [FK_chi_tiet_phieu_nhap_san_pham]
GO
ALTER TABLE [dbo].[Hoa_Don]  WITH CHECK ADD  CONSTRAINT [FK_Hoa_Don_Khach_Hang] FOREIGN KEY([makh])
REFERENCES [dbo].[Khach_Hang] ([makh])
GO
ALTER TABLE [dbo].[Hoa_Don] CHECK CONSTRAINT [FK_Hoa_Don_Khach_Hang]
GO
