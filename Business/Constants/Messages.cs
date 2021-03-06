﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarDailyPriceMin = "Araç kiralık fiyatı 0'dan büyük olmalıdır.";
        public static string CarDeleted = "Araç silindi.";
        public static string CarUpdated = "Araç güncellendi.";
        public static string CarsListed = "Araçlar listelendi.";
        public static string CarDetailsListed = "Araç detayı listelendi.";
        public static string CarsFilterListed = "Araçlar filtreye göre listelendi.";
        public static string BrandAdded = "Marka eklendi.";
        public static string BrandNameMinError = "Araba ismi minimum 2 karakter olmalı.";
        public static string CarNotAvailable = "Araç mevcut değil";
        public static string CarRentSuccess = "Araç kiralandı.";
        public static string ImageLimitError = "Araç için maksimum fotoğraf sayısı 5 olmalı";
        public static string ImageAdded = "Resim eklendi.";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Başarılı";

        public static string CustomerUpdated = "Müşteri güncellendi";

        public static string CustomerFindexPointZero = "Müşteri findeks puanı sıfır";

        public static string CustomerScoreIsInsufficient = "Müşteri findex puanı yetersiz.";

        public static string CarIsRentalled = "Araç heniz teslim edilmemiş";

        public static string CardUpdated { get; internal set; }
        public static string CardDeleted { get; internal set; }
        public static string CardAdded { get; internal set; }
        public static string CardAlreadyExists { get; internal set; }
    }
}
