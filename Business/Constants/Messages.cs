using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    //Proje için sabitler
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi ";
        public static string ProductDeleted = "Ürün Silindi";
        public static string ProductNameInvalid = "Ürün ismi gecersiz";
        public static string MaintenanceTime = "Sistem onarım zamanı";
        public static string ProductListed = "Ürünler Listelendi ";
        public static string ProductCountOfCategoryError = "Ürün kategorisinde 15 ten fazla ürün var";
        public static string ProductNameAlreadyExist = "Aynı isimde ürün zaten var";
        public static string CategoryLimitExceded = "katagori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz Yok";
        public static string UserRegistered = "kullanıcı kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunmadı";
        public static string PasswordError = "şifre hatalı";
        public static string SuccessfulLogin = "Basarili giriş yapıldı";
        public static string UserAlreadyExists = "Boyle bir kullanıcı mevcut";
        public static string AccessTokenCreated = "Token olusturuldu";
    }
}
