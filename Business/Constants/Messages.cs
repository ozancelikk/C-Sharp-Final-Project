using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductsListed="Ürünler Listelendi";
        public static string UnitPriceInvalid;
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists="bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "Kategori Limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied="Yetkiniz yok";
        internal static string UserRegistered="Kayıt olundu";
        internal static string UserNotFound="Kullanıcı bulunamadı";
        internal static string PasswordError="Şifre Hatalı";
        internal static string SuccessfulLogin="Başarılı Giriş";
        internal static string UserAlreadyExists="Kullanıcı mevcut";
        internal static string AccessTokenCreated;
    }
}
