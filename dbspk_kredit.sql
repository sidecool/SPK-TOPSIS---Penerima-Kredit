-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 02, 2020 at 12:47 AM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.2.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbspk_kredit`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_alternatif`
--

CREATE TABLE `tbl_alternatif` (
  `kd_alternatif` varchar(25) NOT NULL,
  `nm_alternatif` varchar(500) NOT NULL,
  `is_aktif` varchar(2) NOT NULL DEFAULT 'N'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_alternatif`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_kriteria`
--

CREATE TABLE `tbl_kriteria` (
  `kd_kriteria` varchar(25) NOT NULL,
  `nm_kriteria` varchar(500) NOT NULL,
  `n_bobot` double NOT NULL,
  `n_atribut` varchar(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_kriteria`
--

INSERT INTO `tbl_kriteria` (`kd_kriteria`, `nm_kriteria`, `n_bobot`, `n_atribut`) VALUES
('C1', 'Kapasitas/Pekerjaan', 25, 'B'),
('C2', 'Kapasitas/Modal', 35, 'B'),
('C3', 'Kolateral/Jaminan', 20, 'B'),
('C4', 'Kondisi Ekonomi/Penghasilan', 20, 'B');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_matriks_kriteria`
--

CREATE TABLE `tbl_matriks_kriteria` (
  `kd_matriks` varchar(25) NOT NULL,
  `kd_alternatif` varchar(25) NOT NULL,
  `kd_sub_kriteria` varchar(25) NOT NULL,
  `kd_kriteria` varchar(25) NOT NULL,
  `kd_sub` varchar(25) NOT NULL,
  `n_normalisasi` double NOT NULL,
  `n_bobot_normalisasi` double NOT NULL,
  `jarak_positif` double NOT NULL,
  `jarak_negatif` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_matriks_preferensi`
--

CREATE TABLE `tbl_matriks_preferensi` (
  `kd_alternatif` varchar(25) NOT NULL,
  `n_positif` double NOT NULL,
  `n_negatif` double NOT NULL,
  `preferensi` double NOT NULL,
  `rank` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pemohon`
--

CREATE TABLE `tbl_pemohon` (
  `kd_pemohon` varchar(25) NOT NULL,
  `nm_pemohon` varchar(500) NOT NULL,
  `no_ktp` varchar(50) NOT NULL,
  `alamat` text NOT NULL,
  `jenis_kelamin` varchar(2) NOT NULL,
  `no_telp` varchar(15) NOT NULL,
  `is_menikah` varchar(2) NOT NULL,
  `pekerjaan` varchar(250) NOT NULL,
  `nm_ibu` varchar(500) NOT NULL,
  `plafon` int(11) NOT NULL,
  `jangka_waktu` int(11) NOT NULL,
  `waktu` varchar(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

ALTER TABLE `tbl_pemohon` ADD `waktu` VARCHAR(2) NOT NULL AFTER `jangka_waktu`;

--
-- Dumping data for table `tbl_pemohon`
--

--
-- Triggers `tbl_pemohon`
--
DELIMITER $$
CREATE TRIGGER `AFTER_PEMOHON_INSERT` AFTER INSERT ON `tbl_pemohon` FOR EACH ROW BEGIN
	INSERT INTO tbl_alternatif(kd_alternatif, nm_alternatif, is_aktif)
	VALUES(new.kd_pemohon, new.nm_pemohon, 'N');
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `AFTER_PEMOHON_UPDATE` AFTER UPDATE ON `tbl_pemohon` FOR EACH ROW BEGIN
	INSERT INTO tbl_alternatif (kd_alternatif, nm_alternatif, is_aktif) VALUES (old.kd_pemohon, new.nm_pemohon, 'N') ON DUPLICATE KEY UPDATE nm_alternatif=new.nm_pemohon; 
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `BEFORE_PEMOHON_DELETE` BEFORE DELETE ON `tbl_pemohon` FOR EACH ROW BEGIN
	DELETE FROM tbl_alternatif WHERE kd_alternatif=old.kd_pemohon;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_sub_kriteria`
--

CREATE TABLE `tbl_sub_kriteria` (
  `kd_sub_kriteria` varchar(25) NOT NULL,
  `kd_kriteria` varchar(25) NOT NULL,
  `kd_sub` varchar(25) NOT NULL,
  `keterangan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_sub_kriteria`
--

INSERT INTO `tbl_sub_kriteria` (`kd_sub_kriteria`, `kd_kriteria`, `kd_sub`, `keterangan`) VALUES
('C1.1', 'C1', '1', 'Tidak bekerja'),
('C1.2', 'C1', '2', 'Petani yang mempunyai usaha'),
('C1.3', 'C1', '3', 'PNS'),
('C1.4', 'C1', '4', 'Wiraswasta'),
('C2.1', 'C2', '1', 'DP > 15% dari Harga'),
('C2.2', 'C2', '2', 'DP 16% - 20% dari Harga'),
('C2.3', 'C2', '3', 'DP 21% - 25% dari Harga'),
('C3.1', 'C3', '1', 'BPKB Motor'),
('C3.2', 'C3', '2', 'BPKB Mobil'),
('C3.3', 'C3', '3', 'Sertifikat Rumah'),
('C3.4', 'C3', '4', 'Sertifikat Tanah'),
('C4.1', 'C4', '1', '100.000 - 1.000.000'),
('C4.2', 'C4', '2', '1.000.000 - 1.500.000'),
('C4.3', 'C4', '3', '1.500.000 - 2.000.000');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user`
--

CREATE TABLE `tbl_user` (
  `USERNAME` varchar(25) NOT NULL,
  `PASSWORD` varchar(25) NOT NULL,
  `NM_USER` varchar(250) NOT NULL,
  `LEVEL` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_user`
--

INSERT INTO `tbl_user` (`USERNAME`, `PASSWORD`, `NM_USER`, `LEVEL`) VALUES
('ADMIN', 'DEMO', 'NAMA ADMINISTRATOR', '0'),
('KEPALA', 'DEMO', 'NAMA PIMPINAN', '1');

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_analisa`
-- (See below for the actual view)
--
CREATE TABLE `v_analisa` (
`kd_matriks` varchar(25)
,`kd_alternatif` varchar(25)
,`kd_sub_kriteria` varchar(25)
,`kd_kriteria` varchar(25)
,`kd_sub` varchar(25)
,`nm_alternatif` varchar(500)
,`nm_kriteria` varchar(500)
,`keterangan` text
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_jarak_solusi`
-- (See below for the actual view)
--
CREATE TABLE `v_jarak_solusi` (
`kd_matriks` varchar(25)
,`kd_alternatif` varchar(25)
,`nm_alternatif` varchar(500)
,`kd_sub_kriteria` varchar(25)
,`kd_kriteria` varchar(25)
,`nm_kriteria` varchar(500)
,`kd_sub` varchar(25)
,`keterangan` text
,`normalisasi` double
,`sum_normalisasi` double
,`akar_sum_normalisasi` double
,`pembobotan` double
,`bobot` double
,`normalisasi_terbobot` double
,`jarak_solusi_positif` double
,`jarak_solusi_negatif` double
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_laporan`
-- (See below for the actual view)
--
CREATE TABLE `v_laporan` (
`kd_alternatif` varchar(25)
,`nm_alternatif` varchar(500)
,`C1` text
,`C2` text
,`C3` text
,`C4` text
,`rank` int(11)
,`nilai` double
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_matrix_solusi_ideal`
-- (See below for the actual view)
--
CREATE TABLE `v_matrix_solusi_ideal` (
`kd_kriteria` varchar(25)
,`n_atribut` varchar(2)
,`positif` double
,`negatif` double
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_max_min_normalisasi`
-- (See below for the actual view)
--
CREATE TABLE `v_max_min_normalisasi` (
`kd_kriteria` varchar(25)
,`max_normal` double
,`min_normal` double
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_normalisasi_terbobot`
-- (See below for the actual view)
--
CREATE TABLE `v_normalisasi_terbobot` (
`kd_matriks` varchar(25)
,`kd_alternatif` varchar(25)
,`nm_alternatif` varchar(500)
,`kd_sub_kriteria` varchar(25)
,`kd_kriteria` varchar(25)
,`nm_kriteria` varchar(500)
,`kd_sub` varchar(25)
,`keterangan` text
,`normalisasi` double
,`sum_normalisasi` double
,`akar_sum_normalisasi` double
,`pembobotan` double
,`bobot` double
,`normalisasi_terbobot` double
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_pembobotan`
-- (See below for the actual view)
--
CREATE TABLE `v_pembobotan` (
`kd_kriteria` varchar(25)
,`sum_normalisasi` double
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_preferensi`
-- (See below for the actual view)
--
CREATE TABLE `v_preferensi` (
`kd_alternatif` varchar(25)
,`positif` double
,`negatif` double
,`preferensi` double
);

-- --------------------------------------------------------

--
-- Structure for view `v_analisa`
--
DROP TABLE IF EXISTS `v_analisa`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_analisa`  AS  select `a`.`kd_matriks` AS `kd_matriks`,`a`.`kd_alternatif` AS `kd_alternatif`,`a`.`kd_sub_kriteria` AS `kd_sub_kriteria`,`a`.`kd_kriteria` AS `kd_kriteria`,`a`.`kd_sub` AS `kd_sub`,`b`.`nm_alternatif` AS `nm_alternatif`,`c`.`nm_kriteria` AS `nm_kriteria`,`d`.`keterangan` AS `keterangan` from (((`tbl_matriks_kriteria` `a` left join `tbl_alternatif` `b` on(`a`.`kd_alternatif` = `b`.`kd_alternatif`)) left join `tbl_kriteria` `c` on(`a`.`kd_kriteria` = `c`.`kd_kriteria`)) left join `tbl_sub_kriteria` `d` on(`a`.`kd_sub_kriteria` = `d`.`kd_sub_kriteria`)) order by `a`.`kd_matriks` ;

-- --------------------------------------------------------

--
-- Structure for view `v_jarak_solusi`
--
DROP TABLE IF EXISTS `v_jarak_solusi`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_jarak_solusi`  AS  select `a`.`kd_matriks` AS `kd_matriks`,`a`.`kd_alternatif` AS `kd_alternatif`,`a`.`nm_alternatif` AS `nm_alternatif`,`a`.`kd_sub_kriteria` AS `kd_sub_kriteria`,`a`.`kd_kriteria` AS `kd_kriteria`,`a`.`nm_kriteria` AS `nm_kriteria`,`a`.`kd_sub` AS `kd_sub`,`a`.`keterangan` AS `keterangan`,`a`.`normalisasi` AS `normalisasi`,`a`.`sum_normalisasi` AS `sum_normalisasi`,`a`.`akar_sum_normalisasi` AS `akar_sum_normalisasi`,`a`.`pembobotan` AS `pembobotan`,`a`.`bobot` AS `bobot`,`a`.`normalisasi_terbobot` AS `normalisasi_terbobot`,pow(`a`.`normalisasi_terbobot` - `b`.`positif`,2) AS `jarak_solusi_positif`,pow(`a`.`normalisasi_terbobot` - `b`.`negatif`,2) AS `jarak_solusi_negatif` from (`v_normalisasi_terbobot` `a` left join `v_matrix_solusi_ideal` `b` on(`a`.`kd_kriteria` = `b`.`kd_kriteria`)) ;

-- --------------------------------------------------------

--
-- Structure for view `v_laporan`
--
DROP TABLE IF EXISTS `v_laporan`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_laporan`  AS  (select `mk`.`kd_alternatif` AS `kd_alternatif`,`a`.`nm_alternatif` AS `nm_alternatif`,max(case when `mk`.`kd_kriteria` = 'C1' then `sk`.`keterangan` else NULL end) AS `C1`,max(case when `mk`.`kd_kriteria` = 'C2' then `sk`.`keterangan` else NULL end) AS `C2`,max(case when `mk`.`kd_kriteria` = 'C3' then `sk`.`keterangan` else NULL end) AS `C3`,max(case when `mk`.`kd_kriteria` = 'C4' then `sk`.`keterangan` else NULL end) AS `C4`,`mp`.`rank` AS `rank`,`mp`.`preferensi` AS `nilai` from (((`tbl_matriks_kriteria` `mk` left join `tbl_alternatif` `a` on(`mk`.`kd_alternatif` = `a`.`kd_alternatif`)) left join `tbl_sub_kriteria` `sk` on(`mk`.`kd_sub_kriteria` = `sk`.`kd_sub_kriteria`)) left join `tbl_matriks_preferensi` `mp` on(`mk`.`kd_alternatif` = `mp`.`kd_alternatif`)) group by `mk`.`kd_alternatif` order by `mp`.`rank`) ;

-- --------------------------------------------------------

--
-- Structure for view `v_matrix_solusi_ideal`
--
DROP TABLE IF EXISTS `v_matrix_solusi_ideal`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_matrix_solusi_ideal`  AS  select `a`.`kd_kriteria` AS `kd_kriteria`,`a`.`n_atribut` AS `n_atribut`,case when `a`.`n_atribut` = 'B' then `b`.`max_normal` else `b`.`min_normal` end AS `positif`,case when `a`.`n_atribut` = 'B' then `b`.`min_normal` else `b`.`max_normal` end AS `negatif` from (`tbl_kriteria` `a` left join `v_max_min_normalisasi` `b` on(`a`.`kd_kriteria` = `b`.`kd_kriteria`)) ;

-- --------------------------------------------------------

--
-- Structure for view `v_max_min_normalisasi`
--
DROP TABLE IF EXISTS `v_max_min_normalisasi`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_max_min_normalisasi`  AS  select `v_normalisasi_terbobot`.`kd_kriteria` AS `kd_kriteria`,max(`v_normalisasi_terbobot`.`normalisasi_terbobot`) AS `max_normal`,min(`v_normalisasi_terbobot`.`normalisasi_terbobot`) AS `min_normal` from `v_normalisasi_terbobot` group by `v_normalisasi_terbobot`.`kd_kriteria` ;

-- --------------------------------------------------------

--
-- Structure for view `v_normalisasi_terbobot`
--
DROP TABLE IF EXISTS `v_normalisasi_terbobot`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_normalisasi_terbobot`  AS  select `a`.`kd_matriks` AS `kd_matriks`,`a`.`kd_alternatif` AS `kd_alternatif`,`b`.`nm_alternatif` AS `nm_alternatif`,`a`.`kd_sub_kriteria` AS `kd_sub_kriteria`,`a`.`kd_kriteria` AS `kd_kriteria`,`c`.`nm_kriteria` AS `nm_kriteria`,`a`.`kd_sub` AS `kd_sub`,`d`.`keterangan` AS `keterangan`,pow(`a`.`kd_sub`,2) AS `normalisasi`,`e`.`sum_normalisasi` AS `sum_normalisasi`,sqrt(`e`.`sum_normalisasi`) AS `akar_sum_normalisasi`,`a`.`kd_sub` / sqrt(`e`.`sum_normalisasi`) AS `pembobotan`,`c`.`n_bobot` / 100 AS `bobot`,`c`.`n_bobot` / 100 * (`a`.`kd_sub` / sqrt(`e`.`sum_normalisasi`)) AS `normalisasi_terbobot` from ((((`tbl_matriks_kriteria` `a` left join `tbl_alternatif` `b` on(`a`.`kd_alternatif` = `b`.`kd_alternatif`)) left join `tbl_kriteria` `c` on(`a`.`kd_kriteria` = `c`.`kd_kriteria`)) left join `tbl_sub_kriteria` `d` on(`a`.`kd_sub_kriteria` = `d`.`kd_sub_kriteria`)) left join `v_pembobotan` `e` on(`a`.`kd_kriteria` = `e`.`kd_kriteria`)) ;

-- --------------------------------------------------------

--
-- Structure for view `v_pembobotan`
--
DROP TABLE IF EXISTS `v_pembobotan`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_pembobotan`  AS  select `tbl_matriks_kriteria`.`kd_kriteria` AS `kd_kriteria`,sum(`tbl_matriks_kriteria`.`n_normalisasi`) AS `sum_normalisasi` from `tbl_matriks_kriteria` group by `tbl_matriks_kriteria`.`kd_kriteria` ;

-- --------------------------------------------------------

--
-- Structure for view `v_preferensi`
--
DROP TABLE IF EXISTS `v_preferensi`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_preferensi`  AS  select `v_jarak_solusi`.`kd_alternatif` AS `kd_alternatif`,sqrt(sum(`v_jarak_solusi`.`jarak_solusi_positif`)) AS `positif`,sqrt(sum(`v_jarak_solusi`.`jarak_solusi_negatif`)) AS `negatif`,sqrt(sum(`v_jarak_solusi`.`jarak_solusi_negatif`)) / (sqrt(sum(`v_jarak_solusi`.`jarak_solusi_positif`)) + sqrt(sum(`v_jarak_solusi`.`jarak_solusi_negatif`))) AS `preferensi` from `v_jarak_solusi` group by `v_jarak_solusi`.`kd_alternatif` ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_alternatif`
--
ALTER TABLE `tbl_alternatif`
  ADD PRIMARY KEY (`kd_alternatif`);

--
-- Indexes for table `tbl_kriteria`
--
ALTER TABLE `tbl_kriteria`
  ADD PRIMARY KEY (`kd_kriteria`);

--
-- Indexes for table `tbl_matriks_kriteria`
--
ALTER TABLE `tbl_matriks_kriteria`
  ADD PRIMARY KEY (`kd_matriks`),
  ADD KEY `kd_sub_kriteria` (`kd_sub_kriteria`),
  ADD KEY `kd_alternatif` (`kd_alternatif`);

--
-- Indexes for table `tbl_matriks_preferensi`
--
ALTER TABLE `tbl_matriks_preferensi`
  ADD PRIMARY KEY (`kd_alternatif`);
--
-- Indexes for table `tbl_pemohon`
--
ALTER TABLE `tbl_pemohon`
  ADD PRIMARY KEY (`kd_pemohon`);

--
-- Indexes for table `tbl_sub_kriteria`
--
ALTER TABLE `tbl_sub_kriteria`
  ADD PRIMARY KEY (`kd_sub_kriteria`),
  ADD KEY `kd_sub` (`kd_sub`),
  ADD KEY `kd_kriteria` (`kd_kriteria`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_matriks_kriteria`
--
ALTER TABLE `tbl_matriks_kriteria`
  ADD CONSTRAINT `fk_alternatif` FOREIGN KEY (`kd_alternatif`) REFERENCES `tbl_alternatif` (`kd_alternatif`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_sub_kriteria` FOREIGN KEY (`kd_sub_kriteria`) REFERENCES `tbl_sub_kriteria` (`kd_sub_kriteria`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_matriks_preferensi`
--
ALTER TABLE `tbl_matriks_preferensi`
  ADD CONSTRAINT `fk_alternatif_preferensi` FOREIGN KEY (`kd_alternatif`) REFERENCES `tbl_matriks_kriteria` (`kd_alternatif`) ON DELETE CASCADE ON UPDATE CASCADE;  

--
-- Constraints for table `tbl_sub_kriteria`
--
ALTER TABLE `tbl_sub_kriteria`
  ADD CONSTRAINT `fk_kriteria` FOREIGN KEY (`kd_kriteria`) REFERENCES `tbl_kriteria` (`kd_kriteria`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
