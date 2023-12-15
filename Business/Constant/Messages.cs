using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constant
{
    public class Messages
    {   
        //Activity
        public static string ActivityAdded = "Aktivite eklendi.";
        public static string ActivityDeleted = "Aktivite silindi.";
        public static string ActivityUpdated = "Aktivite güncellendi.";
        public static string ActivityListed = "Aktivite listelendi.";
        public static string ActivitiesListed = "Aktiviteler listelendi.";
        public static string NotEmptyActiviteInfo = "Aktivite Bilgileri Boş Olamaz!";

        //Food
        public static string FoodAdded = "Besin eklendi.";
        public static string FoodDeleted = "Besin silindi.";
        public static string FoodUpdated = "Besin güncellendi.";
        public static string FoodListed = "Besin listelendi.";
        public static string FoodsListed = "Besinler listelendi.";
        public static string NotEmptyFoodName = "Besin Adı Boş Olamaz!";
        

        //Health Status
        public static string HealthStatusAdded = "Sağlık durumu eklendi.";
        public static string HealthStatusDeleted = "Sağlık durumu silindi.";
        public static string HealthStatusUpdated = "Sağlık durumu güncellendi.";
        public static string HealthStatusListed = "Sağlık durumu listelendi.";
        public static string HealthStatusesListed = "Sağlık durumları listelendi.";
        public static string NotEmptyPetInfo = "Evcil Hayvan Bilgileri Boş Olamaz!";

        //Pet
        public static string PetAdded = "Evcil Hayvan eklendi.";
        public static string PetDeleted = "Evcil Hayvan silindi.";
        public static string PetUpdated = "Evcil Hayvan güncellendi.";
        public static string PetListed = "Evcil Hayvan listelendi.";
        public static string PetsListed = "Evcil Hayvanlar listelendi.";
        public static string NotEmptyPetName = "Evcil Hayvan Adı Boş Olamaz!";
        public static string NotEmptyUserInfo = "Evcil Hayvan Kullanıcı Bilgileri Boş Olamaz!";


        //User
        public static string UserAdded = "Aktivite eklendi.";
        public static string UserDeleted = "Aktivite silindi.";
        public static string UserUpdated = "Aktivite güncellendi.";
        public static string UserListed = "Aktivite listelendi.";
        public static string UsersListed = "Aktiviteler listelendi.";
        public static string UsersFirstNameNotEmpty = "Kullanıcı ismi boş olamaz!";
        public static string InvalidFirstName = "Geçersiz kullanıcı ismi!";
        public static string LessFirstName= "Kullanıcı ismi en az 2 karakter olmalıdır!";
        public static string UsersLastNameNotEmpty = "Kullanıcı soyismi boş olamaz!";
        public static string InvalidLastName = "Geçersiz kullanıcı soyismi!";
        public static string LessLastName = "Kullanıcı soyismi en az 2 karakter olmalıdır!";
        public static string UsersPhoneNumberNotEmpty = "Telefon numarası boş olamaz!";
        public static string InvalidPhoneNumber = "Geçersiz telefon numarası!";
        public static string NotStartPhoneNumber = "Telefon numarası 0(sıfır) ile başlayamaz!";
        public static string UsersEmailNotEmpty = "Email boş olamaz!";
        public static string InvalidEmail = "Geçersiz Email!";

        //System
        public static string Error = "Bir hata oluştu!";
        public static string NotFound = "Kayıt Bulunamadı!";
    }
}
