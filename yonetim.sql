CREATE DATABASE IF NOT EXISTS yonetim;
USE yonetim;

CREATE TABLE apartman (
    daireno INT PRIMARY KEY,
    tckimlik VARCHAR(11),
    adsoyad VARCHAR(100),
    ksayisi INT,
    tel VARCHAR(15),
    tur VARCHAR(20)
);

CREATE TABLE aidat (
    daireno INT,
    adsoyad VARCHAR(100),
    tutar INT,
    ay VARCHAR(20),
    yil INT
);

CREATE TABLE gider (
    tur VARCHAR(100),
    tutar VARCHAR(50),
    tarih DATETIME
);